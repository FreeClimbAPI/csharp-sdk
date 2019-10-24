using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.webhooks.application;
using com.freeclimb;

namespace freeclimb_cs_sdk_test.webhooks.application
{
    [TestClass]
    public class MessageDeliveryCallbackTest
    {
        [TestMethod]
        public void CreateAndVerifyMessageDeliveryTest()
        {
            MessageDelivery md = MessageDelivery.fromJson("{ \"accountId\": \"ACae05391ecca1352e9108d545482a1e6f384e7a49\", \"messageId\": \"SMbde0362aef3d228b3a39baafa9e4f0204e724966\", \"applicationId\": \"APbde0362aef3d228b3a39baafa9e4f0204e724966\", \"phoneNumberId\": \"PNbde0362aef3d228b3a39baafa9e4f0204e724966\", \"text\": \"Hello\", \"status\": \"received\",  \"direction\": \"inbound\", \"from\": \"+17083168669\",  \"requestId\": \"RQ0c74d2e880709c85e8a4e3093b85b910eee4110b\", \"requestType\": \"messageDelivery\", \"to\": \"+12248806211\" }");

            Assert.AreEqual(md.getAccountId, "ACae05391ecca1352e9108d545482a1e6f384e7a49");
            Assert.AreEqual(md.getMessageId, "SMbde0362aef3d228b3a39baafa9e4f0204e724966");
            Assert.AreEqual(md.getStatus, EMessageStatus.Received);
            Assert.AreEqual(md.getDirection,EMessageDirection.Inbound);
            Assert.AreEqual(md.getStatus,EMessageStatus.Received);
            Assert.AreEqual(md.getFrom, "+17083168669");
            Assert.AreEqual(md.getText, "Hello");
            Assert.AreEqual(md.getRequestId, "RQ0c74d2e880709c85e8a4e3093b85b910eee4110b");
            Assert.AreEqual(md.getRequestType, ERequestType.MessageDelivery);
            Assert.AreEqual(md.getTo, "+12248806211");
            Assert.AreEqual(md.getApplicationId, "APbde0362aef3d228b3a39baafa9e4f0204e724966");
            Assert.AreEqual(md.getPhoneNumberId, "PNbde0362aef3d228b3a39baafa9e4f0204e724966");

        }
    }
}
