using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.api;
using com.freeclimb.api.conference;
using System;
using System.Reflection;
using System.Net;
using com.freeclimb;

namespace freeclimb_cs_sdk_test.api.conference
{
    [TestClass]
    public class ConferenceRequesterTest
    {
        [TestMethod]
        public void MakeADefaultConferenceRequesterTest()
        {
            try
            {
                ConferencesRequester req = new ConferencesRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Assert.AreEqual(req.getAccountId, "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");
                Assert.AreEqual(req.getAuthToken, "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5");
            }
            catch (FreeClimbException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void MakeAInitialConferenceRequestTest()
        {
            try
            {
                ConferencesRequester confRequester = new ConferencesRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Type confRequesterType = typeof(ConferencesRequester);
                MethodInfo freeClimbUrlMethodInfo = confRequesterType.GetMethod("SetFreeClimbUrl",
                                                                            BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                                                                            null,
                                                                            new Type[] { typeof(System.String) },
                                                                            null);
                freeClimbUrlMethodInfo.Invoke(confRequester, new Object[] { "http://MakeAInitialConferenceRequestTest:3000" });

                WebRequest.RegisterPrefix("http://MakeAInitialConferenceRequestTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"uri\" : \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Conferences/CFbbe46ff1274e283f7e3ac1df0072ab39\", \"revision\" : 1, \"dateCreated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"dateUpdated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"conferenceId\" : \"CFbbe46ff1274e283f7e3ac1df0072ab39\", \"accountId\" : \"AC142c48f2ee663e214c19ea459516068c\", \"alias\" : \"API\", \"status\" : \"empty\", \"subresourceUris\" : { \"participants\" : \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Conferences/CFbbe46ff1274e283f7e3ac1df0072ab39/Participants\", \"recordings\" : \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Conferences/CFbbe46ff1274e283f7e3ac1df0072ab39/Recordings\"}}");

                ConferenceCreateOptions options = new ConferenceCreateOptions();
                options.setAlias("API");

                Conference conference = confRequester.create(options);

                Assert.IsNotNull(conference);
                Assert.AreEqual(conference.getUri, "/Accounts/AC142c48f2ee663e214c19ea459516068c/Conferences/CFbbe46ff1274e283f7e3ac1df0072ab39");
                Assert.AreEqual(conference.getSubresourceUris.Count, 2);
                Assert.AreEqual(conference.getRevision, 1);
                Assert.IsNotNull(conference.getDateCreated);
                Assert.IsNotNull(conference.getDateUpdated);
                Assert.AreEqual(conference.getStatus, EConferenceStatus.Empty);
            }
            catch (FreeClimbException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void MakeAInitialConferenceRequestWithRequestIdTest()
        {
            try
            {
                ConferencesRequester confRequester = new ConferencesRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Type confRequesterType = typeof(ConferencesRequester);
                MethodInfo freeClimbUrlMethodInfo = confRequesterType.GetMethod("SetFreeClimbUrl",
                                                                            BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                                                                            null,
                                                                            new Type[] { typeof(System.String) },
                                                                            null);
                freeClimbUrlMethodInfo.Invoke(confRequester, new Object[] { "http://MakeAInitialConferenceRequestTest:3000" });

                WebRequest.RegisterPrefix("http://MakeAInitialConferenceRequestTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"uri\" : \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Conferences/CFbbe46ff1274e283f7e3ac1df0072ab39\", \"revision\" : 1, \"dateCreated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"dateUpdated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"conferenceId\" : \"CFbbe46ff1274e283f7e3ac1df0072ab39\", \"accountId\" : \"AC142c48f2ee663e214c19ea459516068c\", \"alias\" : \"API\", \"status\" : \"empty\", \"subresourceUris\" : { \"participants\" : \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Conferences/CFbbe46ff1274e283f7e3ac1df0072ab39/Participants\", \"recordings\" : \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Conferences/CFbbe46ff1274e283f7e3ac1df0072ab39/Recordings\"}}");

                ConferenceCreateOptions options = new ConferenceCreateOptions();
                options.setAlias("API");
                options.setRequestId("RQ1234567890123456789012345678901234567890");
                Conference conference = confRequester.create(options);

                Assert.IsNotNull(conference);
                Assert.AreEqual(conference.getUri, "/Accounts/AC142c48f2ee663e214c19ea459516068c/Conferences/CFbbe46ff1274e283f7e3ac1df0072ab39");
                Assert.AreEqual(conference.getSubresourceUris.Count, 2);
                Assert.AreEqual(conference.getRevision, 1);
                Assert.IsNotNull(conference.getDateCreated);
                Assert.IsNotNull(conference.getDateUpdated);
                Assert.AreEqual(conference.getStatus, EConferenceStatus.Empty);
            }
            catch (FreeClimbException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void GetConferenceRequestTest()
        {
            try
            {
                ConferencesRequester confRequester = new ConferencesRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Type confRequesterType = typeof(ConferencesRequester);
                MethodInfo freeClimbUrlMethodInfo = confRequesterType.GetMethod("SetFreeClimbUrl",
                                                                            BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                                                                            null,
                                                                            new Type[] { typeof(System.String) },
                                                                            null);
                freeClimbUrlMethodInfo.Invoke(confRequester, new Object[] { "http://GetConferenceRequestTest:3000" });

                WebRequest.RegisterPrefix("http://GetConferenceRequestTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"uri\" : \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Conferences/CFbbe46ff1274e283f7e3ac1df0072ab39\", \"revision\" : 1, \"dateCreated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"dateUpdated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"conferenceId\" : \"CFbbe46ff1274e283f7e3ac1df0072ab39\", \"accountId\" : \"AC142c48f2ee663e214c19ea459516068c\", \"alias\" : \"API\", \"playBeep\": \"always\", \"record\": false, \"waitUrl\": null, \"statusCallbackUrl\": null, \"status\" : \"empty\", \"subresourceUris\" : { \"participants\" : \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Conferences/CFbbe46ff1274e283f7e3ac1df0072ab39/Participants\", \"recordings\" : \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Conferences/CFbbe46ff1274e283f7e3ac1df0072ab39/Recordings\"}}");

                Conference conference = confRequester.getConference("CFbbe46ff1274e283f7e3ac1df0072ab39");

                Assert.IsNotNull(conference);
                Assert.AreEqual(conference.getUri, "/Accounts/AC142c48f2ee663e214c19ea459516068c/Conferences/CFbbe46ff1274e283f7e3ac1df0072ab39");
                Assert.AreEqual(conference.getSubresourceUris.Count, 2);
                Assert.AreEqual(conference.getRevision, 1);
                Assert.IsNotNull(conference.getDateCreated);
                Assert.IsNotNull(conference.getDateUpdated);
                Assert.AreEqual(conference.getStatus, EConferenceStatus.Empty);
            }
            catch (FreeClimbException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void GetParticipantRequestTest()
        {
            try
            {
                ConferencesRequester confRequester = new ConferencesRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Type confRequesterType = typeof(ConferencesRequester);
                MethodInfo freeClimbUrlMethodInfo = confRequesterType.GetMethod("SetFreeClimbUrl",
                                                                            BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                                                                            null,
                                                                            new Type[] { typeof(System.String) },
                                                                            null);
                freeClimbUrlMethodInfo.Invoke(confRequester, new Object[] { "http://GetParticipantRequestTest:3000" });

                WebRequest.RegisterPrefix("http://GetParticipantRequestTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"uri\" : \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Conferences/CFbbe4632a3c49700934481addd5ce1659/Participants/CA386025c9bf5d6052a1d1ea42b4d16662\", \"revision\" : 1, \"dateCreated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"dateUpdated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"callId\" : \"CA386025c9bf5d6052a1d1ea42b4d16662\", \"conferenceId\" : \"CFbbe4632a3c49700934481addd5ce1659\", \"accountId\" : \"AC142c48f2ee663e214c19ea459516068c\", \"talk\" : true, \"listen\" : true, \"startConfOnEnter\" : false}");

                Participant participant = confRequester.getParticipant("CFbbe4632a3c49700934481addd5ce1659", "CA386025c9bf5d6052a1d1ea42b4d16662");

                Assert.IsNotNull(participant);
                Assert.AreEqual(participant.getUri, "/Accounts/AC142c48f2ee663e214c19ea459516068c/Conferences/CFbbe4632a3c49700934481addd5ce1659/Participants/CA386025c9bf5d6052a1d1ea42b4d16662");
                Assert.AreEqual(participant.getTalk, EBool.True);
            }
            catch (FreeClimbException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void UpdateConferenceRequestTest()
        {
            try
            {
                ConferencesRequester confRequester = new ConferencesRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Type confRequesterType = typeof(ConferencesRequester);
                MethodInfo freeClimbUrlMethodInfo = confRequesterType.GetMethod("SetFreeClimbUrl",
                                                                            BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                                                                            null,
                                                                            new Type[] { typeof(System.String) },
                                                                            null);
                freeClimbUrlMethodInfo.Invoke(confRequester, new Object[] { "http://UpdateConferenceRequestTest:3000" });

                WebRequest.RegisterPrefix("http://UpdateConferenceRequestTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"uri\" : \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Conferences/CFbbe46ff1274e283f7e3ac1df0072ab39\", \"revision\" : 2, \"dateCreated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"dateUpdated\" : \"Thu, 23 Jun 2016 17:30:06 GMT\", \"conferenceId\" : \"CFbbe46ff1274e283f7e3ac1df0072ab39\", \"accountId\" : \"AC142c48f2ee663e214c19ea459516068c\", \"alias\" : \"API\", \"playBeep\": \"never\", \"record\": true, \"waitUrl\": null, \"statusCallbackUrl\": null, \"status\" : \"empty\", \"subresourceUris\" : { \"participants\" : \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Conferences/CFbbe46ff1274e283f7e3ac1df0072ab39/Participants\", \"recordings\" : \"/Accounts/AC142c48f2ee663e214c19ea459516068c/Conferences/CFbbe46ff1274e283f7e3ac1df0072ab39/Recordings\"}}");

                Conference conference = confRequester.update("CFbbe46ff1274e283f7e3ac1df0072ab39");

                Assert.IsNotNull(conference);
                Assert.AreEqual(conference.getUri, "/Accounts/AC142c48f2ee663e214c19ea459516068c/Conferences/CFbbe46ff1274e283f7e3ac1df0072ab39");
                Assert.AreEqual(conference.getSubresourceUris.Count, 2);
                Assert.AreEqual(conference.getRevision, 2);
                Assert.IsNotNull(conference.getDateCreated);
                Assert.IsNotNull(conference.getDateUpdated);
                Assert.AreEqual(conference.getPlayBeep, EPlayBeep.Never);
                Assert.AreEqual(conference.getRecord, EBool.True);
            }
            catch (FreeClimbException pe)
            {
                Assert.Fail(pe.Message);
            }
        }


        [TestMethod]
        public void DeleteConferenceTest()
        {
            try
            {
                ConferencesRequester confRequester = new ConferencesRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Type confRequesterType = typeof(ConferencesRequester);
                MethodInfo freeClimbUrlMethodInfo = confRequesterType.GetMethod("SetFreeClimbUrl",
                                                                            BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                                                                            null,
                                                                            new Type[] { typeof(System.String) },
                                                                            null);
                freeClimbUrlMethodInfo.Invoke(confRequester, new Object[] { "http://DeleteConferenceTest:3000" });

                WebRequest.RegisterPrefix("http://DeleteConferenceTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK);

                confRequester.deleteConference("CFbbe46ff1274e283f7e3ac1df0072ab39");
            }
            catch (FreeClimbException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void DeleteParticipantTest()
        {
            try
            {
                ConferencesRequester confRequester = new ConferencesRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5", "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");

                Type confRequesterType = typeof(ConferencesRequester);
                MethodInfo freeClimbUrlMethodInfo = confRequesterType.GetMethod("SetFreeClimbUrl",
                                                                            BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                                                                            null,
                                                                            new Type[] { typeof(System.String) },
                                                                            null);
                freeClimbUrlMethodInfo.Invoke(confRequester, new Object[] { "http://DeleteParticipantTest:3000" });

                WebRequest.RegisterPrefix("http://DeleteParticipantTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK);

                confRequester.deleteParticipant("CFbbe46ff1274e283f7e3ac1df0072ab39", "CA386025c9bf5d6052a1d1ea42b4d16662");
            }
            catch (FreeClimbException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

    }
}
