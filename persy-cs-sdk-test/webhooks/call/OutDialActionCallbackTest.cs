using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.persephony.webhooks.call;
using com.persephony;

namespace persy_cs_sdk_test.webhooks.call
{
    [TestClass]
    public class OutDialActionCallbackTest
    {
        [TestMethod]
        public void CreateAndVerifyOutDialActionCallbackTest()
        {
            OutDialActionCallback oa = OutDialActionCallback.fromJson("{\"accountId\":\"AC766bc3fb87212042619f41ac6344feef2f1b0d00\",\"callId\":\"CA06d0eeb157c2322e3c44a19947eec2085e4be356\",\"callStatus\":\"inProgress\",\"conferenceId\":null,\"dialCallId\":\"CA694ec3a0eedfc8d62a96e3c97defc89371b1fdda\",\"direction\":\"outboundDial\",\"from\":\"+12248806205\",\"queueId\":null,\"requestType\":\"outDialStart\",\"to\":\"+18475978014\"}");

            Assert.AreEqual(oa.getAccountId, "AC766bc3fb87212042619f41ac6344feef2f1b0d00");
            Assert.AreEqual(oa.getCallId, "CA06d0eeb157c2322e3c44a19947eec2085e4be356");
            Assert.AreEqual(oa.getCallStatus, ECallStatus.InProgress);
            Assert.IsNull(oa.getConferenceId);
            Assert.AreEqual(oa.getDirection, EDirection.OutboundDial);
            Assert.AreEqual(oa.getFrom, "+12248806205");
            Assert.IsNull(oa.getParentCallId);
            Assert.AreEqual(oa.getDialCallId, "CA694ec3a0eedfc8d62a96e3c97defc89371b1fdda"); 
            Assert.AreEqual(oa.getTo, "+18475978014");
        }
    }
}
