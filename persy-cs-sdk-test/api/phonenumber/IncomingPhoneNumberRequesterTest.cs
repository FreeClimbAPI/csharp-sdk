using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.persephony.api.recording;
using com.persephony.api;
using System.Reflection;
using System.Net;
using System.IO;
using System.Linq;
using com.persephony;
using com.persephony.api.application;
using com.persephony.api.log;
using com.persephony.api.phonenumber;

namespace persy_cs_sdk_test.api.phonenumber
{
    [TestClass]
    public class IncomingPhoneNumberRequesterTest
    {
        [TestMethod]
        public void GetIncomingNumberListTest()
        {
            try
            {
                IncomingPhoneNumbersRequester requester = new IncomingPhoneNumbersRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://GetIncomingListTest:3000");
                }

                WebRequest.RegisterPrefix("http://GetIncomingListTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{\"total\":3,\"start\":0,\"end\":1,\"page\":0,\"numPages\":2,\"pageSize\":2,\"nextPageUri\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/CallingNumbers&cursor=492dc883a811bd0204204ea9047122f93a2788a2\", \"incomingPhoneNumbers\" : [{\"phoneNumber\" : \"+13126516046\", \"alias\" : \"312-651-6046\", \"revision\" : 2, \"dateCreated\" : \"Fri, 11 Nov 2016 13:42:22 GMT\", \"dateUpdated\" : \"Thu, 08 Dec 2016 20:41:18 GMT\", \"phoneNumberId\" : \"PN5fdc25a5db02d03aa1da1f85f18d6bfa6e45a701\", \"region\" : \"Illinois\", \"country\" : \"US\", \"voiceEnabled\" : true, \"smsEnabled\" : true, \"applicationId\" : \"APbd38defccbf9a1db844551aa8ae0531a876bc84b\", \"uri\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/IncomingPhoneNumbers/PN5fdc25a5db02d03aa1da1f85f18d6bfa6e45a701\", \"accountId\" : \"AC907d7e328b3a5b402fa908857e047a243a8949b1\"}, {\"phoneNumber\" : \"+13124881429\", \"alias\" : \"312-488-1429\", \"revision\" : 2, \"dateCreated\" : \"Fri, 11 Nov 2016 13:42:24 GMT\", \"dateUpdated\" : \"Sun, 15 Jan 2017 18:37:53 GMT\", \"phoneNumberId\" : \"PN5b881cc45548df1d015b7450fa9e3f1e301e1b97\", \"region\" : \"Illinois\", \"country\" : \"US\", \"voiceEnabled\" : true, \"smsEnabled\" : true, \"applicationId\" : \"APabfb2706f416285399ae6bdd96d07b3416f6d4ce\", \"uri\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/IncomingPhoneNumbers/PN5b881cc45548df1d015b7450fa9e3f1e301e1b97\", \"accountId\" : \"AC907d7e328b3a5b402fa908857e047a243a8949b1\"}]}");


                IncomingPhoneNumberList list = requester.get();

                Assert.IsNotNull(list);

                Assert.AreEqual(list.getLocalSize, 2);
                Assert.AreEqual((list.export()).Count, 2);

                IncomingPhoneNumber num = list.get(0) as IncomingPhoneNumber;

                Assert.IsNotNull(num);
                Assert.AreEqual(num.getPhoneNumberId, "PN5fdc25a5db02d03aa1da1f85f18d6bfa6e45a701");

                type = typeof(APIRequester);
                fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(list, "http://GetIncomingListTest:3000");
                }

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{\"total\":3,\"start\":2,\"end\":2,\"page\":1,\"numPages\":2,\"pageSize\":2,\"nextPageUri\":null, \"incomingPhoneNumbers\" : [{\"phoneNumber\" : \"+13129975947\", \"alias\" : \"312-997-5947\", \"revision\" : 1, \"dateCreated\" : \"Fri, 11 Nov 2016 13:42:24 GMT\", \"dateUpdated\" : \"Thu, 26 Jan 2017 16:37:43 GMT\", \"phoneNumberId\" : \"PNeced5e8f2764adcc0cd0637bc52e6f45583458a6\", \"region\" : \"Illinois\", \"country\" : \"US\", \"voiceEnabled\" : true, \"smsEnabled\" : true, \"applicationId\" : null, \"uri\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/IncomingPhoneNumbers/PNeced5e8f2764adcc0cd0637bc52e6f45583458a6\", \"accountId\" : \"AC907d7e328b3a5b402fa908857e047a243a8949b1\"}]}");

