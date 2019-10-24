using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.webhooks.call;
using com.freeclimb.webhooks;
using com.freeclimb;

namespace freeclimb_cs_sdk_test.webhooks.call
{
    [TestClass]
    public class CallStatusCallbackTest
    {
        [TestMethod]
        public void CreateAndVerifyCallStatusCallbackTest()
        {
            CallStatusCallback cs = CallStatusCallback.fromJson("{\"accountId\":\"AC736ca2078721a9a41fb47f07bf40d9e21cb304da\",\"callId\":\"CA7d00ca83adccbdf9d3f502176dbdd09fa5b886aa\",\"callStatus\":\"inProgress\",\"conferenceId\":null,\"dialCallStatus\":\"inProgress\",\"direction\":\"outboundAPI\",\"from\":\"+12248806205\",\"parentCallId\":null,\"queueId\":null,\"requestId\":\"RQ50e91227b8187317d84f5bab9a9460c4a2c4aeb2\",\"requestType\":\"outDialApiConnect\",\"to\":\"+18475978014\"}");

            Assert.AreEqual(cs.getAccountId, "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");
            Assert.AreEqual(cs.getCallId, "CA7d00ca83adccbdf9d3f502176dbdd09fa5b886aa");
            Assert.AreEqual(cs.getCallStatus, ECallStatus.InProgress);
            Assert.AreEqual(cs.getDialCallStatus, ECallStatus.InProgress);
            Assert.IsNull(cs.getConferenceId);
            Assert.AreEqual(cs.getDirection, EDirection.OutboundAPI);
            Assert.AreEqual(cs.getFrom, "+12248806205");
            Assert.IsNull(cs.getParentCallId);
            Assert.IsNull(cs.getQueueId);
            Assert.AreEqual(cs.getRequestId, "RQ50e91227b8187317d84f5bab9a9460c4a2c4aeb2");
            Assert.AreEqual(cs.getRequestType, ERequestType.OutDialApiConnect);
            Assert.AreEqual(cs.getTo, "+18475978014");
        }
    }
}
