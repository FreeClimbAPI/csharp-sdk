using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.webhooks.percl;
using com.freeclimb;

namespace freeclimb_cs_sdk_test.webhooks.percl
{
    [TestClass]
    public class GetSpeechActionCallbackTest
    {
        [TestMethod]
        public void CreateAndVerifyGetSpeechStatusCallbackDigitReasonTest()
        {
            GetSpeechActionCallback getSpeechStatusCallback = GetSpeechActionCallback.fromJson("{\"accountId\":\"ACe1006ad515dbfc486dcb75d08db1445b928aef08\",\"callId\":\"CA2a98e2a2635c7cbd610d1085099a6c73e8990c7a\",\"callStatus\":\"inProgress\",\"conferenceId\":null,\"confidence\":null,\"direction\":\"outboundAPI\",\"from\":\"+12248806205\",\"parentCallId\":null,\"queueId\":null,\"reason\":\"digit\",\"requestId\":\"RQc6a43de7b417b7c77b6a1e3c27628bb83c86c6ca\",\"requestType\":\"getSpeech\",\"recognitionResult\":\"3 3 3\",\"to\":\"+18475978014\"}");

            Assert.AreEqual(getSpeechStatusCallback.getRecognitionResult, "3 3 3");
            Assert.AreEqual(getSpeechStatusCallback.getReason, ESpeechTermReason.Digit);
            Assert.AreEqual(getSpeechStatusCallback.getConfidence, 0);
        }

        [TestMethod]
        public void CreateAndVerifyGetSpeechStatusCallbackDigitRecognitionTest()
        {
            GetSpeechActionCallback getSpeechStatusCallback = GetSpeechActionCallback.fromJson("{\"accountId\":\"ACe1006ad515dbfc486dcb75d08db1445b928aef08\",\"callId\":\"CA2a98e2a2635c7cbd610d1085099a6c73e8990c7a\",\"callStatus\":\"inProgress\",\"conferenceId\":null,\"confidence\":92,\"direction\":\"outboundAPI\",\"from\":\"+12248806205\",\"parentCallId\":null,\"queueId\":null,\"reason\":\"recognition\",\"requestId\":\"RQc6a43de7b417b7c77b6a1e3c27628bb83c86c6ca\",\"requestType\":\"getSpeech\",\"recognitionResult\":\"3 3 3\",\"to\":\"+18475978014\"}");

            Assert.AreEqual(getSpeechStatusCallback.getRecognitionResult, "3 3 3");
            Assert.AreEqual(getSpeechStatusCallback.getReason, ESpeechTermReason.Recognition);
            Assert.AreEqual(getSpeechStatusCallback.getConfidence, 92);
        }
    }
}
