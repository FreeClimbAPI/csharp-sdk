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
using freeclimb.Test;
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
                requestType: (string)TestHelpers.getTestValue(typeof(string)),
                accountId: (string)TestHelpers.getTestValue(typeof(string)),
                callId: (string)TestHelpers.getTestValue(typeof(string)),
                from: (string)TestHelpers.getTestValue(typeof(string)),
                to: (string)TestHelpers.getTestValue(typeof(string)),
                callStatus: (CallStatus)TestHelpers.getTestValue(typeof(CallStatus)),
                direction: (CallDirection)TestHelpers.getTestValue(typeof(CallDirection)),
                conferenceId: (string)TestHelpers.getTestValue(typeof(string)),
                queueId: (string)TestHelpers.getTestValue(typeof(string)),
                recordingId: (string)TestHelpers.getTestValue(typeof(string)),
                recordingUrl: (string)TestHelpers.getTestValue(typeof(string)),
                recordingSize: (string)TestHelpers.getTestValue(typeof(string)),
                recordingFormat: (string)TestHelpers.getTestValue(typeof(string)),
                recordingDurationSec: (int)TestHelpers.getTestValue(typeof(int)),
                termReason: (RecordUtteranceTermReason)
                    TestHelpers.getTestValue(typeof(RecordUtteranceTermReason)),
                parentCallId: (string)TestHelpers.getTestValue(typeof(string)),
                privacyMode: (bool)TestHelpers.getTestValue(typeof(bool))
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
    }
}