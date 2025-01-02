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
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using freeclimb.Client;
using freeclimb.Enums;
using freeclimb.Model;
using Newtonsoft.Json;
using Xunit;

namespace freeclimb.Test.Model
{
    /// <summary>
    ///  Class for testing RecordWebhook
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>

    public class RecordWebhookTests : IDisposable
    {
        private RecordWebhook instance;

        public RecordWebhookTests()
        {
            instance = new RecordWebhook(
                requestType: (string)getTestValue(typeof(string)),
                accountId: (string)getTestValue(typeof(string)),
                callId: (string)getTestValue(typeof(string)),
                from: (string)getTestValue(typeof(string)),
                to: (string)getTestValue(typeof(string)),
                callStatus: (CallStatus)getTestValue(typeof(CallStatus)),
                direction: (CallDirection)getTestValue(typeof(CallDirection)),
                conferenceId: (string)getTestValue(typeof(string)),
                queueId: (string)getTestValue(typeof(string)),
                recordingId: (string)getTestValue(typeof(string)),
                recordingUrl: (string)getTestValue(typeof(string)),
                recordingSize: (string)getTestValue(typeof(string)),
                recordingFormat: (string)getTestValue(typeof(string)),
                recordingDurationSec: (int)getTestValue(typeof(int)),
                termReason: (RecordUtteranceTermReason)getTestValue(
                    typeof(RecordUtteranceTermReason)
                ),
                parentCallId: (string)getTestValue(typeof(string)),
                privacyMode: (bool)getTestValue(typeof(bool))
            );
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RecordWebhook
        /// </summary>
        [Fact]
        public void RecordWebhookInstanceTest()
        {
            Assert.IsType<RecordWebhook>(instance);
        }

        /// <summary>
        /// Test the property 'RequestType'
        /// </summary>
        [Fact]
        public void RequestTypeTest() { }

        /// <summary>
        /// Test the property 'AccountId'
        /// </summary>
        [Fact]
        public void AccountIdTest()
        {
            instance.AccountId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.AccountId);
        }

        /// <summary>
        /// Test the property 'CallId'
        /// </summary>
        [Fact]
        public void CallIdTest()
        {
            instance.CallId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.CallId);
        }

