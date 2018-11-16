using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.persephony.webhooks;
using com.persephony.webhooks.call;
using com.persephony;

namespace persy_cs_sdk_test.webhooks.recording
{
    [TestClass]
    public class RecordingUtteranceStatusCallbackTest
    {
        [TestMethod]
        public void CreateAndVerifyRecordingUtteranceActionCallbackTest()
        {
            RecordingUtteranceActionCallback ru = RecordingUtteranceActionCallback.fromJson("{\"accountId\":\"AC736ca2078721a9a41fb47f07bf40d9e21cb304da\",\"callId\":\"CA7d00ca83adccbdf9d3f502176dbdd09fa5b886aa\",\"callStatus\":\"inProgress\",\"conferenceId\":null,\"direction\":\"outboundAPI\",\"from\":\"+12248806205\",\"parentCallId\":null,\"queueId\":null,\"recordingDurationSec\":4,\"recordingFormat\":\"audio/wav\",\"recordingId\":\"RE480dd877f1e9bb161fe4ce5f7af265433d8f5200\",\"recordingSize\":19884,\"recordingUrl\":\"/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Recordings/RE480dd877f1e9bb161fe4ce5f7af265433d8f5200/Download\",\"requestId\":\"RQ36e2885c0baeb78da51f27269440e62862898f4c\",\"requestType\":\"record\",\"termReason\":\"finishKey\",\"to\":\"+18475978014\"}");

            Assert.AreEqual(ru.getAccountId, "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");
            Assert.AreEqual(ru.getCallId, "CA7d00ca83adccbdf9d3f502176dbdd09fa5b886aa");
            Assert.AreEqual(ru.getCallStatus, ECallStatus.InProgress);
            Assert.AreEqual(ru.getRecordingDurationSec, 4);
            Assert.AreEqual(ru.getRecordingFormat, "audio/wav");
            Assert.AreEqual(ru.getRecordingId, "RE480dd877f1e9bb161fe4ce5f7af265433d8f5200");
            Assert.AreEqual(ru.getRecordingSize, 19884);
            Assert.AreEqual(ru.getRecordingUrl, "/Accounts/AC736ca2078721a9a41fb47f07bf40d9e21cb304da/Recordings/RE480dd877f1e9bb161fe4ce5f7af265433d8f5200/Download");
            Assert.AreEqual(ru.getTermReason, ERecordTermReason.FinishKey);
            Assert.IsNull(ru.getConferenceId);
            Assert.AreEqual(ru.getDirection, EDirection.OutboundAPI);
            Assert.AreEqual(ru.getFrom, "+12248806205");
            Assert.IsNull(ru.getParentCallId);
            Assert.IsNull(ru.getQueueId);
            Assert.AreEqual(ru.getRequestId, "RQ36e2885c0baeb78da51f27269440e62862898f4c");
            Assert.AreEqual(ru.getRequestType, ERequestType.Record);
            Assert.AreEqual(ru.getTo, "+18475978014");
        }
    }
}
