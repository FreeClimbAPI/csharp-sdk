using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.persephony.percl;
using com.persephony.api;

namespace persy_cs_sdk_test.percl
{
    [TestClass]
    public class PlayTest
    {
        [TestMethod]
        public void MinimumPlayCommandToJsonTest()
        {
            Play play = new Play("http://foo.com/handleRecording.php");

            string json = play.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"Play\":{\"file\":\"http://foo.com/handleRecording.php\"}}");
        }

        [TestMethod]
        public void PlayCommandToJsonTest()
        {
            Play play = new Play("http://foo.com/greeting.wav");
            play.setLoop(1);
            play.setConferenceId("123");

            string json = play.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"Play\":{\"file\":\"http://foo.com/greeting.wav\",\"conferenceId\":\"123\",\"loop\":1}}");
        }
    }
}