                list.loadNextPage();

                Assert.IsNotNull(list);

                Assert.AreEqual(list.getLocalSize, 3);
                Assert.AreEqual((list.export()).Count, 3);

                num = list.get(2) as IncomingPhoneNumber;
                Assert.IsNotNull(num);
                Assert.AreEqual(num.getPhoneNumberId, "PNeced5e8f2764adcc0cd0637bc52e6f45583458a6");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void GetIncomingNumberListUsingFilterTest()
        {
            try
            {
                IncomingPhoneNumbersRequester requester = new IncomingPhoneNumbersRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://GetCallingListTest:3000");
                }

                WebRequest.RegisterPrefix("http://GetCallingListTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,

                    "{ \"total\" : 1, \"start\" : 0, \"end\" : 0, \"page\" : 0, \"numPages\" : 1, \"pageSize\" : 100, \"nextPageUri\" : null, \"incomingPhoneNumbers\" : [{\"phoneNumber\" : \"+13126516046\", \"alias\" : \"312-651-6046\", \"revision\" : 2, \"dateCreated\" : \"Fri, 11 Nov 2016 13:42:22 GMT\", \"dateUpdated\" : \"Thu, 08 Dec 2016 20:41:18 GMT\", \"phoneNumberId\" : \"PN5fdc25a5db02d03aa1da1f85f18d6bfa6e45a701\", \"region\" : \"Illinois\", \"country\" : \"US\", \"voiceEnabled\" : true, \"smsEnabled\" : true, \"applicationId\" : \"APbd38defccbf9a1db844551aa8ae0531a876bc84b\", \"uri\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/IncomingPhoneNumbers/PN5fdc25a5db02d03aa1da1f85f18d6bfa6e45a701\", \"accountId\" : \"AC907d7e328b3a5b402fa908857e047a243a8949b1\"}]}");

                IncomingPhoneNumbersSearchFilter filter = new IncomingPhoneNumbersSearchFilter();
                filter.setPhoneNumber("^\\+1[0-9]{10}$");
                filter.setAlias("312-651-6046");
                IncomingPhoneNumberList list = requester.get(filter);

                Assert.IsNotNull(list);

                Assert.AreEqual(list.getLocalSize, 1);
                Assert.AreEqual((list.export()).Count, 1);

                IncomingPhoneNumber num = list.get(0) as IncomingPhoneNumber;

                Assert.IsNotNull(num);
                Assert.AreEqual(num.getPhoneNumber, "+13126516046");
                Assert.AreEqual(num.getAlias, "312-651-6046");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void GetIncomingNumberTest()
        {
            try
            {
                IncomingPhoneNumbersRequester requester = new IncomingPhoneNumbersRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://GetIncomingTest:3000");
                }

                WebRequest.RegisterPrefix("http://GetIncomingTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{\"phoneNumber\" : \"+13126516046\", \"alias\" : \"312-651-6046\", \"revision\" : 2, \"dateCreated\" : \"Fri, 11 Nov 2016 13:42:22 GMT\", \"dateUpdated\" : \"Thu, 08 Dec 2016 20:41:18 GMT\", \"phoneNumberId\" : \"PN5fdc25a5db02d03aa1da1f85f18d6bfa6e45a701\", \"region\" : \"Illinois\", \"country\" : \"US\", \"voiceEnabled\" : true, \"smsEnabled\" : true, \"applicationId\" : \"APbd38defccbf9a1db844551aa8ae0531a876bc84b\", \"uri\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/IncomingPhoneNumbers/PN5fdc25a5db02d03aa1da1f85f18d6bfa6e45a701\", \"accountId\" : \"AC907d7e328b3a5b402fa908857e047a243a8949b1\"}");
               

                IncomingPhoneNumber num = requester.get("PN5fdc25a5db02d03aa1da1f85f18d6bfa6e45a701");

                Assert.IsNotNull(num);
                Assert.AreEqual(num.getPhoneNumberId, "PN5fdc25a5db02d03aa1da1f85f18d6bfa6e45a701");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void UpdateIncomingNumberTest()
        {
            try
            {
                IncomingPhoneNumbersRequester requester = new IncomingPhoneNumbersRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://UpdateIncomingTest:3000");
                }

                WebRequest.RegisterPrefix("http://UpdateIncomingTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{ \"phoneNumber\" : \"+13122290330\", \"alias\" : \"new incoming number 1\", \"revision\" : 2, \"dateCreated\" : \"Fri, 11 Nov 2016 13:42:25 GMT\", \"dateUpdated\" : \"Wed, 01 Feb 2017 19:33:00 GMT\", \"phoneNumberId\" : \"PN3816047eda7b012ea2cf6d5e0697a2474363dcd6\", \"region\" : \"Illinois\", \"country\" : \"US\", \"voiceEnabled\" : true, \"smsEnabled\" : true, \"applicationId\" : \"APabfb2706f416285399ae6bdd96d07b3416f6d4ce\", \"uri\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/IncomingPhoneNumbers/PN3816047eda7b012ea2cf6d5e0697a2474363dcd6\", \"accountId\" : \"AC907d7e328b3a5b402fa908857e047a243a8949b1\"} ");
                IncomingPhoneNumberOptions options = new IncomingPhoneNumberOptions();
                options.setAlias("new incoming number 1");
                options.setApplicationId("APabfb2706f416285399ae6bdd96d07b3416f6d4ce");
                IncomingPhoneNumber num = requester.update("PN3816047eda7b012ea2cf6d5e0697a2474363dcd6", options);

                Assert.IsNotNull(num);
                Assert.AreEqual(num.getAlias, "new incoming number 1");
                Assert.AreEqual(num.getPhoneNumberId, "PN3816047eda7b012ea2cf6d5e0697a2474363dcd6");
                Assert.AreEqual(num.getApplicationId, "APabfb2706f416285399ae6bdd96d07b3416f6d4ce");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void UpdateIncomingNumberWithRequestIdTest()
        {
            try
            {
                IncomingPhoneNumbersRequester requester = new IncomingPhoneNumbersRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://UpdateIncomingTest:3000");
                }

                WebRequest.RegisterPrefix("http://UpdateIncomingTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{ \"phoneNumber\" : \"+13122290330\", \"alias\" : \"new incoming number 1\", \"revision\" : 2, \"dateCreated\" : \"Fri, 11 Nov 2016 13:42:25 GMT\", \"dateUpdated\" : \"Wed, 01 Feb 2017 19:33:00 GMT\", \"phoneNumberId\" : \"PN3816047eda7b012ea2cf6d5e0697a2474363dcd6\", \"region\" : \"Illinois\", \"country\" : \"US\", \"voiceEnabled\" : true, \"smsEnabled\" : true, \"applicationId\" : \"APabfb2706f416285399ae6bdd96d07b3416f6d4ce\", \"uri\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/IncomingPhoneNumbers/PN3816047eda7b012ea2cf6d5e0697a2474363dcd6\", \"accountId\" : \"AC907d7e328b3a5b402fa908857e047a243a8949b1\"} ");
                IncomingPhoneNumberOptions options = new IncomingPhoneNumberOptions();
                options.setAlias("new incoming number 1");
                options.setApplicationId("APabfb2706f416285399ae6bdd96d07b3416f6d4ce");
                options.setRequestId("RQ1234567890123456789012345678901234567890");
                IncomingPhoneNumber num = requester.update("PN3816047eda7b012ea2cf6d5e0697a2474363dcd6", options);

                Assert.IsNotNull(num);
                Assert.AreEqual(num.getAlias, "new incoming number 1");
                Assert.AreEqual(num.getPhoneNumberId, "PN3816047eda7b012ea2cf6d5e0697a2474363dcd6");
                Assert.AreEqual(num.getApplicationId, "APabfb2706f416285399ae6bdd96d07b3416f6d4ce");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void CreateIncomingNumberTest()
        {
            try
            {
                IncomingPhoneNumbersRequester requester = new IncomingPhoneNumbersRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://CreateIncomingTest:3000");
                }

                WebRequest.RegisterPrefix("http://CreateIncomingTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{ \"phoneNumber\" : \"+13122290330\", \"alias\" : \"incoming number 1\", \"revision\" : 2, \"dateCreated\" : \"Fri, 11 Nov 2016 13:42:25 GMT\", \"dateUpdated\" : \"Wed, 01 Feb 2017 19:33:00 GMT\", \"phoneNumberId\" : \"PN3816047eda7b012ea2cf6d5e0697a2474363dcd6\", \"region\" : \"Illinois\", \"country\" : \"US\", \"voiceEnabled\" : true, \"smsEnabled\" : true, \"applicationId\" : \"APbd38defccbf9a1db844551aa8ae0531a876bc84b\", \"uri\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/IncomingPhoneNumbers/PN3816047eda7b012ea2cf6d5e0697a2474363dcd6\", \"accountId\" : \"AC907d7e328b3a5b402fa908857e047a243a8949b1\"} ");
                IncomingPhoneNumberOptions options = new IncomingPhoneNumberOptions();
                options.setAlias("incoming number 1");
                options.setApplicationId("APbd38defccbf9a1db844551aa8ae0531a876bc84b");
                IncomingPhoneNumber num = requester.create("+13122290330", options);

                Assert.IsNotNull(num);
                Assert.AreEqual(num.getAlias, "incoming number 1");
                Assert.AreEqual(num.getPhoneNumber, "+13122290330");
                Assert.IsNotNull(num.getPhoneNumberId);
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void CreateIncomingNumberWithRequestIdTest()
        {
            try
            {
                IncomingPhoneNumbersRequester requester = new IncomingPhoneNumbersRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://CreateIncomingTest:3000");
                }

                WebRequest.RegisterPrefix("http://CreateIncomingTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{ \"phoneNumber\" : \"+13122290330\", \"alias\" : \"incoming number 1\", \"revision\" : 2, \"dateCreated\" : \"Fri, 11 Nov 2016 13:42:25 GMT\", \"dateUpdated\" : \"Wed, 01 Feb 2017 19:33:00 GMT\", \"phoneNumberId\" : \"PN3816047eda7b012ea2cf6d5e0697a2474363dcd6\", \"region\" : \"Illinois\", \"country\" : \"US\", \"voiceEnabled\" : true, \"smsEnabled\" : true, \"applicationId\" : \"APbd38defccbf9a1db844551aa8ae0531a876bc84b\", \"uri\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/IncomingPhoneNumbers/PN3816047eda7b012ea2cf6d5e0697a2474363dcd6\", \"accountId\" : \"AC907d7e328b3a5b402fa908857e047a243a8949b1\"} ");
                IncomingPhoneNumberOptions options = new IncomingPhoneNumberOptions();
                options.setAlias("incoming number 1");
                options.setApplicationId("APbd38defccbf9a1db844551aa8ae0531a876bc84b");
                options.setRequestId("RQ1234567890123456789012345678901234567890");
                IncomingPhoneNumber num = requester.create("+13122290330", options);

                Assert.IsNotNull(num);
                Assert.AreEqual(num.getAlias, "incoming number 1");
                Assert.AreEqual(num.getPhoneNumber, "+13122290330");
                Assert.IsNotNull(num.getPhoneNumberId);
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void DeleteIncomingNumberTest()
        {
            try
            {
                IncomingPhoneNumbersRequester requester = new IncomingPhoneNumbersRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://DeleteIncomingTest:3000");
                }

                WebRequest.RegisterPrefix("http://DeleteIncomingTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK);

                requester.delete("PN3816047eda7b012ea2cf6d5e0697a2474363dcd6");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

    }
}
