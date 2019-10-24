using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.percl;
using com.freeclimb;

namespace freeclimb_cs_sdk_test.percl
{
    [TestClass]
    public class SayTest
    {
        [TestMethod]
        public void DefaultSayCommandToJsonTest()
        {
            Say say = new Say();

            string json = say.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"Say\":{\"text\":\"\"}}");
        }

        [TestMethod]
        public void SayCommandToJsonTest()
        {
            Say say = new Say();
            say.setText("hello world");
            say.setLanguage(ELanguage.SpanishMX);
            say.setLoop(1);
            say.setConferenceId("123");

            string json = say.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"Say\":{\"text\":\"hello world\",\"conferenceId\":\"123\",\"language\":\"es-MX\",\"loop\":1}}");
        }
    }
}
