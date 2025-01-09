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
    ///  Class for testing Say
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>

    public class SayTests : IDisposable
    {
        private Say instance;

        public SayTests()
        {
            instance = new Say(
                text: (string)TestHelpers.getTestValue(typeof(string)),
                language: (string)TestHelpers.getTestValue(typeof(string)),
                loop: (int)TestHelpers.getTestValue(typeof(int)),
                privacyMode: (bool)TestHelpers.getTestValue(typeof(bool))
            );
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Say
        /// </summary>
        [Fact]
        public void SayInstanceTest()
        {
            Assert.IsType<Say>(instance);
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
        /// Test the property 'Language'
        /// </summary>
        [Fact]
        public void LanguageTest()
        {
            instance.Language = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Language);
        }

        /// <summary>
        /// Test the property 'Loop'
        /// </summary>
        [Fact]
        public void LoopTest()
        {
            instance.Loop = 1;
            Assert.Equal(1, (int)instance.Loop);
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
    }
}
