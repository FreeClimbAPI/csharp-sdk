using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.percl;
using com.freeclimb.api;
using com.freeclimb;

namespace freeclimb_cs_sdk_test.percl
{
    [TestClass]
    public class GetSpeechTest
    {

        [TestMethod]
        public void GetSpeechNoPromptsTest()
        {
            GetSpeech getSpeech = new GetSpeech("http://foo.com", "DIG1");
            getSpeech.setGrammarType(EGrammarType.BuiltIn);

            string json = getSpeech.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"GetSpeech\":{\"actionUrl\":\"http://foo.com\",\"grammarFile\":\"DIG1\",\"grammarType\":\"BUILTIN\",\"prompts\":[]}}");
        }

        [TestMethod]
        public void GetSpeechPromptsTest()
        {
            GetSpeech getSpeech = new GetSpeech("http://foo.com", "DIG1");
            getSpeech.setGrammarType(EGrammarType.BuiltIn);

            Say say = new Say();
            say.setLanguage(ELanguage.EnglishUS);
            say.setText("Test");

            getSpeech.setPrompts(say);

            string json = getSpeech.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"GetSpeech\":{\"actionUrl\":\"http://foo.com\",\"grammarFile\":\"DIG1\",\"grammarType\":\"BUILTIN\",\"prompts\":[{\"Say\":{\"text\":\"Test\",\"language\":\"en-US\"}}]}}");
        }
    }
}
