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
                alias: (string)TestHelpers.getTestValue(typeof(string)),
                voiceUrl: (string)TestHelpers.getTestValue(typeof(string)),
                voiceFallbackUrl: (string)TestHelpers.getTestValue(typeof(string)),
                callConnectUrl: (string)TestHelpers.getTestValue(typeof(string)),
                statusCallbackUrl: (string)TestHelpers.getTestValue(typeof(string)),
                smsUrl: (string)TestHelpers.getTestValue(typeof(string)),
                smsFallbackUrl: (string)TestHelpers.getTestValue(typeof(string))
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
    }
}
