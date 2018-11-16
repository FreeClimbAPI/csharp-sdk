using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.persephony.api.recording;
using com.persephony.api.application;
using com.persephony.api.log;
using com.persephony;
using com.persephony.api.phonenumber;

namespace persy_cs_sdk_test.api.phonenumber
{
    [TestClass]
    public class IncomingPhoneNumberTest
    {
        [TestMethod]
        public void MakeIncomingNumberFromJsonTest()
        {
            string json = "{ \"phoneNumber\" : \"+13122290330\", \"alias\" : \"new incoming number 1\", \"revision\" : 2, \"dateCreated\" : \"Fri, 11 Nov 2016 13:42:25 GMT\", \"dateUpdated\" : \"Wed, 01 Feb 2017 19:33:00 GMT\", \"phoneNumberId\" : \"PN3816047eda7b012ea2cf6d5e0697a2474363dcd6\", \"region\" : \"Illinois\", \"country\" : \"US\", \"voiceEnabled\" : true, \"smsEnabled\" : true, \"applicationId\" : \"APabfb2706f416285399ae6bdd96d07b3416f6d4ce\", \"uri\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/IncomingPhoneNumbers/PN3816047eda7b012ea2cf6d5e0697a2474363dcd6\", \"accountId\" : \"AC907d7e328b3a5b402fa908857e047a243a8949b1\"} ";
            IncomingPhoneNumber num = IncomingPhoneNumber.fromJson(json);
            Assert.IsNotNull(num);
            Assert.AreEqual(num.getAlias, "new incoming number 1");
            Assert.AreEqual(num.getAccountId, "AC907d7e328b3a5b402fa908857e047a243a8949b1");
            Assert.AreEqual(num.getApplicationId, "APabfb2706f416285399ae6bdd96d07b3416f6d4ce");
            Assert.AreEqual(num.getRegion, "Illinois");
            Assert.AreEqual(num.getCountry, "US");
            Assert.AreEqual(num.getVoiceEnabled, true);
            Assert.AreEqual(num.getSmsEnabled, true);
            Assert.IsNotNull(num.getDateCreated);
            Assert.IsNotNull(num.getDateUpdated);
            Assert.AreEqual(num.getPhoneNumberId, "PN3816047eda7b012ea2cf6d5e0697a2474363dcd6");
            Assert.AreEqual(num.getPhoneNumber, "+13122290330");
            Assert.AreEqual(num.getRevision, 2);
            Assert.AreEqual(num.getUri, "/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/IncomingPhoneNumbers/PN3816047eda7b012ea2cf6d5e0697a2474363dcd6");
        }

    }
}
