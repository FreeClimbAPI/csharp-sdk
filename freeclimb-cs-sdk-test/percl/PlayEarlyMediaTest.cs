using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.percl;

namespace freeclimb_cs_sdk_test.percl
{
    [TestClass]
    public class PlayEarlyMediaTest
    {
        [TestMethod]
        public void PlayEarlyMediaToJsonTest()
        {
            PlayEarlyMedia playEarlyMedia = new PlayEarlyMedia("http://www.foo.com/greeting.wav");

            string json = playEarlyMedia.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"PlayEarlyMedia\":{\"file\":\"http://www.foo.com/greeting.wav\"}}");
        }
    }
}
