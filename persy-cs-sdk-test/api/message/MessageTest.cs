using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.persephony.api.call;
using com.persephony.api;
using com.persephony;
using com.persephony.api.message;

namespace persy_cs_sdk_test.api.call
{
    [TestClass]
    public class MessageTest
    {
        [TestMethod]
        public void MakeMessageFromJsonTest()
        {
            string json = "{\"uri\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Messages/MM16ac1bcbd6f4895c89a798571e89e1e715892924\", \"revision\" : 1, \"dateCreated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"dateUpdated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"messageId\" : \"MM16ac1bcbd6f4895c89a798571e89e1e715892924\", \"accountId\" : \"AC736ca2078721a9a41fb47f07bf40d9e21cb304da\", \"from\" : \"+12248806205\", \"to\" : \"+18475978014\", \"text\" : \"Hello World\", \"direction\" : \"inbound\", \"status\" : \"received\", \"notificationUrl\" : \"http://server/msgNotif\"}";

            Message msg = Message.fromJson(json);
            Assert.IsNotNull(msg);
            Assert.IsNotNull(msg.getUri);
            Assert.AreEqual(msg.getUri, "/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Messages/MM16ac1bcbd6f4895c89a798571e89e1e715892924");
            Assert.AreEqual(msg.getRevision, 1);
            Assert.IsNotNull(msg.getDateCreated);
            Assert.IsNotNull(msg.getDateUpdated);
            Assert.AreEqual(msg.getText, "Hello World");
            Assert.AreEqual(msg.getTo, "+18475978014");
            Assert.AreEqual(msg.getFrom, "+12248806205");
            Assert.AreEqual(msg.getDirection, com.persephony.EMessageDirection.Inbound);
            Assert.AreEqual(msg.getStatus, com.persephony.EMessageStatus.Received);
            Assert.AreEqual(msg.getNotificationUrl, "http://server/msgNotif");
        }
    }
    

}
