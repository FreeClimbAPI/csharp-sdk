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
    ///  Class for testing MessageResult
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>

    public class MessageResultTests : IDisposable
    {
        private MessageResult instance;

        public MessageResultTests()
        {
            instance = new MessageResult(
                uri: (string)TestHelpers.getTestValue(typeof(string)),
                dateCreated: (string)TestHelpers.getTestValue(typeof(string)),
                dateUpdated: (string)TestHelpers.getTestValue(typeof(string)),
                revision: (int)TestHelpers.getTestValue(typeof(int)),
                accountId: (string)TestHelpers.getTestValue(typeof(string)),
                messageId: (string)TestHelpers.getTestValue(typeof(string)),
                status: (MessageStatus)TestHelpers.getTestValue(typeof(MessageStatus)),
                from: (string)TestHelpers.getTestValue(typeof(string)),
                to: (string)TestHelpers.getTestValue(typeof(string)),
                text: (string)TestHelpers.getTestValue(typeof(string)),
                direction: (string)TestHelpers.getTestValue(typeof(string)),
                notificationUrl: (string)TestHelpers.getTestValue(typeof(string)),
                brandId: (string)TestHelpers.getTestValue(typeof(string)),
                campaignId: (string)TestHelpers.getTestValue(typeof(string)),
                segmentCount: (decimal?)TestHelpers.getTestValue(typeof(decimal?)),
                mediaUrls: (List<string>)TestHelpers.getTestValue(typeof(List<string>)),
                tfn: (TFN)TestHelpers.getTestValue(typeof(TFN)),
                phoneNumberId: (string)TestHelpers.getTestValue(typeof(string)),
                applicationId: (string)TestHelpers.getTestValue(typeof(string))
            );
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MessageResult
        /// </summary>
        [Fact]
        public void MessageResultInstanceTest()
        {
            Assert.IsType<MessageResult>(instance);
        }

        /// <summary>
        /// Test the property 'Uri'
        /// </summary>
        [Fact]
        public void UriTest()
        {
            instance.Uri = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Uri);
        }

        /// <summary>
        /// Test the property 'DateCreated'
        /// </summary>
        [Fact]
        public void DateCreatedTest()
        {
            instance.DateCreated = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.DateCreated);
        }

        /// <summary>
        /// Test the property 'DateUpdated'
        /// </summary>
        [Fact]
        public void DateUpdatedTest()
        {
            instance.DateUpdated = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.DateUpdated);
        }

        /// <summary>
        /// Test the property 'Revision'
        /// </summary>
        [Fact]
        public void RevisionTest()
        {
            instance.Revision = 1;
            Assert.Equal(1, (int)instance.Revision);
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
        /// Test the property 'MessageId'
        /// </summary>
        [Fact]
        public void MessageIdTest()
        {
            instance.MessageId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.MessageId);
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
        /// Test the property 'NotificationUrl'
        /// </summary>
        [Fact]
        public void NotificationUrlTest()
        {
            instance.NotificationUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.NotificationUrl);
        }

        /// <summary>
        /// Test the property 'BrandId'
        /// </summary>
        [Fact]
        public void BrandIdTest()
        {
            instance.BrandId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.BrandId);
        }

        /// <summary>
        /// Test the property 'CampaignId'
        /// </summary>
        [Fact]
        public void CampaignIdTest()
        {
            instance.CampaignId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.CampaignId);
        }

        /// <summary>
        /// Test the property 'SegmentCount'
        /// </summary>
        [Fact]
        public void SegmentCountTest()
        {
            instance.SegmentCount = new decimal(1.0);
            Assert.Equal(new decimal(1.0), instance.SegmentCount);
        }

        /// <summary>
        /// Test the property 'MediaUrls'
        /// </summary>
        [Fact]
        public void MediaUrlsTest()
        {
            List<string> testList = new List<string>();
            instance.MediaUrls = testList;
            Assert.Equal(instance.MediaUrls, testList);
        }

        /// <summary>
        /// Test the property 'Tfn'
        /// </summary>
        [Fact]
        public void TfnTest()
        {
            TFN testObject = (TFN)TestHelpers.getTestValue(typeof(TFN));
            instance.Tfn = testObject;
            Assert.Equal(testObject, instance.Tfn);
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

        /// <summary>
        /// Test the property 'ApplicationId'
        /// </summary>
        [Fact]
        public void ApplicationIdTest()
        {
            instance.ApplicationId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.ApplicationId);
        }
    }
}
