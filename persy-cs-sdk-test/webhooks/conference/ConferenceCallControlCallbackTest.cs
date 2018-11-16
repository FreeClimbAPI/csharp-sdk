using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.persephony.webhooks.conference;
using com.persephony;

namespace persy_cs_sdk_test.webhooks.conference
{
    [TestClass]
    public class ConferenceCallControlCallbackTest
    {
        [TestMethod]
        public void CreateAndVerifyConferenceCallControlCallbackTest()
        {
            ConferenceCallControlCallback cs = ConferenceCallControlCallback.fromJson("{\"accountId\":\"AC766bc3fb87212042619f41ac6344feef2f1b0d00\",\"callId\":\"CA98fed82dfb2295fdd9f4a8c102c321cb6cedace6\",\"callStatus\":\"inProgress\",\"conferenceId\":\"CFa31a223c04ac99576d14ce3e50815449fe673bde\",\"direction\":\"inbound\",\"from\":\"1000000051\",\"parentCallId\":null,\"queueId\":null,\"to\":\"+11112223333\",\"digits\":\"1\"}");

            Assert.IsNotNull(cs);
            Assert.AreEqual(cs.getAccountId, "AC766bc3fb87212042619f41ac6344feef2f1b0d00");
            Assert.AreEqual(cs.getConferenceId, "CFa31a223c04ac99576d14ce3e50815449fe673bde");
            Assert.AreEqual(cs.getDigits, "1");
        }
    }
}