using com.freeclimb.api;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace freeclimb_cs_sdk_test.api
{
    [TestClass]
    public class FreeClimbClientTest
    {
        [TestMethod]
        public void MakeFreeClimbClientNoAccountIdTest()
        {
            FreeClimbClient client = new FreeClimbClient("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5");

            Assert.AreEqual(client.getCredAccountId, "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");
            Assert.AreEqual(client.getCredApiKey, "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5");
        }

        [TestMethod]
        public void MakeFreeClimbClientAccountIdTest()
        {
            FreeClimbClient client = new FreeClimbClient("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304ad");

            Assert.AreEqual(client.getCredAccountId, "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");
            Assert.AreEqual(client.getCredApiKey, "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5");
            Assert.AreEqual(client.getAccountId, "AC736ca2078721a9a41fb47f07bf40d9e21cb304ad");
        }
    }
}
