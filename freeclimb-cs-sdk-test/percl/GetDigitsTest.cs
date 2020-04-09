using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.percl;
using com.freeclimb;

namespace freeclimb_cs_sdk_test.percl
{
    [TestClass]
    public class GetDigitsTest
    {
        [TestMethod]
        public void GetDigitsNoPromptsTest()
        {
            GetDigits getDigits = new GetDigits("http://foo.com");

            string json = getDigits.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual("{\"GetDigits\":{\"actionUrl\":\"http://foo.com\",\"prompts\":[]}}", json);
        }

        [TestMethod]
        public void GetDigitsPromptsTest()
        {
            GetDigits getDigits = new GetDigits("http://foo.com");

            Say say = new Say();
            say.setLanguage(ELanguage.EnglishUS);
            say.setText("hello");

            getDigits.setPrompts(say);

            Pause pause = new Pause(1000);

            getDigits.setPrompts(pause);

            say = new Say();
            say.setLanguage(ELanguage.EnglishUS);
            say.setText("goodbye");

            getDigits.setPrompts(say);

            string json = getDigits.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"GetDigits\":{\"actionUrl\":\"http://foo.com\",\"prompts\":[{\"Say\":{\"text\":\"hello\",\"language\":\"en-US\"}},{\"Pause\":{\"length\":1000}},{\"Say\":{\"text\":\"goodbye\",\"language\":\"en-US\"}}]}}");
        }
    }
}
