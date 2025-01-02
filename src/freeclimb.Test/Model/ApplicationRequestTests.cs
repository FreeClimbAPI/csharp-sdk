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
    ///  Class for testing ApplicationRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>

    public class ApplicationRequestTests : IDisposable
    {
        private ApplicationRequest instance;

        public ApplicationRequestTests()
        {
            instance = new ApplicationRequest(
                alias: (string)getTestValue(typeof(string)),
                voiceUrl: (string)getTestValue(typeof(string)),
                voiceFallbackUrl: (string)getTestValue(typeof(string)),
                callConnectUrl: (string)getTestValue(typeof(string)),
                statusCallbackUrl: (string)getTestValue(typeof(string)),
                smsUrl: (string)getTestValue(typeof(string)),
                smsFallbackUrl: (string)getTestValue(typeof(string))
            );
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ApplicationRequest
        /// </summary>
        [Fact]
        public void ApplicationRequestInstanceTest()
        {
            Assert.IsType<ApplicationRequest>(instance);
        }

        /// <summary>
        /// Test the property 'Alias'
        /// </summary>
        [Fact]
        public void AliasTest()
        {
            instance.Alias = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Alias);
        }

        /// <summary>
        /// Test the property 'VoiceUrl'
        /// </summary>
        [Fact]
        public void VoiceUrlTest()
        {
            instance.VoiceUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.VoiceUrl);
        }

        /// <summary>
        /// Test the property 'VoiceFallbackUrl'
        /// </summary>
        [Fact]
        public void VoiceFallbackUrlTest()
        {
            instance.VoiceFallbackUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.VoiceFallbackUrl);
        }

        /// <summary>
        /// Test the property 'CallConnectUrl'
        /// </summary>
        [Fact]
        public void CallConnectUrlTest()
        {
            instance.CallConnectUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.CallConnectUrl);
        }

        /// <summary>
        /// Test the property 'StatusCallbackUrl'
        /// </summary>
        [Fact]
        public void StatusCallbackUrlTest()
        {
            instance.StatusCallbackUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.StatusCallbackUrl);
        }

        /// <summary>
        /// Test the property 'SmsUrl'
        /// </summary>
        [Fact]
        public void SmsUrlTest()
        {
            instance.SmsUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.SmsUrl);
        }

        /// <summary>
        /// Test the property 'SmsFallbackUrl'
        /// </summary>
        [Fact]
        public void SmsFallbackUrlTest()
        {
            instance.SmsFallbackUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.SmsFallbackUrl);
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
