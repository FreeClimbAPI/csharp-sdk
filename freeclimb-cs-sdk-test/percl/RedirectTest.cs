using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.percl;

namespace freeclimb_cs_sdk_test.percl
{
    [TestClass]
    public class RedirectTest
    {
        [TestMethod]
        public void RedirectCommandToJsonTest()
        {
            Redirect redirect = new Redirect("http://foo.com");

            string json = redirect.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"Redirect\":{\"actionUrl\":\"http://foo.com\"}}");
        }
    }
}
