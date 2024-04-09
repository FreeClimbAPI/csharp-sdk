using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace freeclimb.Utils
{
    /// <summary>
    /// This is the Signature Information class, this parses and validates the signature information class
    /// </summary>
    public class SignatureInformation
    {
        public int requestTimestamp;
        public List<string> signatures;
        /// <summary>
        /// This is the Signature Information constructor, this takes the requestHeader and parses it into the attribute values
        /// </summary>
        /// <param name="requestHeader"></param>
        public SignatureInformation(string requestHeader)
        {
            List<string> constructorSignatures = new List<string>();
            string[] signatureHeaders = requestHeader.Split(',');
            foreach (var signatureHeader in signatureHeaders)
            {
                var header = signatureHeader.Split('=')[0];
                var value = signatureHeader.Split('=')[1];
                if (header == "t")
                {
                    requestTimestamp = Int32.Parse(value);
                }
                else if (header == "v1")
                {
                    constructorSignatures.Add(value);
                }
            }
            signatures = constructorSignatures;
        }
        /// <summary>
        /// This is the timestamp validity function, this checks if the request timestamp is valid
        /// </summary>
        /// <param name="tolerance"></param>
        /// <returns>true or false if timestamp is valid or invalid based on condition</returns>
        public Boolean isRequestTimeValid(int tolerance)
        {
            var currentUnixTimestamp = getCurrentUnixTime();
            return currentUnixTimestamp < (requestTimestamp + tolerance);
        }
        /// <summary>
        /// This is the signature validity function, this checks if the request timestamp is valid
        /// </summary>
        /// <param name="requestBody"></param>
        /// <param name="signingSecret"></param>
        /// <returns>true or false if timestamp is valid or invalid based on condition</returns>
        public Boolean isSignatureSafe(String requestBody, String signingSecret)
        {
            string hashValue = computeHash(requestBody, signingSecret);
            return signatures.Contains(hashValue);
        }

        private String computeHash(String requestBody, String signingSecret)
        {
            string hashSeedString = requestTimestamp + "." + requestBody;
            byte[] hashSeed = Encoding.ASCII.GetBytes(hashSeedString);
            byte[] signingSecretBytes = Encoding.ASCII.GetBytes(signingSecret);
            HMACSHA256 hmac = new HMACSHA256(signingSecretBytes);
            byte[] hashValue = hmac.ComputeHash(hashSeed);
            return BitConverter.ToString(hashValue).Replace("-", "").ToLower();
        }

        public int getCurrentUnixTime()
        {
            return (int)((DateTimeOffset)DateTime.UtcNow).ToUnixTimeSeconds();
        }
    }
}
