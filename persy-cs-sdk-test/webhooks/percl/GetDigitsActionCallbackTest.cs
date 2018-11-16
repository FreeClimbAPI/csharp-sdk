using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.persephony.webhooks.percl;
using com.persephony;

namespace persy_cs_sdk_test.webhooks.percl
{
    [TestClass]
    public class GetDigitsActionCallbackTest
    {
        [TestMethod]
        public void CreateAndVerifyGetDigitsActionCallbackTest()
        {
            GetDigitsActionCallback getDigitsStatusCallback = GetDigitsActionCallback.fromJson("{\"accountId\":\"ACabe7063197551fe51671f9ac3a9708e9dad51c4d\",\"callId\":\"CAfd4a3989da31cc8a640524f8e0d44bfb0fba9761\",\"callStatus\":\"inProgress\",\"conferenceId\":null,\"digits\":\"1234567890\",\"direction\":\"inbound\",\"from\":\"1000000060\",\"parentCallId\":null,\"queueId\":null,\"reason\":\"finishKey\",\"requestId\":\"RQd0db15f753ab816348d55ed501a443d66e2018bb\",\"requestType\":\"getDigits\",\"to\":\"+11112223333\"}");

            Assert.AreEqual(getDigitsStatusCallback.getDigits, "1234567890");
            Assert.AreEqual(getDigitsStatusCallback.getReason, EDigitTermReason.FinishKey);
        }
    }
}
