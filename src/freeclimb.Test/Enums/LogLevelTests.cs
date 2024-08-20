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
    ///  Class for testing LogLevel
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LogLevelTests
    {
        private LogLevel instance;

        public LogLevelTests()
        {
            instance = new LogLevel();
            
        }

        /// <summary>
        /// Test an instance of LogLevel
        /// </summary>
        [Fact]
        public void LogLevelInstanceTest()
        {
            Assert.IsType<LogLevel>(instance);
        }


        [Fact]
        public void TestINFOShouldWork()
        {
            LogLevel test = LogLevel.INFO;
            Assert.Equal(typeof(LogLevel), test.GetType());
        }

        [Fact]
        public void TestINFOShouldSerializeToEnum()
        {
            LogLevel expectedValue = LogLevel.INFO;
            LogLevel calculatedValue = (LogLevel)Enum.Parse(typeof(LogLevel), "INFO");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestINFOShouldDeserializeToString()
        {
            LogLevel test = LogLevel.INFO;
            string expectedValue = "INFO";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestWARNINGShouldWork()
        {
            LogLevel test = LogLevel.WARNING;
            Assert.Equal(typeof(LogLevel), test.GetType());
        }

        [Fact]
        public void TestWARNINGShouldSerializeToEnum()
        {
            LogLevel expectedValue = LogLevel.WARNING;
            LogLevel calculatedValue = (LogLevel)Enum.Parse(typeof(LogLevel), "WARNING");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestWARNINGShouldDeserializeToString()
        {
            LogLevel test = LogLevel.WARNING;
            string expectedValue = "WARNING";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestERRORShouldWork()
        {
            LogLevel test = LogLevel.ERROR;
            Assert.Equal(typeof(LogLevel), test.GetType());
        }

        [Fact]
        public void TestERRORShouldSerializeToEnum()
        {
            LogLevel expectedValue = LogLevel.ERROR;
            LogLevel calculatedValue = (LogLevel)Enum.Parse(typeof(LogLevel), "ERROR");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestERRORShouldDeserializeToString()
        {
            LogLevel test = LogLevel.ERROR;
            string expectedValue = "ERROR";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

    }
}
