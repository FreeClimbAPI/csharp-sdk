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
    ///  Class for testing MakeCallRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>

    public class MakeCallRequestTests : IDisposable
    {
        private MakeCallRequest instance;

        public MakeCallRequestTests()
        {
            instance = new MakeCallRequest(
                from: (string)TestHelpers.getTestValue(typeof(string)),
                to: (string)TestHelpers.getTestValue(typeof(string)),
                applicationId: (string)TestHelpers.getTestValue(typeof(string)),
                sendDigits: (string)TestHelpers.getTestValue(typeof(string)),
                ifMachine: (string)TestHelpers.getTestValue(typeof(string)),
                ifMachineUrl: (string)TestHelpers.getTestValue(typeof(string)),
                timeout: (int)TestHelpers.getTestValue(typeof(int)),
                parentCallId: (string)TestHelpers.getTestValue(typeof(string)),
                privacyMode: (bool)TestHelpers.getTestValue(typeof(bool)),
                callConnectUrl: (string)TestHelpers.getTestValue(typeof(string))
            );
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MakeCallRequest
        /// </summary>
        [Fact]
        public void MakeCallRequestInstanceTest()
        {
            Assert.IsType<MakeCallRequest>(instance);
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
        /// Test the property 'ApplicationId'
        /// </summary>
        [Fact]
        public void ApplicationIdTest()
        {
            instance.ApplicationId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.ApplicationId);
        }

        /// <summary>
        /// Test the property 'SendDigits'
        /// </summary>
        [Fact]
        public void SendDigitsTest()
        {
            instance.SendDigits = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.SendDigits);
        }

        /// <summary>
        /// Test the property 'IfMachine'
        /// </summary>
        [Fact]
        public void IfMachineTest()
        {
            instance.IfMachine = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.IfMachine);
        }

        /// <summary>
        /// Test the property 'IfMachineUrl'
        /// </summary>
        [Fact]
        public void IfMachineUrlTest()
        {
            instance.IfMachineUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.IfMachineUrl);
        }

        /// <summary>
        /// Test the property 'Timeout'
        /// </summary>
        [Fact]
        public void TimeoutTest()
        {
            instance.Timeout = 1;
            Assert.Equal(1, (int)instance.Timeout);
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

        /// <summary>
        /// Test the property 'CallConnectUrl'
        /// </summary>
        [Fact]
        public void CallConnectUrlTest()
        {
            instance.CallConnectUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.CallConnectUrl);
        }
    }
}
