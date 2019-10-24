using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.api.recording;
using com.freeclimb.api.application;

namespace freeclimb_cs_sdk_test.api.application
{
    [TestClass]
    public class ApplicationTest
    {
        [TestMethod]
        public void MakeApplicationFromJsonTest()
        {
            string json = "{\"uri\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Applications/APe4238465edbc017acfbddfe80c66594ef6c72669\", \"revision\" : 1, \"dateCreated\" : \"Mon, 30 Jan 2017 23:35:00 GMT\", \"dateUpdated\" : \"Mon, 30 Jan 2017 23:44:39 GMT\", \"applicationId\" : \"APe4238465edbc017acfbddfe80c66594ef6c72669\", \"accountId\" : \"AC66c1bebe590a6389f60efa0ee9ce74d44bc29747\", \"alias\" : \"new test application 1\", \"voiceUrl\" : \"http://CreateAccountTest:3000/VoiceUrl\", \"callConnectUrl\" : \"http://CreateAccountTest:3000/CCUrl2\", \"voiceFallbackUrl\" : \"http://CreateAccountTest:3000/VoiceUrl2\", \"statusCallbackUrl\" : \"http://CreateAccountTest:3000/StatusUrl2\" , \"smsUrl\" : \"http://CreateAccountTest:3000/SmsUrl\", \"smsFallbackUrl\" : \"http://CreateAccountTest:3000/SmsUrl2\"}";
            Application application = Application.fromJson(json);

            Assert.IsNotNull(application);
            Assert.IsNotNull(application.getUri);
            Assert.AreEqual(application.getUri, "/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Applications/APe4238465edbc017acfbddfe80c66594ef6c72669");
            Assert.AreEqual(application.getAccountId, "AC66c1bebe590a6389f60efa0ee9ce74d44bc29747");
            Assert.AreEqual(application.getAlias, "new test application 1");
            Assert.AreEqual(application.getRevision, 1);
            Assert.IsNotNull(application.getDateCreated);
            Assert.IsNotNull(application.getDateUpdated);
            Assert.AreEqual(application.getStatusCallbackUrl, "http://CreateAccountTest:3000/StatusUrl2");
            Assert.AreEqual(application.getVoiceFallbackUrl, "http://CreateAccountTest:3000/VoiceUrl2");
            Assert.AreEqual(application.getVoiceUrl, "http://CreateAccountTest:3000/VoiceUrl");
            Assert.AreEqual(application.getSmsFallbackUrl, "http://CreateAccountTest:3000/SmsUrl2");
            Assert.AreEqual(application.getSmsUrl, "http://CreateAccountTest:3000/SmsUrl");
            Assert.AreEqual(application.getCallConnectUrl, "http://CreateAccountTest:3000/CCUrl2");
        }

    }
}
