using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.percl;

namespace freeclimb_cs_sdk_test.percl
{
    [TestClass]
    public class RemoveFromConferenceTest
    {
        [TestMethod]
        public void RemoveFromConferenceCommandToJsonTest()
        {
            RemoveFromConference removeFromConference = new RemoveFromConference("CA0f9381bf1fa2d3df41142fe24d938d7f62c09074");

            string json = removeFromConference.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"RemoveFromConference\":{\"callId\":\"CA0f9381bf1fa2d3df41142fe24d938d7f62c09074\"}}");
        }
    }
}
