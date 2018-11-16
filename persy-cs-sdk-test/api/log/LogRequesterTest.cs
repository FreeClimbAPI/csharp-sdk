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
using com.persephony.api.log;

namespace persy_cs_sdk_test.api.log
{
    [TestClass]
    public class LogRequesterTest
    {
        [TestMethod]
        public void GetLogListTest()
        {
            try
            {
                LogsRequester requester = new LogsRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://GetLogListTest:3000");
                }

                WebRequest.RegisterPrefix("http://GetLogListTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{\"total\":3,\"start\":0,\"end\":1,\"page\":0,\"numPages\":2,\"pageSize\":2,\"nextPageUri\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Applications&cursor=492dc883a811bd0204204ea9047122f93a2788a2\", \"logs\" : [{\"hostname\":\"spv07vcs10\",\"subsystem\":\"vcsserver\",\"timestamp\":1485450179059490,\"scope\":\"public\",\"level\":\"info\",\"accountId\":\"AC907d7e328b3a5b402fa908857e047a243a8949b1\",\"requestId\":\"RQ5c8c6d7df5d19096eb71ce516a39ade6aa1b0d4f\",\"callId\":\"CA5c8c6d7df5d19096eb71ce516a39ade6aa1b0d4f\",\"message\":\"Customer Response 200 : POST http://172.29.11.10/PersySurvey/PersySurvey/CallStatus\",\"metadata\":{}},{\"hostname\":\"spv07vcs10\",\"subsystem\":\"vcsserver\",\"timestamp\":1485450178755768,\"scope\":\"public\",\"level\":\"info\",\"accountId\":\"AC907d7e328b3a5b402fa908857e047a243a8949b1\",\"requestId\":\"RQ5c8c6d7df5d19096eb71ce516a39ade6aa1b0d4f\",\"callId\":\"CA5c8c6d7df5d19096eb71ce516a39ade6aa1b0d4f\",\"message\":\"Customer Request : POST http://172.29.11.10/PersySurvey/PersySurvey/CallStatus\",\"metadata\":{\"requestBody\":{\"accountId\":\"AC907d7e328b3a5b402fa908857e047a243a8949b1\",\"callDuration\":7,\"callId\":\"CA5c8c6d7df5d19096eb71ce516a39ade6aa1b0d4f\",\"callStatus\":\"completed\",\"conferenceId\":null,\"direction\":\"inbound\",\"from\":\"+13038472859\",\"parentCallId\":null,\"queueId\":null,\"requestType\":\"callStatus\",\"to\":\"+13124881429\"},\"requestHeaders\":{\"X-Pulse-Signature\":\"a80fc8c501a7b46a1864d16572882ff86712317a\",\"X-Pulse-Timestamp\":1485450178,\"url\":\"http://172.29.11.10/PersySurvey/PersySurvey/CallStatus\"}}}]}");

                LogList logList = requester.get();

                Assert.IsNotNull(logList);

                Assert.AreEqual(logList.getLocalSize, 2);
                Assert.AreEqual((logList.export()).Count, 2);

                Log log = logList.get(0) as Log;

                Assert.IsNotNull(log);
                Assert.AreEqual(log.getCallId, "CA5c8c6d7df5d19096eb71ce516a39ade6aa1b0d4f");
                Assert.AreEqual(log.getRequestId, "RQ5c8c6d7df5d19096eb71ce516a39ade6aa1b0d4f");

                type = typeof(APIRequester);
                fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(logList, "http://GetLogListTest:3000");
                }

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{\"total\":3,\"start\":2,\"end\":2,\"page\":1,\"numPages\":2,\"pageSize\":2,\"nextPageUri\":null, \"logs\" : [ {\"hostname\":\"spv07vcs10\",\"subsystem\":\"vcsserver\",\"timestamp\":1485450178603416,\"scope\":\"public\",\"level\":\"info\",\"accountId\":\"AC907d7e328b3a5b402fa908857e047a243a8949b1\",\"requestId\":null,\"callId\":\"CA5c8c6d7df5d19096eb71ce516a39ade6aa1b0d4f\",\"message\":\"Customer Response 200 : POST http://172.29.11.10/PersySurvey/PersySurvey/NextQuestion\",\"metadata\":[{\"GetSpeech\":{\"actionUrl\":\"http://172.29.11.10/PersySurvey/PersySurvey/HandleQuestionResponse\",\"grammarFile\":\"http://172.29.11.10/PersySurvey/Grammars/969d88d2-8edb-4ad9-8436-aa0c4d268f56.grxml\",\"grammarRule\":\"Choices\",\"grammarType\":\"URL\",\"noInputTimeoutMs\":4000,\"prompts\":[{\"Say\":{\"text\":\"what is your favorite color\"}}],\"recognitionTimeoutMs\":5000}}]}]}");

