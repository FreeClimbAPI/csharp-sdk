/*
 * FreeClimb API
 *
 * FreeClimb is a cloud-based application programming interface (API) that puts the power of the Vail platform in your hands. FreeClimb simplifies the process of creating applications that can use a full range of telephony features without requiring specialized or on-site telephony equipment. Using the FreeClimb REST API to write applications is easy! You have the option to use the language of your choice or hit the API directly. Your application can execute a command by issuing a RESTful request to the FreeClimb API. The base URL to send HTTP requests to the FreeClimb REST API is: /apiserver. FreeClimb authenticates and processes your request.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@freeclimb.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */




using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;
using freeclimb.Api;
using freeclimb.Model;
using freeclimb.Client;
using System.Reflection;
using Newtonsoft.Json;
using System.Globalization;
using freeclimb.Enums;


namespace freeclimb.Test.Enums
{
    /// <summary>
    ///  Class for testing MessageStatus
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MessageStatusTests
    {
        private MessageStatus instance;

        public MessageStatusTests()
        {
            instance = new MessageStatus();
        }

        /// <summary>
        /// Test an instance of MessageStatus
        /// </summary>
        [Fact]
        public void MessageStatusInstanceTest()
        {
            Assert.IsType<MessageStatus>(instance);
        }


        [Fact]
        public void TestNEWShouldWork()
        {
            MessageStatus test = MessageStatus.NEW;
            Assert.Equal(typeof(MessageStatus), test.GetType());
        }

        [Fact]
        public void TestNEWShouldSerializeToEnum()
        {
            MessageStatus expectedValue = MessageStatus.NEW;
            MessageStatus calculatedValue = (MessageStatus)Enum.Parse(typeof(MessageStatus), "NEW");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestNEWShouldDeserializeToString()
        {
            MessageStatus test = MessageStatus.NEW;
            string expectedValue = "NEW";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestQUEUEDShouldWork()
        {
            MessageStatus test = MessageStatus.QUEUED;
            Assert.Equal(typeof(MessageStatus), test.GetType());
        }

        [Fact]
        public void TestQUEUEDShouldSerializeToEnum()
        {
            MessageStatus expectedValue = MessageStatus.QUEUED;
            MessageStatus calculatedValue = (MessageStatus)Enum.Parse(typeof(MessageStatus), "QUEUED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestQUEUEDShouldDeserializeToString()
        {
            MessageStatus test = MessageStatus.QUEUED;
            string expectedValue = "QUEUED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestREJECTEDShouldWork()
        {
            MessageStatus test = MessageStatus.REJECTED;
            Assert.Equal(typeof(MessageStatus), test.GetType());
        }

        [Fact]
        public void TestREJECTEDShouldSerializeToEnum()
        {
            MessageStatus expectedValue = MessageStatus.REJECTED;
            MessageStatus calculatedValue = (MessageStatus)Enum.Parse(typeof(MessageStatus), "REJECTED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestREJECTEDShouldDeserializeToString()
        {
            MessageStatus test = MessageStatus.REJECTED;
            string expectedValue = "REJECTED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestSENDINGShouldWork()
        {
            MessageStatus test = MessageStatus.SENDING;
            Assert.Equal(typeof(MessageStatus), test.GetType());
        }

        [Fact]
        public void TestSENDINGShouldSerializeToEnum()
        {
            MessageStatus expectedValue = MessageStatus.SENDING;
            MessageStatus calculatedValue = (MessageStatus)Enum.Parse(typeof(MessageStatus), "SENDING");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestSENDINGShouldDeserializeToString()
        {
            MessageStatus test = MessageStatus.SENDING;
            string expectedValue = "SENDING";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestSENTShouldWork()
        {
            MessageStatus test = MessageStatus.SENT;
            Assert.Equal(typeof(MessageStatus), test.GetType());
        }

        [Fact]
        public void TestSENTShouldSerializeToEnum()
        {
            MessageStatus expectedValue = MessageStatus.SENT;
            MessageStatus calculatedValue = (MessageStatus)Enum.Parse(typeof(MessageStatus), "SENT");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestSENTShouldDeserializeToString()
        {
            MessageStatus test = MessageStatus.SENT;
            string expectedValue = "SENT";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestFAILEDShouldWork()
        {
            MessageStatus test = MessageStatus.FAILED;
            Assert.Equal(typeof(MessageStatus), test.GetType());
        }

        [Fact]
        public void TestFAILEDShouldSerializeToEnum()
        {
            MessageStatus expectedValue = MessageStatus.FAILED;
            MessageStatus calculatedValue = (MessageStatus)Enum.Parse(typeof(MessageStatus), "FAILED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestFAILEDShouldDeserializeToString()
        {
            MessageStatus test = MessageStatus.FAILED;
            string expectedValue = "FAILED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestRECEIVEDShouldWork()
        {
            MessageStatus test = MessageStatus.RECEIVED;
            Assert.Equal(typeof(MessageStatus), test.GetType());
        }

        [Fact]
        public void TestRECEIVEDShouldSerializeToEnum()
        {
            MessageStatus expectedValue = MessageStatus.RECEIVED;
            MessageStatus calculatedValue = (MessageStatus)Enum.Parse(typeof(MessageStatus), "RECEIVED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestRECEIVEDShouldDeserializeToString()
        {
            MessageStatus test = MessageStatus.RECEIVED;
            string expectedValue = "RECEIVED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestUNDELIVEREDShouldWork()
        {
            MessageStatus test = MessageStatus.UNDELIVERED;
            Assert.Equal(typeof(MessageStatus), test.GetType());
        }

        [Fact]
        public void TestUNDELIVEREDShouldSerializeToEnum()
        {
            MessageStatus expectedValue = MessageStatus.UNDELIVERED;
            MessageStatus calculatedValue = (MessageStatus)Enum.Parse(typeof(MessageStatus), "UNDELIVERED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestUNDELIVEREDShouldDeserializeToString()
        {
            MessageStatus test = MessageStatus.UNDELIVERED;
            string expectedValue = "UNDELIVERED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestEXPIREDShouldWork()
        {
            MessageStatus test = MessageStatus.EXPIRED;
            Assert.Equal(typeof(MessageStatus), test.GetType());
        }

        [Fact]
        public void TestEXPIREDShouldSerializeToEnum()
        {
            MessageStatus expectedValue = MessageStatus.EXPIRED;
            MessageStatus calculatedValue = (MessageStatus)Enum.Parse(typeof(MessageStatus), "EXPIRED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestEXPIREDShouldDeserializeToString()
        {
            MessageStatus test = MessageStatus.EXPIRED;
            string expectedValue = "EXPIRED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDELETEDShouldWork()
        {
            MessageStatus test = MessageStatus.DELETED;
            Assert.Equal(typeof(MessageStatus), test.GetType());
        }

        [Fact]
        public void TestDELETEDShouldSerializeToEnum()
        {
            MessageStatus expectedValue = MessageStatus.DELETED;
            MessageStatus calculatedValue = (MessageStatus)Enum.Parse(typeof(MessageStatus), "DELETED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDELETEDShouldDeserializeToString()
        {
            MessageStatus test = MessageStatus.DELETED;
            string expectedValue = "DELETED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestUNKNOWNShouldWork()
        {
            MessageStatus test = MessageStatus.UNKNOWN;
            Assert.Equal(typeof(MessageStatus), test.GetType());
        }

        [Fact]
        public void TestUNKNOWNShouldSerializeToEnum()
        {
            MessageStatus expectedValue = MessageStatus.UNKNOWN;
            MessageStatus calculatedValue = (MessageStatus)Enum.Parse(typeof(MessageStatus), "UNKNOWN");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestUNKNOWNShouldDeserializeToString()
        {
            MessageStatus test = MessageStatus.UNKNOWN;
            string expectedValue = "UNKNOWN";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

    }
}
