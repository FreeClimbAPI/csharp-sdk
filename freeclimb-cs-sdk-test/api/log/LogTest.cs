using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.api.recording;
using com.freeclimb.api.application;
using com.freeclimb.api.log;
using com.freeclimb;

namespace freeclimb_cs_sdk_test.api.log
{
    [TestClass]
    public class LogTest
    {
        [TestMethod]
        public void MakeLogFromJsonTest()
        {
            string json = "{\"hostname\":\"spv07vcs10\",\"subsystem\":\"vcsserver\",\"timestamp\":1485450179059490,\"scope\":\"public\",\"level\":\"info\",\"accountId\":\"AC907d7e328b3a5b402fa908857e047a243a8949b1\",\"requestId\":\"RQ5c8c6d7df5d19096eb71ce516a39ade6aa1b0d4f\",\"callId\":\"CA5c8c6d7df5d19096eb71ce516a39ade6aa1b0d4f\",\"message\":\"Customer Response 200 : POST http://172.29.11.10/FreeClimbSurvey/FreeClimbSurvey/CallStatus\",\"metadata\":{}}";
            Log log = Log.fromJson(json);

            Assert.IsNotNull(log);
            Assert.AreEqual(log.getAccountId, "AC907d7e328b3a5b402fa908857e047a243a8949b1");
            Assert.AreNotEqual(log.getLevel, ELogLevel.NONE);
            Assert.AreEqual(log.getCallId, "CA5c8c6d7df5d19096eb71ce516a39ade6aa1b0d4f");
            Assert.IsNotNull(log.getTimestamp);
            Assert.AreEqual(log.getMessage, "Customer Response 200 : POST http://172.29.11.10/FreeClimbSurvey/FreeClimbSurvey/CallStatus");
            Assert.IsNotNull(log.getMetadata);
            Assert.AreEqual(log.getRequestId, "RQ5c8c6d7df5d19096eb71ce516a39ade6aa1b0d4f");
        }

    }
}
