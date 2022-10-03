using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.percl;
using com.freeclimb.api;
using com.freeclimb;

namespace freeclimb_cs_sdk_test.percl
{
    [TestClass]
    public class UnparkTest
    {
        [TestMethod]
        public void MinimumUnparkCommandToJsonTest()
        {
            Unpark unpark = new Unpark();

            string json = unpark.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"Unpark\":{}}");
        }
    }
}
