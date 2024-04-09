using Xunit;

using freeclimb.Utils;
using System;

namespace freeclimb.Test.Utils
{
    public class RequestVerifierTests : IDisposable
    {
        private RequestVerifier instance;


        public RequestVerifierTests()
        {
            RequestVerifier instance = new RequestVerifier();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SignatureInformation
        /// </summary>
        [Fact]
        public void RequestVerifierInstanceTests()
        {
            // TODO uncomment below to test "IsType" AccountRequest
            //Assert.IsType<RequestVerifier>(instance);
        }

        [Fact]
        public void checkRequestBodyTest()
        {
            string requestBody = "";
            string signingSecret = "sigsec_ead6d3b6904196c60835d039e91b3341c77a7793";
            string requestHeader = "t=1679931346,v1=4945505e46930b6e31df721c069f10cd3a4cfb3c8e2ec67d2663fae49f95644f,v1=1ba18712726898fbbe48cd862dd096a709f7ad761a5bab14bda9ac24d963a6a8";
            int tolerance = 5 * 60 * 1000;
            Action act = () => RequestVerifier.verifyRequestSignature(requestBody, requestHeader, signingSecret, tolerance);
            Exception exception = Assert.Throws<Exception>(act);
            Assert.Equal("Request Body cannot be empty or null", exception.Message);
        }
        [Fact]
        public void checkRequestHeaderTest()
        {
            string requestBody = "{\"accountId\":\"AC1334ffb694cd8d969f51cddf5f7c9b478546d50c\",\"callId\":\"CAccb0b00506553cda09b51c5477f672a49e0b2213\",\"callStatus\":\"ringing\",\"conferenceId\":null,\"direction\":\"inbound\",\"from\":\"+13121000109\",\"parentCallId\":null,\"queueId\":null,\"requestType\":\"inboundCall\",\"to\":\"+13121000096\"}";
            string signingSecret = "sigsec_ead6d3b6904196c60835d039e91b3341c77a7793";
            string requestHeader = "t=1679944186,";
            int tolerance = 5 * 60 * 1000;
            Action act = () => RequestVerifier.verifyRequestSignature(requestBody, requestHeader, signingSecret, tolerance);
            Exception exception = Assert.Throws<Exception>(act);
            Assert.Equal("Error with request header, signatures are not present", exception.Message);
        }
        [Fact]
        public void checkRequestHeaderTest2()
        {
            string requestBody = "{\"accountId\":\"AC1334ffb694cd8d969f51cddf5f7c9b478546d50c\",\"callId\":\"CAccb0b00506553cda09b51c5477f672a49e0b2213\",\"callStatus\":\"ringing\",\"conferenceId\":null,\"direction\":\"inbound\",\"from\":\"+13121000109\",\"parentCallId\":null,\"queueId\":null,\"requestType\":\"inboundCall\",\"to\":\"+13121000096\"}";
            string signingSecret = "sigsec_ead6d3b6904196c60835d039e91b3341c77a7793";
            string requestHeader = "v1=c3957749baf61df4b1506802579cc69a74c77a1ae21447b930e5a704f9ec4120,v1=1ba18712726898fbbe48cd862dd096a709f7ad761a5bab14bda9ac24d963a6a8";
            int tolerance = 5 * 60 * 1000;
            Action act = () => RequestVerifier.verifyRequestSignature(requestBody, requestHeader, signingSecret, tolerance);
            Exception exception = Assert.Throws<Exception>(act);
            Assert.Equal("Error with request header, timestamp is not present", exception.Message);
        }
        [Fact]
        public void checkRequestHeaderTest3()
        {
            string requestBody = "{\"accountId\":\"AC1334ffb694cd8d969f51cddf5f7c9b478546d50c\",\"callId\":\"CAccb0b00506553cda09b51c5477f672a49e0b2213\",\"callStatus\":\"ringing\",\"conferenceId\":null,\"direction\":\"inbound\",\"from\":\"+13121000109\",\"parentCallId\":null,\"queueId\":null,\"requestType\":\"inboundCall\",\"to\":\"+13121000096\"}";
            string signingSecret = "sigsec_ead6d3b6904196c60835d039e91b3341c77a7793";
            string requestHeader = "";
            int tolerance = 5 * 60;
            Action act = () => RequestVerifier.verifyRequestSignature(requestBody, requestHeader, signingSecret, tolerance);
            Exception exception = Assert.Throws<Exception>(act);
            Assert.Equal("Error with request header, Request header is empty", exception.Message);
        }
        [Fact]
        public void checkSigningSecretTest()
        {
            string requestBody = "{\"accountId\":\"AC1334ffb694cd8d969f51cddf5f7c9b478546d50c\",\"callId\":\"CAccb0b00506553cda09b51c5477f672a49e0b2213\",\"callStatus\":\"ringing\",\"conferenceId\":null,\"direction\":\"inbound\",\"from\":\"+13121000109\",\"parentCallId\":null,\"queueId\":null,\"requestType\":\"inboundCall\",\"to\":\"+13121000096\"}";
            string signingSecret = "";
            string requestHeader = "t=1679944186,v1=c3957749baf61df4b1506802579cc69a74c77a1ae21447b930e5a704f9ec4120,v1=1ba18712726898fbbe48cd862dd096a709f7ad761a5bab14bda9ac24d963a6a8";
            int tolerance = 5 * 60;
            Action act = () => RequestVerifier.verifyRequestSignature(requestBody, requestHeader, signingSecret, tolerance);
            Exception exception = Assert.Throws<Exception>(act);
            Assert.Equal("Signing secret cannot be empty or null", exception.Message);
        }
        [Fact]
        public void checkToleranceTest()
        {
            string requestBody = "{\"accountId\":\"AC1334ffb694cd8d969f51cddf5f7c9b478546d50c\",\"callId\":\"CAccb0b00506553cda09b51c5477f672a49e0b2213\",\"callStatus\":\"ringing\",\"conferenceId\":null,\"direction\":\"inbound\",\"from\":\"+13121000109\",\"parentCallId\":null,\"queueId\":null,\"requestType\":\"inboundCall\",\"to\":\"+13121000096\"}";
            string signingSecret = "sigsec_ead6d3b6904196c60835d039e91b3341c77a7793";
            string requestHeader = "t=1679944186,v1=c3957749baf61df4b1506802579cc69a74c77a1ae21447b930e5a704f9ec4120,v1=1ba18712726898fbbe48cd862dd096a709f7ad761a5bab14bda9ac24d963a6a8";
            int tolerance = int.MaxValue;
            Action act = () => RequestVerifier.verifyRequestSignature(requestBody, requestHeader, signingSecret, tolerance);
            Exception exception = Assert.Throws<Exception>(act);
            Assert.Equal("Tolerance value must be a positive integer", exception.Message);
        }
        [Fact]
        public void checkToleranceTest2()
        {
            string requestBody = "{\"accountId\":\"AC1334ffb694cd8d969f51cddf5f7c9b478546d50c\",\"callId\":\"CAccb0b00506553cda09b51c5477f672a49e0b2213\",\"callStatus\":\"ringing\",\"conferenceId\":null,\"direction\":\"inbound\",\"from\":\"+13121000109\",\"parentCallId\":null,\"queueId\":null,\"requestType\":\"inboundCall\",\"to\":\"+13121000096\"}";
            string signingSecret = "sigsec_ead6d3b6904196c60835d039e91b3341c77a7793";
            string requestHeader = "t=1679944186,v1=c3957749baf61df4b1506802579cc69a74c77a1ae21447b930e5a704f9ec4120,v1=1ba18712726898fbbe48cd862dd096a709f7ad761a5bab14bda9ac24d963a6a8";
            int tolerance = -5;
            Action act = () => RequestVerifier.verifyRequestSignature(requestBody, requestHeader, signingSecret, tolerance);
            Exception exception = Assert.Throws<Exception>(act);
            Assert.Equal("Tolerance value must be a positive integer", exception.Message);
        }
        [Fact]
        public void checkToleranceTest3()
        {
            string requestBody = "{\"accountId\":\"AC1334ffb694cd8d969f51cddf5f7c9b478546d50c\",\"callId\":\"CAccb0b00506553cda09b51c5477f672a49e0b2213\",\"callStatus\":\"ringing\",\"conferenceId\":null,\"direction\":\"inbound\",\"from\":\"+13121000109\",\"parentCallId\":null,\"queueId\":null,\"requestType\":\"inboundCall\",\"to\":\"+13121000096\"}";
            string signingSecret = "sigsec_ead6d3b6904196c60835d039e91b3341c77a7793";
            string requestHeader = "t=1679944186,v1=c3957749baf61df4b1506802579cc69a74c77a1ae21447b930e5a704f9ec4120,v1=1ba18712726898fbbe48cd862dd096a709f7ad761a5bab14bda9ac24d963a6a8";
            int tolerance = 0;
            Action act = () => RequestVerifier.verifyRequestSignature(requestBody, requestHeader, signingSecret, tolerance);
            Exception exception = Assert.Throws<Exception>(act);
            Assert.Equal("Tolerance value must be a positive integer", exception.Message);
        }
        [Fact]
        public void verifyToleranceTest()
        {
            string requestBody = "{\"accountId\":\"AC1334ffb694cd8d969f51cddf5f7c9b478546d50c\",\"callId\":\"CAccb0b00506553cda09b51c5477f672a49e0b2213\",\"callStatus\":\"ringing\",\"conferenceId\":null,\"direction\":\"inbound\",\"from\":\"+13121000109\",\"parentCallId\":null,\"queueId\":null,\"requestType\":\"inboundCall\",\"to\":\"+13121000096\"}";
            string signingSecret = "sigsec_ead6d3b6904196c60835d039e91b3341c77a7793";
            int currentTime = (int)((DateTimeOffset)DateTime.UtcNow).ToUnixTimeSeconds();
            string requestTime = (currentTime - (6 * 60 * 1000)).ToString();
            string requestHeader = "t=" + requestTime + ",v1=1d798c86e977ff734dec3a8b8d67fe8621dcc1df46ef4212e0bfe2e122b01bfd,v1=1ba18712726898fbbe48cd862dd096a709f7ad761a5bab14bda9ac24d963a6a8";
            int tolerance = 5 * 60 * 1000;
            Action act = () => RequestVerifier.verifyRequestSignature(requestBody, requestHeader, signingSecret, tolerance);
            Exception exception = Assert.Throws<Exception>(act);
            Assert.Equal("Request time exceeded tolerance threshold. Request: " + requestTime + ", CurrentTime: " + currentTime.ToString() + ", tolerance: 300000", exception.Message);
        }
        [Fact]
        public void verifySignatureTest()
        {
            string requestBody = "{\"accountId\":\"AC1334ffb694cd8d969f51cddf5f7c9b478546d50c\",\"callId\":\"CAccb0b00506553cda09b51c5477f672a49e0b2213\",\"callStatus\":\"ringing\",\"conferenceId\":null,\"direction\":\"inbound\",\"from\":\"+13121000109\",\"parentCallId\":null,\"queueId\":null,\"requestType\":\"inboundCall\",\"to\":\"+13121000096\"}";
            string signingSecret = "sigsec_ead6d3b6904196c60835d039e91b3341c77a7793";
            int currentTime = (int)((DateTimeOffset)DateTime.UtcNow).ToUnixTimeSeconds();
            string requestHeader = "t=" + currentTime.ToString() + ",v1=1d798c86e977ff734dec3a8b8d67fe8621dcc1df46ef4212e0bfe2e122b01bfd,v1=1ba18712726898fbbe48cd862dd096a709f7ad761a5bab14bda9ac24d963a6a8";
            int tolerance = 5 * 60 * 1000;
            Action act = () => RequestVerifier.verifyRequestSignature(requestBody, requestHeader, signingSecret, tolerance);
            Exception exception = Assert.Throws<Exception>(act);
            Assert.Equal("Unverified signature request, If this request was unexpected, it may be from a bad actor. Please proceed with caution. If the request was exepected, please check any typos or issues with the signingSecret", exception.Message);
        }
        [Fact]
        public void verifyRequestSignatureTest()
        {
            string requestBody = "{\"accountId\":\"AC1334ffb694cd8d969f51cddf5f7c9b478546d50c\",\"callId\":\"CAccb0b00506553cda09b51c5477f672a49e0b2213\",\"callStatus\":\"ringing\",\"conferenceId\":null,\"direction\":\"inbound\",\"from\":\"+13121000109\",\"parentCallId\":null,\"queueId\":null,\"requestType\":\"inboundCall\",\"to\":\"+13121000096\"}";
            string signingSecret = "sigsec_ead6d3b6904196c60835d039e91b3341c77a7793";
            string requestHeader = "t=2140000000,v1=c3957749baf61df4b1506802579cc69a74c77a1ae21447b930e5a704f9ec4120,v1=814978ae2603594cfc9310680625ea6cdb958d7c940f0695726048f1e4d7af9e";
            int tolerance = 5 * 60 * 1000;
            var exception = Record.Exception(() => RequestVerifier.verifyRequestSignature(requestBody, requestHeader, signingSecret, tolerance));
            Assert.Null(exception);
        }
    }
}