                logList.loadNextPage();

                Assert.IsNotNull(logList);

                Assert.AreEqual(logList.getLocalSize, 3);
                Assert.AreEqual((logList.export()).Count, 3);

                log = logList.get(2) as Log;
                Assert.IsNotNull(log);
                Assert.AreEqual(log.getCallId, "CA5c8c6d7df5d19096eb71ce516a39ade6aa1b0d4f");
                Assert.IsNull(log.getRequestId);
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void GetLogListUsingPqlTest()
        {
            try
            {
                LogsRequester requester = new LogsRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://GetLogListTest:3000");
                }

                WebRequest.RegisterPrefix("http://GetLogListTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{\"total\":1,\"start\":0,\"end\":0,\"page\":0,\"numPages\":1,\"pageSize\":2,\"nextPageUri\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Applications&cursor=492dc883a811bd0204204ea9047122f93a2788a2\", \"logs\" : [{\"hostname\":\"spv07vcs10\",\"subsystem\":\"vcsserver\",\"timestamp\":1485450178603416,\"scope\":\"public\",\"level\":\"info\",\"accountId\":\"AC907d7e328b3a5b402fa908857e047a243a8949b1\",\"requestId\":null,\"callId\":\"CA5c8c6d7df5d19096eb71ce516a39ade6aa1b0d4f\",\"message\":\"Customer Response 200 : POST http://172.29.11.10/PersySurvey/PersySurvey/NextQuestion\",\"metadata\":[{\"GetSpeech\":{\"actionUrl\":\"http://172.29.11.10/PersySurvey/PersySurvey/HandleQuestionResponse\",\"grammarFile\":\"http://172.29.11.10/PersySurvey/Grammars/969d88d2-8edb-4ad9-8436-aa0c4d268f56.grxml\",\"grammarRule\":\"Choices\",\"grammarType\":\"URL\",\"noInputTimeoutMs\":4000,\"prompts\":[{\"Say\":{\"text\":\"what is your favorite color\"}}],\"recognitionTimeoutMs\":5000}}]}]}");
                LogSearchFilters filters = new LogSearchFilters();
                string pql = "level=\"info\"";
                filters.setPql(pql);
                LogList logList = requester.get(filters);

                Assert.IsNotNull(logList);

                Assert.AreEqual(logList.getLocalSize, 1);
                Assert.AreEqual((logList.export()).Count, 1);

                Log log = logList.get(0) as Log;

                Assert.IsNotNull(log);
                Assert.AreEqual(log.getLevel, ELogLevel.Info);
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void GetLogListUsingRequestIdTest()
        {
            try
            {
                LogsRequester requester = new LogsRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://GetLogListTest:3000");
                }

                WebRequest.RegisterPrefix("http://GetLogListTest:3000", new TestWebRequestCreate());

                string requestId = "RQ1234567890123456789012345678901234567890";
                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{\"total\":1,\"start\":0,\"end\":0,\"page\":0,\"numPages\":1,\"pageSize\":2,\"nextPageUri\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Applications&cursor=492dc883a811bd0204204ea9047122f93a2788a2\", \"logs\" : [{\"hostname\":\"spv07vcs10\",\"subsystem\":\"vcsserver\",\"timestamp\":1485450178603416,\"scope\":\"public\",\"level\":\"info\",\"accountId\":\"AC907d7e328b3a5b402fa908857e047a243a8949b1\",\"requestId\":\""+requestId+"\",\"callId\":\"CA5c8c6d7df5d19096eb71ce516a39ade6aa1b0d4f\",\"message\":\"Customer Response 200 : POST http://172.29.11.10/PersySurvey/PersySurvey/NextQuestion\",\"metadata\":[{\"GetSpeech\":{\"actionUrl\":\"http://172.29.11.10/PersySurvey/PersySurvey/HandleQuestionResponse\",\"grammarFile\":\"http://172.29.11.10/PersySurvey/Grammars/969d88d2-8edb-4ad9-8436-aa0c4d268f56.grxml\",\"grammarRule\":\"Choices\",\"grammarType\":\"URL\",\"noInputTimeoutMs\":4000,\"prompts\":[{\"Say\":{\"text\":\"what is your favorite color\"}}],\"recognitionTimeoutMs\":5000}}]}]}");
                LogSearchFilters filters = new LogSearchFilters();
                filters.setRequestId(requestId);
                LogList logList = requester.get(filters);

                Assert.IsNotNull(logList);

                Assert.AreEqual(logList.getLocalSize, 1);
                Assert.AreEqual((logList.export()).Count, 1);

                Log log = logList.get(0) as Log;

                Assert.IsNotNull(log);
                Assert.AreEqual(log.getRequestId, requestId);
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

    }
}
