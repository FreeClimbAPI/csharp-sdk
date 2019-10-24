using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.percl;
using com.freeclimb.api;
using com.freeclimb;

namespace freeclimb_cs_sdk_test.percl
{
    [TestClass]
    public class RecordUtteranceTest
    {
        [TestMethod]
        public void MinimumRecordUtteranceCommandToJsonTest()
        {
            RecordUtterance recordUtterance = new RecordUtterance("http://foo.com/handleRecording.php");

            string json = recordUtterance.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"RecordUtterance\":{\"actionUrl\":\"http://foo.com/handleRecording.php\"}}");
        }
        
        [TestMethod]
        public void RecordUtteranceCommandToJsonTest()
        {
            RecordUtterance recordUtterance = new RecordUtterance("http://foo.com/handleRecording.php");
            recordUtterance.setSilenceTimeoutMs(2500);
            recordUtterance.setMaxLengthSec(60);
            recordUtterance.setFinishOnKey(EFinishOnKey.Pound);
            recordUtterance.setPlayBeep(com.freeclimb.EBool.True);
            recordUtterance.setAutoStart(com.freeclimb.EBool.False);

            string json = recordUtterance.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"RecordUtterance\":{\"actionUrl\":\"http://foo.com/handleRecording.php\",\"silenceTimeoutMs\":2500,\"finishOnKey\":\"#\",\"maxLengthSec\":60,\"playBeep\":true,\"autoStart\":false}}");
        }
    }
}
