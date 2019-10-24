using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.api.recording;

namespace freeclimb_cs_sdk_test.api.recording
{
    [TestClass]
    public class RecordingTest
    {
        [TestMethod]
        public void MakeRecordingWithCallIdFromJsonTest()
        {
            string json = "{\"uri\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Recordings/REb1eecfce410141ad1749c0fc84dfbb6fc4c2a810\",\"revision\":1,\"dateCreated\":\"Mon, 27 Jun 2016 17:53:55 GMT\",\"dateUpdated\":\"Mon, 27 Jun 2016 17:53:55 GMT\",\"recordingId\":\"REb1eecfce410141ad1749c0fc84dfbb6fc4c2a810\",\"accountId\":\"ACabe7063197551fe51671f9ac3a9708e9dad51c4d\",\"callId\":\"CA3cb8a52f461bcf64cbd3111d9492c3f61943eef9\",\"durationSec\":9}";
            Recording recording = Recording.fromJson(json);

            Assert.IsNotNull(recording);
            Assert.IsNotNull(recording.getUri);
            Assert.AreEqual(recording.getUri, "/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Recordings/REb1eecfce410141ad1749c0fc84dfbb6fc4c2a810");
            Assert.AreEqual(recording.getCallId, "CA3cb8a52f461bcf64cbd3111d9492c3f61943eef9");
            Assert.IsNull(recording.getConferenceId);
            Assert.AreEqual(recording.getRevision, 1);
            Assert.IsNotNull(recording.getDateCreated);
            Assert.IsNotNull(recording.getDateUpdated);
            Assert.AreEqual(recording.getDurationSec, 9);
        }

        [TestMethod]
        public void MakeRecordingWithConferenceIdFromJsonTest()
        {
            string json = "{\"uri\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Recordings/REb1eecfce410141ad1749c0fc84dfbb6fc4c2a810\",\"revision\":1,\"dateCreated\":\"Mon, 27 Jun 2016 17:53:55 GMT\",\"dateUpdated\":\"Mon, 27 Jun 2016 17:53:55 GMT\",\"recordingId\":\"REb1eecfce410141ad1749c0fc84dfbb6fc4c2a810\",\"accountId\":\"ACabe7063197551fe51671f9ac3a9708e9dad51c4d\",\"conferenceId\":\"CF3cb8a52f461bcf64cbd3111d9492c3f61943eef9\",\"durationSec\":9}";
            Recording recording = Recording.fromJson(json);

            Assert.IsNotNull(recording);
            Assert.IsNotNull(recording.getUri);
            Assert.AreEqual(recording.getUri, "/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Recordings/REb1eecfce410141ad1749c0fc84dfbb6fc4c2a810");
            Assert.AreEqual(recording.getConferenceId, "CF3cb8a52f461bcf64cbd3111d9492c3f61943eef9");
            Assert.IsNull(recording.getCallId);
            Assert.AreEqual(recording.getRevision, 1);
            Assert.IsNotNull(recording.getDateCreated);
            Assert.IsNotNull(recording.getDateUpdated);
            Assert.AreEqual(recording.getDurationSec, 9);
        }

        [TestMethod]
        public void MakeRecordingWithConferenceIdNullCallIdFromJsonTest()
        {
            string json = "{\"uri\":\"/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Recordings/REb1eecfce410141ad1749c0fc84dfbb6fc4c2a810\",\"revision\":1,\"dateCreated\":\"Mon, 27 Jun 2016 17:53:55 GMT\",\"dateUpdated\":\"Mon, 27 Jun 2016 17:53:55 GMT\",\"recordingId\":\"REb1eecfce410141ad1749c0fc84dfbb6fc4c2a810\",\"accountId\":\"ACabe7063197551fe51671f9ac3a9708e9dad51c4d\",\"conferenceId\":\"CF3cb8a52f461bcf64cbd3111d9492c3f61943eef9\",\"callId\":null,\"durationSec\":9}";
            Recording recording = Recording.fromJson(json);

            Assert.IsNotNull(recording);
            Assert.IsNotNull(recording.getUri);
            Assert.AreEqual(recording.getUri, "/Accounts/ACabe7063197551fe51671f9ac3a9708e9dad51c4d/Recordings/REb1eecfce410141ad1749c0fc84dfbb6fc4c2a810");
            Assert.AreEqual(recording.getConferenceId, "CF3cb8a52f461bcf64cbd3111d9492c3f61943eef9");
            Assert.IsNull(recording.getCallId);
            Assert.AreEqual(recording.getRevision, 1);
            Assert.IsNotNull(recording.getDateCreated);
            Assert.IsNotNull(recording.getDateUpdated);
            Assert.AreEqual(recording.getDurationSec, 9);
        }
    }
}
