using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.api.call;
using com.freeclimb.api;
using System.Net;
using System;
using System.Reflection;
using com.freeclimb;
using com.freeclimb.api.message;

namespace freeclimb_cs_sdk_test.api.call
{
    [TestClass]
    public class MessagesRequesterTest
    {
        [TestMethod]
        public void MakeADefaultMessagesRequesterTest()
        {
            try
            {
                MessagesRequester req = new MessagesRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Assert.AreEqual(req.getAccountId, "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");
                Assert.AreEqual(req.getApiKey, "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5");
            }
            catch (FreeClimbException pe)
            {
                Assert.Fail(pe.Message);
            }
        }


        [TestMethod]
        public void MakeAInitialSmsRequestWithRequiredFieldsTest()
        {
            try
            {
                MessagesRequester messagesRequester = new MessagesRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Type messagesRequesterType = typeof(MessagesRequester);
                MethodInfo freeClimbUrlMethodInfo = messagesRequesterType.GetMethod("SetFreeClimbUrl",
                                                                             BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                                                                             null,
                                                                             new Type[] { typeof(System.String) },
                                                                             null);
                freeClimbUrlMethodInfo.Invoke(messagesRequester, new Object[] { "http://MakeAInitialSmsRequestTest:3000" });

                WebRequest.RegisterPrefix("http://MakeAInitialSmsRequestTest:3000", new TestWebRequestCreate());

                string to = "+18475978014";
                string from = "+12248806205";
                string text = "Hello World";
                
                
                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"uri\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Messages/MM16ac1bcbd6f4895c89a798571e89e1e715892924\", \"revision\" : 1, \"dateCreated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"dateUpdated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"messageId\" : \"MM16ac1bcbd6f4895c89a798571e89e1e715892924\", \"accountId\" : \"AC736ca2078721a9a41fb47f07bf40d9e21cb304da\", \"from\" : \"" + from + "\", \"to\" : \"" + to + "\", \"text\" : \"" + text + "\", \"direction\" : \"outbound\", \"status\" : \"queued\"}");
                Message msg = messagesRequester.create(from,to,text);

                Assert.IsNotNull(msg);
                Assert.IsNotNull(msg.getUri);
                Assert.AreEqual(msg.getUri, "/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Messages/MM16ac1bcbd6f4895c89a798571e89e1e715892924");
                Assert.AreEqual(msg.getRevision, 1);
                Assert.IsNotNull(msg.getDateCreated);
                Assert.IsNotNull(msg.getDateUpdated);
                Assert.AreEqual(msg.getDirection, com.freeclimb.EMessageDirection.Outbound);
                Assert.AreEqual(msg.getStatus, com.freeclimb.EMessageStatus.Queued);
                Assert.AreEqual(msg.getFrom, from);
                Assert.AreEqual(msg.getTo, to);
                Assert.AreEqual(msg.getText, text);
                
            }
            catch (FreeClimbException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void MakeAInitialSmsRequestWithOptionalFieldsTest()
        {
            try
            {
                MessagesRequester messagesRequester = new MessagesRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Type messagesRequesterType = typeof(MessagesRequester);
                MethodInfo freeClimbUrlMethodInfo = messagesRequesterType.GetMethod("SetFreeClimbUrl",
                                                                             BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                                                                             null,
                                                                             new Type[] { typeof(System.String) },
                                                                             null);
                freeClimbUrlMethodInfo.Invoke(messagesRequester, new Object[] { "http://MakeAInitialSmsRequestTest:3000" });

                WebRequest.RegisterPrefix("http://MakeAInitialSmsRequestTest:3000", new TestWebRequestCreate());

                string to = "+18475978014";
                string from = "+12248806205";
                string text = "Hello World";
                string notifUrl = "http://server/msgNotif";
                MessageOptions options = new MessageOptions();
                options.setNotificationUrl(notifUrl);

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"uri\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Messages/MM16ac1bcbd6f4895c89a798571e89e1e715892924\", \"revision\" : 1, \"dateCreated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"dateUpdated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"messageId\" : \"MM16ac1bcbd6f4895c89a798571e89e1e715892924\", \"accountId\" : \"AC736ca2078721a9a41fb47f07bf40d9e21cb304da\", \"from\" : \"" + from + "\", \"to\" : \"" + to + "\", \"text\" : \"" + text + "\", \"direction\" : \"outbound\", \"status\" : \"sending\", \"notificationUrl\" : \"" + notifUrl + "\"}");
                Message msg = messagesRequester.create(from, to, text, options);

                Assert.IsNotNull(msg);
                Assert.IsNotNull(msg.getUri);
                Assert.AreEqual(msg.getUri, "/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Messages/MM16ac1bcbd6f4895c89a798571e89e1e715892924");
                Assert.AreEqual(msg.getRevision, 1);
                Assert.IsNotNull(msg.getDateCreated);
                Assert.IsNotNull(msg.getDateUpdated);
                Assert.AreEqual(msg.getDirection, com.freeclimb.EMessageDirection.Outbound);
                Assert.AreEqual(msg.getStatus, com.freeclimb.EMessageStatus.Sending);
                Assert.AreEqual(msg.getFrom, from);
                Assert.AreEqual(msg.getTo, to);
                Assert.AreEqual(msg.getText, text);
                Assert.AreEqual(msg.getNotificationUrl, notifUrl);
                
            }
            catch (FreeClimbException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void MakeAFailedSmsRequestWithNotRequiredFieldsTest()
        {
            try
            {
                MessagesRequester messagesRequester = new MessagesRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Type messagesRequesterType = typeof(MessagesRequester);
                MethodInfo freeClimbUrlMethodInfo = messagesRequesterType.GetMethod("SetFreeClimbUrl",
                                                                             BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                                                                             null,
                                                                             new Type[] { typeof(System.String) },
                                                                             null);
                freeClimbUrlMethodInfo.Invoke(messagesRequester, new Object[] { "http://MakeAInitialSmsRequestTest:3000" });

                WebRequest.RegisterPrefix("http://MakeAInitialSmsRequestTest:3000", new TestWebRequestCreate());

                string to = "";
                string from = "+12248806205";
                string text = "Hello World";

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"uri\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Messages/MM16ac1bcbd6f4895c89a798571e89e1e715892924\", \"revision\" : 1, \"dateCreated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"dateUpdated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"messageId\" : \"MM16ac1bcbd6f4895c89a798571e89e1e715892924\", \"accountId\" : \"AC736ca2078721a9a41fb47f07bf40d9e21cb304da\", \"from\" : \"" + from + "\", \"to\" : \"" + to + "\", \"text\" : \"" + text + "\", \"direction\" : \"outbound\", \"status\" : \"sending\"}");
                Message msg = messagesRequester.create(from,to,text);
            }
            catch (FreeClimbException /* pe */)
            {
                Assert.IsTrue(true);
                return;
            }
            // if no exception, it fails
            Assert.Fail();
        }

        [TestMethod]
        public void GetMessageListTest()
        {
            try
            {
                MessagesRequester requester = new MessagesRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("freeClimbUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://GetMessageListTest:3000");
                }

                string to = "+18475978014";
                string from = "+12248806205";
                string text = "Hello World";

                WebRequest.RegisterPrefix("http://GetMessageListTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{\"total\":3,\"start\":0,\"end\":1,\"page\":0,\"numPages\":2,\"pageSize\":2,\"nextPageUri\":\"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Messages&cursor=492dc883a811bd0204204ea9047122f93a2788a2\", \"messages\" : [{\"uri\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Messages/MM16ac1bcbd6f4895c89a798571e89e1e715892924\", \"revision\" : 1, \"dateCreated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"dateUpdated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"messageId\" : \"MM16ac1bcbd6f4895c89a798571e89e1e715892924\", \"accountId\" : \"AC736ca2078721a9a41fb47f07bf40d9e21cb304da\", \"from\" : \"" + from + "\", \"to\" : \"" + to + "\", \"text\" : \"" + text + "\", \"direction\" : \"inbound\", \"status\" : \"received\"}, {\"uri\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Messages/MM16ac1bcbd6f4895c89a798571e89e1e715892925\", \"revision\" : 1, \"dateCreated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"dateUpdated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"messageId\" : \"MM16ac1bcbd6f4895c89a798571e89e1e715892925\", \"accountId\" : \"AC736ca2078721a9a41fb47f07bf40d9e21cb304da\", \"from\" : \"" + from + "\", \"to\" : \"" + to + "\", \"text\" : \"" + text + "\", \"direction\" : \"inbound\", \"status\" : \"received\"}]}");


                MessageList msgList = requester.get();

                Assert.IsNotNull(msgList);

                Assert.AreEqual(msgList.getLocalSize, 2);
                Assert.AreEqual((msgList.export()).Count, 2);

                Message msg = msgList.get(0) as Message;

                Assert.IsNotNull(msg);
                Assert.AreEqual(msg.getMessageId, "MM16ac1bcbd6f4895c89a798571e89e1e715892924");

                type = typeof(APIRequester);
                fieldInfo = type.GetField("freeClimbUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(msgList, "http://GetMessageListTest:3000");
                }

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{\"total\":3,\"start\":2,\"end\":2,\"page\":1,\"numPages\":2,\"pageSize\":2,\"nextPageUri\":null, \"messages\" : [{\"uri\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Messages/MM16ac1bcbd6f4895c89a798571e89e1e715892926\", \"revision\" : 1, \"dateCreated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"dateUpdated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"messageId\" : \"MM16ac1bcbd6f4895c89a798571e89e1e715892926\", \"accountId\" : \"AC736ca2078721a9a41fb47f07bf40d9e21cb304da\", \"from\" : \"" + from + "\", \"to\" : \"" + to + "\", \"text\" : \"" + text + "\", \"direction\" : \"inbound\", \"status\" : \"received\"}]}");

                msgList.loadNextPage();

                Assert.IsNotNull(msgList);

                Assert.AreEqual(msgList.getLocalSize, 3);
                Assert.AreEqual((msgList.export()).Count, 3);

                msg = msgList.get(2) as Message;
                Assert.IsNotNull(msg);
                Assert.AreEqual(msg.getMessageId, "MM16ac1bcbd6f4895c89a798571e89e1e715892926");
            }
            catch (FreeClimbException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void GetMessageListWithFiltersTest()
        {
            try
            {
                MessagesRequester requester = new MessagesRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("freeClimbUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://GetMessageListTest:3000");
                }

                string to = "+18475978014";
                string from = "+12248806205";
                string text = "Hello World";

                WebRequest.RegisterPrefix("http://GetMessageListTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{\"total\":1,\"start\":0,\"end\":0,\"page\":0,\"numPages\":1,\"pageSize\":2,\"nextPageUri\":null, \"messages\" : [{\"uri\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Messages/MM16ac1bcbd6f4895c89a798571e89e1e715892926\", \"revision\" : 1, \"dateCreated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"dateUpdated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"messageId\" : \"MM16ac1bcbd6f4895c89a798571e89e1e715892926\", \"accountId\" : \"AC736ca2078721a9a41fb47f07bf40d9e21cb304da\", \"from\" : \"" + from + "\", \"to\" : \"" + to + "\", \"text\" : \"" + text + "\", \"direction\" : \"inbound\", \"status\" : \"received\"}]}");

                MessagesSearchFilter filters = new MessagesSearchFilter();
                filters.setFrom(from);
                filters.setDirection(com.freeclimb.EMessageDirection.Inbound);
                DateTime now = DateTime.Now;
                DateTime yesterday = now.AddDays(-1);
                string dateFormatStr = "yyyy-MM-dd HH:mm:ss";
                filters.setBeginTime(yesterday.ToString(dateFormatStr));
                filters.setEndTime(now.ToString(dateFormatStr));
                MessageList msgList = requester.get(filters);

                Assert.IsNotNull(msgList);

                Assert.AreEqual(msgList.getLocalSize, 1);
                Assert.AreEqual((msgList.export()).Count, 1);

                Message msg = msgList.get(0) as Message;

                Assert.IsNotNull(msg);
                Assert.AreEqual(msg.getMessageId, "MM16ac1bcbd6f4895c89a798571e89e1e715892926");
                Assert.AreEqual(msg.getFrom, from);

            }
            catch (FreeClimbException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void GetMessageTest()
        {
            try
            {
                MessagesRequester requester = new MessagesRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("freeClimbUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://GetMessageTest:3000");
                }

                WebRequest.RegisterPrefix("http://GetMessageTest:3000", new TestWebRequestCreate());

                string to = "+18475978014";
                string from = "+12248806205";
                string text = "Hello World";
                string notifUrl = "http://server/msgNotif";

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"uri\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Messages/MM16ac1bcbd6f4895c89a798571e89e1e715892924\", \"revision\" : 1, \"dateCreated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"dateUpdated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"messageId\" : \"MM16ac1bcbd6f4895c89a798571e89e1e715892924\", \"accountId\" : \"AC736ca2078721a9a41fb47f07bf40d9e21cb304da\", \"from\" : \"" + from + "\", \"to\" : \"" + to + "\", \"text\" : \"" + text + "\", \"direction\" : \"outbound\", \"status\" : \"queued\", \"notificationUrl\" : \"" + notifUrl + "\"}");

                Message msg = requester.get("MM16ac1bcbd6f4895c89a798571e89e1e715892924");

                Assert.IsNotNull(msg);
                Assert.AreEqual(msg.getMessageId, "MM16ac1bcbd6f4895c89a798571e89e1e715892924");
                Assert.AreEqual(msg.getFrom, from);
                Assert.AreEqual(msg.getTo, to);
                Assert.AreEqual(msg.getText, text);
                Assert.AreEqual(msg.getDirection, com.freeclimb.EMessageDirection.Outbound);
                Assert.AreEqual(msg.getStatus, com.freeclimb.EMessageStatus.Queued);
                Assert.AreEqual(msg.getNotificationUrl, notifUrl);
            }
            catch (FreeClimbException pe)
            {
                Assert.Fail(pe.Message);
            }
        }
    }
}
