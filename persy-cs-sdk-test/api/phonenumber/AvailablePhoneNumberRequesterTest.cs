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
    public class AvailablePhoneNumberRequesterTest
    {
        [TestMethod]
        public void GetAvailableListTest()
        {
            try
            {
                AvailablePhoneNumbersRequester requester = new AvailablePhoneNumbersRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://GetAvailableListTest:3000");
                }

                WebRequest.RegisterPrefix("http://GetAvailableListTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{\"total\":3,\"start\":0,\"end\":1,\"page\":0,\"numPages\":2,\"pageSize\":2,\"nextPageUri\":\"/AvailablePhoneNumbers&cursor=492dc883a811bd0204204ea9047122f93a2788a2\", \"availablePhoneNumbers\" : [{\"phoneNumber\" : \"+13122290330\", \"alias\" : \"312-229-0330\", \"revision\" : 1, \"dateCreated\" : \"Fri, 11 Nov 2016 13:42:25 GMT\", \"dateUpdated\" : \"Fri, 11 Nov 2016 13:42:25 GMT\", \"region\" : \"Illinois\", \"country\" : \"US\", \"voiceEnabled\" : true, \"smsEnabled\" : true}, {\"phoneNumber\" : \"+13122290365\", \"alias\" : \"312-229-0365\", \"revision\" : 1, \"dateCreated\" : \"Fri, 11 Nov 2016 13:42:25 GMT\", \"dateUpdated\" : \"Fri, 11 Nov 2016 13:42:25 GMT\", \"region\" : \"Illinois\", \"country\" : \"US\", \"voiceEnabled\" : true, \"smsEnabled\" : true}]}");
                                                                         

                AvailablePhoneNumberList list = requester.get();

                Assert.IsNotNull(list);

                Assert.AreEqual(list.getLocalSize, 2);
                Assert.AreEqual((list.export()).Count, 2);

                AvailablePhoneNumber num = list.get(0) as AvailablePhoneNumber;

                Assert.IsNotNull(num);
                Assert.AreEqual(num.getAlias, "312-229-0330");
                Assert.AreEqual(num.getPhoneNumber, "+13122290330");

                type = typeof(APIRequester);
                fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(list, "http://GetAvailableListTest:3000");
                }

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{\"total\":3,\"start\":2,\"end\":2,\"page\":1,\"numPages\":2,\"pageSize\":2,\"nextPageUri\":null, \"availablePhoneNumbers\" : [ {\"phoneNumber\" : \"+13123004536\", \"alias\" : \"312-300-4536\", \"revision\" : 1, \"dateCreated\" : \"Fri, 11 Nov 2016 13:42:25 GMT\", \"dateUpdated\" : \"Fri, 11 Nov 2016 13:42:25 GMT\", \"region\" : \"Illinois\", \"country\" : \"US\", \"voiceEnabled\" : true, \"smsEnabled\" : true}]}");

                list.loadNextPage();

                Assert.IsNotNull(list);

                Assert.AreEqual(list.getLocalSize, 3);
                Assert.AreEqual((list.export()).Count, 3);

                num = list.get(2) as AvailablePhoneNumber;
                Assert.IsNotNull(num);
                Assert.AreEqual(num.getPhoneNumber, "+13123004536");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void GetAvailableListUsingFilterTest()
        {
            try
            {
                AvailablePhoneNumbersRequester requester = new AvailablePhoneNumbersRequester("AC907d7e328b3a5b402fa908857e047a243a8949b1", "2c78e8a8d1033b77902758e584ad5fc4a1c5ee02", "AC907d7e328b3a5b402fa908857e047a243a8949b1");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("persyUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(requester, "http://GetAvailableListTest:3000");
                }

                WebRequest.RegisterPrefix("http://GetAvailableListTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                    "{\"total\":3,\"start\":0,\"end\":1,\"page\":0,\"numPages\":2,\"pageSize\":2,\"nextPageUri\":\"/AvailablePhoneNumbers&cursor=492dc883a811bd0204204ea9047122f93a2788a2\", \"availablePhoneNumbers\" : [{\"phoneNumber\" : \"+13122290330\", \"alias\" : \"312-229-0330\", \"revision\" : 1, \"dateCreated\" : \"Fri, 11 Nov 2016 13:42:25 GMT\", \"dateUpdated\" : \"Fri, 11 Nov 2016 13:42:25 GMT\", \"region\" : \"Illinois\", \"country\" : \"US\", \"voiceEnabled\" : true, \"smsEnabled\" : true}, {\"phoneNumber\" : \"+13122290365\", \"alias\" : \"312-229-0365\", \"revision\" : 1, \"dateCreated\" : \"Fri, 11 Nov 2016 13:42:25 GMT\", \"dateUpdated\" : \"Fri, 11 Nov 2016 13:42:25 GMT\", \"region\" : \"Illinois\", \"country\" : \"US\", \"voiceEnabled\" : true, \"smsEnabled\" : true}]}");

                AvailablePhoneNumbersSearchFilter filter = new AvailablePhoneNumbersSearchFilter();
                filter.setPhoneNumber("^\\+1312[0-9]{7}$");
                AvailablePhoneNumberList list = requester.get(filter);

                Assert.IsNotNull(list);

                Assert.AreEqual(list.getLocalSize, 2);
                Assert.AreEqual((list.export()).Count, 2);
                Assert.AreEqual(list.getTotalSize, 3);

                AvailablePhoneNumber num = list.get(0) as AvailablePhoneNumber;

                Assert.IsNotNull(num);
                Assert.AreEqual(num.getAlias, "312-229-0330");
                Assert.AreEqual(num.getPhoneNumber, "+13122290330");
            }
            catch (PersyException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

    }
}
