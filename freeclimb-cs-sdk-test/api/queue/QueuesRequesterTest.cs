using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.api.queue;
using com.freeclimb.api;
using System.Reflection;
using System.Net;

namespace freeclimb_cs_sdk_test.api.queue
{
    [TestClass]
    public class QueuesRequesterTest
    {
        [TestMethod]
        public void DefaultQueueCreateTest()
        {
            QueuesRequester queuesRequester = new QueuesRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

            Type type = typeof(APIRequester);
            FieldInfo fieldInfo = type.GetField("freeClimbUrl", BindingFlags.NonPublic | BindingFlags.Instance);
            if (fieldInfo != null)
            {
                fieldInfo.SetValue(queuesRequester, "http://DefaultQueueCreate:3000");
            }

            WebRequest.RegisterPrefix("http://DefaultQueueCreate:3000", new TestWebRequestCreate());
            TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                         "{\"uri\": \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Queues/QU5ef8732a3c49700934481addd5ce1659\", \"dateCreated\": \"Mon, 11 Aug 2014 22:00:14 GMT\", \"dateUpdated\": \"Mon, 11 Aug 2014 22:00:14 GMT\", \"revision\": 1, \"queueId\": \"QU5ef8732a3c49700934481addd5ce1659\", \"alias\": null, \"currentSize\": 0, \"maxSize\": 100, \"averageWaitTime\": 0}");

            Queue queue = queuesRequester.create();

            Assert.IsNotNull(queue);
            Assert.AreEqual(queue.getUri, "/Accounts/AC142c48f2ee663e214c19ea459516068c/Queues/QU5ef8732a3c49700934481addd5ce1659");
            Assert.AreEqual(queue.getQueueId, "QU5ef8732a3c49700934481addd5ce1659");
        }

        [TestMethod]
        public void QueueCreateWithOptionsTest()
        {
            QueuesRequester queuesRequester = new QueuesRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

            Type type = typeof(APIRequester);
            FieldInfo fieldInfo = type.GetField("freeClimbUrl", BindingFlags.NonPublic | BindingFlags.Instance);
            if (fieldInfo != null)
            {
                fieldInfo.SetValue(queuesRequester, "http://QueueCreateWithOptions:3000");
            }

            WebRequest.RegisterPrefix("http://QueueCreateWithOptions:3000", new TestWebRequestCreate());
            TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                         "{\"uri\": \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Queues/QU5ef8732a3c49700934481addd5ce1659\", \"dateCreated\": \"Mon, 11 Aug 2014 22:00:14 GMT\", \"dateUpdated\": \"Mon, 11 Aug 2014 22:00:14 GMT\", \"revision\": 1, \"queueId\": \"QU5ef8732a3c49700934481addd5ce1659\", \"alias\": \"newQueue\", \"currentSize\": 0, \"maxSize\": 1000, \"averageWaitTime\": 0}");

            QueueOptions queueOptions = new QueueOptions();
            queueOptions.setAlias("newQueue");
            queueOptions.setMaxSize(1000);
            Queue queue = queuesRequester.create(queueOptions);

