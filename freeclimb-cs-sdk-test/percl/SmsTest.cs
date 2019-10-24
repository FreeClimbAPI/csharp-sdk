using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.percl;

namespace freeclimb_cs_sdk_test.percl
{
    [TestClass]
    public class SmsTest
    {
        [TestMethod]
        public void SmsCommandToJsonTest()
        {
            string to = "+11234567890";
            string from = "+11234567890";
            string text = "Hello";
            string notif = "http://foo.com/notif";
            Sms sms = new Sms(from, to, text);
            sms.setNotificationUrl(notif);

            string json = sms.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"Sms\":{\"from\":\""+from+"\",\"to\":\""+to+"\",\"text\":\""+text+"\",\"notificationUrl\":\""+notif+"\"}}");
        }
    }
}
