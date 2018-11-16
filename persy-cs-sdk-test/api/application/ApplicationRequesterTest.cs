using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.persephony.api.recording;
using com.persephony.api;
using System.Reflection;
using System.Net;
using System.IO;
using System.Linq;
using com.persephony;
using com.persephony.api.application;

namespace persy_cs_sdk_test.api.application
{
    [TestClass]
    public class ApplicationRequesterTest
    {
        [TestMethod]
        public void GetApplicationListTest()
        {
            try
            {
                ApplicationsRequester requester = new ApplicationsRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://GetApplicationListTest:3000");
                }

                WebRequest.RegisterPrefix("http://GetApplicationListTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{\"total\":3,\"start\":0,\"end\":1,\"page\":0,\"numPages\":2,\"pageSize\":2,\"nextPageUri\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Applications&cursor=492dc883a811bd0204204ea9047122f93a2788a2\", \"applications\" : [{ \"uri\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Applications/APe4238465edbc017acfbddfe80c66594ef6c72669\", \"revision\" : 2, \"dateCreated\" : \"Mon, 30 Jan 2017 23:35:00 GMT\", \"dateUpdated\" : \"Mon, 30 Jan 2017 23:44:39 GMT\", \"applicationId\" : \"APe4238465edbc017acfbddfe80c66594ef6c72669\", \"accountId\" : \"AC66c1bebe590a6389f60efa0ee9ce74d44bc29747\", \"alias\" : \"new test application 1\", \"voiceUrl\" : \"http://CreateApplicationTest:3000/VoiceUrl2\", \"callConnectUrl\" : \"http://CreateApplicationTest:3000/CCUrl2\", \"voiceFallbackUrl\" : \"http://CreateApplicationTest:3000/VoiceUrl2\", \"statusCallbackUrl\" : \"http://CreateApplicationTest:3000/Status2\",  \"smsUrl\" : \"http://CreateApplicationTest:3000/SmsUrl\", \"smsFallbackUrl\" : \"http://CreateApplicationTest:3000/SmsUrl2\"}, { \"uri\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Applications/AP6b60f3f88a46cc0ab42cb82781bdaa124a435076\", \"revision\" : 1, \"dateCreated\" : \"Mon, 30 Jan 2017 23:35:44 GMT\", \"dateUpdated\" : \"Mon, 30 Jan 2017 23:35:44 GMT\", \"applicationId\" : \"AP6b60f3f88a46cc0ab42cb82781bdaa124a435076\", \"accountId\" : \"AC66c1bebe590a6389f60efa0ee9ce74d44bc29747\", \"alias\" : \"test application 2\", \"voiceUrl\" : \"http://CreateApplicationTest:3000/VoiceUrl\", \"callConnectUrl\" : \"http://CreateApplicationTest:3000/CCUrl\", \"voiceFallbackUrl\" : \"http://CreateApplicationTest:3000/VoiceUrl\", \"statusCallbackUrl\" : \"http://CreateApplicationTest:3000/Status\",  \"smsUrl\" : \"http://CreateApplicationTest:3000/SmsUrl\", \"smsFallbackUrl\" : \"http://CreateApplicationTest:3000/SmsUrl2\"}]}");
                                                                         

                ApplicationList appList = requester.get();

                Assert.IsNotNull(appList);

                Assert.AreEqual(appList.getLocalSize, 2);
                Assert.AreEqual((appList.export()).Count, 2);

                Application app = appList.get(0) as Application;

                Assert.IsNotNull(app);
                Assert.AreEqual(app.getApplicationId, "APe4238465edbc017acfbddfe80c66594ef6c72669");

                type = typeof(APIRequester);
                fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(appList, "http://GetApplicationListTest:3000");
                }

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{\"total\":3,\"start\":2,\"end\":2,\"page\":1,\"numPages\":2,\"pageSize\":2,\"nextPageUri\":null, \"applications\" : [ { \"uri\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Applications/AP6b60f3f88a46cc0ab42cb82781bdaa124a435076\", \"revision\" : 1, \"dateCreated\" : \"Mon, 30 Jan 2017 23:35:44 GMT\", \"dateUpdated\" : \"Mon, 30 Jan 2017 23:35:44 GMT\", \"applicationId\" : \"AP6b60f3f88a46cc0ab42cb82781bdaa124a435076\", \"accountId\" : \"AC66c1bebe590a6389f60efa0ee9ce74d44bc29747\", \"alias\" : \"test application 2\", \"voiceUrl\" : \"http://CreateApplicationTest:3000/VoiceUrl\", \"callConnectUrl\" : \"http://CreateApplicationTest:3000/CCUrl\", \"voiceFallbackUrl\" : \"http://CreateApplicationTest:3000/VoiceUrl\", \"statusCallbackUrl\" : \"http://CreateApplicationTest:3000/Status\" ,  \"smsUrl\" : \"http://CreateApplicationTest:3000/SmsUrl\", \"smsFallbackUrl\" : \"http://CreateApplicationTest:3000/SmsUrl2\"}]}");

