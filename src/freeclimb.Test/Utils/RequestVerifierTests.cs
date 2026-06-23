using System;
using freeclimb.Utils;
using Xunit;

namespace freeclimb.Test.Utils
{
    public class RequestVerifierTests : IDisposable
    {
        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        [Fact]
        public void checkRequestBodyTest()
        {
            string requestBody = "";
            string signingSecret = "sigsec_ead6d3b6904196c60835d039e91b3341c77a7793";
            string requestHeader =
                "t=1679931346,v1=117b796d951eb332e8196a3803517e4b5a6ac09a33cc7e87890cb99bde159341,v1=1ba18712726898fbbe48cd862dd096a709f7ad761a5bab14bda9ac24d963a6a8";
            int tolerance = 5 * 60 * 1000;
            Action act = () =>
                RequestVerifier.verifyRequestSignature(
                    requestBody,
                    requestHeader,
                    signingSecret,
                    tolerance
                );
            Exception exception = Assert.Throws<Exception>(act);
            Assert.Equal("Request Body cannot be empty or null", exception.Message);
        }

        [Fact]
        public void checkRequestHeaderTest()
        {
            string requestBody =
                "{\"accountId\":\"AC0123456789abcdefABCDEF0123456789abcdef00\",\"callId\":\"CA0123456789abcdefABCDEF0123456789abcdef00\",\"callStatus\":\"ringing\",\"conferenceId\":null,\"direction\":\"inbound\",\"from\":\"+13121000109\",\"parentCallId\":null,\"queueId\":null,\"requestType\":\"inboundCall\",\"to\":\"+13121000096\"}";
            string signingSecret = "sigsec_ead6d3b6904196c60835d039e91b3341c77a7793";
            string requestHeader = "t=1679944186,";
            int tolerance = 5 * 60 * 1000;
            Action act = () =>
                RequestVerifier.verifyRequestSignature(
                    requestBody,
                    requestHeader,
                    signingSecret,
                    tolerance
                );
            Exception exception = Assert.Throws<Exception>(act);
            Assert.Equal(
                "Error with request header, signatures are not present",
                exception.Message
            );
        }

        [Fact]
        public void checkRequestHeaderTest2()
        {
            string requestBody =
                "{\"accountId\":\"AC0123456789abcdefABCDEF0123456789abcdef00\",\"callId\":\"CA0123456789abcdefABCDEF0123456789abcdef00\",\"callStatus\":\"ringing\",\"conferenceId\":null,\"direction\":\"inbound\",\"from\":\"+13121000109\",\"parentCallId\":null,\"queueId\":null,\"requestType\":\"inboundCall\",\"to\":\"+13121000096\"}";
            string signingSecret = "sigsec_ead6d3b6904196c60835d039e91b3341c77a7793";
            string requestHeader =
                "v1=2f33654710a27e57828fa8556c2ed47c7a324aca88f155e296579e2ae851ce7b,v1=1ba18712726898fbbe48cd862dd096a709f7ad761a5bab14bda9ac24d963a6a8";
            int tolerance = 5 * 60 * 1000;
            Action act = () =>
                RequestVerifier.verifyRequestSignature(
                    requestBody,
                    requestHeader,
                    signingSecret,
                    tolerance
                );
            Exception exception = Assert.Throws<Exception>(act);
            Assert.Equal("Error with request header, timestamp is not present", exception.Message);
        }

        [Fact]
        public void checkRequestHeaderTest3()
        {
            string requestBody =
                "{\"accountId\":\"AC0123456789abcdefABCDEF0123456789abcdef00\",\"callId\":\"CA0123456789abcdefABCDEF0123456789abcdef00\",\"callStatus\":\"ringing\",\"conferenceId\":null,\"direction\":\"inbound\",\"from\":\"+13121000109\",\"parentCallId\":null,\"queueId\":null,\"requestType\":\"inboundCall\",\"to\":\"+13121000096\"}";
            string signingSecret = "sigsec_ead6d3b6904196c60835d039e91b3341c77a7793";
            string requestHeader = "";
            int tolerance = 5 * 60;
            Action act = () =>
                RequestVerifier.verifyRequestSignature(
                    requestBody,
                    requestHeader,
                    signingSecret,
                    tolerance
                );
            Exception exception = Assert.Throws<Exception>(act);
            Assert.Equal("Error with request header, Request header is empty", exception.Message);
        }

