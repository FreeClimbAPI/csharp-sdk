using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.percl;
using com.freeclimb.api;
using com.freeclimb;

namespace freeclimb_cs_sdk_test.percl
{
    [TestClass]
    public class ParkTest
    {
        [TestMethod]
        public void MinimumParkCommandToJsonTest()
        {
            Park park = new Park("http://foo.com/wait", "http://foo.com/action");

            string json = park.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"Park\":{\"waitUrl\":\"http://foo.com/wait\", \"actionUrl\":\"http://foo.com/action\"}}");
        }
    }
}
