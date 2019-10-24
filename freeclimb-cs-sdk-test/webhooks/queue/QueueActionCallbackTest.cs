using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.webhooks.queue;
using com.freeclimb;

namespace freeclimb_cs_sdk_test.webhooks.queue
{
    [TestClass]
    public class QueueActionCallbackTest
    {
        [TestMethod]
        public void CreateAndVerifyQueueActionCallbackTest()
        {
            QueueActionCallback qa = QueueActionCallback.fromJson("{\"accountId\":\"AC736ca2078721a9a41fb47f07bf40d9e21cb304da\",\"callId\":\"CA7d00ca83adccbdf9d3f502176dbdd09fa5b886aa\",\"callStatus\":\"inProgress\",\"conferenceId\":null,\"dialCallStatus\":\"inProgress\",\"direction\":\"outboundAPI\",\"from\":\"+12248806205\",\"parentCallId\":null,\"queueId\":\"QU5ef8732a3c49700934481addd5ce1659\",\"requestId\":\"RQ50e91227b8187317d84f5bab9a9460c4a2c4aeb2\",\"requestType\":\"outDialApiConnect\",\"to\":\"+18475978014\",\"queueTime\":12345,\"queueResult\":\"hangup\"}");

            Assert.AreEqual(qa.getAccountId, "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");
            Assert.AreEqual(qa.getCallId, "CA7d00ca83adccbdf9d3f502176dbdd09fa5b886aa");
            Assert.IsNull(qa.getConferenceId);
            Assert.AreEqual(qa.getFrom, "+12248806205");
            Assert.IsNull(qa.getParentCallId);
            Assert.AreEqual(qa.getQueueId, "QU5ef8732a3c49700934481addd5ce1659");
            Assert.AreEqual(qa.getRequestId, "RQ50e91227b8187317d84f5bab9a9460c4a2c4aeb2");
            Assert.AreEqual(qa.getRequestType, ERequestType.OutDialApiConnect);
            Assert.AreEqual(qa.getTo, "+18475978014");
            Assert.AreEqual(qa.getQueueTime, 12345);
            Assert.AreEqual(qa.getQueueResult, EResults.Hangup);
        }
    }
}
