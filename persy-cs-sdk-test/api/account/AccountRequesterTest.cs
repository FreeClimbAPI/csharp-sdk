using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.persephony.api.recording;
using com.persephony.api;
using System.Reflection;
using System.Net;
using System.IO;
using System.Linq;
using com.persephony;
using com.persephony.api.account;

namespace persy_cs_sdk_test.api.account
{
    [TestClass]
    public class AccountRequesterTest
    {

        [TestMethod]
        public void GetAccountTest()
        {
            try
            {
                AccountsRequester accountRequester = new AccountsRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(accountRequester, "http://GetAccountTest:3000");
                }

                WebRequest.RegisterPrefix("http://GetAccountTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"uri\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747\", \"revision\" : 3, \"dateCreated\" : \"Mon, 30 Jan 2017 16:30:49 GMT\", \"dateUpdated\" : \"Mon, 30 Jan 2017 17:31:47 GMT\", \"accountId\" : \"AC66c1bebe590a6389f60efa0ee9ce74d44bc29747\", \"authToken\" : \"e1b6406c8db5369912234f006ce1cbaa267561da\", \"alias\" : \"new test account 1\", \"label\" : \"test account 1 label\", \"type\" : \"trial\", \"status\" : \"active\", \"subresourceUris\" : {\"applications\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Applications\", \"calls\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Calls\", \"availablePhoneNumbers\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/AvailablePhoneNumbers\", \"conferences\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Conferences\", \"incomingPhoneNumbers\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/IncomingPhoneNumbers\", \"logs\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Logs\", \"callingNumbers\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/CallingNumbers\", \"recordings\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Recordings\", \"queues\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Queues\"}}");

                Account account = accountRequester.get("AC66c1bebe590a6389f60efa0ee9ce74d44bc29747");

                Assert.IsNotNull(account);
                Assert.AreEqual(account.getAccountId, "AC66c1bebe590a6389f60efa0ee9ce74d44bc29747");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void UpdateAccountTest()
        {
            try
            {
                AccountsRequester accountRequester = new AccountsRequester("AC66c1bebe590a6389f60efa0ee9ce74d44bc29747", "e1b6406c8db5369912234f006ce1cbaa267561da");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(accountRequester, "http://CreateAccountTest:3000");
                }

                WebRequest.RegisterPrefix("http://CreateAccountTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"uri\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747\", \"revision\" : 3, \"dateCreated\" : \"Mon, 30 Jan 2017 16:30:49 GMT\", \"dateUpdated\" : \"Mon, 30 Jan 2017 17:31:47 GMT\", \"accountId\" : \"AC66c1bebe590a6389f60efa0ee9ce74d44bc29747\", \"authToken\" : \"e1b6406c8db5369912234f006ce1cbaa267561da\", \"alias\" : \"new test account 1\", \"label\" : \"test account 1 label\", \"type\" : \"trial\", \"status\" : \"active\", \"subresourceUris\" : {\"applications\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Applications\", \"calls\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Calls\", \"availablePhoneNumbers\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/AvailablePhoneNumbers\", \"conferences\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Conferences\", \"incomingPhoneNumbers\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/IncomingPhoneNumbers\", \"logs\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Logs\", \"callingNumbers\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/CallingNumbers\", \"recordings\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Recordings\", \"queues\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Queues\"}}");
                AccountOptions options = new AccountOptions();
                options.setAlias("new test account 1");
                options.setLabel("test account 1 label");
                Account account = accountRequester.update("AC66c1bebe590a6389f60efa0ee9ce74d44bc29747");

                Assert.IsNotNull(account);
                Assert.AreEqual(account.getAlias, "new test account 1");
                Assert.AreEqual(account.getLabel, "test account 1 label");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void UpdateAccountWithRequestIdTest()
        {
            try
            {
                AccountsRequester accountRequester = new AccountsRequester("AC66c1bebe590a6389f60efa0ee9ce74d44bc29747", "e1b6406c8db5369912234f006ce1cbaa267561da");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(accountRequester, "http://CreateAccountTest:3000");
                }

                WebRequest.RegisterPrefix("http://CreateAccountTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"uri\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747\", \"revision\" : 3, \"dateCreated\" : \"Mon, 30 Jan 2017 16:30:49 GMT\", \"dateUpdated\" : \"Mon, 30 Jan 2017 17:31:47 GMT\", \"accountId\" : \"AC66c1bebe590a6389f60efa0ee9ce74d44bc29747\", \"authToken\" : \"e1b6406c8db5369912234f006ce1cbaa267561da\", \"alias\" : \"new test account 1\", \"label\" : \"test account 1 label\", \"type\" : \"trial\", \"status\" : \"active\", \"subresourceUris\" : {\"applications\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Applications\", \"calls\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Calls\", \"availablePhoneNumbers\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/AvailablePhoneNumbers\", \"conferences\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Conferences\", \"incomingPhoneNumbers\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/IncomingPhoneNumbers\", \"logs\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Logs\", \"callingNumbers\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/CallingNumbers\", \"recordings\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Recordings\", \"queues\" : \"/Accounts/AC66c1bebe590a6389f60efa0ee9ce74d44bc29747/Queues\"}}");
                AccountOptions options = new AccountOptions();
                options.setAlias("new test account 1");
                options.setLabel("test account 1 label");
                options.setRequestId("RQ1234567890123456789012345678901234567890");
                Account account = accountRequester.update("AC66c1bebe590a6389f60efa0ee9ce74d44bc29747");

                Assert.IsNotNull(account);
                Assert.AreEqual(account.getAlias, "new test account 1");
                Assert.AreEqual(account.getLabel, "test account 1 label");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }


        [TestMethod]
        public void DeleteAccountTest()
        {
            try
            {
                AccountsRequester accountRequester = new AccountsRequester("ACabe7063197551fe51671f9ac3a9708e9dad51c4d", "204c15aae7a486c42776aea4dbafe8c68a773071");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(accountRequester, "http://DeleteAccountTest:3000");
                }

                WebRequest.RegisterPrefix("http://DeleteAccountTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK);

                accountRequester.delete("AC66c1bebe590a6389f60efa0ee9ce74d44bc29747");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        
    }
}
