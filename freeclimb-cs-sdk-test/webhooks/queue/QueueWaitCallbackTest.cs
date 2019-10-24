using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.webhooks.queue;
using com.freeclimb;

namespace freeclimb_cs_sdk_test.webhooks.queue
{
    [TestClass]
    public class QueueWaitCallbackTest
    {
        [TestMethod]
        public void CreateAndVerifyQueueWaitCallbackTest()
        {
            QueueWaitCallback qw = QueueWaitCallback.fromJson("{\"accountId\":\"AC736ca2078721a9a41fb47f07bf40d9e21cb304da\",\"callId\":\"CA7d00ca83adccbdf9d3f502176dbdd09fa5b886aa\",\"callStatus\":\"inProgress\",\"conferenceId\":null,\"dialCallStatus\":\"inProgress\",\"direction\":\"outboundAPI\",\"from\":\"+12248806205\",\"parentCallId\":null,\"queueId\":\"QU5ef8732a3c49700934481addd5ce1659\",\"requestId\":\"RQ50e91227b8187317d84f5bab9a9460c4a2c4aeb2\",\"requestType\":\"outDialApiConnect\",\"to\":\"+18475978014\",\"queuePosition\":1,\"queueTime\":12345,\"averageQueueTime\":10,\"currentQueueSize\":100}");

            Assert.AreEqual(qw.getAccountId, "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");
            Assert.AreEqual(qw.getCallId, "CA7d00ca83adccbdf9d3f502176dbdd09fa5b886aa");
            Assert.IsNull(qw.getConferenceId);
            Assert.AreEqual(qw.getFrom, "+12248806205");
            Assert.IsNull(qw.getParentCallId);
            Assert.AreEqual(qw.getQueueId, "QU5ef8732a3c49700934481addd5ce1659");
            Assert.AreEqual(qw.getRequestId, "RQ50e91227b8187317d84f5bab9a9460c4a2c4aeb2");
            Assert.AreEqual(qw.getRequestType, ERequestType.OutDialApiConnect);
            Assert.AreEqual(qw.getTo, "+18475978014");
            Assert.AreEqual(qw.getQueueTime, 12345);
            Assert.AreEqual(qw.getQueuePosition, 1);
            Assert.AreEqual(qw.getCurrentQueueSize, 100);
        }
    }
}
