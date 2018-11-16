using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.persephony.webhooks.call;
using com.persephony;

namespace persy_cs_sdk_test.webhooks.call
{
    [TestClass]
    public class OutDialIfMachineCallbackTest
    {
        [TestMethod]
        public void CreateAndVerifyOutDialIfMachineFaxCallbackTest()
        {
           OutDialIfMachineCallback oim = OutDialIfMachineCallback.fromJson("{\"accountId\":\"AC766bc3fb87212042619f41ac6344feef2f1b0d00\",\"callId\":\"CA06d0eeb157c2322e3c44a19947eec2085e4be356\",\"callStatus\":\"inProgress\",\"conferenceId\":null,\"parentCallId\":\"CA694ec3a0eedfc8d62a96e3c97defc89371b1fdda\",\"direction\":\"outboundDial\",\"machineType\":\"faxMachine\",\"from\":\"+12248806205\",\"queueId\":null,\"requestType\":\"machineDetected\",\"to\":\"+18475978014\"}");

            Assert.AreEqual(oim.getAccountId, "AC766bc3fb87212042619f41ac6344feef2f1b0d00");
            Assert.AreEqual(oim.getCallId, "CA06d0eeb157c2322e3c44a19947eec2085e4be356");
            Assert.AreEqual(oim.getCallStatus, ECallStatus.InProgress);
            Assert.IsNull(oim.getConferenceId);
            Assert.AreEqual(oim.getDirection, EDirection.OutboundDial);
            Assert.AreEqual(oim.getFrom, "+12248806205");
            Assert.AreEqual(oim.getMachineType, EMachineType.Fax);
            Assert.AreEqual(oim.getParentCallId, "CA694ec3a0eedfc8d62a96e3c97defc89371b1fdda");
            Assert.AreEqual(oim.getTo, "+18475978014");
        }

        [TestMethod]
        public void CreateAndVerifyOutDialIfMachineAnsweringCallbackTest()
        {
            OutDialIfMachineCallback oim = OutDialIfMachineCallback.fromJson("{\"accountId\":\"AC766bc3fb87212042619f41ac6344feef2f1b0d00\",\"callId\":\"CA06d0eeb157c2322e3c44a19947eec2085e4be356\",\"callStatus\":\"inProgress\",\"conferenceId\":null,\"parentCallId\":\"CA694ec3a0eedfc8d62a96e3c97defc89371b1fdda\",\"direction\":\"outboundDial\",\"machineType\":\"answeringMachine\",\"from\":\"+12248806205\",\"queueId\":null,\"requestType\":\"machineDetected\",\"to\":\"+18475978014\"}");

            Assert.AreEqual(oim.getAccountId, "AC766bc3fb87212042619f41ac6344feef2f1b0d00");
            Assert.AreEqual(oim.getCallId, "CA06d0eeb157c2322e3c44a19947eec2085e4be356");
            Assert.AreEqual(oim.getCallStatus, ECallStatus.InProgress);
            Assert.IsNull(oim.getConferenceId);
            Assert.AreEqual(oim.getDirection, EDirection.OutboundDial);
            Assert.AreEqual(oim.getFrom, "+12248806205");
            Assert.AreEqual(oim.getMachineType, EMachineType.Answering);
            Assert.AreEqual(oim.getParentCallId, "CA694ec3a0eedfc8d62a96e3c97defc89371b1fdda");
            Assert.AreEqual(oim.getTo, "+18475978014");
        }
    }
}
