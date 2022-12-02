/*
 * FreeClimb API
 *
 * FreeClimb is a cloud-based application programming interface (API) that puts the power of the Vail platform in your hands. FreeClimb simplifies the process of creating applications that can use a full range of telephony features without requiring specialized or on-site telephony equipment. Using the FreeClimb REST API to write applications is easy! You have the option to use the language of your choice or hit the API directly. Your application can execute a command by issuing a RESTful request to the FreeClimb API. The base URL to send HTTP requests to the FreeClimb REST API is: /apiserver. FreeClimb authenticates and processes your request.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@freeclimb.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Moq;
using Moq.Protected;
using Xunit;

using freeclimb.Client;
using freeclimb.Api;
// uncomment below to import models
using freeclimb.Model;
using freeclimb.Enums;

namespace freeclimb.Test.Api
{
    /// <summary>
    ///  Class for testing DefaultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DefaultApiTests : IDisposable
    {
        private Configuration config;

        private DefaultApi instance;

        public DefaultApiTests()
        {
            config = new Configuration();
            config.BasePath = "http://127.0.0.1:4010/";
            config.Username = "TEST-ACCOUNT-ID";
            config.Password = "TEST-API-KEY";
            instance = new DefaultApi(config);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DefaultApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<DefaultApi>(instance);
        }

        /// <summary>
        /// Test BuyAPhoneNumber
        /// </summary>
        [Fact]

        public void BuyAPhoneNumberTest()
        {

            BuyIncomingNumberRequest buyIncomingNumberRequest = buyIncomingNumberRequestTestValue();

            var response = instance.BuyAPhoneNumber(buyIncomingNumberRequest);
            //Assert.IsType<IncomingNumberResult>(response);
            Assert.IsAssignableFrom<IncomingNumberResult>(response);
        }

        /// <summary>
        /// Test CreateAConference
        /// </summary>
        [Fact]

        public void CreateAConferenceTest()
        {

            CreateConferenceRequest createConferenceRequest = createConferenceRequestTestValue();

            var response = instance.CreateAConference(createConferenceRequest);
            //Assert.IsType<ConferenceResult>(response);
            Assert.IsAssignableFrom<ConferenceResult>(response);
        }

        /// <summary>
        /// Test CreateAQueue
        /// </summary>
        [Fact]

        public void CreateAQueueTest()
        {

            QueueRequest queueRequest = queueRequestTestValue();

            var response = instance.CreateAQueue(queueRequest);
            //Assert.IsType<QueueResult>(response);
            Assert.IsAssignableFrom<QueueResult>(response);
        }

        /// <summary>
        /// Test CreateAnApplication
        /// </summary>
        [Fact]

        public void CreateAnApplicationTest()
        {

            ApplicationRequest applicationRequest = applicationRequestTestValue();

            var response = instance.CreateAnApplication(applicationRequest);
            //Assert.IsType<ApplicationResult>(response);
            Assert.IsAssignableFrom<ApplicationResult>(response);
        }

        /// <summary>
        /// Test DeleteARecording
        /// </summary>
        [Fact]

        public void DeleteARecordingTest()
        {

            string recordingId = recordingIdTestValue();

            instance.DeleteARecording(recordingId);
        }

        /// <summary>
        /// Test DeleteAnApplication
        /// </summary>
        [Fact]

        public void DeleteAnApplicationTest()
        {

            string applicationId = applicationIdTestValue();

            instance.DeleteAnApplication(applicationId);
        }

        /// <summary>
        /// Test DeleteAnIncomingNumber
        /// </summary>
        [Fact]

        public void DeleteAnIncomingNumberTest()
        {

            string phoneNumberId = phoneNumberIdTestValue();

            instance.DeleteAnIncomingNumber(phoneNumberId);
        }

        /// <summary>
        /// Test DequeueAMember
        /// </summary>
        [Fact]

        public void DequeueAMemberTest()
        {

            string queueId = queueIdTestValue();

            string callId = callIdTestValue();

            var response = instance.DequeueAMember(queueId, callId);
            //Assert.IsType<QueueMember>(response);
            Assert.IsAssignableFrom<QueueMember>(response);
        }

        /// <summary>
        /// Test DequeueHeadMember
        /// </summary>
        [Fact]

        public void DequeueHeadMemberTest()
        {

            string queueId = queueIdTestValue();

            var response = instance.DequeueHeadMember(queueId);
            //Assert.IsType<QueueMember>(response);
            Assert.IsAssignableFrom<QueueMember>(response);
        }

        /// <summary>
        /// Test DownloadARecordingFile
        /// </summary>
        [Fact]

        public void DownloadARecordingFileTest()
        {

            string recordingId = recordingIdTestValue();

            var response = instance.DownloadARecordingFile(recordingId);
            //Assert.IsType<System.IO.Stream>(response);
            Assert.IsAssignableFrom<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test FilterLogs
        /// </summary>
        [Fact]

        public void FilterLogsTest()
        {

            FilterLogsRequest filterLogsRequest = filterLogsRequestTestValue();

            var response = instance.FilterLogs(filterLogsRequest);
            //Assert.IsType<LogList>(response);
            Assert.IsAssignableFrom<LogList>(response);
        }

        /// <summary>
        /// Test GetACall
        /// </summary>
        [Fact]

        public void GetACallTest()
        {

            string callId = callIdTestValue();

            var response = instance.GetACall(callId);
            //Assert.IsType<CallResult>(response);
            Assert.IsAssignableFrom<CallResult>(response);
        }

        /// <summary>
        /// Test GetAConference
        /// </summary>
        [Fact]

        public void GetAConferenceTest()
        {

            string conferenceId = conferenceIdTestValue();

            var response = instance.GetAConference(conferenceId);
            //Assert.IsType<ConferenceResult>(response);
            Assert.IsAssignableFrom<ConferenceResult>(response);
        }

        /// <summary>
        /// Test GetAMember
        /// </summary>
        [Fact]

        public void GetAMemberTest()
        {

            string queueId = queueIdTestValue();

            string callId = callIdTestValue();

            var response = instance.GetAMember(queueId, callId);
            //Assert.IsType<QueueMember>(response);
            Assert.IsAssignableFrom<QueueMember>(response);
        }

        /// <summary>
        /// Test GetAParticipant
        /// </summary>
        [Fact]

        public void GetAParticipantTest()
        {

            string conferenceId = conferenceIdTestValue();

            string callId = callIdTestValue();

            var response = instance.GetAParticipant(conferenceId, callId);
            //Assert.IsType<ConferenceParticipantResult>(response);
            Assert.IsAssignableFrom<ConferenceParticipantResult>(response);
        }

        /// <summary>
        /// Test GetAQueue
        /// </summary>
        [Fact]

        public void GetAQueueTest()
        {

            string queueId = queueIdTestValue();

            var response = instance.GetAQueue(queueId);
            //Assert.IsType<QueueResult>(response);
            Assert.IsAssignableFrom<QueueResult>(response);
        }

        /// <summary>
        /// Test GetARecording
        /// </summary>
        [Fact]

        public void GetARecordingTest()
        {

            string recordingId = recordingIdTestValue();

            var response = instance.GetARecording(recordingId);
            //Assert.IsType<RecordingResult>(response);
            Assert.IsAssignableFrom<RecordingResult>(response);
        }

        /// <summary>
        /// Test GetAnAccount
        /// </summary>
        [Fact]

        public void GetAnAccountTest()
        {

            var response = instance.GetAnAccount();
            //Assert.IsType<AccountResult>(response);
            Assert.IsAssignableFrom<AccountResult>(response);
        }

        /// <summary>
        /// Test GetAnApplication
        /// </summary>
        [Fact]

        public void GetAnApplicationTest()
        {

            string applicationId = applicationIdTestValue();

            var response = instance.GetAnApplication(applicationId);
            //Assert.IsType<ApplicationResult>(response);
            Assert.IsAssignableFrom<ApplicationResult>(response);
        }

        /// <summary>
        /// Test GetAnIncomingNumber
        /// </summary>
        [Fact]

        public void GetAnIncomingNumberTest()
        {

            string phoneNumberId = phoneNumberIdTestValue();

            var response = instance.GetAnIncomingNumber(phoneNumberId);
            //Assert.IsType<IncomingNumberResult>(response);
            Assert.IsAssignableFrom<IncomingNumberResult>(response);
        }

        /// <summary>
        /// Test GetAnSmsMessage
        /// </summary>
        [Fact]

        public void GetAnSmsMessageTest()
        {

            string messageId = messageIdTestValue();

            var response = instance.GetAnSmsMessage(messageId);
            //Assert.IsType<MessageResult>(response);
            Assert.IsAssignableFrom<MessageResult>(response);
        }

        /// <summary>
        /// Test GetHeadMember
        /// </summary>
        [Fact]

        public void GetHeadMemberTest()
        {

            string queueId = queueIdTestValue();

            var response = instance.GetHeadMember(queueId);
            //Assert.IsType<QueueMember>(response);
            Assert.IsAssignableFrom<QueueMember>(response);
        }

        /// <summary>
        /// Test ListActiveQueues
        /// </summary>
        [Fact]

        public void ListActiveQueuesTest()
        {

            string alias = aliasTestValue();

            var response = instance.ListActiveQueues(alias);
            //Assert.IsType<QueueList>(response);
            Assert.IsAssignableFrom<QueueList>(response);
        }

        /// <summary>
        /// Test ListAllAccountLogs
        /// </summary>
        [Fact]

        public void ListAllAccountLogsTest()
        {

            var response = instance.ListAllAccountLogs();
            //Assert.IsType<LogList>(response);
            Assert.IsAssignableFrom<LogList>(response);
        }

        /// <summary>
        /// Test ListApplications
        /// </summary>
        [Fact]

        public void ListApplicationsTest()
        {

            string alias = aliasTestValue();

            var response = instance.ListApplications(alias);
            //Assert.IsType<ApplicationList>(response);
            Assert.IsAssignableFrom<ApplicationList>(response);
        }

        /// <summary>
        /// Test ListAvailableNumbers
        /// </summary>
        [Fact]

        public void ListAvailableNumbersTest()
        {

            string phoneNumber = phoneNumberTestValue();

            string region = regionTestValue();

            string country = countryTestValue();

            bool? voiceEnabled = voiceEnabledTestValue();

            bool? smsEnabled = smsEnabledTestValue();

            bool? capabilitiesVoice = capabilitiesVoiceTestValue();

            bool? capabilitiesSms = capabilitiesSmsTestValue();

            bool? capabilitiesTollFree = capabilitiesTollFreeTestValue();

            bool? capabilitiesTenDLC = capabilitiesTenDLCTestValue();

            bool? capabilitiesShortCode = capabilitiesShortCodeTestValue();

            var response = instance.ListAvailableNumbers(phoneNumber, region, country, voiceEnabled, smsEnabled, capabilitiesVoice, capabilitiesSms, capabilitiesTollFree, capabilitiesTenDLC, capabilitiesShortCode);
            //Assert.IsType<AvailableNumberList>(response);
            Assert.IsAssignableFrom<AvailableNumberList>(response);
        }

        /// <summary>
        /// Test ListCallLogs
        /// </summary>
        [Fact]

        public void ListCallLogsTest()
        {

            string callId = callIdTestValue();

            var response = instance.ListCallLogs(callId);
            //Assert.IsType<LogList>(response);
            Assert.IsAssignableFrom<LogList>(response);
        }

        /// <summary>
        /// Test ListCallRecordings
        /// </summary>
        [Fact]

        public void ListCallRecordingsTest()
        {

            string callId = callIdTestValue();

            string dateCreated = dateCreatedTestValue();

            var response = instance.ListCallRecordings(callId, dateCreated);
            //Assert.IsType<RecordingList>(response);
            Assert.IsAssignableFrom<RecordingList>(response);
        }

        /// <summary>
        /// Test ListCalls
        /// </summary>
        [Fact]

        public void ListCallsTest()
        {

            bool? active = activeTestValue();

            string to = toTestValue();

            string from = fromTestValue();

            CallStatus? status = statusTestEnum();

            string startTime = startTimeTestValue();

            string endTime = endTimeTestValue();

            string parentCallId = parentCallIdTestValue();

            var response = instance.ListCalls(active, to, from, status, startTime, endTime, parentCallId);
            //Assert.IsType<CallList>(response);
            Assert.IsAssignableFrom<CallList>(response);
        }

        /// <summary>
        /// Test ListConferences
        /// </summary>
        [Fact]

        public void ListConferencesTest()
        {

            string status = statusTestValue();

            string alias = aliasTestValue();

            string dateCreated = dateCreatedTestValue();

            string dateUpdated = dateUpdatedTestValue();

            var response = instance.ListConferences(status, alias, dateCreated, dateUpdated);
            //Assert.IsType<ConferenceList>(response);
            Assert.IsAssignableFrom<ConferenceList>(response);
        }

        /// <summary>
        /// Test ListIncomingNumbers
        /// </summary>
        [Fact]

        public void ListIncomingNumbersTest()
        {

            string phoneNumber = phoneNumberTestValue();

            string alias = aliasTestValue();

            string region = regionTestValue();

            string country = countryTestValue();

            string applicationId = applicationIdTestValue();

            bool? hasApplication = hasApplicationTestValue();

            bool? voiceEnabled = voiceEnabledTestValue();

            bool? smsEnabled = smsEnabledTestValue();

            bool? capabilitiesVoice = capabilitiesVoiceTestValue();

            bool? capabilitiesSms = capabilitiesSmsTestValue();

            bool? capabilitiesTollFree = capabilitiesTollFreeTestValue();

            bool? capabilitiesTenDLC = capabilitiesTenDLCTestValue();

            bool? capabilitiesShortCode = capabilitiesShortCodeTestValue();

            bool? offnet = offnetTestValue();

            var response = instance.ListIncomingNumbers(phoneNumber, alias, region, country, applicationId, hasApplication, voiceEnabled, smsEnabled, capabilitiesVoice, capabilitiesSms, capabilitiesTollFree, capabilitiesTenDLC, capabilitiesShortCode, offnet);
            //Assert.IsType<IncomingNumberList>(response);
            Assert.IsAssignableFrom<IncomingNumberList>(response);
        }

        /// <summary>
        /// Test ListMembers
        /// </summary>
        [Fact]

        public void ListMembersTest()
        {

            string queueId = queueIdTestValue();

            var response = instance.ListMembers(queueId);
            //Assert.IsType<QueueMemberList>(response);
            Assert.IsAssignableFrom<QueueMemberList>(response);
        }

        /// <summary>
        /// Test ListParticipants
        /// </summary>
        [Fact]

        public void ListParticipantsTest()
        {

            string conferenceId = conferenceIdTestValue();

            bool? talk = talkTestValue();

            bool? listen = listenTestValue();

            var response = instance.ListParticipants(conferenceId, talk, listen);
            //Assert.IsType<ConferenceParticipantList>(response);
            Assert.IsAssignableFrom<ConferenceParticipantList>(response);
        }

        /// <summary>
        /// Test ListRecordings
        /// </summary>
        [Fact]

        public void ListRecordingsTest()
        {

            string callId = callIdTestValue();

            string conferenceId = conferenceIdTestValue();

            string dateCreated = dateCreatedTestValue();

            var response = instance.ListRecordings(callId, conferenceId, dateCreated);
            //Assert.IsType<RecordingList>(response);
            Assert.IsAssignableFrom<RecordingList>(response);
        }

        /// <summary>
        /// Test ListSmsMessages
        /// </summary>
        [Fact]

        public void ListSmsMessagesTest()
        {

            string to = toTestValue();

            string from = fromTestValue();

            string beginTime = beginTimeTestValue();

            string endTime = endTimeTestValue();

            MessageDirection? direction = directionTestEnum();

            var response = instance.ListSmsMessages(to, from, beginTime, endTime, direction);
            //Assert.IsType<MessagesList>(response);
            Assert.IsAssignableFrom<MessagesList>(response);
        }

        /// <summary>
        /// Test MakeACall
        /// </summary>
        [Fact]

        public void MakeACallTest()
        {

            MakeCallRequest makeCallRequest = makeCallRequestTestValue();

            var response = instance.MakeACall(makeCallRequest);
            //Assert.IsType<CallResult>(response);
            Assert.IsAssignableFrom<CallResult>(response);
        }

        /// <summary>
        /// Test RemoveAParticipant
        /// </summary>
        [Fact]

        public void RemoveAParticipantTest()
        {

            string conferenceId = conferenceIdTestValue();

            string callId = callIdTestValue();

            instance.RemoveAParticipant(conferenceId, callId);
        }

        /// <summary>
        /// Test SendAnSmsMessage
        /// </summary>
        [Fact]

        public void SendAnSmsMessageTest()
        {

            MessageRequest messageRequest = messageRequestTestValue();

            var response = instance.SendAnSmsMessage(messageRequest);
            //Assert.IsType<MessageResult>(response);
            Assert.IsAssignableFrom<MessageResult>(response);
        }

        /// <summary>
        /// Test StreamARecordingFile
        /// </summary>
        [Fact]

        public void StreamARecordingFileTest()
        {

            string recordingId = recordingIdTestValue();

            var response = instance.StreamARecordingFile(recordingId);
            //Assert.IsType<System.IO.Stream>(response);
            Assert.IsAssignableFrom<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test UpdateAConference
        /// </summary>
        [Fact]

        public void UpdateAConferenceTest()
        {

            string conferenceId = conferenceIdTestValue();

            UpdateConferenceRequest updateConferenceRequest = updateConferenceRequestTestValue();

            var response = instance.UpdateAConference(conferenceId, updateConferenceRequest);
            //Assert.IsType<ConferenceResult>(response);
            Assert.IsAssignableFrom<ConferenceResult>(response);
        }

        /// <summary>
        /// Test UpdateALiveCall
        /// </summary>
        [Fact]

        public void UpdateALiveCallTest()
        {

            string callId = callIdTestValue();

            UpdateCallRequest updateCallRequest = updateCallRequestTestValue();

            instance.UpdateALiveCall(callId, updateCallRequest);
        }

        /// <summary>
        /// Test UpdateAParticipant
        /// </summary>
        [Fact]

        public void UpdateAParticipantTest()
        {

            string conferenceId = conferenceIdTestValue();

            string callId = callIdTestValue();

            UpdateConferenceParticipantRequest updateConferenceParticipantRequest = updateConferenceParticipantRequestTestValue();

            var response = instance.UpdateAParticipant(conferenceId, callId, updateConferenceParticipantRequest);
            //Assert.IsType<ConferenceParticipantResult>(response);
            Assert.IsAssignableFrom<ConferenceParticipantResult>(response);
        }

        /// <summary>
        /// Test UpdateAQueue
        /// </summary>
        [Fact]

        public void UpdateAQueueTest()
        {

            string queueId = queueIdTestValue();

            QueueRequest queueRequest = queueRequestTestValue();

            var response = instance.UpdateAQueue(queueId, queueRequest);
            //Assert.IsType<QueueResult>(response);
            Assert.IsAssignableFrom<QueueResult>(response);
        }

        /// <summary>
        /// Test UpdateAnAccount
        /// </summary>
        [Fact]

        public void UpdateAnAccountTest()
        {

            AccountRequest accountRequest = accountRequestTestValue();

            instance.UpdateAnAccount(accountRequest);
        }

        /// <summary>
        /// Test UpdateAnApplication
        /// </summary>
        [Fact]

        public void UpdateAnApplicationTest()
        {

            string applicationId = applicationIdTestValue();

            ApplicationRequest applicationRequest = applicationRequestTestValue();

            var response = instance.UpdateAnApplication(applicationId, applicationRequest);
            //Assert.IsType<ApplicationResult>(response);
            Assert.IsAssignableFrom<ApplicationResult>(response);
        }

        /// <summary>
        /// Test UpdateAnIncomingNumber
        /// </summary>
        [Fact]

        public void UpdateAnIncomingNumberTest()
        {

            string phoneNumberId = phoneNumberIdTestValue();

            IncomingNumberRequest incomingNumberRequest = incomingNumberRequestTestValue();

            var response = instance.UpdateAnIncomingNumber(phoneNumberId, incomingNumberRequest);
            //Assert.IsType<IncomingNumberResult>(response);
            Assert.IsAssignableFrom<IncomingNumberResult>(response);
        }

        private string accountIdTestValue()
        {
            return "AC0000000000000000000000000000000000000000";
        }

        private string applicationIdTestValue()
        {
            return "AP0000000000000000000000000000000000000000";
        }

        private string recordingIdTestValue()
        {
            return "RC0000000000000000000000000000000000000000";
        }

        private string callIdTestValue()
        {
            return "CA0000000000000000000000000000000000000000";
        }

        private string phoneNumberTestValue()
        {
            return "+13124567890";
        }

        private string phoneNumberIdTestValue()
        {
            return "PN0000000000000000000000000000000000000000";
        }

        private string queueIdTestValue()
        {
            return "QU0000000000000000000000000000000000000000";
        }

        private string conferenceIdTestValue()
        {
            return "CN0000000000000000000000000000000000000000";
        }

        private string messageIdTestValue()
        {
            return "ME0000000000000000000000000000000000000000";
        }

        private string aliasTestValue()
        {
            return "TEST-ALIAS";
        }

        private string dateCreatedTestValue()
        {
            return "Mon, 15 Jun 2020 20:20:20 GMT";
        }

        private string dateUpdatedTestValue()
        {
            return "Wed, 17, Jun 2020 20:20:20 GMT";
        }

        private BuyIncomingNumberRequest buyIncomingNumberRequestTestValue()
        {
            return new BuyIncomingNumberRequest("+18001234567", "TEST-ALIAS", "TEST-APP");
        }

        private IncomingNumberRequest incomingNumberRequestTestValue()
        {
            return new IncomingNumberRequest(applicationIdTestValue(), aliasTestValue());
        }

        private IncomingNumberResult incomingNumberResultTestValue()
        {
            Capabilities capabilities = new Capabilities(true, true, true, true, false);
            return new IncomingNumberResult("example.com", "Mon, 15 Jun 2020 20:20:20 GMT", "Wed, 17 Jun 2020 20:20:20 GMT", 0, capabilities);
        }

        private MakeCallRequest makeCallRequestTestValue()
        {
            return new MakeCallRequest("+18001234567", "+18003214567", "TEST-APP");
        }

        private CreateConferenceRequest createConferenceRequestTestValue()
        {
            PlayBeep enumPlayBeepStatus = Reflection.GetEnumByValue<PlayBeep>("always");
            return new CreateConferenceRequest("TEST-CONF", enumPlayBeepStatus, true);
        }

        private ConferenceResult conferenceResultTestValue()
        {
            return new ConferenceResult();
        }

        private QueueRequest queueRequestTestValue()
        {
            return new QueueRequest("TEST-QUEUE");
        }

        private QueueMember queueMemberTestValue()
        {
            return new QueueMember("example.com", callIdTestValue(), 0, 0, "Mon, 15 Jun 2009 20:45:30 GMT");

        }

        private QueueResult queueResultTestValue()
        {
            return new QueueResult("example.com", "Mon, 15 Jun 2020 20:20:20 GMT",
                "Wed, 17 Jun 2020 20:20:20 GMT", 0, accountIdTestValue(),
                queueIdTestValue(), "TEST-QUEUE", 100, 0, 0, 0);
        }

        private ApplicationRequest applicationRequestTestValue()
        {
            return new ApplicationRequest("TEST-APP", "voice.com", "voicefallback.com", "callconnect.com", "status.com", "sms.com", "smsfallback.com");
        }

        private ApplicationResult applicationResultTestValue()
        {
            return new ApplicationResult("example.com", "Mon, 15 Jun 2009 20:45:30 GMT", "Wed, 17 Jun 2009 20:45:30 GMT", 3,
                accountIdTestValue(), applicationIdTestValue(), "TEST-APP", "voice.com", "voicefallback.com", "callconnect.com",
                "status.com", "sms.com", "smsfallback.com");
        }

        private string regionTestValue()
        {
            return "IL";
        }

        private string countryTestValue()
        {
            return "US";
        }

        private bool voiceEnabledTestValue()
        {
            return true;
        }

        private bool smsEnabledTestValue()
        {
            return true;
        }

        private bool capabilitiesVoiceTestValue()
        {
            return true;
        }

        private bool capabilitiesSmsTestValue()
        {
            return true;
        }

        private bool capabilitiesTollFreeTestValue()
        {
            return false;
        }

        private bool capabilitiesTenDLCTestValue()
        {
            return true;
        }

        private bool capabilitiesShortCodeTestValue()
        {
            return true;
        }
        private bool offnetTestValue()
        {
            return true;
        }

        private AvailableNumberList availableNumberListTestValue()
        {
            List<AvailableNumber> numList = new List<AvailableNumber>();
            Capabilities capabilities = new Capabilities(true, true, true, true, false);
            AvailableNumber num1 = new AvailableNumber(capabilities, "TEST-CAMPAIGN", "+18003608245", true, true, "US", "IL");
            AvailableNumber num2 = new AvailableNumber(capabilities, "TEST-CAMPAIGN", phoneNumberTestValue(), true, true, "US", "IL");
            numList.Add(num1);
            numList.Add(num2);
            return new AvailableNumberList(2, 1, 1, 1, 1, 10, "example.com", numList);
        }

        private FilterLogsRequest filterLogsRequestTestValue()
        {
            return new FilterLogsRequest("test");
        }

        private LogList logListTestValue()
        {
            return new LogList();
        }

        private CallResult callResultTestValue()
        {
            CallStatus enumCallStatus = Reflection.GetEnumByValue<CallStatus>("inProgress");
            return new CallResult("example.com", dateCreatedTestValue(), "Mon, 15 Jun 2020 20:45:32 GMT",
                1, callIdTestValue(), null, accountIdTestValue(), phoneNumberTestValue(), "+13124567890",
                null, enumCallStatus, dateCreatedTestValue(), dateCreatedTestValue(), null);
        }

        private ConferenceParticipantResult conferenceParticipantResultTestValue()
        {
            return new ConferenceParticipantResult("example.com", dateCreatedTestValue(), null, 1,
                accountIdTestValue(), conferenceIdTestValue(), callIdTestValue(), true, true, true);
        }

        private RecordingResult recordingResultTestValue()
        {
            return new RecordingResult("example.com", dateCreatedTestValue(), null, 1, recordingIdTestValue(), accountIdTestValue(), callIdTestValue(), 10);
        }

        private AccountResult accountResultTestValue()
        {
            return new AccountResult("example.com", dateCreatedTestValue(), null, 1, accountIdTestValue(), "TEST-API-KEY", "TEST-ALIAS");
        }

        private MessageResult messageResultTestValue()
        {
            MessageStatus enumMessageStatus = Reflection.GetEnumByValue<MessageStatus>("sent");
            return new MessageResult("example.com", dateCreatedTestValue(), null, 1, accountIdTestValue(), messageIdTestValue(), enumMessageStatus,
                phoneNumberTestValue(), "+13121113456", "Test text message", "outbound");
        }

        public QueueList queueListTestValue()
        {
            List<QueueResult> queueResults = new List<QueueResult>();
            queueResults.Add(queueResultTestValue());
            return new QueueList(1, 1, 1, 1, 1, 10, null, queueResults);
        }

        private ApplicationList applicationListTestValue()
        {
            List<ApplicationResult> applicationResults = new List<ApplicationResult>();
            applicationResults.Add(applicationResultTestValue());
            return new ApplicationList(1, 1, 1, 1, 1, 10, null, applicationResults);
        }

        private RecordingList recordingListTestValue()
        {
            List<RecordingResult> recordingList = new List<RecordingResult>();
            recordingList.Add(recordingResultTestValue());
            RecordingResult rec2 = recordingResultTestValue();
            rec2.RecordingId = "RC00000000000000000000000000000000000000001";
            recordingList.Add(rec2);
            return new RecordingList(2, 1, 1, 1, 1, 10, null, recordingList);
        }

        private ConferenceList conferenceListTestValue()
        {
            List<ConferenceResult> conferences = new List<ConferenceResult>();
            conferences.Add(conferenceResultTestValue());
            return new ConferenceList(1, 1, 1, 1, 1, 10, null, conferences);
        }

        private bool activeTestValue()
        {
            return true;
        }

        private string toTestValue()
        {
            return phoneNumberTestValue();
        }

        private string fromTestValue()
        {
            return "+18009991234";
        }

        private string statusTestValue()
        {
            return "completed";
        }

        private CallStatus statusTestEnum()
        {
            return Reflection.GetEnumByValue<CallStatus>("completed");
        }

        private string startTimeTestValue()
        {
            return "2022-12-12 01:01:01";
        }

        private string endTimeTestValue()
        {
            return "2022-12-12 02:02:02";
        }

        private string parentCallIdTestValue()
        {
            return callIdTestValue();
        }

        private CallList callListTestValue()
        {
            List<CallResult> calls = new List<CallResult>();
            calls.Add(callResultTestValue());
            return new CallList(1, 1, 1, 1, 1, 10, null, calls);
        }

        private bool hasApplicationTestValue()
        {
            return false;
        }

        private IncomingNumberList incomingNumberListTestValue()
        {
            List<IncomingNumberResult> incomingNumbers = new List<IncomingNumberResult>();
            incomingNumbers.Add(incomingNumberResultTestValue());
            return new IncomingNumberList(1, 1, 1, 1, 1, 10, null, incomingNumbers);
        }

        private QueueMemberList queueMemberListTestValue()
        {
            List<QueueMember> queues = new List<QueueMember>();
            queues.Add(queueMemberTestValue());
            return new QueueMemberList(1, 1, 1, 1, 1, 10, null, queues);
        }

        private bool talkTestValue() { return true; }

        private bool listenTestValue() { return true; }

        private ConferenceParticipantList conferenceParticipantListTestValue()
        {
            List<ConferenceParticipantResult> conferences = new List<ConferenceParticipantResult>();
            conferences.Add(conferenceParticipantResultTestValue());
            return new ConferenceParticipantList(1, 1, 1, 1, 1, 10, null, conferences);
        }

        private string beginTimeTestValue() { return "2022-12-12 01:01:01:01"; }

        private string directionTestValue() { return "outbound"; }

        private MessageDirection directionTestEnum()
        {
            return Reflection.GetEnumByValue<MessageDirection>("outbound");
        }

        private MessagesList messagesListTestValue()
        {
            List<MessageResult> messages = new List<MessageResult>();
            messages.Add(messageResultTestValue());
            return new MessagesList(1, 1, 1, 1, 1, 10, null, messages);
        }

        private UpdateConferenceRequest updateConferenceRequestTestValue()
        {
            PlayBeep enumPlayBeepStatus = Reflection.GetEnumByValue<PlayBeep>("always");
            return new UpdateConferenceRequest("TEST-CONF", enumPlayBeepStatus);
        }

        private UpdateCallRequest updateCallRequestTestValue()
        {
            UpdateCallRequestStatus enumCallRequestStatus = Reflection.GetEnumByValue<UpdateCallRequestStatus>("completed");
            return new UpdateCallRequest(enumCallRequestStatus);
        }

        private UpdateConferenceParticipantRequest updateConferenceParticipantRequestTestValue()
        {
            return new UpdateConferenceParticipantRequest(true, true);
        }

        private AccountRequest accountRequestTestValue()
        {
            return new AccountRequest("TEST-ACCOUNT", null);
        }

        private MessageRequest messageRequestTestValue()
        {
            return new MessageRequest("example.com", dateCreatedTestValue(), dateUpdatedTestValue(), 2, phoneNumberTestValue(), "+13124445555",
               "test text message", null, accountIdTestValue());
        }

        private System.IO.Stream systemIOStreamTestValue()
        {
            System.IO.MemoryStream memStream = new System.IO.MemoryStream();
            System.IO.Stream stream = memStream;
            return stream;
        }
    }
}
