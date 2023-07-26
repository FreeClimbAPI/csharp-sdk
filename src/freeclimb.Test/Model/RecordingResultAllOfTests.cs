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


namespace freeclimb.Test.Model
{
    /// <summary>
    ///  Class for testing RecordingResultAllOf
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RecordingResultAllOfTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for RecordingResultAllOf
        private RecordingResultAllOf instance;

        public RecordingResultAllOfTests()
        {
            instance = new RecordingResultAllOf();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RecordingResultAllOf
        /// </summary>
        [Fact]
        public void RecordingResultAllOfInstanceTest()
        {
            // TODO uncomment below to test "IsType" RecordingResultAllOf
            Assert.IsType<RecordingResultAllOf>(instance);
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
        /// Test the property 'DurationSec'
        /// </summary>
        [Fact]
        public void DurationSecTest()
        {
            
            instance.DurationSec = 1;
            Assert.Equal(1, (int) instance.DurationSec);
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
    }
}
