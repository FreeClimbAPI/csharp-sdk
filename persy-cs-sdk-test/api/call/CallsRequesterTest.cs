using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.persephony.api.call;
using com.persephony.api;
using System.Net;
using System;
using System.Reflection;
using com.persephony;

namespace persy_cs_sdk_test.api.call
{
    [TestClass]
    public class CallsRequesterTest
    {
        [TestMethod]
        public void MakeADefaultCallsRequesterTest()
        {
            try
            {
                CallsRequester req = new CallsRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Assert.AreEqual(req.getAccountId, "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");
                Assert.AreEqual(req.getAuthToken, "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void MakeACallsRequestAppIdNoOptionsTest()     
        {
            try
            {
                CallsRequester callsRequester = new CallsRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Type callsRequesterType = typeof(CallsRequester);
                MethodInfo persyUrlMethodInfo = callsRequesterType.GetMethod("setPersyUrl", 
                                                                             BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, 
                                                                             null, 
                                                                             new Type[] { typeof(System.String) }, 
                                                                             null);
                persyUrlMethodInfo.Invoke(callsRequester, new Object[] { "http://MakeACallsRequestAppIdNoOptionsTest:3000" });

                WebRequest.RegisterPrefix("http://MakeACallsRequestAppIdNoOptionsTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"uri\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924\", \"revision\" : 1, \"dateCreated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"dateUpdated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"callId\" : \"CA16ac1bcbd6f4895c89a798571e89e1e715892924\", \"parentCallId\" : null, \"accountId\" : \"AC736ca2078721a9a41fb47f07bf40d9e21cb304da\", \"from\" : \"+12248806205\", \"to\" : \"+18475978014\", \"phoneNumberId\" : \"PN1311218371073288ff9c0434698753f98ea4228a\", \"status\" : \"queued\", \"startTime\" : null, \"endTime\" : null, \"duration\" : 0, \"direction\" : \"outboundAPI\", \"answeredBy\" : null, \"callerName\" : null, \"subresourceUris\" : {\"notifications\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924/Notifications\", \"recordings\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924/Recordings\"}}");

                Call call = callsRequester.create("+18475978014", "+12248806205", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Assert.IsNotNull(call);
                Assert.IsNotNull(call.getUri);
                Assert.AreEqual(call.getUri, "/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924");
                Assert.AreEqual(call.getSubresourceUris.Count, 2);
                Assert.AreEqual(call.getRevision, 1);
                Assert.IsNotNull(call.getDateCreated);
                Assert.IsNotNull(call.getDateUpdated);
                Assert.AreEqual(call.getStatus, ECallStatus.Queued);
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void MakeAInitialCallsRequestTest()     
        {
            try
            {
                CallsRequester callsRequester = new CallsRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Type callsRequesterType = typeof(CallsRequester);
                MethodInfo persyUrlMethodInfo = callsRequesterType.GetMethod("setPersyUrl", 
                                                                             BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, 
                                                                             null, 
                                                                             new Type[] { typeof(System.String) }, 
                                                                             null);
                persyUrlMethodInfo.Invoke(callsRequester, new Object[] { "http://MakeAInitialCallsRequestTest:3000" });

                WebRequest.RegisterPrefix("http://MakeAInitialCallsRequestTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"uri\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924\", \"revision\" : 1, \"dateCreated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"dateUpdated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"callId\" : \"CA16ac1bcbd6f4895c89a798571e89e1e715892924\", \"parentCallId\" : null, \"accountId\" : \"AC736ca2078721a9a41fb47f07bf40d9e21cb304da\", \"from\" : \"+12248806205\", \"to\" : \"+18475978014\", \"phoneNumberId\" : \"PN1311218371073288ff9c0434698753f98ea4228a\", \"status\" : \"queued\", \"startTime\" : null, \"endTime\" : null, \"duration\" : 0, \"direction\" : \"outboundAPI\", \"answeredBy\" : null, \"callerName\" : null, \"subresourceUris\" : {\"notifications\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924/Notifications\", \"recordings\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924/Recordings\"}}");

                Call call = callsRequester.create("+18475978014", "+12248806205", "http://foo.com/Persephony/RecordingCallAnswered");

                Assert.IsNotNull(call);
                Assert.IsNotNull(call.getUri);
                Assert.AreEqual(call.getUri, "/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924");
                Assert.AreEqual(call.getSubresourceUris.Count, 2);
                Assert.AreEqual(call.getRevision, 1);
                Assert.IsNotNull(call.getDateCreated);
                Assert.IsNotNull(call.getDateUpdated);
                Assert.AreEqual(call.getStatus, ECallStatus.Queued);
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void MakeAInitialCallsRequestWithOptionsTest()
        {
            try
            {
                CallsRequester callsRequester = new CallsRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Type callsRequesterType = typeof(CallsRequester);
                MethodInfo persyUrlMethodInfo = callsRequesterType.GetMethod("setPersyUrl",
                                                                             BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                                                                             null,
                                                                             new Type[] { typeof(System.String) },
                                                                             null);
                persyUrlMethodInfo.Invoke(callsRequester, new Object[] { "http://MakeAInitialCallsRequestTest:3000" });

                WebRequest.RegisterPrefix("http://MakeAInitialCallsRequestTest:3000", new TestWebRequestCreate());

                CallOrigOptions options = new CallOrigOptions();
                string parentCallId = "CA1234567890123456789012345678901234567890";
                options.setRequestId("RQ1234567890123456789012345678901234567890");
                options.setParentCallId(parentCallId);

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"uri\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924\", \"revision\" : 1, \"dateCreated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"dateUpdated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"callId\" : \"CA16ac1bcbd6f4895c89a798571e89e1e715892924\", \"parentCallId\" : \""+parentCallId+"\", \"accountId\" : \"AC736ca2078721a9a41fb47f07bf40d9e21cb304da\", \"from\" : \"+12248806205\", \"to\" : \"+18475978014\", \"phoneNumberId\" : \"PN1311218371073288ff9c0434698753f98ea4228a\", \"status\" : \"queued\", \"startTime\" : null, \"endTime\" : null, \"duration\" : 0, \"direction\" : \"outboundAPI\", \"answeredBy\" : null, \"callerName\" : null, \"subresourceUris\" : {\"notifications\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924/Notifications\", \"recordings\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924/Recordings\"}}");
                Call call = callsRequester.create("+18475978014", "+12248806205", "http://foo.com/Persephony/RecordingCallAnswered", options);

                Assert.IsNotNull(call);
                Assert.IsNotNull(call.getUri);
                Assert.AreEqual(call.getUri, "/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924");
                Assert.AreEqual(call.getSubresourceUris.Count, 2);
                Assert.AreEqual(call.getRevision, 1);
                Assert.IsNotNull(call.getDateCreated);
                Assert.IsNotNull(call.getDateUpdated);
                Assert.AreEqual(call.getStatus, ECallStatus.Queued);
                Assert.AreEqual(call.getParentCallId, parentCallId);
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void MakeUpdateRequestTest()
        {
            try
            {
                CallsRequester callsRequester = new CallsRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Type callsRequesterType = typeof(CallsRequester);
                MethodInfo persyUrlMethodInfo = callsRequesterType.GetMethod("setPersyUrl",
                                                                             BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                                                                             null,
                                                                             new Type[] { typeof(System.String) },
                                                                             null);
                persyUrlMethodInfo.Invoke(callsRequester, new Object[] { "http://MakeUpdateRequestTest:3000" });

                WebRequest.RegisterPrefix("http://MakeUpdateRequestTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"uri\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924\", \"revision\" : 1, \"dateCreated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"dateUpdated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"callId\" : \"CA16ac1bcbd6f4895c89a798571e89e1e715892924\", \"parentCallId\" : null, \"accountId\" : \"AC736ca2078721a9a41fb47f07bf40d9e21cb304da\", \"from\" : \"+12248806205\", \"to\" : \"+18475978014\", \"phoneNumberId\" : \"PN1311218371073288ff9c0434698753f98ea4228a\", \"status\" : \"canceled\", \"startTime\" : null, \"endTime\" : null, \"duration\" : 0, \"direction\" : \"outboundAPI\", \"answeredBy\" : null, \"callerName\" : null, \"subresourceUris\" : {\"notifications\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924/Notifications\", \"recordings\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924/Recordings\"}}");

                CallTermOptions callOptions = new CallTermOptions();
                callOptions.setStatus(ECallStatus.Canceled);
                callsRequester.update("CA16ac1bcbd6f4895c89a798571e89e1e715892924", callOptions);
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void MakeUpdateRequestWithRequestIdTest()
        {
            try
            {
                CallsRequester callsRequester = new CallsRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Type callsRequesterType = typeof(CallsRequester);
                MethodInfo persyUrlMethodInfo = callsRequesterType.GetMethod("setPersyUrl",
                                                                             BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                                                                             null,
                                                                             new Type[] { typeof(System.String) },
                                                                             null);
                persyUrlMethodInfo.Invoke(callsRequester, new Object[] { "http://MakeUpdateRequestTest:3000" });

                WebRequest.RegisterPrefix("http://MakeUpdateRequestTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"uri\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924\", \"revision\" : 1, \"dateCreated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"dateUpdated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"callId\" : \"CA16ac1bcbd6f4895c89a798571e89e1e715892924\", \"parentCallId\" : null, \"accountId\" : \"AC736ca2078721a9a41fb47f07bf40d9e21cb304da\", \"from\" : \"+12248806205\", \"to\" : \"+18475978014\", \"phoneNumberId\" : \"PN1311218371073288ff9c0434698753f98ea4228a\", \"status\" : \"canceled\", \"startTime\" : null, \"endTime\" : null, \"duration\" : 0, \"direction\" : \"outboundAPI\", \"answeredBy\" : null, \"callerName\" : null, \"subresourceUris\" : {\"notifications\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924/Notifications\", \"recordings\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924/Recordings\"}}");

                CallTermOptions callOptions = new CallTermOptions();
                callOptions.setStatus(ECallStatus.Canceled);
                callOptions.setRequestId("RQ1234567890123456789012345678901234567890");
                callsRequester.update("CA16ac1bcbd6f4895c89a798571e89e1e715892924", callOptions);
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void GetCallListTest()
        {
            try
            {
                CallsRequester callsRequester = new CallsRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Type callsRequesterType = typeof(CallsRequester);
                MethodInfo persyUrlMethodInfo = callsRequesterType.GetMethod("setPersyUrl",
                                                                             BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                                                                             null,
                                                                             new Type[] { typeof(System.String) },
                                                                             null);
                persyUrlMethodInfo.Invoke(callsRequester, new Object[] { "http://GetCallListTest:3000" });

                WebRequest.RegisterPrefix("http://GetCallListTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"total\":3,\"start\":0,\"end\":1,\"page\":0,\"numPages\":2,\"pageSize\":2,\"nextPageUri\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls?cursor=492dc883a811bd0204204ea9047122f93a2788a2\",\"calls\":[{\"uri\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CAfe92a5efbaf90f04bbec946a0d74dad520dd883b\",\"revision\":1,\"dateCreated\":\"Mon, 28 Mar 2016 19:58:21 GMT\",\"dateUpdated\":\"Mon, 28 Mar 2016 19:58:21 GMT\",\"callId\":\"CAfe92a5efbaf90f04bbec946a0d74dad520dd883b\",\"parentCallId\":null,\"accountId\":\"ACabe7063197551fe51671f9ac3a9708e9dad51c4d\",\"from\":\"847655770\",\"to\":\"+11112223333\",\"phoneNumberId\":null,\"status\":\"completed\",\"startTime\":\"Mon, 28 Mar 2016 19:58:21 GMT\",\"endTime\":\"Mon, 28 Mar 2016 19:58:30 GMT\",\"duration\":9,\"direction\":\"inbound\",\"answeredBy\":null,\"callerName\":null,\"subresourceUris\":{\"notifications\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CAfe92a5efbaf90f04bbec946a0d74dad520dd883b/Notifications\",\"recordings\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CAfe92a5efbaf90f04bbec946a0d74dad520dd883b/Recordings\"}},{\"uri\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CA25c3c744acdedcdb92a44dbae42d486bf20028ab\",\"revision\":1,\"dateCreated\":\"Mon, 28 Mar 2016 20:03:42 GMT\",\"dateUpdated\":\"Mon, 28 Mar 2016 20:03:42 GMT\",\"callId\":\"CA25c3c744acdedcdb92a44dbae42d486bf20028ab\",\"parentCallId\":null,\"accountId\":\"ACabe7063197551fe51671f9ac3a9708e9dad51c4d\",\"from\":\"847655770\",\"to\":\"+11112223333\",\"phoneNumberId\":null,\"status\":\"completed\",\"startTime\":\"Mon, 28 Mar 2016 20:03:42 GMT\",\"endTime\":\"Mon, 28 Mar 2016 20:03:50 GMT\",\"duration\":8,\"direction\":\"inbound\",\"answeredBy\":null,\"callerName\":null,\"subresourceUris\":{\"notifications\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CA25c3c744acdedcdb92a44dbae42d486bf20028ab/Notifications\",\"recordings\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CA25c3c744acdedcdb92a44dbae42d486bf20028ab/Recordings\"}}]}");

                CallList callList = callsRequester.get();

                Assert.IsNotNull(callList);

                Assert.AreEqual(callList.getLocalSize, 2);
                Assert.AreEqual((callList.export()).Count, 2);

                Call call = callList.get(0) as Call;

                Assert.IsNotNull(call);
                Assert.AreEqual(call.getCallId, "CAfe92a5efbaf90f04bbec946a0d74dad520dd883b");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(callList, "http://GetCallListTest:3000");
                }

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"total\":3,\"start\":2,\"end\":2,\"page\":1,\"numPages\":2,\"pageSize\":2,\"nextPageUri\":null,\"calls\":[{\"uri\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CAfe92a5efbaf90f04bbec946a0d74dad520dd884b\",\"revision\":1,\"dateCreated\":\"Mon, 28 Mar 2016 19:58:21 GMT\",\"dateUpdated\":\"Mon, 28 Mar 2016 19:58:21 GMT\",\"callId\":\"CAfe92a5efbaf90f04bbec946a0d74dad520dd884b\",\"parentCallId\":null,\"accountId\":\"ACabe7063197551fe51671f9ac3a9708e9dad51c4d\",\"from\":\"847655770\",\"to\":\"+11112223333\",\"phoneNumberId\":null,\"status\":\"completed\",\"startTime\":\"Mon, 28 Mar 2016 19:58:21 GMT\",\"endTime\":\"Mon, 28 Mar 2016 19:58:30 GMT\",\"duration\":9,\"direction\":\"inbound\",\"answeredBy\":null,\"callerName\":null,\"subresourceUris\":{\"notifications\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CAfe92a5efbaf90f04bbec946a0d74dad520dd883b/Notifications\",\"recordings\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CAfe92a5efbaf90f04bbec946a0d74dad520dd883b/Recordings\"}}]}");

                callList.loadNextPage();

                Assert.IsNotNull(callList);

                Assert.AreEqual(callList.getLocalSize, 3);
                Assert.AreEqual((callList.export()).Count, 3);

                call = callList.get(2) as Call;
                Assert.IsNotNull(call);
                Assert.AreEqual(call.getCallId, "CAfe92a5efbaf90f04bbec946a0d74dad520dd884b");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void GetCallListWithStartTimeQueryTest()
        {
            try
            {
                CallsRequester callsRequester = new CallsRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Type callsRequesterType = typeof(CallsRequester);
                MethodInfo persyUrlMethodInfo = callsRequesterType.GetMethod("setPersyUrl",
                                                                             BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                                                                             null,
                                                                             new Type[] { typeof(System.String) },
                                                                             null);
                persyUrlMethodInfo.Invoke(callsRequester, new Object[] { "http://GetCallListWithStartTimeQueryTest:3000" });

                WebRequest.RegisterPrefix("http://GetCallListWithStartTimeQueryTest:3000/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls?startTime=2015-01-01%2000%3a00%3a00", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"total\":3,\"start\":0,\"end\":1,\"page\":0,\"numPages\":2,\"pageSize\":2,\"nextPageUri\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls?cursor=492dc883a811bd0204204ea9047122f93a2788a2\",\"calls\":[{\"uri\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CAfe92a5efbaf90f04bbec946a0d74dad520dd883b\",\"revision\":1,\"dateCreated\":\"Mon, 28 Mar 2016 19:58:21 GMT\",\"dateUpdated\":\"Mon, 28 Mar 2016 19:58:21 GMT\",\"callId\":\"CAfe92a5efbaf90f04bbec946a0d74dad520dd883b\",\"parentCallId\":null,\"accountId\":\"ACabe7063197551fe51671f9ac3a9708e9dad51c4d\",\"from\":\"847655770\",\"to\":\"+11112223333\",\"phoneNumberId\":null,\"status\":\"completed\",\"startTime\":\"Mon, 28 Mar 2016 19:58:21 GMT\",\"endTime\":\"Mon, 28 Mar 2016 19:58:30 GMT\",\"duration\":9,\"direction\":\"inbound\",\"answeredBy\":null,\"callerName\":null,\"subresourceUris\":{\"notifications\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CAfe92a5efbaf90f04bbec946a0d74dad520dd883b/Notifications\",\"recordings\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CAfe92a5efbaf90f04bbec946a0d74dad520dd883b/Recordings\"}},{\"uri\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CA25c3c744acdedcdb92a44dbae42d486bf20028ab\",\"revision\":1,\"dateCreated\":\"Mon, 28 Mar 2016 20:03:42 GMT\",\"dateUpdated\":\"Mon, 28 Mar 2016 20:03:42 GMT\",\"callId\":\"CA25c3c744acdedcdb92a44dbae42d486bf20028ab\",\"parentCallId\":null,\"accountId\":\"ACabe7063197551fe51671f9ac3a9708e9dad51c4d\",\"from\":\"847655770\",\"to\":\"+11112223333\",\"phoneNumberId\":null,\"status\":\"completed\",\"startTime\":\"Mon, 28 Mar 2016 20:03:42 GMT\",\"endTime\":\"Mon, 28 Mar 2016 20:03:50 GMT\",\"duration\":8,\"direction\":\"inbound\",\"answeredBy\":null,\"callerName\":null,\"subresourceUris\":{\"notifications\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CA25c3c744acdedcdb92a44dbae42d486bf20028ab/Notifications\",\"recordings\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CA25c3c744acdedcdb92a44dbae42d486bf20028ab/Recordings\"}}]}");

                CallsSearchFilters listOptions = new CallsSearchFilters();
                listOptions.setStartTime("2015-01-01 00:00:00");

                CallList callList = callsRequester.get(listOptions);

                Assert.IsNotNull(callList);

                Assert.AreEqual(callList.getLocalSize, 2);
                Assert.AreEqual((callList.export()).Count, 2);

                Call call = callList.get(0) as Call;

                Assert.IsNotNull(call);
                Assert.AreEqual(call.getCallId, "CAfe92a5efbaf90f04bbec946a0d74dad520dd883b");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(callList, "http://GetCallListWithStartTimeQueryTest:3000");
                }

                WebRequest.RegisterPrefix("http://getcalllistwithstarttimequerytest:3000/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls?cursor=492dc883a811bd0204204ea9047122f93a2788a2", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"total\":3,\"start\":2,\"end\":2,\"page\":1,\"numPages\":2,\"pageSize\":2,\"nextPageUri\":null,\"calls\":[{\"uri\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CAfe92a5efbaf90f04bbec946a0d74dad520dd884b\",\"revision\":1,\"dateCreated\":\"Mon, 28 Mar 2016 19:58:21 GMT\",\"dateUpdated\":\"Mon, 28 Mar 2016 19:58:21 GMT\",\"callId\":\"CAfe92a5efbaf90f04bbec946a0d74dad520dd884b\",\"parentCallId\":null,\"accountId\":\"ACabe7063197551fe51671f9ac3a9708e9dad51c4d\",\"from\":\"847655770\",\"to\":\"+11112223333\",\"phoneNumberId\":null,\"status\":\"completed\",\"startTime\":\"Mon, 28 Mar 2016 19:58:21 GMT\",\"endTime\":\"Mon, 28 Mar 2016 19:58:30 GMT\",\"duration\":9,\"direction\":\"inbound\",\"answeredBy\":null,\"callerName\":null,\"subresourceUris\":{\"notifications\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CAfe92a5efbaf90f04bbec946a0d74dad520dd883b/Notifications\",\"recordings\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CAfe92a5efbaf90f04bbec946a0d74dad520dd883b/Recordings\"}}]}");

                callList.loadNextPage();

                Assert.IsNotNull(callList);

                Assert.AreEqual(callList.getLocalSize, 3);
                Assert.AreEqual((callList.export()).Count, 3);

                call = callList.get(2) as Call;
                Assert.IsNotNull(call);
                Assert.AreEqual(call.getCallId, "CAfe92a5efbaf90f04bbec946a0d74dad520dd884b");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void GetCallListWithStartTimeAndToQueryTest()
        {
            try
            {
                CallsRequester callsRequester = new CallsRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Type callsRequesterType = typeof(CallsRequester);
                MethodInfo persyUrlMethodInfo = callsRequesterType.GetMethod("setPersyUrl",
                                                                             BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                                                                             null,
                                                                             new Type[] { typeof(System.String) },
                                                                             null);
                persyUrlMethodInfo.Invoke(callsRequester, new Object[] { "http://GetCallListWithStartTimeAndToQueryTest:3000" });

                WebRequest.RegisterPrefix("http://GetCallListWithStartTimeAndToQueryTest:3000/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls?to=%2b1234567890&startTime=2015-01-01%2000%3a00%3a00", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"total\":3,\"start\":0,\"end\":1,\"page\":0,\"numPages\":2,\"pageSize\":2,\"nextPageUri\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls?cursor=492dc883a811bd0204204ea9047122f93a2788a2\",\"calls\":[{\"uri\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CAfe92a5efbaf90f04bbec946a0d74dad520dd883b\",\"revision\":1,\"dateCreated\":\"Mon, 28 Mar 2016 19:58:21 GMT\",\"dateUpdated\":\"Mon, 28 Mar 2016 19:58:21 GMT\",\"callId\":\"CAfe92a5efbaf90f04bbec946a0d74dad520dd883b\",\"parentCallId\":null,\"accountId\":\"ACabe7063197551fe51671f9ac3a9708e9dad51c4d\",\"from\":\"847655770\",\"to\":\"+11112223333\",\"phoneNumberId\":null,\"status\":\"completed\",\"startTime\":\"Mon, 28 Mar 2016 19:58:21 GMT\",\"endTime\":\"Mon, 28 Mar 2016 19:58:30 GMT\",\"duration\":9,\"direction\":\"inbound\",\"answeredBy\":null,\"callerName\":null,\"subresourceUris\":{\"notifications\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CAfe92a5efbaf90f04bbec946a0d74dad520dd883b/Notifications\",\"recordings\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CAfe92a5efbaf90f04bbec946a0d74dad520dd883b/Recordings\"}},{\"uri\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CA25c3c744acdedcdb92a44dbae42d486bf20028ab\",\"revision\":1,\"dateCreated\":\"Mon, 28 Mar 2016 20:03:42 GMT\",\"dateUpdated\":\"Mon, 28 Mar 2016 20:03:42 GMT\",\"callId\":\"CA25c3c744acdedcdb92a44dbae42d486bf20028ab\",\"parentCallId\":null,\"accountId\":\"ACabe7063197551fe51671f9ac3a9708e9dad51c4d\",\"from\":\"847655770\",\"to\":\"+11112223333\",\"phoneNumberId\":null,\"status\":\"completed\",\"startTime\":\"Mon, 28 Mar 2016 20:03:42 GMT\",\"endTime\":\"Mon, 28 Mar 2016 20:03:50 GMT\",\"duration\":8,\"direction\":\"inbound\",\"answeredBy\":null,\"callerName\":null,\"subresourceUris\":{\"notifications\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CA25c3c744acdedcdb92a44dbae42d486bf20028ab/Notifications\",\"recordings\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CA25c3c744acdedcdb92a44dbae42d486bf20028ab/Recordings\"}}]}");

                CallsSearchFilters listOptions = new CallsSearchFilters();
                listOptions.setStartTime("2015-01-01 00:00:00");
                listOptions.setTo("+1234567890");

                CallList callList = callsRequester.get(listOptions);

                Assert.IsNotNull(callList);

                Assert.AreEqual(callList.getLocalSize, 2);
                Assert.AreEqual((callList.export()).Count, 2);

                Call call = callList.get(0) as Call;

                Assert.IsNotNull(call);
                Assert.AreEqual(call.getCallId, "CAfe92a5efbaf90f04bbec946a0d74dad520dd883b");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(callList, "http://GetCallListWithStartTimeAndToQueryTest:3000");
                }

                WebRequest.RegisterPrefix("http://GetCallListWithStartTimeAndToQueryTest:3000/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls?cursor=492dc883a811bd0204204ea9047122f93a2788a2", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"total\":3,\"start\":2,\"end\":2,\"page\":1,\"numPages\":2,\"pageSize\":2,\"nextPageUri\":null,\"calls\":[{\"uri\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CAfe92a5efbaf90f04bbec946a0d74dad520dd884b\",\"revision\":1,\"dateCreated\":\"Mon, 28 Mar 2016 19:58:21 GMT\",\"dateUpdated\":\"Mon, 28 Mar 2016 19:58:21 GMT\",\"callId\":\"CAfe92a5efbaf90f04bbec946a0d74dad520dd884b\",\"parentCallId\":null,\"accountId\":\"ACabe7063197551fe51671f9ac3a9708e9dad51c4d\",\"from\":\"847655770\",\"to\":\"+11112223333\",\"phoneNumberId\":null,\"status\":\"completed\",\"startTime\":\"Mon, 28 Mar 2016 19:58:21 GMT\",\"endTime\":\"Mon, 28 Mar 2016 19:58:30 GMT\",\"duration\":9,\"direction\":\"inbound\",\"answeredBy\":null,\"callerName\":null,\"subresourceUris\":{\"notifications\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CAfe92a5efbaf90f04bbec946a0d74dad520dd883b/Notifications\",\"recordings\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CAfe92a5efbaf90f04bbec946a0d74dad520dd883b/Recordings\"}}]}");

                callList.loadNextPage();

                Assert.IsNotNull(callList);

                Assert.AreEqual(callList.getLocalSize, 3);
                Assert.AreEqual((callList.export()).Count, 3);

                call = callList.get(2) as Call;
                Assert.IsNotNull(call);
                Assert.AreEqual(call.getCallId, "CAfe92a5efbaf90f04bbec946a0d74dad520dd884b");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void GetCallTest()
        {
            try
            {
                CallsRequester callsRequester = new CallsRequester("ACabe7063197551fe51671f9ac3a9708e9dad51c4d", "204c15aae7a486c42776aea4dbafe8c68a773071", "ACabe7063197551fe51671f9ac3a9708e9dad51c4d");

                Type callsRequesterType = typeof(CallsRequester);
                MethodInfo persyUrlMethodInfo = callsRequesterType.GetMethod("setPersyUrl",
                                                                             BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                                                                             null,
                                                                             new Type[] { typeof(System.String) },
                                                                             null);
                persyUrlMethodInfo.Invoke(callsRequester, new Object[] { "http://GetCallTest:3000" });

                WebRequest.RegisterPrefix("http://GetCallTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"uri\" : \"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CAfe92a5efbaf90f04bbec946a0d74dad520dd883b\", \"revision\" : 1, \"dateCreated\" : \"Mon, 28 Mar 2016 19:58:21 GMT\", \"dateUpdated\" : \"Mon, 28 Mar 2016 19:58:21 GMT\", \"callId\" : \"CAfe92a5efbaf90f04bbec946a0d74dad520dd883b\", \"parentCallId\" : null, \"accountId\" : \"ACabe7063197551fe51671f9ac3a9708e9dad51c4d\", \"from\" : \"847655770\", \"to\" : \"+11112223333\", \"phoneNumberId\" : null, \"status\" : \"completed\", \"startTime\" : \"Mon, 28 Mar 2016 19:58:21 GMT\", \"endTime\" : \"Mon, 28 Mar 2016 19:58:30 GMT\", \"duration\" : 9, \"direction\" : \"inbound\", \"answeredBy\" : null, \"callerName\" : null, \"subresourceUris\" : {\"notifications\" : \"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CAfe92a5efbaf90f04bbec946a0d74dad520dd883b/Notifications\", \"recordings\" : \"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Calls/CAfe92a5efbaf90f04bbec946a0d74dad520dd883b/Recordings\"}}");

                Call call = callsRequester.get("CAfe92a5efbaf90f04bbec946a0d74dad520dd883b");

                Assert.IsNotNull(call);
                Assert.AreEqual(call.getCallId, "CAfe92a5efbaf90f04bbec946a0d74dad520dd883b");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }
    }
}
