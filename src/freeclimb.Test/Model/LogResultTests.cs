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


namespace freeclimb.Test.Model
{
    /// <summary>
    ///  Class for testing LogResult
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LogResultTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for LogResult
        private LogResult instance;

        public LogResultTests()
        {
            instance = new LogResult();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LogResult
        /// </summary>
        [Fact]
        public void LogResultInstanceTest()
        {
            // TODO uncomment below to test "IsType" LogResult
            Assert.IsType<LogResult>(instance);
        }


        /// <summary>
        /// Test the property 'Timestamp'
        /// </summary>
        [Fact]
        public void TimestampTest()
        {
            
            instance.Timestamp = 1;
            Assert.Equal(1, (int) instance.Timestamp);
        }
        /// <summary>
        /// Test the property 'Level'
        /// </summary>
        [Fact]
        public void LevelTest()
        {
            instance.Level = LogLevel.INFO;
            Assert.Equal(instance.Level,LogLevel.INFO);
            instance.Level = LogLevel.WARNING;
            Assert.Equal(instance.Level,LogLevel.WARNING);
            instance.Level = LogLevel.ERROR;
            Assert.Equal(instance.Level,LogLevel.ERROR);
            
        }
        /// <summary>
        /// Test the property 'RequestId'
        /// </summary>
        [Fact]
        public void RequestIdTest()
        {
            instance.RequestId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.RequestId);
            
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
        /// Test the property 'CallId'
        /// </summary>
        [Fact]
        public void CallIdTest()
        {
            instance.CallId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.CallId);
            
        }
        /// <summary>
        /// Test the property 'Message'
        /// </summary>
        [Fact]
        public void MessageTest()
        {
            instance.Message = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Message);
            
        }
        /// <summary>
        /// Test the property 'Metadata'
        /// </summary>
        [Fact]
        public void MetadataTest()
        {
            object testObject = new object();
            instance.Metadata = testObject;
            Assert.Equal(testObject, instance.Metadata);
            
        }
    }
}
