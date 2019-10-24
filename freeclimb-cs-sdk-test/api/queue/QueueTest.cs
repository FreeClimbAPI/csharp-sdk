using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.api.queue;

namespace freeclimb_cs_sdk_test.api.queue
{
    [TestClass]
    public class QueueTest
    {
        [TestMethod]
        public void MakeQueueFromJsonTest()
        {
            string json = "{ \"uri\": \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Queues/QU5ef8732a3c49700934481addd5ce1659\", \"dateCreated\": \"Mon, 11 Aug 2014 22:00:14 GMT\", \"dateUpdated\": \"Mon, 11 Aug 2014 22:00:14 GMT\", \"revision\": 1, \"queueId\": \"QU5ef8732a3c49700934481addd5ce1659\", \"alias\": \"persistent_queue1\", \"currentSize\": 0, \"maxSize\": 10, \"averageWaitTime\": 0, \"subresourceUris\": { \"members\": \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Queues/QUbbe46ff1274e283f7e3ac1df0072ab39/Members\" }}";

            Queue queue = Queue.fromJson(json);

            Assert.IsNotNull(queue);
            Assert.IsNotNull(queue.getUri);
            Assert.AreEqual(queue.getUri, "/Accounts/AC142c48f2ee663e214c19ea459516068c/Queues/QU5ef8732a3c49700934481addd5ce1659");
            Assert.AreEqual(queue.getQueueId, "QU5ef8732a3c49700934481addd5ce1659");
            Assert.AreEqual(queue.getSubresourceUris.Count, 1);

            string result;
            Assert.IsTrue(queue.getSubresourceUris.TryGetValue(Queue.SubresourceUri.Members, out result));
            Assert.AreEqual(result, "/Accounts/AC142c48f2ee663e214c19ea459516068c/Queues/QUbbe46ff1274e283f7e3ac1df0072ab39/Members");
        }
    }
}