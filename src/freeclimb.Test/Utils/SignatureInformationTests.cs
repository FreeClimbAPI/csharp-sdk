using Xunit;

using freeclimb.Utils;
using System;

namespace freeclimb.Test.Utils
{
    public class SignatureInformationTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AccountRequest
        private SignatureInformation instance;

        public SignatureInformationTests()
        {
            string requestHeader = "t=1679944186,v1=c3957749baf61df4b1506802579cc69a74c77a1ae21447b930e5a704f9ec4120,v1=1ba18712726898fbbe48cd862dd096a709f7ad761a5bab14bda9ac24d963a6a8";
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
            int tolerance = 5 * 60;
            Boolean isRequestTimeValid = instance.isRequestTimeValid(tolerance);
            Assert.Equal<Boolean>(isRequestTimeValid, true);
        }
        /// <summary>
        /// Test the method 'isSignatureSafe'
        /// </summary>
        [Fact]
        public void isSignatureSafeTest()
        {
            string requestBody = "{\"accountId\":\"AC1334ffb694cd8d969f51cddf5f7c9b478546d50c\",\"callId\":\"CAccb0b00506553cda09b51c5477f672a49e0b2213\",\"callStatus\":\"ringing\",\"conferenceId\":null,\"direction\":\"inbound\",\"from\":\"+13121000109\",\"parentCallId\":null,\"queueId\":null,\"requestType\":\"inboundCall\",\"to\":\"+13121000096\"}";
            string signingSecret = "sigsec_ead6d3b6904196c60835d039e91b3341c77a7793";
            Boolean isSignatureSafe = instance.isSignatureSafe(requestBody, signingSecret);
            Assert.Equal<Boolean>(isSignatureSafe, true);
        }
    }
}