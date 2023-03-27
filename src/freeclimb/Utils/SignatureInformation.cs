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
                var headerKey = signatureHeader.Split('=')[0];
                var headerValue = signatureHeader.Split('=')[1];
                if (headerKey == "t")
                {
                    requestTimestamp = Int32.Parse(headerValue);
                }
                else if (headerKey == "v1")
                {
                    constructorSignatures.Add(headerValue);
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
            return (requestTimestamp + tolerance) < currentUnixTimestamp;
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
            //Convert hashValue to proper hexadecimal string format
            string hashHexadecimalValue = BitConverter.ToString(hashValue).Replace("-", "").ToLower();
            return hashHexadecimalValue;
        }

        private int getCurrentUnixTime()
        {
            DateTime now = DateTime.UtcNow;
            return (int)((DateTimeOffset)now).ToUnixTimeSeconds();
        }
    }
}
