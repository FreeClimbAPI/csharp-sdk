using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace freeclimb.Utils
{
    public class RequestVerifier
    {
        public const int DEFAULT_TOLERANCE = 5 * 60 * 1000;
        public static void verifyRequestSignature(String requestBody, String requestHeader, String signingSecret, int tolerance = DEFAULT_TOLERANCE)
        {
            RequestVerifier verifier = new RequestVerifier();
            verifier.checkRequestBody(requestBody);
            verifier.checkRequestHeader(requestHeader);
            verifier.checkSigningSecret(signingSecret);
            verifier.checkTolerance(tolerance);
            SignatureInformation info = new SignatureInformation(requestHeader);
            verifier.verifyTolerance(info, tolerance);
            verifier.verifySignature(info, requestBody, signingSecret);
        }

        private void checkRequestBody(String requestBody)
        {
            if (requestBody == "" || requestBody == null)
            {
                throw new Exception("Request Body cannot be empty or null");
            }
        }

        private void checkRequestHeader(String requestHeader)
        {
            if (requestHeader == "" || requestHeader == null)
            {
                throw new Exception("Error with request header, Request header is empty");
            }
            else if (!requestHeader.Contains("t="))
            {
                throw new Exception("Error with request header, timestamp is not present");
            }
            else if (!requestHeader.Contains("v1="))
            {
                throw new Exception("Error with request header, signatures are not present");
            }
        }

        private void checkSigningSecret(String signingSecret)
        {
            if (signingSecret == "" || signingSecret == null)
            {
                throw new Exception("Signing secret cannot be empty or null");
            }
        }
        private void checkTolerance(int tolerance)
        {
            if (tolerance <= 0 || tolerance >= int.MaxValue)
            {
                throw new Exception("Tolerance value must be a positive integer");
            }
        }

        private void verifyTolerance(SignatureInformation info, int tolerance)
        {
            int currentTime = info.getCurrentUnixTime();
            if (!info.isRequestTimeValid(tolerance))
            {
                throw new Exception(String.Format("Request time exceeded tolerance threshold. Request: {0}, CurrentTime: {1}, tolerance: {2}", info.requestTimestamp, currentTime, tolerance));
            }
        }
        private void verifySignature(SignatureInformation info, String requestBody, String signingSecret)
        {
            if (!info.isSignatureSafe(requestBody, signingSecret))
            {
                throw new Exception("Unverified signature request, If this request was unexpected, it may be from a bad actor. Please proceed with caution. If the request was exepected, please check any typos or issues with the signingSecret");
            }
        }
    }
}