                appList.loadNextPage();

                Assert.IsNotNull(appList);

                Assert.AreEqual(appList.getLocalSize, 3);
                Assert.AreEqual((appList.export()).Count, 3);

                app = appList.get(2) as Application;
                Assert.IsNotNull(app);
                Assert.AreEqual(app.getApplicationId, "AP6b60f3f88a46cc0ab42cb82781bdaa124a435076");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void GetApplicationListByAliasTest()
        {
            try
            {
                ApplicationsRequester requester = new ApplicationsRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://GetApplicationListTest:3000");
                }

                WebRequest.RegisterPrefix("http://GetApplicationListTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{\"total\":1,\"start\":0,\"end\":0,\"page\":0,\"numPages\":1,\"pageSize\":2,\"nextPageUri\":null, \"applications\" : [{ \"uri\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Applications/APe4238465edbc017acfbddfe80c66594ef6c72669\", \"revision\" : 2, \"dateCreated\" : \"Mon, 30 Jan 2017 23:35:00 GMT\", \"dateUpdated\" : \"Mon, 30 Jan 2017 23:44:39 GMT\", \"applicationId\" : \"APe4238465edbc017acfbddfe80c66594ef6c72669\", \"accountId\" : \"AC66c1bebe590a6389f60efa0ee9ce74d44bc29747\", \"alias\" : \"new test application 1\", \"voiceUrl\" : \"http://CreateApplicationTest:3000/VoiceUrl2\", \"callConnectUrl\" : \"http://CreateApplicationTest:3000/CCUrl2\", \"voiceFallbackUrl\" : \"http://CreateApplicationTest:3000/VoiceUrl2\", \"statusCallbackUrl\" : \"http://CreateApplicationTest:3000/Status2\",  \"smsUrl\" : \"http://CreateApplicationTest:3000/SmsUrl\", \"smsFallbackUrl\" : \"http://CreateApplicationTest:3000/SmsUrl2\"}]}");

                ApplicationsSearchFilters filters = new ApplicationsSearchFilters();
                filters.setAlias("new test application 1");
                ApplicationList appList = requester.get(filters);

                Assert.IsNotNull(appList);

                Assert.AreEqual(appList.getLocalSize, 1);
                Assert.AreEqual((appList.export()).Count, 1);

                Application app = appList.get(0) as Application;

                Assert.IsNotNull(app);
                Assert.AreEqual(app.getApplicationId, "APe4238465edbc017acfbddfe80c66594ef6c72669");
                Assert.AreEqual(app.getAlias, "new test application 1");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void GetApplicationTest()
        {
            try
            {
                ApplicationsRequester requester = new ApplicationsRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://GetApplicationTest:3000");
                }

                WebRequest.RegisterPrefix("http://GetApplicationTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{\"uri\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Applications/APe4238465edbc017acfbddfe80c66594ef6c72669\", \"revision\" : 1, \"dateCreated\" : \"Mon, 30 Jan 2017 23:35:00 GMT\", \"dateUpdated\" : \"Mon, 30 Jan 2017 23:35:00 GMT\", \"applicationId\" : \"APe4238465edbc017acfbddfe80c66594ef6c72669\", \"accountId\" : \"AC66c1bebe590a6389f60efa0ee9ce74d44bc29747\", \"alias\" : \"test application 1\", \"voiceUrl\" : \"http://CreateApplicationTest:3000/VoiceUrl\", \"callConnectUrl\" : \"http://CreateApplicationTest:3000/CCUrl\", \"voiceFallbackUrl\" : \"http://CreateApplicationTest:3000/VoiceUrl\", \"statusCallbackUrl\" : \"http://CreateApplicationTest:3000/Status\",  \"smsUrl\" : \"http://CreateApplicationTest:3000/SmsUrl\", \"smsFallbackUrl\" : \"http://CreateApplicationTest:3000/SmsUrl2\"}");

                Application app = requester.get("APe4238465edbc017acfbddfe80c66594ef6c72669");

                Assert.IsNotNull(app);
                Assert.AreEqual(app.getApplicationId, "APe4238465edbc017acfbddfe80c66594ef6c72669");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void UpdateApplicationTest()
        {
            try
            {
                ApplicationsRequester requester = new ApplicationsRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://UpdateApplicationTest:3000");
                }

                WebRequest.RegisterPrefix("http://UpdateApplicationTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{\"uri\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Applications/APe4238465edbc017acfbddfe80c66594ef6c72669\", \"revision\" : 2, \"dateCreated\" : \"Mon, 30 Jan 2017 23:35:00 GMT\", \"dateUpdated\" : \"Mon, 30 Jan 2017 23:44:39 GMT\", \"applicationId\" : \"APe4238465edbc017acfbddfe80c66594ef6c72669\", \"accountId\" : \"AC66c1bebe590a6389f60efa0ee9ce74d44bc29747\", \"alias\" : \"new test application 1\", \"voiceUrl\" : \"http://CreateApplicationTest:3000/VoiceUrl2\", \"callConnectUrl\" : \"http://CreateApplicationTest:3000/CCUrl2\", \"voiceFallbackUrl\" : \"http://CreateApplicationTest:3000/VoiceUrl2\", \"statusCallbackUrl\" : \"http://CreateApplicationTest:3000/Status2\",  \"smsUrl\" : \"http://CreateApplicationTest:3000/SmsUrl\", \"smsFallbackUrl\" : \"http://CreateApplicationTest:3000/SmsUrl2\"}");
                ApplicationOptions options = new ApplicationOptions();
                options.setAlias("new test application 1");
                options.setVoiceUrl("http://CreateApplicationTest:3000/VoiceUrl2");
                options.setVoiceFallbackUrl("http://CreateApplicationTest:3000/VoiceUrl2");
                options.setSmsUrl("http://CreateApplicationTest:3000/SmsUrl");
                options.setSmsFallbackUrl("http://CreateApplicationTest:3000/SmsUrl2");
                options.setCallConnectUrl("http://CreateApplicationTest:3000/CCUrl2");
                options.setStatusCallbackUrl("http://CreateApplicationTest:3000/Status2");
                Application app = requester.update("APe4238465edbc017acfbddfe80c66594ef6c72669", options);

                Assert.IsNotNull(app);
                Assert.AreEqual(app.getAlias, "new test application 1");
                Assert.AreEqual(app.getVoiceFallbackUrl, "http://CreateApplicationTest:3000/VoiceUrl2");
                Assert.AreEqual(app.getVoiceUrl, "http://CreateApplicationTest:3000/VoiceUrl2");
                Assert.AreEqual(app.getSmsFallbackUrl, "http://CreateApplicationTest:3000/SmsUrl2");
                Assert.AreEqual(app.getSmsUrl, "http://CreateApplicationTest:3000/SmsUrl");
                Assert.AreEqual(app.getStatusCallbackUrl, "http://CreateApplicationTest:3000/Status2");
                Assert.AreEqual(app.getCallConnectUrl, "http://CreateApplicationTest:3000/CCUrl2");
                Assert.AreEqual(app.getApplicationId, "APe4238465edbc017acfbddfe80c66594ef6c72669");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void CreateApplicationTest()
        {
            try
            {
                ApplicationsRequester requester = new ApplicationsRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://CreateApplicationTest:3000");
                }

                WebRequest.RegisterPrefix("http://CreateApplicationTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{\"uri\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Applications/APe4238465edbc017acfbddfe80c66594ef6c72669\", \"revision\" : 1, \"dateCreated\" : \"Mon, 30 Jan 2017 23:35:00 GMT\", \"dateUpdated\" : \"Mon, 30 Jan 2017 23:35:00 GMT\", \"applicationId\" : \"APe4238465edbc017acfbddfe80c66594ef6c72669\", \"accountId\" : \"AC66c1bebe590a6389f60efa0ee9ce74d44bc29747\", \"alias\" : \"test application 1\", \"voiceUrl\" : \"http://CreateApplicationTest:3000/VoiceUrl\", \"callConnectUrl\" : \"http://CreateApplicationTest:3000/CCUrl\", \"voiceFallbackUrl\" : \"http://CreateApplicationTest:3000/VoiceUrl\", \"statusCallbackUrl\" : \"http://CreateApplicationTest:3000/Status\",  \"smsUrl\" : \"http://CreateApplicationTest:3000/SmsUrl\", \"smsFallbackUrl\" : \"http://CreateApplicationTest:3000/SmsUrl2\" }");
                ApplicationOptions options = new ApplicationOptions();
                options.setAlias("test application 1");
                options.setVoiceUrl("http://CreateApplicationTest:3000/VoiceUrl");
                options.setVoiceFallbackUrl("http://CreateApplicationTest:3000/VoiceUrl");
                options.setSmsUrl("http://CreateApplicationTest:3000/SmsUrl");
                options.setSmsFallbackUrl("http://CreateApplicationTest:3000/SmsUrl2");
                options.setCallConnectUrl("http://CreateApplicationTest:3000/CCUrl");
                options.setStatusCallbackUrl("http://CreateApplicationTest:3000/Status");
                Application app = requester.create(options);

                Assert.IsNotNull(app);
                Assert.AreEqual(app.getAlias, "test application 1");
                Assert.AreEqual(app.getVoiceFallbackUrl, "http://CreateApplicationTest:3000/VoiceUrl");
                Assert.AreEqual(app.getVoiceUrl, "http://CreateApplicationTest:3000/VoiceUrl");
                Assert.AreEqual(app.getSmsFallbackUrl, "http://CreateApplicationTest:3000/SmsUrl2");
                Assert.AreEqual(app.getSmsUrl, "http://CreateApplicationTest:3000/SmsUrl");
                Assert.AreEqual(app.getStatusCallbackUrl, "http://CreateApplicationTest:3000/Status");
                Assert.AreEqual(app.getCallConnectUrl, "http://CreateApplicationTest:3000/CCUrl");
                Assert.AreEqual(app.getAccountId, "AC66c1bebe590a6389f60efa0ee9ce74d44bc29747");
                Assert.AreEqual(app.getApplicationId, "APe4238465edbc017acfbddfe80c66594ef6c72669");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void UpdateApplicationWithRequestIdTest()
        {
            try
            {
                ApplicationsRequester requester = new ApplicationsRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://UpdateApplicationTest:3000");
                }

                WebRequest.RegisterPrefix("http://UpdateApplicationTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{\"uri\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Applications/APe4238465edbc017acfbddfe80c66594ef6c72669\", \"revision\" : 2, \"dateCreated\" : \"Mon, 30 Jan 2017 23:35:00 GMT\", \"dateUpdated\" : \"Mon, 30 Jan 2017 23:44:39 GMT\", \"applicationId\" : \"APe4238465edbc017acfbddfe80c66594ef6c72669\", \"accountId\" : \"AC66c1bebe590a6389f60efa0ee9ce74d44bc29747\", \"alias\" : \"new test application 1\", \"voiceUrl\" : \"http://CreateApplicationTest:3000/VoiceUrl2\", \"callConnectUrl\" : \"http://CreateApplicationTest:3000/CCUrl2\", \"voiceFallbackUrl\" : \"http://CreateApplicationTest:3000/VoiceUrl2\", \"statusCallbackUrl\" : \"http://CreateApplicationTest:3000/Status2\",  \"smsUrl\" : \"http://CreateApplicationTest:3000/SmsUrl\", \"smsFallbackUrl\" : \"http://CreateApplicationTest:3000/SmsUrl2\"}");
                ApplicationOptions options = new ApplicationOptions();
                options.setAlias("new test application 1");
                options.setVoiceUrl("http://CreateApplicationTest:3000/VoiceUrl2");
                options.setVoiceFallbackUrl("http://CreateApplicationTest:3000/VoiceUrl2");
                options.setSmsUrl("http://CreateApplicationTest:3000/SmsUrl");
                options.setSmsFallbackUrl("http://CreateApplicationTest:3000/SmsUrl2");
                options.setCallConnectUrl("http://CreateApplicationTest:3000/CCUrl2");
                options.setStatusCallbackUrl("http://CreateApplicationTest:3000/Status2");
                options.setRequestId("RQ1234567890123456789012345678901234567890");
                Application app = requester.update("APe4238465edbc017acfbddfe80c66594ef6c72669", options);

                Assert.IsNotNull(app);
                Assert.AreEqual(app.getAlias, "new test application 1");
                Assert.AreEqual(app.getVoiceFallbackUrl, "http://CreateApplicationTest:3000/VoiceUrl2");
                Assert.AreEqual(app.getVoiceUrl, "http://CreateApplicationTest:3000/VoiceUrl2");
                Assert.AreEqual(app.getSmsFallbackUrl, "http://CreateApplicationTest:3000/SmsUrl2");
                Assert.AreEqual(app.getSmsUrl, "http://CreateApplicationTest:3000/SmsUrl");
                Assert.AreEqual(app.getStatusCallbackUrl, "http://CreateApplicationTest:3000/Status2");
                Assert.AreEqual(app.getCallConnectUrl, "http://CreateApplicationTest:3000/CCUrl2");
                Assert.AreEqual(app.getApplicationId, "APe4238465edbc017acfbddfe80c66594ef6c72669");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void CreateApplicationWithRequestIdTest()
        {
            try
            {
                ApplicationsRequester requester = new ApplicationsRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://CreateApplicationTest:3000");
                }

                WebRequest.RegisterPrefix("http://CreateApplicationTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{\"uri\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Applications/APe4238465edbc017acfbddfe80c66594ef6c72669\", \"revision\" : 1, \"dateCreated\" : \"Mon, 30 Jan 2017 23:35:00 GMT\", \"dateUpdated\" : \"Mon, 30 Jan 2017 23:35:00 GMT\", \"applicationId\" : \"APe4238465edbc017acfbddfe80c66594ef6c72669\", \"accountId\" : \"AC66c1bebe590a6389f60efa0ee9ce74d44bc29747\", \"alias\" : \"test application 1\", \"voiceUrl\" : \"http://CreateApplicationTest:3000/VoiceUrl\", \"callConnectUrl\" : \"http://CreateApplicationTest:3000/CCUrl\", \"voiceFallbackUrl\" : \"http://CreateApplicationTest:3000/VoiceUrl\", \"statusCallbackUrl\" : \"http://CreateApplicationTest:3000/Status\",  \"smsUrl\" : \"http://CreateApplicationTest:3000/SmsUrl\", \"smsFallbackUrl\" : \"http://CreateApplicationTest:3000/SmsUrl2\"}");
                ApplicationOptions options = new ApplicationOptions();
                options.setAlias("test application 1");
                options.setVoiceUrl("http://CreateApplicationTest:3000/VoiceUrl");
                options.setVoiceFallbackUrl("http://CreateApplicationTest:3000/VoiceUrl");
                options.setSmsUrl("http://CreateApplicationTest:3000/SmsUrl");
                options.setSmsFallbackUrl("http://CreateApplicationTest:3000/SmsUrl2");
                options.setCallConnectUrl("http://CreateApplicationTest:3000/CCUrl");
                options.setStatusCallbackUrl("http://CreateApplicationTest:3000/Status");
                options.setRequestId("RQ1234567890123456789012345678901234567890");
                Application app = requester.create(options);

                Assert.IsNotNull(app);
                Assert.AreEqual(app.getAlias, "test application 1");
                Assert.AreEqual(app.getVoiceFallbackUrl, "http://CreateApplicationTest:3000/VoiceUrl");
                Assert.AreEqual(app.getVoiceUrl, "http://CreateApplicationTest:3000/VoiceUrl");
                Assert.AreEqual(app.getSmsFallbackUrl, "http://CreateApplicationTest:3000/SmsUrl2");
                Assert.AreEqual(app.getSmsUrl, "http://CreateApplicationTest:3000/SmsUrl");
                Assert.AreEqual(app.getStatusCallbackUrl, "http://CreateApplicationTest:3000/Status");
                Assert.AreEqual(app.getCallConnectUrl, "http://CreateApplicationTest:3000/CCUrl");
                Assert.AreEqual(app.getAccountId, "AC66c1bebe590a6389f60efa0ee9ce74d44bc29747");
                Assert.AreEqual(app.getApplicationId, "APe4238465edbc017acfbddfe80c66594ef6c72669");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void DeleteApplicationTest()
        {
            try
            {
                ApplicationsRequester requester = new ApplicationsRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://DeleteApplicationTest:3000");
                }

                WebRequest.RegisterPrefix("http://DeleteApplicationTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK);

                requester.delete("APe4238465edbc017acfbddfe80c66594ef6c72669");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }


    }
}
