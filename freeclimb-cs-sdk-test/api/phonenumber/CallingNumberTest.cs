using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.api.recording;
using com.freeclimb.api.application;
using com.freeclimb.api.log;
using com.freeclimb;
using com.freeclimb.api.phonenumber;

namespace freeclimb_cs_sdk_test.api.phonenumber
{
    [TestClass]
    public class CallingNumberTest
    {
        [TestMethod]
        public void MakeCallingNumberFromJsonTest()
        {
            string json = "{ \"phoneNumber\" : \"+13033447438\", \"alias\" : \"Calling number 1\", \"revision\" : 1, \"dateCreated\" : \"Wed, 01 Feb 2017 17:33:27 GMT\", \"dateUpdated\" : \"Wed, 01 Feb 2017 17:33:27 GMT\", \"callingNumberId\" : \"PN7bbef986a434fd30ba006551ed6cc507403b5e87\", \"uri\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/CallingNumbers/PN7bbef986a434fd30ba006551ed6cc507403b5e87\", \"accountId\" : \"AC907d7e328b3a5b402fa908857e047a243a8949b1\"}";
            CallingNumber num = CallingNumber.fromJson(json);
            Assert.IsNotNull(num);
            Assert.AreEqual(num.getAlias, "Calling number 1");
            Assert.AreEqual(num.getAccountId, "AC907d7e328b3a5b402fa908857e047a243a8949b1");
            Assert.AreEqual(num.getCallingNumberId, "PN7bbef986a434fd30ba006551ed6cc507403b5e87");
            Assert.IsNotNull(num.getDateCreated);
            Assert.IsNotNull(num.getDateUpdated);
            Assert.AreEqual(num.getPhoneNumber, "+13033447438");
            Assert.AreEqual(num.getRevision, 1);
            Assert.AreEqual(num.getUri, "/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/CallingNumbers/PN7bbef986a434fd30ba006551ed6cc507403b5e87");
        }

    }
}
