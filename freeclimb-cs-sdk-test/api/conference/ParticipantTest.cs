using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.api.conference;
using com.freeclimb;

namespace freeclimb_cs_sdk_test.api.conference
{
    [TestClass]
    public class ParticipantTest
    {
        [TestMethod]
        public void MakeParticipantFromJsonTest()
        {
            string json = "{\"uri\" : \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Conferences/ CFbbe4632a3c49700934481addd5ce1659/Participants/CA386025c9bf5d6052a1d1ea42b4d16662\", \"revision\" : 1, \"dateCreated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"dateUpdated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"callId\" : \"CA386025c9bf5d6052a1d1ea42b4d16662\", \"conferenceId\" : \"CFbbe4632a3c49700934481addd5ce1659\", \"accountId\" : \"AC142c48f2ee663e214c19ea459516068c\", \"talk\" : true, \"listen\" : true, \"startConfOnEnter\" : false}";
            Participant participant = Participant.fromJson(json);

            Assert.IsNotNull(participant);
            Assert.AreEqual(participant.getConferenceId, "CFbbe4632a3c49700934481addd5ce1659");
            Assert.AreEqual(participant.getAccountId, "AC142c48f2ee663e214c19ea459516068c");
            Assert.AreEqual(participant.getCallId, "CA386025c9bf5d6052a1d1ea42b4d16662");
            Assert.AreEqual(participant.getTalk, EBool.True);
            Assert.AreEqual(participant.getListen, EBool.True);
            Assert.AreEqual(participant.getStartConfOnEnter, EBool.False);
        }
    }
}
