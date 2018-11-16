using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace persy_cs_sdk_test
{
    [TestClass]
    public class PersyListTest
    {
        private static String inputJson = "{\"total\": 2, \"start\": 0, \"end\": 0, \"page\": 0, \"numPages\": 2, \"pageSize\": 1, \"nextPageUri\": \"/Accounts?newpage=veryyes\", \"tests\": [{\"uri\": \"/Accounts/ac3iu409/Recordings/RE382904702\", \"dateUpdated\": \"Fri, 10 Jun 2016 21:35:27 GMT\", \"dateCreated\": \"Fri, 10 Jun 2016 21:35:27 GMT\", \"revision\": 0, \"testValue\": \"VALUE!!!\"}]}";

        [TestMethod]
        public void MakeListFromJsonTest()
        {
            TestsList list = new TestsList("ACCOUNTID", "AUTHTOKEN", PersyListTest.inputJson);

            Assert.AreEqual(list.getTotalSize, 2);
            Assert.AreEqual(list.getLocalSize, 1);
            Assert.IsNotNull(list.get(0));
            Assert.IsInstanceOfType(list.get(0), typeof(Test));
            Assert.AreEqual(list.get(0).testValue, "VALUE!!!");
            Assert.IsNotNull(list.export());
            Assert.AreEqual(list.export().Count, list.getLocalSize);
        }
    }
}
