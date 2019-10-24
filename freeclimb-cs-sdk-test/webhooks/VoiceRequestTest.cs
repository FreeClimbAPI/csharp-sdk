using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.webhooks;
using com.freeclimb;

namespace freeclimb_cs_sdk_test.webhooks
{
    [TestClass]
    public class VoiceRequestTest
    {
        [TestMethod]
        public void CreateAndVerifyVoiceRequestTest()
        {
            VoiceRequest vr = VoiceRequest.fromJson("{ \"accountId\": \"ACae05391ecca1352e9108d545482a1e6f384e7a49\", \"callId\": \"CAbde0362aef3d228b3a39baafa9e4f0204e724966\", \"callStatus\": \"ringing\", \"conferenceId\": null, \"direction\": \"inbound\", \"from\": \"+17083168669\", \"parentCallId\": null, \"queueId\": null, \"requestId\": \"RQ0c74d2e880709c85e8a4e3093b85b910eee4110b\", \"requestType\": \"inboundCall\", \"to\": \"+12248806211\" }");

            Assert.AreEqual(vr.getAccountId, "ACae05391ecca1352e9108d545482a1e6f384e7a49");
            Assert.AreEqual(vr.getCallId, "CAbde0362aef3d228b3a39baafa9e4f0204e724966");
            Assert.AreEqual(vr.getCallStatus, ECallStatus.Ringing);
            Assert.IsNull(vr.getConferenceId);
            Assert.AreEqual(vr.getDirection,EDirection.Inbound);
            Assert.AreEqual(vr.getFrom, "+17083168669");
            Assert.IsNull(vr.getParentCallId);
            Assert.IsNull(vr.getQueueId);
            Assert.AreEqual(vr.getRequestId, "RQ0c74d2e880709c85e8a4e3093b85b910eee4110b");
            Assert.AreEqual(vr.getRequestType, ERequestType.InboundCall);
            Assert.AreEqual(vr.getTo, "+12248806211");
        }
    }
}
