using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using com.freeclimb.api;
using System.IO;

namespace com.freeclimb
{
    [JsonObject]
    public sealed class Utils
    {
        /// <summary>
        /// Verify the request received by the application using account signing secrets
        /// </summary>
        /// <param name="header"></param>
        /// <param name="requestBody"></param>
        /// <param name="signingSecret"></param>
        /// <param name="tolerance"></param>
        /// <returns>true if signature can be verified by the algorithm</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public static bool verifyRequest(string header, Stream requestBody, string signingSecret, int tolerance = defaultToleranceMs)
        {
            //Defensive move, saving the current position
            //of the stream just in case the caller needs it back in the same spot
            var startPos = requestBody.Position;

            MemoryStream localBody = new MemoryStream();
            var reader = new StreamReader(requestBody);
            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            var bodyStr = reader.ReadToEnd();

            //Restore the position in the stream
            reader.BaseStream.Position = startPos;

            return VerifyRequestV1(bodyStr, header, signingSecret, tolerance);
        }


        /// <summary>
        /// Use the "v1" algorithm to verify the signature
        /// </summary>
        /// <param name="requestBody"></param>
        /// <param name="signatureHeader"></param>
        /// <param name="signingSecret"></param>
        /// <param name="tolerance"></param>
        /// <returns>true if signature can be verified by the algorithm</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        internal static bool VerifyRequestV1(string requestBody, string signatureHeader, string signingSecret, int tolerance = defaultToleranceMs)
        {
            if (tolerance < 0 || tolerance > defaultToleranceMs)
            {
                tolerance = defaultToleranceMs;
            }

            int ts = 0;
            string tsStr = "";
            var signatures = new List<string>();

            //Find the tags
            //Tags are separated by `,`
            string[] signatureSpl = signatureHeader.Split(',');

            foreach (var kvPair in signatureSpl)
            {
                //Now split each entry with the separator `=`
                string[] sigElems = kvPair.Split('=');

                for (int i = 0; i < sigElems.Length; i += 2)
                {
                    if (sigElems[i] == "t")
                    {
                        if (!Int32.TryParse(sigElems[i + 1], out ts))
                        {
                            throw new FreeClimbException(String.Format("{0} bad timestamp supplied in header", sigElems[1]));
                        }
                        tsStr = sigElems[i + 1];
                    }
                    else if (sigElems[i] == "v1")
                    {
                        //The signature from FreeClimb is preceeded by "v1="
                        signatures.Add(sigElems[i + 1]);
                    }
                }
            }

            //Ensure that request is within the tolerance time-limit
            DateTime now = DateTime.Now;
            int ms = now.Millisecond;
            if (ms > (ts + tolerance))
            {
                throw new FreeClimbException(String.Format("{0} current time is outside tolerance limits", tolerance));
            }

            //Verify the signature

            //Concatenate the supplied timestamp bytes with a `.` character's bytes (ascii) and the bytes of the request body
            string hashSeedStr = tsStr + '.' + requestBody;
            byte[] hashSeed = Encoding.ASCII.GetBytes(hashSeedStr);

            //Convert the signing secret to the bytes value
            byte[] signingSecretBytes = Encoding.ASCII.GetBytes(signingSecret);

            //Using the account's signing secret as a key, use HMAC to hash the hash from the previous step.
            HMACSHA256 hmac = new HMACSHA256(signingSecretBytes);
            byte[] hashValue = hmac.ComputeHash(hashSeed);

            if (!signatures.Contains(BitConverter.ToString(hashValue).Replace("-", "").ToLower()))
            {
                throw new FreeClimbException(String.Format(
                    "Unverified Request Signature - FreeClimb was unable to verify that this request originated from FreeClimb. " +
                    "If this request was unexpected, it may be from a bad actor. " +
                    "Please proceed with caution. If this request was expected, " +
                    "to fix this issue try checking for any typos or misspelling of your signing secret."));
            }

            //If we're here the signature matched
            return true;
        }


        /// <summary>
        /// Default Tolerance of 5 mins
        /// </summary>
        public const int defaultToleranceMs = 5 * 60 * 1000;
    }
}