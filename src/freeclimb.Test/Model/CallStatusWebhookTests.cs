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
    ///  Class for testing CallStatusWebhook
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>

    public class CallStatusWebhookTests : IDisposable
    {
        private CallStatusWebhook instance;

        public CallStatusWebhookTests()
        {
            instance = new CallStatusWebhook(
                requestType: (string)TestHelpers.getTestValue(typeof(string)),
                callId: (string)TestHelpers.getTestValue(typeof(string)),
                accountId: (string)TestHelpers.getTestValue(typeof(string)),
                from: (string)TestHelpers.getTestValue(typeof(string)),
                to: (string)TestHelpers.getTestValue(typeof(string)),
                callStatus: (CallStatus)TestHelpers.getTestValue(typeof(CallStatus)),
                callEndedReason: (CallEndedReason)TestHelpers.getTestValue(typeof(CallEndedReason)),
                direction: (CallDirection)TestHelpers.getTestValue(typeof(CallDirection)),
                conferenceId: (string)TestHelpers.getTestValue(typeof(string)),
                queueId: (string)TestHelpers.getTestValue(typeof(string))
            );
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CallStatusWebhook
        /// </summary>
        [Fact]
        public void CallStatusWebhookInstanceTest()
        {
            Assert.IsType<CallStatusWebhook>(instance);
        }

        /// <summary>
        /// Test the property 'RequestType'
        /// </summary>
        [Fact]
        public void RequestTypeTest() { }

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
        /// Test the property 'AccountId'
        /// </summary>
        [Fact]
        public void AccountIdTest()
        {
            instance.AccountId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.AccountId);
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
        /// Test the property 'CallEndedReason'
        /// </summary>
        [Fact]
        public void CallEndedReasonTest()
        {
            instance.CallEndedReason = CallEndedReason.BUSY;
            Assert.Equal(CallEndedReason.BUSY, instance.CallEndedReason);
            instance.CallEndedReason = CallEndedReason.FAILED;
            Assert.Equal(CallEndedReason.FAILED, instance.CallEndedReason);
            instance.CallEndedReason = CallEndedReason.NO_ANSWER;
            Assert.Equal(CallEndedReason.NO_ANSWER, instance.CallEndedReason);
            instance.CallEndedReason = CallEndedReason.CALL_CANCELED;
            Assert.Equal(CallEndedReason.CALL_CANCELED, instance.CallEndedReason);
            instance.CallEndedReason = CallEndedReason.FAR_END_HANGUP;
            Assert.Equal(CallEndedReason.FAR_END_HANGUP, instance.CallEndedReason);
            instance.CallEndedReason = CallEndedReason.APP_HANGUP;
            Assert.Equal(CallEndedReason.APP_HANGUP, instance.CallEndedReason);
            instance.CallEndedReason = CallEndedReason.APP_REJECT;
            Assert.Equal(CallEndedReason.APP_REJECT, instance.CallEndedReason);
            instance.CallEndedReason = CallEndedReason.APP_NO_PERCL;
            Assert.Equal(CallEndedReason.APP_NO_PERCL, instance.CallEndedReason);
            instance.CallEndedReason = CallEndedReason.APP_INVALID_PERCL;
            Assert.Equal(CallEndedReason.APP_INVALID_PERCL, instance.CallEndedReason);
            instance.CallEndedReason = CallEndedReason.CONFERENCE_TERMINATED;
            Assert.Equal(CallEndedReason.CONFERENCE_TERMINATED, instance.CallEndedReason);
            instance.CallEndedReason = CallEndedReason.CONFERENCE_EMPTIED;
            Assert.Equal(CallEndedReason.CONFERENCE_EMPTIED, instance.CallEndedReason);
            instance.CallEndedReason = CallEndedReason.REMOVED_FROM_CONFERENCE;
            Assert.Equal(CallEndedReason.REMOVED_FROM_CONFERENCE, instance.CallEndedReason);
            instance.CallEndedReason = CallEndedReason.MACHINE_DETECTED;
            Assert.Equal(CallEndedReason.MACHINE_DETECTED, instance.CallEndedReason);
            instance.CallEndedReason = CallEndedReason.WEBHOOK_FAILED;
            Assert.Equal(CallEndedReason.WEBHOOK_FAILED, instance.CallEndedReason);
            instance.CallEndedReason = CallEndedReason.WEBHOOK_INVALID_RESPONSE;
            Assert.Equal(CallEndedReason.WEBHOOK_INVALID_RESPONSE, instance.CallEndedReason);
            instance.CallEndedReason = CallEndedReason.VOICE_DISABLED;
            Assert.Equal(CallEndedReason.VOICE_DISABLED, instance.CallEndedReason);
            instance.CallEndedReason = CallEndedReason.CONFIG_ERROR_NO_APPLICATION;
            Assert.Equal(CallEndedReason.CONFIG_ERROR_NO_APPLICATION, instance.CallEndedReason);
            instance.CallEndedReason = CallEndedReason.CONFIG_ERROR_NO_VOICE_URL;
            Assert.Equal(CallEndedReason.CONFIG_ERROR_NO_VOICE_URL, instance.CallEndedReason);
            instance.CallEndedReason = CallEndedReason.MAX_REDIRECTS_ERROR;
            Assert.Equal(CallEndedReason.MAX_REDIRECTS_ERROR, instance.CallEndedReason);
            instance.CallEndedReason = CallEndedReason.PERCL_PROCESSING_ERROR;
            Assert.Equal(CallEndedReason.PERCL_PROCESSING_ERROR, instance.CallEndedReason);
            instance.CallEndedReason = CallEndedReason.INTERNAL_ERROR;
            Assert.Equal(CallEndedReason.INTERNAL_ERROR, instance.CallEndedReason);
            instance.CallEndedReason = CallEndedReason.GRPC_HANGUP;
            Assert.Equal(CallEndedReason.GRPC_HANGUP, instance.CallEndedReason);
            instance.CallEndedReason = CallEndedReason.MAX_DURATION;
            Assert.Equal(CallEndedReason.MAX_DURATION, instance.CallEndedReason);
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

        [Fact]
        public void TestDeserializeJsonToCallStatusWebhook()
        {
            string payload = @"{ ""requestType"": ""callStatus"" }";
            CallStatusWebhook deserialized = CallStatusWebhook.Deserialize(payload);
            Assert.IsType<CallStatusWebhook>(deserialized);
            Assert.Equal("callStatus", deserialized.RequestType);
        }
    }
}