        /// <summary>
        /// Test the property 'From'
        /// </summary>
        [Fact]
        public void FromTest()
        {
            instance.From = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.From);
        }

        /// <summary>
        /// Test the property 'To'
        /// </summary>
        [Fact]
        public void ToTest()
        {
            instance.To = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.To);
        }

        /// <summary>
        /// Test the property 'CallStatus'
        /// </summary>
        [Fact]
        public void CallStatusTest()
        {
            instance.CallStatus = CallStatus.QUEUED;
            Assert.Equal(CallStatus.QUEUED, instance.CallStatus);
            instance.CallStatus = CallStatus.RINGING;
            Assert.Equal(CallStatus.RINGING, instance.CallStatus);
            instance.CallStatus = CallStatus.IN_PROGRESS;
            Assert.Equal(CallStatus.IN_PROGRESS, instance.CallStatus);
            instance.CallStatus = CallStatus.CANCELED;
            Assert.Equal(CallStatus.CANCELED, instance.CallStatus);
            instance.CallStatus = CallStatus.COMPLETED;
            Assert.Equal(CallStatus.COMPLETED, instance.CallStatus);
            instance.CallStatus = CallStatus.FAILED;
            Assert.Equal(CallStatus.FAILED, instance.CallStatus);
            instance.CallStatus = CallStatus.BUSY;
            Assert.Equal(CallStatus.BUSY, instance.CallStatus);
            instance.CallStatus = CallStatus.NO_ANSWER;
            Assert.Equal(CallStatus.NO_ANSWER, instance.CallStatus);
        }

        /// <summary>
        /// Test the property 'Direction'
        /// </summary>
        [Fact]
        public void DirectionTest()
        {
            instance.Direction = CallDirection.INBOUND;
            Assert.Equal(CallDirection.INBOUND, instance.Direction);
            instance.Direction = CallDirection.OUTBOUND_API;
            Assert.Equal(CallDirection.OUTBOUND_API, instance.Direction);
            instance.Direction = CallDirection.OUTBOUND_DIAL;
            Assert.Equal(CallDirection.OUTBOUND_DIAL, instance.Direction);
        }

        /// <summary>
        /// Test the property 'ConferenceId'
        /// </summary>
        [Fact]
        public void ConferenceIdTest()
        {
            instance.ConferenceId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.ConferenceId);
        }

        /// <summary>
        /// Test the property 'QueueId'
        /// </summary>
        [Fact]
        public void QueueIdTest()
        {
            instance.QueueId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.QueueId);
        }

        /// <summary>
        /// Test the property 'RecordingId'
        /// </summary>
        [Fact]
        public void RecordingIdTest()
        {
            instance.RecordingId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.RecordingId);
        }

        /// <summary>
        /// Test the property 'RecordingUrl'
        /// </summary>
        [Fact]
        public void RecordingUrlTest()
        {
            instance.RecordingUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.RecordingUrl);
        }

        /// <summary>
        /// Test the property 'RecordingSize'
        /// </summary>
        [Fact]
        public void RecordingSizeTest()
        {
            instance.RecordingSize = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.RecordingSize);
        }

        /// <summary>
        /// Test the property 'RecordingFormat'
        /// </summary>
        [Fact]
        public void RecordingFormatTest()
        {
            instance.RecordingFormat = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.RecordingFormat);
        }

        /// <summary>
        /// Test the property 'RecordingDurationSec'
        /// </summary>
        [Fact]
        public void RecordingDurationSecTest()
        {
            instance.RecordingDurationSec = 1;
            Assert.Equal(1, (int)instance.RecordingDurationSec);
        }

        /// <summary>
        /// Test the property 'TermReason'
        /// </summary>
        [Fact]
        public void TermReasonTest()
        {
            instance.TermReason = RecordUtteranceTermReason.FINISH_KEY;
            Assert.Equal(RecordUtteranceTermReason.FINISH_KEY, instance.TermReason);
            instance.TermReason = RecordUtteranceTermReason.TIMEOUT;
            Assert.Equal(RecordUtteranceTermReason.TIMEOUT, instance.TermReason);
            instance.TermReason = RecordUtteranceTermReason.HANGUP;
            Assert.Equal(RecordUtteranceTermReason.HANGUP, instance.TermReason);
            instance.TermReason = RecordUtteranceTermReason.MAX_LENGTH;
            Assert.Equal(RecordUtteranceTermReason.MAX_LENGTH, instance.TermReason);
        }

        /// <summary>
        /// Test the property 'ParentCallId'
        /// </summary>
        [Fact]
        public void ParentCallIdTest()
        {
            instance.ParentCallId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.ParentCallId);
        }

        /// <summary>
        /// Test the property 'PrivacyMode'
        /// </summary>
        [Fact]
        public void PrivacyModeTest()
        {
            instance.PrivacyMode = false;
            Assert.False(instance.PrivacyMode);
        }

        [Fact]
        public void TestDeserializeJsonToRecordWebhook()
        {
            string payload = @"{ ""requestType"": ""record"" }";
            RecordWebhook deserialized = RecordWebhook.Deserialize(payload);
            Assert.IsType<RecordWebhook>(deserialized);
            Assert.Equal("record", deserialized.RequestType);
        }

        public object getTestValue(Type type)
        {
            if (type == typeof(int))
            {
                return 1;
            }
            if (type == typeof(Nullable<int>))
            {
                return 1;
            }
            if (type == typeof(string))
            {
                return "TEST_STRING";
            }
            if (type == typeof(decimal))
            {
                return new decimal(0.1);
            }
            if (type == typeof(Nullable<decimal>))
            {
                return new decimal(0.1);
            }
            if (type == typeof(bool))
            {
                return true;
            }
            if (type == typeof(Nullable<bool>))
            {
                return true;
            }
            if (type == typeof(CallStatus))
            {
                return CallStatusValueConverter.FromString("completed");
            }
            if (type == typeof(CallDirection))
            {
                return CallDirectionValueConverter.FromString("inbound");
            }
            if (type == typeof(GetDigitsReason))
            {
                return GetDigitsReasonValueConverter.FromString("timeout");
            }
            if (type == typeof(LogLevel))
            {
                return LogLevelValueConverter.FromString("info");
            }
            if (type == typeof(CallEndedReason))
            {
                return CallEndedReasonValueConverter.FromString("busy");
            }
            if (type == typeof(SMSTenDLCBrandEntityType))
            {
                return SMSTenDLCBrandEntityTypeValueConverter.FromString("PUBLIC_PROFIT");
            }
            if (type == typeof(SMSTenDLCBrandStockExchange))
            {
                return SMSTenDLCBrandStockExchangeValueConverter.FromString("NONE");
            }
            if (type == typeof(SMSTenDLCBrandRelationship))
            {
                return SMSTenDLCBrandRelationshipValueConverter.FromString("BASIC_ACCOUNT");
            }
            if (type == typeof(SMSTenDLCBrandAltBusinessIdType))
            {
                return SMSTenDLCBrandAltBusinessIdTypeValueConverter.FromString("NONE");
            }
            if (type == typeof(SMSTenDLCBrandIdentityStatus))
            {
                return SMSTenDLCBrandIdentityStatusValueConverter.FromString("SELF_DECLARED");
            }
            if (type == typeof(PlayBeep))
            {
                return PlayBeepValueConverter.FromString("always");
            }
            if (type == typeof(UpdateCallRequestStatus))
            {
                return UpdateCallRequestStatusValueConverter.FromString("canceled");
            }
            if (type == typeof(QueueResultStatus))
            {
                return QueueResultStatusValueConverter.FromString("queueFull");
            }
            if (type == typeof(ConferenceStatus))
            {
                return ConferenceStatusValueConverter.FromString("empty");
            }
            if (type == typeof(MachineType))
            {
                return MachineTypeValueConverter.FromString("answering machine");
            }
            if (type == typeof(SMSTenDLCCampaignStatus))
            {
                return SMSTenDLCCampaignStatusValueConverter.FromString("ACTIVE");
            }
            if (type == typeof(SMSTenDLCPartnerCampaignStatus))
            {
                return SMSTenDLCPartnerCampaignStatusValueConverter.FromString("ACTIVE");
            }
            if (type == typeof(SMSTollFreeCampaignRegistrationStatus))
            {
                return SMSTollFreeCampaignRegistrationStatusValueConverter.FromString(
                    "UNREGISTERED"
                );
            }
            if (type == typeof(MessageStatus))
            {
                return MessageStatusValueConverter.FromString("new");
            }
            if (type == typeof(RecordUtteranceTermReason))
            {
                return RecordUtteranceTermReasonValueConverter.FromString("finishKey");
            }
            if (type == typeof(GrammarType))
            {
                return GrammarTypeValueConverter.FromString("URL");
            }
            if (type == typeof(CompletionResultStatus))
            {
                return CompletionResultStatusValueConverter.FromString("success");
            }
            if (type == typeof(AnsweredBy))
            {
                return AnsweredByValueConverter.FromString("human");
            }
            if (type == typeof(IfMachine))
            {
                return IfMachineValueConverter.FromString("redirect");
            }
            if (type == typeof(AccountType))
            {
                return AccountTypeValueConverter.FromString("trial");
            }
            if (type == typeof(AccountStatus))
            {
                return AccountStatusValueConverter.FromString("closed");
            }
            if (type == typeof(TranscribeTermReason))
            {
                return TranscribeTermReasonValueConverter.FromString("error");
            }
            if (type == typeof(TranscribeReason))
            {
                return TranscribeReasonValueConverter.FromString("internalError");
            }
            if (type == typeof(BargeInReason))
            {
                return BargeInReasonValueConverter.FromString("noBargeIn");
            }
            if (type == typeof(GetSpeechReason))
            {
                return GetSpeechReasonValueConverter.FromString("error");
            }
            if (type == typeof(UpdateConferenceRequestStatus))
            {
                return UpdateConferenceRequestStatusValueConverter.FromString("empty");
            }
            if (type == typeof(Capabilities))
            {
                return new Capabilities(false, false, false, false, false);
            }
            if (type == typeof(List<string>))
            {
                return new List<string>();
            }
            if (type == typeof(List<SMSTenDLCCampaign>))
            {
                return new List<SMSTenDLCCampaign>();
            }
            if (type == typeof(List<ConferenceResult>))
            {
                return new List<ConferenceResult>();
            }
            if (type == typeof(List<MessageResult>))
            {
                return new List<MessageResult>();
            }
            if (type == typeof(List<ApplicationResult>))
            {
                return new List<ApplicationResult>();
            }
            if (type == typeof(List<IncomingNumberResult>))
            {
                return new List<IncomingNumberResult>();
            }
            if (type == typeof(List<SMSTollFreeCampaign>))
            {
                return new List<SMSTollFreeCampaign>();
            }
            if (type == typeof(List<SMSTenDLCBrand>))
            {
                return new List<SMSTenDLCBrand>();
            }
            if (type == typeof(List<QueueResult>))
            {
                return new List<QueueResult>();
            }
            if (type == typeof(List<AvailableNumber>))
            {
                return new List<AvailableNumber>();
            }
            if (type == typeof(List<SMSTenDLCPartnerCampaign>))
            {
                return new List<SMSTenDLCPartnerCampaign>();
            }
            if (type == typeof(List<PerclCommand>))
            {
                return new List<PerclCommand>();
            }
            if (type == typeof(List<QueueMember>))
            {
                return new List<QueueMember>();
            }
            if (type == typeof(List<QueueResult>))
            {
                return new List<QueueResult>();
            }
            if (type == typeof(List<CallResult>))
            {
                return new List<CallResult>();
            }
            if (type == typeof(List<ConferenceParticipantResult>))
            {
                return new List<ConferenceParticipantResult>();
            }
            if (type == typeof(List<LogResult>))
            {
                return new List<LogResult>();
            }
            if (type == typeof(List<RecordingResult>))
            {
                return new List<RecordingResult>();
            }
            if (type == typeof(Capabilities))
            {
                return new Capabilities(
                    voice: false,
                    sms: false,
                    tenDLC: false,
                    tollFree: false,
                    shortCode: false
                );
            }
            if (type == typeof(TFN))
            {
                return new TFN(campaignId: "TEST_CAMPAIGN");
            }
            if (type == typeof(Dictionary<string, Object>))
            {
                return new Dictionary<string, Object>();
            }
            if (type == typeof(TranscribeUtteranceRecord))
            {
                return new TranscribeUtteranceRecord();
            }
            if (type == typeof(SMSTenDLCPartnerCampaignBrand))
            {
                return new SMSTenDLCPartnerCampaignBrand(
                    firstName: "TEST_FIRST_NAME",
                    lastName: "TEST_LAST_NAME",
                    displayName: "TEST_DISPLAY_NAME",
                    companyName: "TEST_COMPANY_NAME",
                    website: "TEST_WEBSITE",
                    evpVettingScore: 0,
                    accountId: "TEST_ACCOUNT_ID",
                    phone: "TEST_PHONE_NUMBER",
                    email: "TEST_EMAIL"
                );
            }
            if (type == typeof(DateTime))
            {
                return DateTime.Today;
            }
            if (type == typeof(Nullable<DateTime>))
            {
                return DateTime.Today;
            }
            if (type == typeof(DateOnly))
            {
                return DateOnly.FromDateTime(DateTime.Now);
            }
            if (type == typeof(Nullable<DateOnly>))
            {
                return DateOnly.FromDateTime(DateTime.Now);
            }
            if (type == typeof(Object))
            {
                return new Dictionary<string, string>();
            }
            throw new ArgumentException("Provided type has no test value", type.ToString());
        }
    }
}
