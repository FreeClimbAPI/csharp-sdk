using com.freeclimb.api;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace freeclimb_cs_sdk_test.api
{
    [TestClass]
    public class FreeClimbCommonTest
    {
        [TestMethod]
        public void MakeFreeClimbCommonFromJsonTest()
        {
            string json = "{\"uri\" : \"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924\", \"revision\" : 101, \"dateCreated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"dateUpdated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\" }";
            FreeClimbCommon pc = JsonConvert.DeserializeObject<FreeClimbCommon>(json);

            Assert.AreEqual(pc.getUri, "/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Calls/CA16ac1bcbd6f4895c89a798571e89e1e715892924");
            Assert.AreEqual(pc.getDateCreated.ToString(), "6/23/2016 5:30:06 PM");
            Assert.AreEqual(pc.getDateUpdated.ToString(), "6/23/2016 5:30:06 PM");
            Assert.AreEqual(pc.getRevision, 101);
        }
    }
}
