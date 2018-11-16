using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.persephony.api;

namespace persy_cs_sdk_test
{
    [TestClass]
    public class PersyClientTest
    {
        [TestMethod]
        public void MakePersyClientNoAccountIdTest()
        {
            PersyClient client = new PersyClient("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5");

            Assert.AreEqual(client.getCredAccountId, "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");
            Assert.AreEqual(client.getCredAuthToken, "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5");
        }

        [TestMethod]
        public void MakePersyClientAccountIdTest()
        {
            PersyClient client = new PersyClient("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304ad");

            Assert.AreEqual(client.getCredAccountId, "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");
            Assert.AreEqual(client.getCredAuthToken, "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5");
            Assert.AreEqual(client.getAccountId, "AC736ca2078721a9a41fb47f07bf40d9e21cb304ad");
        }
    }
}
