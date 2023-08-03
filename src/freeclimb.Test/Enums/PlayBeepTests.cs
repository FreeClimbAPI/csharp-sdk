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
    ///  Class for testing PlayBeep
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PlayBeepTests
    {
        private PlayBeep instance;

        public PlayBeepTests()
        {
            instance = new PlayBeep();
        }

        /// <summary>
        /// Test an instance of PlayBeep
        /// </summary>
        [Fact]
        public void PlayBeepInstanceTest()
        {
            Assert.IsType<PlayBeep>(instance);
        }


        [Fact]
        public void TestALWAYSShouldWork()
        {
            PlayBeep test = PlayBeep.ALWAYS;
            Assert.Equal(typeof(PlayBeep), test.GetType());
        }

        [Fact]
        public void TestALWAYSShouldSerializeToEnum()
        {
            PlayBeep expectedValue = PlayBeep.ALWAYS;
            PlayBeep calculatedValue = (PlayBeep)Enum.Parse(typeof(PlayBeep), "ALWAYS");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestALWAYSShouldDeserializeToString()
        {
            PlayBeep test = PlayBeep.ALWAYS;
            string expectedValue = "ALWAYS";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestNEVERShouldWork()
        {
            PlayBeep test = PlayBeep.NEVER;
            Assert.Equal(typeof(PlayBeep), test.GetType());
        }

        [Fact]
        public void TestNEVERShouldSerializeToEnum()
        {
            PlayBeep expectedValue = PlayBeep.NEVER;
            PlayBeep calculatedValue = (PlayBeep)Enum.Parse(typeof(PlayBeep), "NEVER");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestNEVERShouldDeserializeToString()
        {
            PlayBeep test = PlayBeep.NEVER;
            string expectedValue = "NEVER";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestENTRY_ONLYShouldWork()
        {
            PlayBeep test = PlayBeep.ENTRY_ONLY;
            Assert.Equal(typeof(PlayBeep), test.GetType());
        }

        [Fact]
        public void TestENTRY_ONLYShouldSerializeToEnum()
        {
            PlayBeep expectedValue = PlayBeep.ENTRY_ONLY;
            PlayBeep calculatedValue = (PlayBeep)Enum.Parse(typeof(PlayBeep), "ENTRY_ONLY");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestENTRY_ONLYShouldDeserializeToString()
        {
            PlayBeep test = PlayBeep.ENTRY_ONLY;
            string expectedValue = "ENTRY_ONLY";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestEXIT_ONLYShouldWork()
        {
            PlayBeep test = PlayBeep.EXIT_ONLY;
            Assert.Equal(typeof(PlayBeep), test.GetType());
        }

        [Fact]
        public void TestEXIT_ONLYShouldSerializeToEnum()
        {
            PlayBeep expectedValue = PlayBeep.EXIT_ONLY;
            PlayBeep calculatedValue = (PlayBeep)Enum.Parse(typeof(PlayBeep), "EXIT_ONLY");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestEXIT_ONLYShouldDeserializeToString()
        {
            PlayBeep test = PlayBeep.EXIT_ONLY;
            string expectedValue = "EXIT_ONLY";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

    }
}
