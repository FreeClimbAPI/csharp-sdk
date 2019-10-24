using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.api.conference;
using com.freeclimb;

namespace freeclimb_cs_sdk_test.api.conference
{
    [TestClass]
    public class ConferenceTest
    {
        [TestMethod]
        public void MakeConferenceFromJsonTest()
        {
            string json = "{\"uri\" : \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Conferences/CFbbe46ff1274e283f7e3ac1df0072ab39\", \"revision\" : 1, \"dateCreated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"dateUpdated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"conferenceId\" : \"CFbbe46ff1274e283f7e3ac1df0072ab39\", \"accountId\" : \"AC142c48f2ee663e214c19ea459516068c\", \"alias\" : \"API Design\", \"playBeep\" : \"always\", \"record\" : false, \"status\" : \"empty\", \"waitUrl\" : \"http://foo.com/freeclimb/wait\", \"statusCallbackUrl\" : \"http://foo.com/freeclimb/status\", \"subresourceUris\" : { \"participants\" : \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Conferences/CFbbe46ff1274e283f7e3ac1df0072ab39/Participants\", \"recordings\" : \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Conferences/CFbbe46ff1274e283f7e3ac1df0072ab39/Recordings\"}}";
            Conference conference = Conference.fromJson(json);

            Assert.IsNotNull(conference);
            Assert.AreEqual(conference.getStatusCallBackUrl, "http://foo.com/freeclimb/status");
            Assert.AreEqual(conference.getWaitUrl, "http://foo.com/freeclimb/wait");
            Assert.AreEqual(conference.getConferenceId, "CFbbe46ff1274e283f7e3ac1df0072ab39");
            Assert.AreEqual(conference.getAccountId, "AC142c48f2ee663e214c19ea459516068c");
            Assert.AreEqual(conference.getPlayBeep, EPlayBeep.Always);
            Assert.AreEqual(conference.getRecord, EBool.False);
            Assert.AreEqual(conference.getStatus, EConferenceStatus.Empty);

            Assert.AreEqual(conference.getSubresourceUris.Count, 2);

            string result;
            Assert.IsTrue(conference.getSubresourceUris.TryGetValue(Conference.SubresourceUri.Recordings, out result));
            Assert.AreEqual(result, "/Accounts/AC142c48f2ee663e214c19ea459516068c/Conferences/CFbbe46ff1274e283f7e3ac1df0072ab39/Recordings");

            Assert.IsTrue(conference.getSubresourceUris.TryGetValue(Conference.SubresourceUri.Participants, out result));
            Assert.AreEqual(result, "/Accounts/AC142c48f2ee663e214c19ea459516068c/Conferences/CFbbe46ff1274e283f7e3ac1df0072ab39/Participants");
        }
    }
}
