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
    public class CallingNumberRequesterTest
    {
        [TestMethod]
        public void GetCallingNumberListTest()
        {
            try
            {
                CallingNumbersRequester requester = new CallingNumbersRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://GetCallingListTest:3000");
                }

                WebRequest.RegisterPrefix("http://GetCallingListTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{\"total\":3,\"start\":0,\"end\":1,\"page\":0,\"numPages\":2,\"pageSize\":2,\"nextPageUri\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/CallingNumbers&cursor=492dc883a811bd0204204ea9047122f93a2788a2\", \"callingNumbers\" : [{\"phoneNumber\" : \"+13033447438\", \"alias\" : \"new Calling number 1\", \"revision\" : 2, \"dateCreated\" : \"Wed, 01 Feb 2017 17:33:27 GMT\", \"dateUpdated\" : \"Wed, 01 Feb 2017 17:42:00 GMT\", \"callingNumberId\" : \"PN7bbef986a434fd30ba006551ed6cc507403b5e87\", \"uri\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/CallingNumbers/PN7bbef986a434fd30ba006551ed6cc507403b5e87\", \"accountId\" : \"AC907d7e328b3a5b402fa908857e047a243a8949b1\"}, {\"phoneNumber\" : \"+13033447440\", \"alias\" : \"Calling number 2\", \"revision\" : 1, \"dateCreated\" : \"Wed, 01 Feb 2017 17:33:43 GMT\", \"dateUpdated\" : \"Wed, 01 Feb 2017 17:33:43 GMT\", \"callingNumberId\" : \"PNef08e0fcf2e37067d3f0a190671c6d0d45cefb63\", \"uri\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/CallingNumbers/PNef08e0fcf2e37067d3f0a190671c6d0d45cefb63\", \"accountId\" : \"AC907d7e328b3a5b402fa908857e047a243a8949b1\"}]}");


                CallingNumberList list = requester.get();

                Assert.IsNotNull(list);

                Assert.AreEqual(list.getLocalSize, 2);
                Assert.AreEqual((list.export()).Count, 2);

                CallingNumber num = list.get(0) as CallingNumber;

                Assert.IsNotNull(num);
                Assert.AreEqual(num.getCallingNumberId, "PN7bbef986a434fd30ba006551ed6cc507403b5e87");

                type = typeof(APIRequester);
                fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(list, "http://GetCallingListTest:3000");
                }

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{\"total\":3,\"start\":2,\"end\":2,\"page\":1,\"numPages\":2,\"pageSize\":2,\"nextPageUri\":null, \"callingNumbers\" : [ {\"phoneNumber\" : \"+13033447440\", \"alias\" : \"Calling number 2\", \"revision\" : 1, \"dateCreated\" : \"Wed, 01 Feb 2017 17:33:43 GMT\", \"dateUpdated\" : \"Wed, 01 Feb 2017 17:33:43 GMT\", \"callingNumberId\" : \"PNef08e0fcf2e37067d3f0a190671c6d0d45cefb63\", \"uri\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/CallingNumbers/PNef08e0fcf2e37067d3f0a190671c6d0d45cefb63\", \"accountId\" : \"AC907d7e328b3a5b402fa908857e047a243a8949b1\"}]}");

                list.loadNextPage();

                Assert.IsNotNull(list);

                Assert.AreEqual(list.getLocalSize, 3);
                Assert.AreEqual((list.export()).Count, 3);

                num = list.get(2) as CallingNumber;
                Assert.IsNotNull(num);
                Assert.AreEqual(num.getCallingNumberId, "PNef08e0fcf2e37067d3f0a190671c6d0d45cefb63");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void GetCallingNumberListUsingFilterTest()
        {
            try
            {
                CallingNumbersRequester requester = new CallingNumbersRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://GetCallingListTest:3000");
                }

                WebRequest.RegisterPrefix("http://GetCallingListTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{\"total\":1,\"start\":0,\"end\":0,\"page\":0,\"numPages\":1,\"pageSize\":2,\"nextPageUri\":null, \"callingNumbers\" : [{\"phoneNumber\" : \"+13033447438\", \"alias\" : \"Calling number 1\", \"revision\" : 2, \"dateCreated\" : \"Wed, 01 Feb 2017 17:33:27 GMT\", \"dateUpdated\" : \"Wed, 01 Feb 2017 17:42:00 GMT\", \"callingNumberId\" : \"PN7bbef986a434fd30ba006551ed6cc507403b5e87\", \"uri\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/CallingNumbers/PN7bbef986a434fd30ba006551ed6cc507403b5e87\", \"accountId\" : \"AC907d7e328b3a5b402fa908857e047a243a8949b1\"}]}");

                CallingNumbersSearchFilter filter = new CallingNumbersSearchFilter();
                filter.setPhoneNumber("+13033447438");
                filter.setAlias("Calling number 1");
                CallingNumberList list = requester.get(filter);

                Assert.IsNotNull(list);

                Assert.AreEqual(list.getLocalSize, 1);
                Assert.AreEqual((list.export()).Count, 1);

                CallingNumber num = list.get(0) as CallingNumber;

                Assert.IsNotNull(num);
                Assert.AreEqual(num.getPhoneNumber, "+13033447438");
                Assert.AreEqual(num.getAlias, "Calling number 1");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void GetCallingNumberTest()
        {
            try
            {
                CallingNumbersRequester requester = new CallingNumbersRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://GetCallingTest:3000");
                }

                WebRequest.RegisterPrefix("http://GetCallingTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{ \"phoneNumber\" : \"+13033447438\", \"alias\" : \"Calling number 1\", \"revision\" : 1, \"dateCreated\" : \"Wed, 01 Feb 2017 17:33:27 GMT\", \"dateUpdated\" : \"Wed, 01 Feb 2017 17:33:27 GMT\", \"callingNumberId\" : \"PN7bbef986a434fd30ba006551ed6cc507403b5e87\", \"uri\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/CallingNumbers/PN7bbef986a434fd30ba006551ed6cc507403b5e87\", \"accountId\" : \"AC907d7e328b3a5b402fa908857e047a243a8949b1\"}");
               

                CallingNumber num = requester.get("PN7bbef986a434fd30ba006551ed6cc507403b5e87");

                Assert.IsNotNull(num);
                Assert.AreEqual(num.getCallingNumberId, "PN7bbef986a434fd30ba006551ed6cc507403b5e87");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void UpdateCallingNumberTest()
        {
            try
            {
                CallingNumbersRequester requester = new CallingNumbersRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://UpdateCallingTest:3000");
                }

                WebRequest.RegisterPrefix("http://UpdateCallingTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{ \"phoneNumber\" : \"+13033447438\", \"alias\" : \"new Calling number 1\", \"revision\" : 1, \"dateCreated\" : \"Wed, 01 Feb 2017 17:33:27 GMT\", \"dateUpdated\" : \"Wed, 01 Feb 2017 17:33:27 GMT\", \"callingNumberId\" : \"PN7bbef986a434fd30ba006551ed6cc507403b5e87\", \"uri\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/CallingNumbers/PN7bbef986a434fd30ba006551ed6cc507403b5e87\", \"accountId\" : \"AC907d7e328b3a5b402fa908857e047a243a8949b1\"}");
                CallingNumberOptions options = new CallingNumberOptions();
                options.setAlias("calling number new");

                CallingNumber num = requester.update("PN7bbef986a434fd30ba006551ed6cc507403b5e87", options);

                Assert.IsNotNull(num);
                Assert.AreEqual(num.getAlias, "new Calling number 1");
                Assert.AreEqual(num.getCallingNumberId, "PN7bbef986a434fd30ba006551ed6cc507403b5e87");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void UpdateCallingNumberWithRequestIdTest()
        {
            try
            {
                CallingNumbersRequester requester = new CallingNumbersRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://UpdateCallingTest:3000");
                }

                WebRequest.RegisterPrefix("http://UpdateCallingTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{ \"phoneNumber\" : \"+13033447438\", \"alias\" : \"new Calling number 1\", \"revision\" : 1, \"dateCreated\" : \"Wed, 01 Feb 2017 17:33:27 GMT\", \"dateUpdated\" : \"Wed, 01 Feb 2017 17:33:27 GMT\", \"callingNumberId\" : \"PN7bbef986a434fd30ba006551ed6cc507403b5e87\", \"uri\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/CallingNumbers/PN7bbef986a434fd30ba006551ed6cc507403b5e87\", \"accountId\" : \"AC907d7e328b3a5b402fa908857e047a243a8949b1\"}");
                CallingNumberOptions options = new CallingNumberOptions();
                options.setAlias("calling number new");
                options.setRequestId("RQ1234567890123456789012345678901234567890");

                CallingNumber num = requester.update("PN7bbef986a434fd30ba006551ed6cc507403b5e87", options);

                Assert.IsNotNull(num);
                Assert.AreEqual(num.getAlias, "new Calling number 1");
                Assert.AreEqual(num.getCallingNumberId, "PN7bbef986a434fd30ba006551ed6cc507403b5e87");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void CreateCallingNumberTest()
        {
            try
            {
                CallingNumbersRequester requester = new CallingNumbersRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://CreateCallingTest:3000");
                }

                WebRequest.RegisterPrefix("http://CreateCallingTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{ \"phoneNumber\" : \"+13033447438\", \"alias\" : \"Calling number 1\", \"revision\" : 1, \"dateCreated\" : \"Wed, 01 Feb 2017 17:33:27 GMT\", \"dateUpdated\" : \"Wed, 01 Feb 2017 17:33:27 GMT\", \"callingNumberId\" : \"PN7bbef986a434fd30ba006551ed6cc507403b5e87\", \"uri\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/CallingNumbers/PN7bbef986a434fd30ba006551ed6cc507403b5e87\", \"accountId\" : \"AC907d7e328b3a5b402fa908857e047a243a8949b1\"}");
                CallingNumberOptions options = new CallingNumberOptions();
                options.setAlias("Calling number 1");
                CallingNumber num = requester.create("+13033447438", options);

                Assert.IsNotNull(num);
                Assert.AreEqual(num.getAlias, "Calling number 1");
                Assert.AreEqual(num.getPhoneNumber, "+13033447438");
                Assert.IsNotNull(num.getCallingNumberId);
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void CreateCallingNumberWithRequestIdTest()
        {
            try
            {
                CallingNumbersRequester requester = new CallingNumbersRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://CreateCallingTest:3000");
                }

                WebRequest.RegisterPrefix("http://CreateCallingTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{ \"phoneNumber\" : \"+13033447438\", \"alias\" : \"Calling number 1\", \"revision\" : 1, \"dateCreated\" : \"Wed, 01 Feb 2017 17:33:27 GMT\", \"dateUpdated\" : \"Wed, 01 Feb 2017 17:33:27 GMT\", \"callingNumberId\" : \"PN7bbef986a434fd30ba006551ed6cc507403b5e87\", \"uri\" : \"/Accounts/AC907d7e328b3a5b402fa908857e047a243a8949b1/CallingNumbers/PN7bbef986a434fd30ba006551ed6cc507403b5e87\", \"accountId\" : \"AC907d7e328b3a5b402fa908857e047a243a8949b1\"}");
                CallingNumberOptions options = new CallingNumberOptions();
                options.setAlias("Calling number 1");
                options.setRequestId("RQ1234567890123456789012345678901234567890");

                CallingNumber num = requester.create("+13033447438", options);

                Assert.IsNotNull(num);
                Assert.AreEqual(num.getAlias, "Calling number 1");
                Assert.AreEqual(num.getPhoneNumber, "+13033447438");
                Assert.IsNotNull(num.getCallingNumberId);
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void DeleteCallingNumberTest()
        {
            try
            {
                CallingNumbersRequester requester = new CallingNumbersRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://DeleteCallingTest:3000");
                }

                WebRequest.RegisterPrefix("http://DeleteCallingTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK);

                requester.delete("PN7bbef986a434fd30ba006551ed6cc507403b5e87");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

    }
}
