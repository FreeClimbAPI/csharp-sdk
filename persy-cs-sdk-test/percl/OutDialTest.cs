using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.persephony.percl;
using com.persephony.api;
using com.persephony;

namespace persy_cs_sdk_test.percl
{
    [TestClass]
    public class OutDialTest
    {
        [TestMethod]
        public void OutDialCommandToJsonTest()
        {
            OutDial outdial = new OutDial("+18475971234", "http://foo.com/callConnectUrl");
            outdial.setActionUrl("http://foo.com/actionUrl");
            outdial.setIfMachine(EIfMachine.Hangup); 
            outdial.setSendDigits("12{2}34{4}#");
            outdial.setTimeout(1000);
            outdial.setIfMachineUrl("http://foo.com/ifMachineUrl");
            outdial.setStatusCallbackUrl("http://foo.com/statusCallbackUrl");

            string json = outdial.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"OutDial\":{\"destination\":\"+18475971234\",\"callConnectUrl\":\"http://foo.com/callConnectUrl\",\"sendDigits\":\"12{2}34{4}#\",\"timeout\":1000,\"ifMachine\":\"hangup\",\"actionUrl\":\"http://foo.com/actionUrl\",\"ifMachineUrl\":\"http://foo.com/ifMachineUrl\",\"statusCallbackUrl\":\"http://foo.com/statusCallbackUrl\"}}");
        }
    }
}
