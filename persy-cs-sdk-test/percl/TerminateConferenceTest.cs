using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.persephony.percl;

namespace persy_cs_sdk_test.percl
{
    [TestClass]
    public class TerminateConferenceTest
    {
        [TestMethod]
        public void TerminateConferenceCommandToJsonTest()
        {
            TerminateConference removeFromConference = new TerminateConference("CFafa975185bfe5e34bb70b18dfbdb4dfdd74d9a64");

            string json = removeFromConference.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"TerminateConference\":{\"conferenceId\":\"CFafa975185bfe5e34bb70b18dfbdb4dfdd74d9a64\"}}");
        }
    }
}
