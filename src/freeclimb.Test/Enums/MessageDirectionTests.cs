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
    ///  Class for testing MessageDirection
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MessageDirectionTests
    {
        private MessageDirection instance;

        public MessageDirectionTests()
        {
            instance = new MessageDirection();
        }

        /// <summary>
        /// Test an instance of MessageDirection
        /// </summary>
        [Fact]
        public void MessageDirectionInstanceTest()
        {
            Assert.IsType<MessageDirection>(instance);
        }


        [Fact]
        public void TestINBOUNDShouldWork()
        {
            MessageDirection test = MessageDirection.INBOUND;
            Assert.Equal(typeof(MessageDirection), test.GetType());
        }

        [Fact]
        public void TestINBOUNDShouldSerializeToEnum()
        {
            MessageDirection expectedValue = MessageDirection.INBOUND;
            MessageDirection calculatedValue = (MessageDirection)Enum.Parse(typeof(MessageDirection), "INBOUND");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestINBOUNDShouldDeserializeToString()
        {
            MessageDirection test = MessageDirection.INBOUND;
            string expectedValue = "INBOUND";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestOUTBOUNDShouldWork()
        {
            MessageDirection test = MessageDirection.OUTBOUND;
            Assert.Equal(typeof(MessageDirection), test.GetType());
        }

        [Fact]
        public void TestOUTBOUNDShouldSerializeToEnum()
        {
            MessageDirection expectedValue = MessageDirection.OUTBOUND;
            MessageDirection calculatedValue = (MessageDirection)Enum.Parse(typeof(MessageDirection), "OUTBOUND");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestOUTBOUNDShouldDeserializeToString()
        {
            MessageDirection test = MessageDirection.OUTBOUND;
            string expectedValue = "OUTBOUND";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

    }
}
