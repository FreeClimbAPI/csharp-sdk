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

namespace freeclimb.Test.Enums
{
    /// <summary>
    ///  Class for testing ConferenceStatus
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>

    public class ConferenceStatusTests : IDisposable
    {
        private ConferenceStatus instance;

        public ConferenceStatusTests()
        {
            instance = new ConferenceStatus();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ConferenceStatus
        /// </summary>
        [Fact]
        public void ConferenceStatusInstanceTest()
        {
            Assert.IsType<ConferenceStatus>(instance);
        }

        [Fact]
        public void TestEMPTYShouldWork()
        {
            ConferenceStatus test = ConferenceStatus.EMPTY;
            Assert.Equal(typeof(ConferenceStatus), test.GetType());
        }

        [Fact]
        public void TestEMPTYShouldSerializeToEnum()
        {
            ConferenceStatus expectedValue = ConferenceStatus.EMPTY;
            ConferenceStatus calculatedValue = (ConferenceStatus)
                Enum.Parse(typeof(ConferenceStatus), "EMPTY");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestEMPTYShouldDeserializeToString()
        {
            ConferenceStatus test = ConferenceStatus.EMPTY;
            string expectedValue = "EMPTY";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestPOPULATEDShouldWork()
        {
            ConferenceStatus test = ConferenceStatus.POPULATED;
            Assert.Equal(typeof(ConferenceStatus), test.GetType());
        }

        [Fact]
        public void TestPOPULATEDShouldSerializeToEnum()
        {
            ConferenceStatus expectedValue = ConferenceStatus.POPULATED;
            ConferenceStatus calculatedValue = (ConferenceStatus)
                Enum.Parse(typeof(ConferenceStatus), "POPULATED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestPOPULATEDShouldDeserializeToString()
        {
            ConferenceStatus test = ConferenceStatus.POPULATED;
            string expectedValue = "POPULATED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestIN_PROGRESSShouldWork()
        {
            ConferenceStatus test = ConferenceStatus.IN_PROGRESS;
            Assert.Equal(typeof(ConferenceStatus), test.GetType());
        }

        [Fact]
        public void TestIN_PROGRESSShouldSerializeToEnum()
        {
            ConferenceStatus expectedValue = ConferenceStatus.IN_PROGRESS;
            ConferenceStatus calculatedValue = (ConferenceStatus)
                Enum.Parse(typeof(ConferenceStatus), "IN_PROGRESS");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestIN_PROGRESSShouldDeserializeToString()
        {
            ConferenceStatus test = ConferenceStatus.IN_PROGRESS;
            string expectedValue = "IN_PROGRESS";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestTERMINATEDShouldWork()
        {
            ConferenceStatus test = ConferenceStatus.TERMINATED;
            Assert.Equal(typeof(ConferenceStatus), test.GetType());
        }

        [Fact]
        public void TestTERMINATEDShouldSerializeToEnum()
        {
            ConferenceStatus expectedValue = ConferenceStatus.TERMINATED;
            ConferenceStatus calculatedValue = (ConferenceStatus)
                Enum.Parse(typeof(ConferenceStatus), "TERMINATED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestTERMINATEDShouldDeserializeToString()
        {
            ConferenceStatus test = ConferenceStatus.TERMINATED;
            string expectedValue = "TERMINATED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }
    }
}
