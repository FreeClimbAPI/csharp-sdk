using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.persephony.api.call;
using com.persephony;

namespace persy_cs_sdk_test.api.call
{
    [TestClass]
    public class OutboundCallTest
    {
        [TestMethod]
        public void MakeOutboundCallFromJsonDefaultTest()
        {
            string json = "{\"to\":\"+18475978014\",\"from\":\"+12248806205\",\"callConnectUrl\":\"http://foo.com/Persephony/RecordingCallAnswered\",\"timeout\":27}";

            OutboundCall call = OutboundCall.fromJson(json);

            Assert.IsNotNull(call);
            Assert.AreEqual(call.getFrom, "+12248806205");
            Assert.AreEqual(call.getTo, "+18475978014");
            Assert.AreEqual(call.getCallConnectUrl, "http://foo.com/Persephony/RecordingCallAnswered");
            Assert.AreEqual(call.getTimeout, (uint)27);
            Assert.AreEqual(call.getIfMachine, EIfMachine.NONE);
        }

        [TestMethod]
        public void MakeOutboundCallFromJsonTest()
        {
            string json = "{\"to\":\"+18475978014\",\"from\":\"+12248806205\",\"callConnectUrl\":\"http://foo.com/Persephony/RecordingCallAnswered\",\"timeout\":27,\"ifMachine\":\"continue\"}";

            OutboundCall call = OutboundCall.fromJson(json);

            Assert.IsNotNull(call);
            Assert.AreEqual(call.getFrom, "+12248806205");
            Assert.AreEqual(call.getTo, "+18475978014");
            Assert.AreEqual(call.getCallConnectUrl, "http://foo.com/Persephony/RecordingCallAnswered");
            Assert.AreEqual(call.getTimeout, (uint)27);
            Assert.AreEqual(call.getIfMachine, EIfMachine.Continue);
        }

        [TestMethod]
        public void MakeOutboundCallToJsonTest()
        {
            OutboundCall call = new OutboundCall();
            call.setTo("+18475978014");
            call.setFrom("+12248806205");
            call.setCallConnectUrl("http://foo.com/Persephony/RecordingCallAnswered");

            string json = call.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"to\":\"+18475978014\",\"from\":\"+12248806205\",\"callConnectUrl\":\"http://foo.com/Persephony/RecordingCallAnswered\"}");
        }
    }
}