        [Fact]
        public void checkSigningSecretTest()
        {
            string requestBody =
                "{\"accountId\":\"AC0123456789abcdefABCDEF0123456789abcdef00\",\"callId\":\"CA0123456789abcdefABCDEF0123456789abcdef00\",\"callStatus\":\"ringing\",\"conferenceId\":null,\"direction\":\"inbound\",\"from\":\"+13121000109\",\"parentCallId\":null,\"queueId\":null,\"requestType\":\"inboundCall\",\"to\":\"+13121000096\"}";
            string signingSecret = "";
            string requestHeader =
                "t=1679944186,v1=2f33654710a27e57828fa8556c2ed47c7a324aca88f155e296579e2ae851ce7b,v1=1ba18712726898fbbe48cd862dd096a709f7ad761a5bab14bda9ac24d963a6a8";
            int tolerance = 5 * 60;
            Action act = () =>
                RequestVerifier.verifyRequestSignature(
                    requestBody,
                    requestHeader,
                    signingSecret,
                    tolerance
                );
            Exception exception = Assert.Throws<Exception>(act);
            Assert.Equal("Signing secret cannot be empty or null", exception.Message);
        }

        [Fact]
        public void checkToleranceTest()
        {
            string requestBody =
                "{\"accountId\":\"AC0123456789abcdefABCDEF0123456789abcdef00\",\"callId\":\"CA0123456789abcdefABCDEF0123456789abcdef00\",\"callStatus\":\"ringing\",\"conferenceId\":null,\"direction\":\"inbound\",\"from\":\"+13121000109\",\"parentCallId\":null,\"queueId\":null,\"requestType\":\"inboundCall\",\"to\":\"+13121000096\"}";
            string signingSecret = "sigsec_ead6d3b6904196c60835d039e91b3341c77a7793";
            string requestHeader =
                "t=1679944186,v1=2f33654710a27e57828fa8556c2ed47c7a324aca88f155e296579e2ae851ce7b,v1=1ba18712726898fbbe48cd862dd096a709f7ad761a5bab14bda9ac24d963a6a8";
            int tolerance = int.MaxValue;
            Action act = () =>
                RequestVerifier.verifyRequestSignature(
                    requestBody,
                    requestHeader,
                    signingSecret,
                    tolerance
                );
            Exception exception = Assert.Throws<Exception>(act);
            Assert.Equal("Tolerance value must be a positive integer", exception.Message);
        }

        [Fact]
        public void checkToleranceTest2()
        {
            string requestBody =
                "{\"accountId\":\"AC0123456789abcdefABCDEF0123456789abcdef00\",\"callId\":\"CA0123456789abcdefABCDEF0123456789abcdef00\",\"callStatus\":\"ringing\",\"conferenceId\":null,\"direction\":\"inbound\",\"from\":\"+13121000109\",\"parentCallId\":null,\"queueId\":null,\"requestType\":\"inboundCall\",\"to\":\"+13121000096\"}";
            string signingSecret = "sigsec_ead6d3b6904196c60835d039e91b3341c77a7793";
            string requestHeader =
                "t=1679944186,v1=2f33654710a27e57828fa8556c2ed47c7a324aca88f155e296579e2ae851ce7b,v1=1ba18712726898fbbe48cd862dd096a709f7ad761a5bab14bda9ac24d963a6a8";
            int tolerance = -5;
            Action act = () =>
                RequestVerifier.verifyRequestSignature(
                    requestBody,
                    requestHeader,
                    signingSecret,
                    tolerance
                );
            Exception exception = Assert.Throws<Exception>(act);
            Assert.Equal("Tolerance value must be a positive integer", exception.Message);
        }

        [Fact]
        public void checkToleranceTest3()
        {
            string requestBody =
                "{\"accountId\":\"AC0123456789abcdefABCDEF0123456789abcdef00\",\"callId\":\"CA0123456789abcdefABCDEF0123456789abcdef00\",\"callStatus\":\"ringing\",\"conferenceId\":null,\"direction\":\"inbound\",\"from\":\"+13121000109\",\"parentCallId\":null,\"queueId\":null,\"requestType\":\"inboundCall\",\"to\":\"+13121000096\"}";
            string signingSecret = "sigsec_ead6d3b6904196c60835d039e91b3341c77a7793";
            string requestHeader =
                "t=1679944186,v1=2f33654710a27e57828fa8556c2ed47c7a324aca88f155e296579e2ae851ce7b,v1=1ba18712726898fbbe48cd862dd096a709f7ad761a5bab14bda9ac24d963a6a8";
            int tolerance = 0;
            Action act = () =>
                RequestVerifier.verifyRequestSignature(
                    requestBody,
                    requestHeader,
                    signingSecret,
                    tolerance
                );
            Exception exception = Assert.Throws<Exception>(act);
            Assert.Equal("Tolerance value must be a positive integer", exception.Message);
        }

