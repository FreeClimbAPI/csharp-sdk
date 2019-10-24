using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.webhooks;
using com.freeclimb;

namespace freeclimb_cs_sdk_test
{
    [TestClass]
    public class StatusCallbackTest
    {
        [TestMethod]
        public void CreateAndVerifyStatusCallbackTest()
        {
            StatusCallback sc = StatusCallback.fromJson("{ \"accountId\": \"ACae05391ecca1352e9108d545482a1e6f384e7a49\", \"callDuration\": 41, \"callId\": \"CAbde0362aef3d228b3a39baafa9e4f0204e724966\", \"callStatus\": \"completed\", \"conferenceId\": null, \"direction\": \"inbound\", \"from\": \"+17083168669\", \"parentCallId\": null, \"queueId\": null, \"requestId\": \"RQa766ca5ee92fc6c528b72aff5e8b48f5f4e056e8\", \"requestType\": \"callStatus\", \"to\": \"+12248806211\" }");

            Assert.AreEqual(sc.getAccountId, "ACae05391ecca1352e9108d545482a1e6f384e7a49");
            Assert.AreEqual(sc.getCallDuration, 41);
            Assert.AreEqual(sc.getCallId, "CAbde0362aef3d228b3a39baafa9e4f0204e724966");
            Assert.AreEqual(sc.getCallStatus, ECallStatus.Completed);
            Assert.IsNull(sc.getConferenceId);
            Assert.AreEqual(sc.getDirection, EDirection.Inbound);
            Assert.AreEqual(sc.getFrom, "+17083168669");
            Assert.IsNull(sc.getParentCallId);
            Assert.IsNull(sc.getQueueId);
            Assert.AreEqual(sc.getRequestId, "RQa766ca5ee92fc6c528b72aff5e8b48f5f4e056e8");
            Assert.AreEqual(sc.getRequestType, ERequestType.CallStatus);
            Assert.AreEqual(sc.getTo, "+12248806211");
            Assert.IsNull(sc.getRecordingUrl);
            Assert.IsNull(sc.getRecordingUrl);
            Assert.AreEqual(sc.getRecordingDurationSec,0);
        }
    }
}
