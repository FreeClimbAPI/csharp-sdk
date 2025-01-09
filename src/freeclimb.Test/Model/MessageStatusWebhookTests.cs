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
    ///  Class for testing MessageStatusWebhook
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>

    public class MessageStatusWebhookTests : IDisposable
    {
        private MessageStatusWebhook instance;

        public MessageStatusWebhookTests()
        {
            instance = new MessageStatusWebhook(
                requestType: (string)TestHelpers.getTestValue(typeof(string)),
                accountId: (string)TestHelpers.getTestValue(typeof(string)),
                messageId: (string)TestHelpers.getTestValue(typeof(string)),
                callId: (string)TestHelpers.getTestValue(typeof(string)),
                from: (string)TestHelpers.getTestValue(typeof(string)),
                to: (string)TestHelpers.getTestValue(typeof(string)),
                text: (string)TestHelpers.getTestValue(typeof(string)),
                direction: (string)TestHelpers.getTestValue(typeof(string)),
                applicationId: (string)TestHelpers.getTestValue(typeof(string)),
                status: (MessageStatus)TestHelpers.getTestValue(typeof(MessageStatus)),
                phoneNumberId: (string)TestHelpers.getTestValue(typeof(string))
            );
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MessageStatusWebhook
        /// </summary>
        [Fact]
        public void MessageStatusWebhookInstanceTest()
        {
            Assert.IsType<MessageStatusWebhook>(instance);
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
        /// Test the property 'MessageId'
        /// </summary>
        [Fact]
        public void MessageIdTest()
        {
            instance.MessageId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.MessageId);
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
        /// Test the property 'Text'
        /// </summary>
        [Fact]
        public void TextTest()
        {
            instance.Text = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Text);
        }

        /// <summary>
        /// Test the property 'Direction'
        /// </summary>
        [Fact]
        public void DirectionTest()
        {
            instance.Direction = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Direction);
        }

        /// <summary>
        /// Test the property 'ApplicationId'
        /// </summary>
        [Fact]
        public void ApplicationIdTest()
        {
            instance.ApplicationId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.ApplicationId);
        }

        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            instance.Status = MessageStatus.NEW;
            Assert.Equal(MessageStatus.NEW, instance.Status);
            instance.Status = MessageStatus.QUEUED;
            Assert.Equal(MessageStatus.QUEUED, instance.Status);
            instance.Status = MessageStatus.REJECTED;
            Assert.Equal(MessageStatus.REJECTED, instance.Status);
            instance.Status = MessageStatus.SENDING;
            Assert.Equal(MessageStatus.SENDING, instance.Status);
            instance.Status = MessageStatus.SENT;
            Assert.Equal(MessageStatus.SENT, instance.Status);
            instance.Status = MessageStatus.FAILED;
            Assert.Equal(MessageStatus.FAILED, instance.Status);
            instance.Status = MessageStatus.RECEIVED;
            Assert.Equal(MessageStatus.RECEIVED, instance.Status);
            instance.Status = MessageStatus.UNDELIVERED;
            Assert.Equal(MessageStatus.UNDELIVERED, instance.Status);
            instance.Status = MessageStatus.EXPIRED;
            Assert.Equal(MessageStatus.EXPIRED, instance.Status);
            instance.Status = MessageStatus.DELETED;
            Assert.Equal(MessageStatus.DELETED, instance.Status);
            instance.Status = MessageStatus.UNKNOWN;
            Assert.Equal(MessageStatus.UNKNOWN, instance.Status);
        }

        /// <summary>
        /// Test the property 'PhoneNumberId'
        /// </summary>
        [Fact]
        public void PhoneNumberIdTest()
        {
            instance.PhoneNumberId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.PhoneNumberId);
        }

        [Fact]
        public void TestDeserializeJsonToMessageStatusWebhook()
        {
            string payload = @"{ ""requestType"": ""messageStatus"" }";
            MessageStatusWebhook deserialized = MessageStatusWebhook.Deserialize(payload);
            Assert.IsType<MessageStatusWebhook>(deserialized);
            Assert.Equal("messageStatus", deserialized.RequestType);
        }
    }
}
