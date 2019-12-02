using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.percl;

namespace freeclimb_cs_sdk_test.percl
{
    [TestClass]

    public class RejectTest
    {
        [TestMethod]
        public void DefaultRejectCommandToJsonTest()
        {
            Reject reject = new Reject();

            string json = reject.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"Reject\":{}");
        }

        [TestMethod]
        public void RejectCommandToJsonTest()
        {
            Reject reject = new Reject();
            reject.setReason("not available right now");

            string json = reject.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"Reject\":{\"reason\":\"not available right now\",}}");
        }
    }
}
