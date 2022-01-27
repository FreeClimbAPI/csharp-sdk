using Newtonsoft.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.api.recording;
using com.freeclimb.api.application;
using com.freeclimb.api.log;
using com.freeclimb;
using com.freeclimb.api.phonenumber;

namespace freeclimb_cs_sdk_test.api.phonenumber
{
    [TestClass]
    public class AvailablePhoneNumberTest
    {
        [TestMethod]
        public void MakeAvailablePhoneNumberFromJsonTest()
        {
            var jsonData = new {
                phoneNumber = "+13122290330",
                alias = "312-229-0330",
                revision = 1,
                dateCreated = "Fri, 11 Nov 2016 13:42:25 GMT",
                dateUpdated = "Fri, 11 Nov 2016 13:42:25 GMT",
                region = "Illinois",
                country = "US",
                campaignId = "test campaign ID",
                provider = "test provider",
                capabilities = new {
                    sms = false,
                    voice = true,
                    tollFree = true,
                    tenDLC = false,
                    shortCode = true
                }
            };
            string json = JsonConvert.SerializeObject(jsonData);
            AvailablePhoneNumber num = AvailablePhoneNumber.fromJson(json);
            Assert.IsNotNull(num);
            Assert.AreEqual(num.getAlias, "312-229-0330");
            Assert.AreEqual(num.getCountry, "US");
            Assert.AreEqual(num.getPhoneNumber, "+13122290330");
            Assert.AreEqual(num.getRegion, "Illinois");
            Assert.AreEqual(num.getCampaignId, "test campaign ID");
            Assert.AreEqual(num.getProvider, "test provider");
            PhoneNumberCapabilities cap = num.getCapabilities;
            Assert.AreEqual(cap.getSms, false);
            Assert.AreEqual(cap.getVoice, true);
            Assert.AreEqual(cap.getTollFree, true);
            Assert.AreEqual(cap.getTenDLC, false);
            Assert.AreEqual(cap.getShortCode, true);
        }

    }
}
