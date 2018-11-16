using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.persephony.api.call;
using com.persephony.api;
using com.persephony;

namespace persy_cs_sdk_test.api.call
{
    [TestClass]
    public class CallTest
    {
        [TestMethod]
        public void MakeCallFromJsonTest()
        {
            string json = "{\"uri\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924\", \"revision\" : 1, \"dateCreated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"dateUpdated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"callId\" : \"CA16ac1bcbd6f4895c89a798571e89e1e715892924\", \"parentCallId\" : null, \"accountId\" : \"AC736ca2078721a9a41fb47f07bf40d9e21cb304da\", \"from\" : \"+12248806205\", \"to\" : \"+18475978014\", \"phoneNumberId\" : \"PN1311218371073288ff9c0434698753f98ea4228a\", \"status\" : \"queued\", \"startTime\" : null, \"endTime\" : null, \"duration\" : 0, \"direction\" : \"outboundAPI\", \"answeredBy\" : null, \"callerName\" : null, \"subresourceUris\" : {\"logs\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924/Logs\", \"notifications\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924/Notifications\", \"recordings\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924/Recordings\"}}";

            Call call = Call.fromJson(json);

            Assert.IsNotNull(call);
            Assert.IsNotNull(call.getUri);
            Assert.AreEqual(call.getUri, "/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924");
            Assert.AreEqual(call.getSubresourceUris.Count, 3);

            string result;
            Assert.IsTrue(call.getSubresourceUris.TryGetValue(Call.SubresourceUri.Notifications, out result));
            Assert.AreEqual(result, "/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924/Notifications");

            Assert.IsTrue(call.getSubresourceUris.TryGetValue(Call.SubresourceUri.Recordings, out result));
            Assert.AreEqual(result, "/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924/Recordings");

            Assert.IsTrue(call.getSubresourceUris.TryGetValue(Call.SubresourceUri.Logs, out result));
            Assert.AreEqual(result, "/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924/Logs");

            Assert.AreEqual(call.getRevision, 1);
            Assert.IsNotNull(call.getDateCreated);
            Assert.IsNotNull(call.getDateUpdated);
            Assert.AreEqual(call.getStatus, ECallStatus.Queued);
        }
    }
    

}
