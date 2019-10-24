using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.percl;

namespace freeclimb_cs_sdk_test.percl
{
    [TestClass]
    public class HangupTest
    {
        [TestMethod]
        public void DefaultHangupCommandToJsonTest()
        {
            Hangup hangup = new Hangup();

            string json = hangup.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"Hangup\":{}}");
        }

        [TestMethod]
        public void HangupCommandToJsonTest()
        {
            Hangup hangup = new Hangup();
            hangup.setCallId("12345");
            hangup.setReason("the reason");

            string json = hangup.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"Hangup\":{\"callId\":\"12345\",\"reason\":\"the reason\"}}");
        }
    }
}
