using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.percl;
using com.freeclimb.api;
using System;

namespace freeclimb_cs_sdk_test.percl
{
    [TestClass]
    public class EnqueueTest
    {
        [TestMethod]
        public void EnqueueRequiredTest()
        {
            Enqueue enqueue = new Enqueue("14f487e2-de1a-4a45-a682-5df8e3f3458d", "http://foo.com");

            string json = enqueue.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"Enqueue\":{\"queueId\":\"14f487e2-de1a-4a45-a682-5df8e3f3458d\",\"actionUrl\":\"http://foo.com\",\"waitUrl\":null,\"notificationUrl\":null}}");
        }

        [TestMethod]
        public void EnqueueRequiredWithWaitUrlTest()
        {
            Enqueue enqueue = new Enqueue("14f487e2-de1a-4a45-a682-5df8e3f3458d", "http://foo.com");

            enqueue.setWaitUrl("http://foo.com/wait");
            string json = enqueue.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"Enqueue\":{\"queueId\":\"14f487e2-de1a-4a45-a682-5df8e3f3458d\",\"actionUrl\":\"http://foo.com\",\"waitUrl\":\"http://foo.com/wait\",\"notificationUrl\":null}}");
        }

        [TestMethod]
        public void EnqueueRequiredWithNotificationUrlTest()
        {
            Enqueue enqueue = new Enqueue("14f487e2-de1a-4a45-a682-5df8e3f3458d", "http://foo.com");

            enqueue.setNotificationUrl("http://foo.com/notif");
            string json = enqueue.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"Enqueue\":{\"queueId\":\"14f487e2-de1a-4a45-a682-5df8e3f3458d\",\"actionUrl\":\"http://foo.com\",\"waitUrl\":null,\"notificationUrl\":\"http://foo.com/notif\"}}");
        }

        [TestMethod]
        public void EnqueueRequiredWithAllTest()
        {
            Enqueue enqueue = new Enqueue("14f487e2-de1a-4a45-a682-5df8e3f3458d", "http://foo.com");

            enqueue.setNotificationUrl("http://foo.com/notif");
            enqueue.setWaitUrl("http://foo.com/wait");
            string json = enqueue.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"Enqueue\":{\"queueId\":\"14f487e2-de1a-4a45-a682-5df8e3f3458d\",\"actionUrl\":\"http://foo.com\",\"waitUrl\":\"http://foo.com/wait\",\"notificationUrl\":\"http://foo.com/notif\"}}");
        }
    }
}
