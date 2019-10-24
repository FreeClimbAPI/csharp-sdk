using com.freeclimb;
using com.freeclimb.percl;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace freeclimb_cs_sdk_test.percl
{
    [TestClass]
    public class SetListenTest
    {
        [TestMethod]
        public void SetListenCommandToJsonTest()
        {
            SetListen listen = new SetListen("CA0f9381bf1fa2d3df41142fe24d938d7f62c09074");

            listen.setListen(EBool.False);
            string json = listen.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"SetListen\":{\"callId\":\"CA0f9381bf1fa2d3df41142fe24d938d7f62c09074\",\"listen\":false}}");
        }
    }
}
