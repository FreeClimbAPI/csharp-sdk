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
    public class IncomingPhoneNumberTest
    {
        [TestMethod]
        public void MakeIncomingNumberFromJsonTest()
        {
            var jsonData = new {
                phoneNumber = "+13122290330",
                alias = "new incoming number 1",
                revision = 2,
                dateCreated = "Fri, 11 Nov 2016 13:42:25 GMT",
                dateUpdated = "Fri, 11 Nov 2016 13:42:25 GMT",
                phoneNumberId = "PN3816047eda7b012ea2cf6d5e0697a2474363dcd6",
                region = "Illinois",
                country = "US",
                applicationId = "APabfb2706f416285399ae6bdd96d07b3416f6d4ce",
                uri = "/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/IncomingPhoneNumbers/PN3816047eda7b012ea2cf6d5e0697a2474363dcd6",
                accountId = "AC907d7e328b3a5b402fa908857e047a243a8949b1",
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
            IncomingPhoneNumber num = IncomingPhoneNumber.fromJson(json);
            Assert.IsNotNull(num);
            Assert.AreEqual(num.getAlias, "new incoming number 1");
            Assert.AreEqual(num.getAccountId, "AC907d7e328b3a5b402fa908857e047a243a8949b1");
            Assert.AreEqual(num.getApplicationId, "APabfb2706f416285399ae6bdd96d07b3416f6d4ce");
            Assert.AreEqual(num.getRegion, "Illinois");
            Assert.AreEqual(num.getCountry, "US");
            Assert.IsNotNull(num.getDateCreated);
            Assert.IsNotNull(num.getDateUpdated);
            Assert.AreEqual(num.getPhoneNumberId, "PN3816047eda7b012ea2cf6d5e0697a2474363dcd6");
            Assert.AreEqual(num.getPhoneNumber, "+13122290330");
            Assert.AreEqual(num.getRevision, 2);
            Assert.AreEqual(num.getUri, "/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/IncomingPhoneNumbers/PN3816047eda7b012ea2cf6d5e0697a2474363dcd6");
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
