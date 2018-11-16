using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.persephony.api.recording;
using com.persephony.api.account;

namespace persy_cs_sdk_test.api.account
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void MakeAccountFromJsonTest()
        {
            string json = "{ \"uri\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1\", \"revision\" : 1, \"dateCreated\" : \"Thu, 08 Dec 2016 17:08:08 GMT\", \"dateUpdated\" : \"Thu, 08 Dec 2016 17:08:08 GMT\", \"accountId\" : \"AC907d7e328b3a5b402fa908857e047a243a8949b1\", \"authToken\" : \"2c78e8a8d1033b77902758e584ad5fc4a1c5ee02\", \"alias\" : \"Master Account\", \"label\" : null, \"type\" : \"trial\", \"status\" : \"active\", \"subresourceUris\" : { \"applications\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/Applications\", \"calls\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/Calls\", \"availablePhoneNumbers\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/AvailablePhoneNumbers\", \"conferences\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/Conferences\", \"incomingPhoneNumbers\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/IncomingPhoneNumbers\", \"logs\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/Logs\", \"callingNumbers\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/CallingNumbers\", \"recordings\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/Recordings\", \"queues\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/Queues\"} }";
            Account account = Account.fromJson(json);

            Assert.IsNotNull(account);
            Assert.IsNotNull(account.getUri);
            Assert.AreEqual(account.getUri, "/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1");
            Assert.AreEqual(account.getAccountId, "AC907d7e328b3a5b402fa908857e047a243a8949b1");
            Assert.AreEqual(account.getAuthToken, "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02");
            Assert.AreEqual(account.getAlias, "Master Account");
            Assert.AreEqual(account.getRevision, 1);
            Assert.IsNotNull(account.getDateCreated);
            Assert.IsNotNull(account.getDateUpdated);
            Assert.AreEqual(account.getType, com.persephony.EAccountType.Trial);
            Assert.AreEqual(account.getStatus, com.persephony.EAccountStatus.Active);
            Assert.AreEqual(account.getSubresourceUris.Count, 9);
        }

    }
}
