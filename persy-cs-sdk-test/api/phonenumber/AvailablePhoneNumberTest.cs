using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.persephony.api.recording;
using com.persephony.api.application;
using com.persephony.api.log;
using com.persephony;
using com.persephony.api.phonenumber;

namespace persy_cs_sdk_test.api.phonenumber
{
    [TestClass]
    public class AvailablePhoneNumberTest
    {
        [TestMethod]
        public void MakeAvailablePhoneNumberFromJsonTest()
        {
            string json = "{\"phoneNumber\" : \"+13122290330\", \"alias\" : \"312-229-0330\", \"revision\" : 1, \"dateCreated\" : \"Fri, 11 Nov 2016 13:42:25 GMT\", \"dateUpdated\" : \"Fri, 11 Nov 2016 13:42:25 GMT\", \"region\" : \"Illinois\", \"country\" : \"US\", \"voiceEnabled\" : true, \"smsEnabled\" : true}";
            AvailablePhoneNumber num = AvailablePhoneNumber.fromJson(json);
            Assert.IsNotNull(num);
            Assert.AreEqual(num.getAlias, "312-229-0330");
            Assert.AreEqual(num.getCountry, "US");
            Assert.AreEqual(num.getPhoneNumber, "+13122290330");
            Assert.AreEqual(num.getRegion, "Illinois");
            Assert.AreEqual(num.getVoiceEnabled, true);
            Assert.AreEqual(num.getSmsEnabled, true);
        }

    }
}
