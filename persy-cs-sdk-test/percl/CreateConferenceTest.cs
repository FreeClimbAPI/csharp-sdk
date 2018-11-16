using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.persephony.percl;
using com.persephony;

namespace persy_cs_sdk_test.percl
{
    [TestClass]
    public class CreateConferenceTest
    {
        [TestMethod]
        public void CreateConferenceRequiredTest()
        {
            CreateConference createConference = new CreateConference("http://foo.com/conf");

            string json = createConference.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"CreateConference\":{\"actionUrl\":\"http://foo.com/conf\",\"alias\":null,\"playBeep\":\"always\",\"record\":false,\"waitUrl\":null,\"statusCallbackUrl\":null}}");
        }


        [TestMethod]
        public void CreateConferenceWithWaitUrlTest()
        {
            CreateConference createConference = new CreateConference("http://foo.com/conf");

            createConference.setWaitUrl("http://foo.com/wait");
            string json = createConference.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"CreateConference\":{\"actionUrl\":\"http://foo.com/conf\",\"alias\":null,\"playBeep\":\"always\",\"record\":false,\"waitUrl\":\"http://foo.com/wait\",\"statusCallbackUrl\":null}}");
        }

        [TestMethod]
        public void CreateConferenceWithStatusCallbackUrlTest()
        {
            CreateConference createConference = new CreateConference("http://foo.com/conf");

            createConference.setStatusCallbackUrl("http://foo.com/status");
            string json = createConference.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"CreateConference\":{\"actionUrl\":\"http://foo.com/conf\",\"alias\":null,\"playBeep\":\"always\",\"record\":false,\"waitUrl\":null,\"statusCallbackUrl\":\"http://foo.com/status\"}}");
        }

        [TestMethod]
        public void CreateConferenceWithAllTest()
        {
            CreateConference createConference = new CreateConference("http://foo.com/conf");

            createConference.setStatusCallbackUrl("http://foo.com/status");
            createConference.setWaitUrl("http://foo.com/wait");
            createConference.setAlias("test");
            createConference.setPlayBeep(EPlayBeep.EntryOnly);
            createConference.setRecord(EBool.True);
            string json = createConference.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"CreateConference\":{\"actionUrl\":\"http://foo.com/conf\",\"alias\":\"test\",\"playBeep\":\"entryOnly\",\"record\":true,\"waitUrl\":\"http://foo.com/wait\",\"statusCallbackUrl\":\"http://foo.com/status\"}}");
        }
    }
}