        [Fact]
        public void verifyToleranceTest()
        {
            string requestBody =
                "{\"accountId\":\"AC0123456789abcdefABCDEF0123456789abcdef00\",\"callId\":\"CA0123456789abcdefABCDEF0123456789abcdef00\",\"callStatus\":\"ringing\",\"conferenceId\":null,\"direction\":\"inbound\",\"from\":\"+13121000109\",\"parentCallId\":null,\"queueId\":null,\"requestType\":\"inboundCall\",\"to\":\"+13121000096\"}";
            string signingSecret = "sigsec_ead6d3b6904196c60835d039e91b3341c77a7793";
            int currentTime = (int)((DateTimeOffset)DateTime.UtcNow).ToUnixTimeSeconds();
            string requestTime = (currentTime - (6 * 60)).ToString();
            string requestHeader =
                "t="
                + requestTime
                + ",v1=1d798c86e977ff734dec3a8b8d67fe8621dcc1df46ef4212e0bfe2e122b01bfd,v1=1ba18712726898fbbe48cd862dd096a709f7ad761a5bab14bda9ac24d963a6a8";
            int tolerance = 5 * 60;
            Action act = () =>
                RequestVerifier.verifyRequestSignature(
                    requestBody,
                    requestHeader,
                    signingSecret,
                    tolerance
                );
            Exception exception = Assert.Throws<Exception>(act);
            Assert.Equal(
                "Request time exceeded tolerance threshold. Request: "
                    + requestTime
                    + ", CurrentTime: "
                    + currentTime.ToString()
                    + ", tolerance: 300",
                exception.Message
            );
        }

        [Fact]
        public void verifySignatureTest()
        {
            string requestBody =
                "{\"accountId\":\"AC0123456789abcdefABCDEF0123456789abcdef00\",\"callId\":\"CA0123456789abcdefABCDEF0123456789abcdef00\",\"callStatus\":\"ringing\",\"conferenceId\":null,\"direction\":\"inbound\",\"from\":\"+13121000109\",\"parentCallId\":null,\"queueId\":null,\"requestType\":\"inboundCall\",\"to\":\"+13121000096\"}";
            string signingSecret = "sigsec_ead6d3b6904196c60835d039e91b3341c77a7793";
            int currentTime = (int)((DateTimeOffset)DateTime.UtcNow).ToUnixTimeSeconds();
            string requestHeader =
                "t="
                + currentTime.ToString()
                + ",v1=1d798c86e977ff734dec3a8b8d67fe8621dcc1df46ef4212e0bfe2e122b01bfd,v1=1ba18712726898fbbe48cd862dd096a709f7ad761a5bab14bda9ac24d963a6a8";
            int tolerance = 5 * 60;
            Action act = () =>
                RequestVerifier.verifyRequestSignature(
                    requestBody,
                    requestHeader,
                    signingSecret,
                    tolerance
                );
            Exception exception = Assert.Throws<Exception>(act);
            Assert.Equal(
                "Unverified signature request, If this request was unexpected, it may be from a bad actor. Please proceed with caution. If the request was exepected, please check any typos or issues with the signingSecret",
                exception.Message
            );
        }

        [Fact]
        public void verifyRequestSignatureTest()
        {
            string requestBody =
                "{\"accountId\":\"AC0123456789abcdefABCDEF0123456789abcdef00\",\"callId\":\"CA0123456789abcdefABCDEF0123456789abcdef00\",\"callStatus\":\"ringing\",\"conferenceId\":null,\"direction\":\"inbound\",\"from\":\"+13121000109\",\"parentCallId\":null,\"queueId\":null,\"requestType\":\"inboundCall\",\"to\":\"+13121000096\"}";
            string signingSecret = "sigsec_ead6d3b6904196c60835d039e91b3341c77a7793";
            string requestHeader =
                "t=2140000000,v1=2f33654710a27e57828fa8556c2ed47c7a324aca88f155e296579e2ae851ce7b,v1=6bb730259ccd4d4df2524cb0893a25195fa8b61965e7444b9e38731a66952806";
            int tolerance = 5 * 60;
            var exception = Record.Exception(
                () =>
                    RequestVerifier.verifyRequestSignature(
                        requestBody,
                        requestHeader,
                        signingSecret,
                        tolerance
                    )
            );
            Assert.Null(exception);
        }
    }
}
