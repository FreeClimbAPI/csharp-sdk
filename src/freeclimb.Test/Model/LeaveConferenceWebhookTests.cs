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
    ///  Class for testing LeaveConferenceWebhook
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>

    public class LeaveConferenceWebhookTests : IDisposable
    {
        private LeaveConferenceWebhook instance;

        public LeaveConferenceWebhookTests()
        {
            instance = new LeaveConferenceWebhook(
                requestType: (string)TestHelpers.getTestValue(typeof(string)),
                callId: (string)TestHelpers.getTestValue(typeof(string)),
                accountId: (string)TestHelpers.getTestValue(typeof(string)),
                from: (string)TestHelpers.getTestValue(typeof(string)),
                to: (string)TestHelpers.getTestValue(typeof(string)),
                callStatus: (CallStatus)TestHelpers.getTestValue(typeof(CallStatus)),
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
        /// Test an instance of LeaveConferenceWebhook
        /// </summary>
        [Fact]
        public void LeaveConferenceWebhookInstanceTest()
        {
            Assert.IsType<LeaveConferenceWebhook>(instance);
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
        public void TestDeserializeJsonToLeaveConferenceWebhook()
        {
            string payload = @"{ ""requestType"": ""leaveConference"" }";
            LeaveConferenceWebhook deserialized = LeaveConferenceWebhook.Deserialize(payload);
            Assert.IsType<LeaveConferenceWebhook>(deserialized);
            Assert.Equal("leaveConference", deserialized.RequestType);
        }
    }
}