            Assert.IsNotNull(queue);
            Assert.AreEqual(queue.getUri, "/Accounts/AC142c48f2ee663e214c19ea459516068c/Queues/QU5ef8732a3c49700934481addd5ce1659");
            Assert.AreEqual(queue.getQueueId, "QU5ef8732a3c49700934481addd5ce1659");
        }

        [TestMethod]
        public void QueueCreateWithOptionsWithRequestIdTest()
        {
            QueuesRequester queuesRequester = new QueuesRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

            Type type = typeof(APIRequester);
            FieldInfo fieldInfo = type.GetField("freeClimbUrl", BindingFlags.NonPublic | BindingFlags.Instance);
            if (fieldInfo != null)
            {
                fieldInfo.SetValue(queuesRequester, "http://QueueCreateWithOptions:3000");
            }

            WebRequest.RegisterPrefix("http://QueueCreateWithOptions:3000", new TestWebRequestCreate());
            TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                         "{\"uri\": \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Queues/QU5ef8732a3c49700934481addd5ce1659\", \"dateCreated\": \"Mon, 11 Aug 2014 22:00:14 GMT\", \"dateUpdated\": \"Mon, 11 Aug 2014 22:00:14 GMT\", \"revision\": 1, \"queueId\": \"QU5ef8732a3c49700934481addd5ce1659\", \"alias\": \"newQueue\", \"currentSize\": 0, \"maxSize\": 1000, \"averageWaitTime\": 0}");

            QueueOptions queueOptions = new QueueOptions();
            queueOptions.setAlias("newQueue");
            queueOptions.setMaxSize(1000);
            queueOptions.setRequestId("RQ1234567890123456789012345678901234567890");
            Queue queue = queuesRequester.create(queueOptions);

            Assert.IsNotNull(queue);
            Assert.AreEqual(queue.getUri, "/Accounts/AC142c48f2ee663e214c19ea459516068c/Queues/QU5ef8732a3c49700934481addd5ce1659");
            Assert.AreEqual(queue.getQueueId, "QU5ef8732a3c49700934481addd5ce1659");
        }

        [TestMethod]
        public void QueueMemberTest()
        {
            QueuesRequester queuesRequester = new QueuesRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

            Type type = typeof(APIRequester);
            FieldInfo fieldInfo = type.GetField("freeClimbUrl", BindingFlags.NonPublic | BindingFlags.Instance);
            if (fieldInfo != null)
            {
                fieldInfo.SetValue(queuesRequester, "http://QueueMember:3000");
            }

            WebRequest.RegisterPrefix("http://QueueMember:3000", new TestWebRequestCreate());
            TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                         "{\"callId\": \"CA386025c9bf5d6052a1d1ea42b4d16662\", \"dateEnqueued\": \"Thu, 23 Jun 2016 17:30:06 GMT\",\"waitTime\": 30,\"position\": 1, \"uri\": \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Queues/QU5ef8732a3c49700934481addd5ce1659/Members/CA386025c9bf5d6052a1d1ea42b4d16662\"}");

            QueueMember queueMember = queuesRequester.getQueueMember("QU5ef8732a3c49700934481addd5ce1659", "CA386025c9bf5d6052a1d1ea42b4d16662");

            Assert.IsNotNull(queueMember);
            Assert.IsNotNull(queueMember.getUri);
            Assert.AreEqual(queueMember.getUri, "/Accounts/AC142c48f2ee663e214c19ea459516068c/Queues/QU5ef8732a3c49700934481addd5ce1659/Members/CA386025c9bf5d6052a1d1ea42b4d16662");
            Assert.IsNotNull(queueMember.getCallId);
            Assert.AreEqual(queueMember.getCallId, "CA386025c9bf5d6052a1d1ea42b4d16662");
        }

        [TestMethod]
        public void QueueMemberListTest()
        {
            try
            { 
                QueuesRequester queuesRequester = new QueuesRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Type callsRequesterType = typeof(QueuesRequester);
                MethodInfo freeClimbUrlMethodInfo = callsRequesterType.GetMethod("SetFreeClimbUrl",
                                                                             BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                                                                             null,
                                                                             new Type[] { typeof(System.String) },
                                                                             null);
                freeClimbUrlMethodInfo.Invoke(queuesRequester, new Object[] { "http://QueueMemberList:3000" });

                WebRequest.RegisterPrefix("http://QueueMemberList:3000", new TestWebRequestCreate());
                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"page\": 0, \"numPages\": 2, \"pageSize\": 2, \"total\": 3, \"start\": 0, \"end\": 1, \"nextPageUri\": \"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Queues&cursor=492dc883a811bd0204204ea9047122f93a2788a2\", \"queueMembers\": [{\"callId\": \"CA386025c9bf5d6052a1d1ea42b4d16662\", \"dateEnqueued\": \"Mon, 11 Aug 2014 22:00:14 GMT\",\"waitTime\": 30,\"position\": 1, \"uri\": \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Queues/QU5ef8732a3c49700934481addd5ce1659/Members/CA386025c9bf5d6052a1d1ea42b4d16662\"},{\"callId\": \"CA386025c9bf5d6052a1d1ea42b4d16662\", \"dateEnqueued\": \"Mon, 11 Aug 2014 22:00:14 GMT\",\"waitTime\": 30,\"position\": 1, \"uri\": \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Queues/QU5ef8732a3c49700934481addd5ce1659/Members/CA386025c9bf5d6052a1d1ea42b4d16662\"}]}");

                QueueMemberList queueMemberList = queuesRequester.getMembers("QU5ef8732a3c49700934481addd5ce1659");

                Assert.IsNotNull(queueMemberList);

                Assert.AreEqual(queueMemberList.getLocalSize, 2);
                Assert.AreEqual((queueMemberList.export()).Count, 2);

                QueueMember queueMember = queueMemberList.get(0) as QueueMember;

                Assert.IsNotNull(queueMember);
                Assert.AreEqual(queueMember.getCallId, "CA386025c9bf5d6052a1d1ea42b4d16662");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("freeClimbUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(queueMemberList, "http://QueueMemberList:3000");
                }

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"page\": 1, \"numPages\": 2, \"pageSize\": 2, \"total\": 3, \"start\": 2, \"end\": 2, \"nextPageUri\": null, \"queueMembers\": [{\"callId\": \"CA386025c9bf5d6052a1d1ea42b4d16663\", \"dateEnqueued\": \"Mon, 11 Aug 2014 22:00:14 GMT\",\"waitTime\": 30,\"position\": 1, \"uri\": \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Queues/ QU5ef8732a3c49700934481addd5ce1659/Members/CA386025c9bf5d6052a1d1ea42b4d16662\"}]}");

                queueMemberList.loadNextPage();

                Assert.IsNotNull(queueMemberList);

                Assert.AreEqual(queueMemberList.getLocalSize, 3);
                Assert.AreEqual((queueMemberList.export()).Count, 3);

                queueMember = queueMemberList.get(2) as QueueMember;

                Assert.IsNotNull(queueMember);
                Assert.AreEqual(queueMember.getCallId, "CA386025c9bf5d6052a1d1ea42b4d16663");
            }
            catch (FreeClimbException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void QueueListTest()
        {
            try
            {
                QueuesRequester queuesRequester = new QueuesRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Type callsRequesterType = typeof(QueuesRequester);
                MethodInfo freeClimbUrlMethodInfo = callsRequesterType.GetMethod("SetFreeClimbUrl",
                                                                             BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                                                                             null,
                                                                             new Type[] { typeof(System.String) },
                                                                             null);
                freeClimbUrlMethodInfo.Invoke(queuesRequester, new Object[] { "http://QueueList:3000" });

                WebRequest.RegisterPrefix("http://QueueList:3000", new TestWebRequestCreate());
                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"page\": 0, \"numPages\": 2, \"pageSize\": 2, \"total\": 3, \"start\": 0, \"end\": 1, \"nextPageUri\": \"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Queues&cursor=492dc883a811bd0204204ea9047122f93a2788a2\", \"queues\": [{\"uri\": \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Queues/QU5ef8732a3c49700934481addd5ce1659\", \"dateCreated\": \"Mon, 11 Aug 2014 22:00:14 GMT\", \"dateUpdated\": \"Mon, 11 Aug 2014 22:00:14 GMT\", \"revision\": 1, \"queueId\": \"QU5ef8732a3c49700934481addd5ce1659\", \"alias\": \"newqueue\", \"currentSize\": 0, \"maxSize\": 100, \"averageWaitTime\": 0},{\"uri\": \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Queues/QU5ef8732a3c49700934481addd5ce1659\", \"dateCreated\": \"Mon, 11 Aug 2014 22:00:14 GMT\", \"dateUpdated\": \"Mon, 11 Aug 2014 22:00:14 GMT\", \"revision\": 1, \"queueId\": \"QU5ef8732a3c49700934481addd5ce1659\", \"alias\": \"newqueue\", \"currentSize\": 0, \"maxSize\": 100, \"averageWaitTime\": 0}]}");
                QueueList queueList = queuesRequester.get();

                Assert.IsNotNull(queueList);

                Assert.AreEqual(queueList.getLocalSize, 2);
                Assert.AreEqual((queueList.export()).Count, 2);

                Queue queue = queueList.get(0) as Queue;

                Assert.IsNotNull(queue);
                Assert.AreEqual(queue.getQueueId, "QU5ef8732a3c49700934481addd5ce1659");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("freeClimbUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(queueList, "http://QueueList:3000");
                }

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"page\": 1, \"numPages\": 2, \"pageSize\": 2, \"total\": 3, \"start\": 2, \"end\": 2, \"nextPageUri\": null, \"queues\": [{\"uri\": \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Queues/QU5ef8732a3c49700934481addd5ce1659\", \"dateCreated\": \"Mon, 11 Aug 2014 22:00:14 GMT\", \"dateUpdated\": \"Mon, 11 Aug 2014 22:00:14 GMT\", \"revision\": 1, \"queueId\": \"QU5ef8732a3c49700934481addd5ce1670\", \"alias\": \"newqueue\", \"currentSize\": 0, \"maxSize\": 100, \"averageWaitTime\": 0}]}");

                queueList.loadNextPage();

                Assert.IsNotNull(queueList);

                Assert.AreEqual(queueList.getLocalSize, 3);
                Assert.AreEqual((queueList.export()).Count, 3);

                queue = queueList.get(2) as Queue;

                Assert.IsNotNull(queue);
                Assert.AreEqual(queue.getQueueId, "QU5ef8732a3c49700934481addd5ce1670");
            }
            catch (FreeClimbException pe)
            {
                Assert.Fail(pe.Message);
            }
        }
    }
}
