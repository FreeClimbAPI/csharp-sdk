using System;
using freeclimb.Utils;
using Xunit;

namespace freeclimb.Test.Utils
{
    public class SignatureInformationTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AccountRequest
        private SignatureInformation instance;
        private int timestamp = 1679944186;

        public SignatureInformationTests()
        {
            string requestHeader =
                "t="
                + timestamp.ToString()
                + ",v1=2f33654710a27e57828fa8556c2ed47c7a324aca88f155e296579e2ae851ce7b,v1=1ba18712726898fbbe48cd862dd096a709f7ad761a5bab14bda9ac24d963a6a8";
            instance = new SignatureInformation(requestHeader);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SignatureInformation
        /// </summary>
        [Fact]
        public void SignatureInformationInstanceTests()
        {
            // TODO uncomment below to test "IsType" AccountRequest
            //Assert.IsType<SignatureInformation>(instance);
        }

        /// <summary>
        /// Test the method 'isRequestTimeValid'
        /// </summary>
        [Fact]
        public void isRequestTimeValidTest()
        {
            //For test purposes, this relates to three days, we also want to ensure that the signature header remains the same during tests
            string requestHeader =
                "t="
                + instance.getCurrentUnixTime().ToString()
                + ",v1=2f33654710a27e57828fa8556c2ed47c7a324aca88f155e296579e2ae851ce7b,v1=1ba18712726898fbbe48cd862dd096a709f7ad761a5bab14bda9ac24d963a6a8";
            instance = new SignatureInformation(requestHeader);
            int tolerance = 5 * 60;
            Boolean isRequestTimeValid = instance.isRequestTimeValid(tolerance);
            Assert.True(isRequestTimeValid);
        }

        [Fact]
        public void isRequestTimeValidTest2()
        {
            //For test purposes, this relates to three days, we also want to ensure that the signature header remains the same during tests
            string requestHeader =
                "t="
                + (instance.getCurrentUnixTime() - (600 * 60)).ToString()
                + ",v1=2f33654710a27e57828fa8556c2ed47c7a324aca88f155e296579e2ae851ce7b,v1=1ba18712726898fbbe48cd862dd096a709f7ad761a5bab14bda9ac24d963a6a8";
            instance = new SignatureInformation(requestHeader);
            int tolerance = 500 * 60;
            Boolean isRequestTimeValid = instance.isRequestTimeValid(tolerance);
            Assert.False(isRequestTimeValid);
        }

        /// <summary>
        /// Test the method 'isSignatureSafe'
        /// </summary>
        [Fact]
        public void isSignatureSafeTest()
        {
            string requestBody =
                "{\"accountId\":\"AC0123456789abcdefABCDEF0123456789abcdef00\",\"callId\":\"CA0123456789abcdefABCDEF0123456789abcdef00\",\"callStatus\":\"ringing\",\"conferenceId\":null,\"direction\":\"inbound\",\"from\":\"+13121000109\",\"parentCallId\":null,\"queueId\":null,\"requestType\":\"inboundCall\",\"to\":\"+13121000096\"}";
            string signingSecret = "sigsec_ead6d3b6904196c60835d039e91b3341c77a7793";
            Boolean isSignatureSafe = instance.isSignatureSafe(requestBody, signingSecret);
            Assert.True(isSignatureSafe);
        }

        [Fact]
        public void isSignatureSafeTest2()
        {
            string requestBody =
                "{\"accountId\":\"AC0123456789abcdefABCDEF0123456789abcdef00\",\"callId\":\"CA0123456789abcdefABCDEF0123456789abcdef00\",\"callStatus\":\"ringing\",\"conferenceId\":null,\"direction\":\"inbound\",\"from\":\"+13121000109\",\"parentCallId\":null,\"queueId\":null,\"requestType\":\"inboundCall\",\"to\":\"+13121000096\"}";
            string signingSecret = "sigsec_ead6d3b6904196c60835d039e91b3341c77a7794";
            Boolean isSignatureSafe = instance.isSignatureSafe(requestBody, signingSecret);
            Assert.False(isSignatureSafe);
        }
    }
}
