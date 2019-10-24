using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.webhooks.message;
using com.freeclimb;

namespace freeclimb_cs_sdk_test.webhooks.message
{
    [TestClass]
    public class MessageStatusCallbackTest
    {
        [TestMethod]
        public void CreateAndVerifyMessageStatusTest()
        {
            MessageStatus ms = MessageStatus.fromJson("{ \"accountId\": \"ACae05391ecca1352e9108d545482a1e6f384e7a49\", \"callId\": \"CAbde0362aef3d228b3a39baafa9e4f0204e724966\",\"parentCallId\": null, \"messageId\": \"SMbde0362aef3d228b3a39baafa9e4f0204e724966\", \"applicationId\": \"APbde0362aef3d228b3a39baafa9e4f0204e724966\", \"phoneNumberId\": \"PNbde0362aef3d228b3a39baafa9e4f0204e724966\", \"text\": \"Hello\", \"status\": \"received\",  \"direction\": \"inbound\", \"from\": \"+17083168669\",  \"requestId\": \"RQ0c74d2e880709c85e8a4e3093b85b910eee4110b\", \"requestType\": \"messageStatus\", \"to\": \"+12248806211\" }");

            Assert.AreEqual(ms.getAccountId, "ACae05391ecca1352e9108d545482a1e6f384e7a49");
            Assert.AreEqual(ms.getMessageId, "SMbde0362aef3d228b3a39baafa9e4f0204e724966");
            Assert.AreEqual(ms.getStatus, EMessageStatus.Received);
            Assert.AreEqual(ms.getDirection,EMessageDirection.Inbound);
            Assert.AreEqual(ms.getStatus,EMessageStatus.Received);
            Assert.AreEqual(ms.getFrom, "+17083168669");
            Assert.AreEqual(ms.getText, "Hello");
            Assert.AreEqual(ms.getRequestId, "RQ0c74d2e880709c85e8a4e3093b85b910eee4110b");
            Assert.AreEqual(ms.getRequestType, ERequestType.MessageStatus);
            Assert.AreEqual(ms.getTo, "+12248806211");
            Assert.AreEqual(ms.getApplicationId, "APbde0362aef3d228b3a39baafa9e4f0204e724966");
            Assert.AreEqual(ms.getPhoneNumberId, "PNbde0362aef3d228b3a39baafa9e4f0204e724966");
            Assert.AreEqual(ms.getCallId, "CAbde0362aef3d228b3a39baafa9e4f0204e724966");
            Assert.IsNull(ms.getParentCallId);

        }
    }
}
