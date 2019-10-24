using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb;
using com.freeclimb.percl;

namespace freeclimb_cs_sdk_test.percl
{
    [TestClass]
    public class SetTalkTest
    {
        [TestMethod]
        public void SetTalkCommandToJsonTest()
        {
            SetTalk listen = new SetTalk("CA0f9381bf1fa2d3df41142fe24d938d7f62c09074");

            listen.setTalk(EBool.False);
            string json = listen.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"SetTalk\":{\"callId\":\"CA0f9381bf1fa2d3df41142fe24d938d7f62c09074\",\"talk\":false}}");
        }
    }
}
