using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.api.queue;

namespace freeclimb_cs_sdk_test.api.queue
{
    [TestClass]
    public class QueueMemberTest
    {
        [TestMethod]
        public void MakeQueueMemberFromJsonTest()
        {
            string json = "{\"callId\": \"CA386025c9bf5d6052a1d1ea42b4d16662\", \"dateEnqueued\": \"Thu, 23 Jun 2016 17:30:06 GMT\",\"waitTime\": 30,\"position\": 1, \"uri\": \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Queues/QU5ef8732a3c49700934481addd5ce1659/Members/CA386025c9bf5d6052a1d1ea42b4d16662\"}";
            QueueMember queueMember = QueueMember.fromJson(json);

            Assert.IsNotNull(queueMember);
            Assert.IsNotNull(queueMember.getUri);
            Assert.AreEqual(queueMember.getUri, "/Accounts/AC142c48f2ee663e214c19ea459516068c/Queues/QU5ef8732a3c49700934481addd5ce1659/Members/CA386025c9bf5d6052a1d1ea42b4d16662");
            Assert.IsNotNull(queueMember.getCallId);
            Assert.AreEqual(queueMember.getCallId, "CA386025c9bf5d6052a1d1ea42b4d16662");
        }
    }
}
