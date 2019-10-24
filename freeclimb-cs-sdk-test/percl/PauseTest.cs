using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.percl;
using com.freeclimb.api;

namespace freeclimb_cs_sdk_test.percl
{
    [TestClass]
    public class PauseTest
    {
        [TestMethod]
        public void MinimumPauseCommandToJsonTest()
        {
            Pause pause = new Pause(4000);

            string json = pause.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"Pause\":{\"length\":4000}}");
        }

        [TestMethod]
        public void PauseCommandToJsonTest()
        {
            Pause pause = new Pause(4000);
            pause.setDetectEnergy(com.freeclimb.EBool.True);
            pause.setMaxGap(10);
            pause.setMinDuration(30);
            pause.setActionUrl("http://foo.com/handleRecording.php");

            string json = pause.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"Pause\":{\"length\":4000,\"detectEnergy\":true,\"minDuration\":30,\"maxGap\":10,\"actionUrl\":\"http://foo.com/handleRecording.php\"}}");
        }
    }
}
