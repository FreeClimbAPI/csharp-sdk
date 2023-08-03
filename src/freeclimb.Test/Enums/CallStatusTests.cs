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
    ///  Class for testing CallStatus
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CallStatusTests
    {
        private CallStatus instance;

        public CallStatusTests()
        {
            instance = new CallStatus();
        }

        /// <summary>
        /// Test an instance of CallStatus
        /// </summary>
        [Fact]
        public void CallStatusInstanceTest()
        {
            Assert.IsType<CallStatus>(instance);
        }


        [Fact]
        public void TestQUEUEDShouldWork()
        {
            CallStatus test = CallStatus.QUEUED;
            Assert.Equal(typeof(CallStatus), test.GetType());
        }

        [Fact]
        public void TestQUEUEDShouldSerializeToEnum()
        {
            CallStatus expectedValue = CallStatus.QUEUED;
            CallStatus calculatedValue = (CallStatus)Enum.Parse(typeof(CallStatus), "QUEUED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestQUEUEDShouldDeserializeToString()
        {
            CallStatus test = CallStatus.QUEUED;
            string expectedValue = "QUEUED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestRINGINGShouldWork()
        {
            CallStatus test = CallStatus.RINGING;
            Assert.Equal(typeof(CallStatus), test.GetType());
        }

        [Fact]
        public void TestRINGINGShouldSerializeToEnum()
        {
            CallStatus expectedValue = CallStatus.RINGING;
            CallStatus calculatedValue = (CallStatus)Enum.Parse(typeof(CallStatus), "RINGING");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestRINGINGShouldDeserializeToString()
        {
            CallStatus test = CallStatus.RINGING;
            string expectedValue = "RINGING";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestIN_PROGRESSShouldWork()
        {
            CallStatus test = CallStatus.IN_PROGRESS;
            Assert.Equal(typeof(CallStatus), test.GetType());
        }

        [Fact]
        public void TestIN_PROGRESSShouldSerializeToEnum()
        {
            CallStatus expectedValue = CallStatus.IN_PROGRESS;
            CallStatus calculatedValue = (CallStatus)Enum.Parse(typeof(CallStatus), "IN_PROGRESS");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestIN_PROGRESSShouldDeserializeToString()
        {
            CallStatus test = CallStatus.IN_PROGRESS;
            string expectedValue = "IN_PROGRESS";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestCANCELEDShouldWork()
        {
            CallStatus test = CallStatus.CANCELED;
            Assert.Equal(typeof(CallStatus), test.GetType());
        }

        [Fact]
        public void TestCANCELEDShouldSerializeToEnum()
        {
            CallStatus expectedValue = CallStatus.CANCELED;
            CallStatus calculatedValue = (CallStatus)Enum.Parse(typeof(CallStatus), "CANCELED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestCANCELEDShouldDeserializeToString()
        {
            CallStatus test = CallStatus.CANCELED;
            string expectedValue = "CANCELED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestCOMPLETEDShouldWork()
        {
            CallStatus test = CallStatus.COMPLETED;
            Assert.Equal(typeof(CallStatus), test.GetType());
        }

        [Fact]
        public void TestCOMPLETEDShouldSerializeToEnum()
        {
            CallStatus expectedValue = CallStatus.COMPLETED;
            CallStatus calculatedValue = (CallStatus)Enum.Parse(typeof(CallStatus), "COMPLETED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestCOMPLETEDShouldDeserializeToString()
        {
            CallStatus test = CallStatus.COMPLETED;
            string expectedValue = "COMPLETED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestFAILEDShouldWork()
        {
            CallStatus test = CallStatus.FAILED;
            Assert.Equal(typeof(CallStatus), test.GetType());
        }

        [Fact]
        public void TestFAILEDShouldSerializeToEnum()
        {
            CallStatus expectedValue = CallStatus.FAILED;
            CallStatus calculatedValue = (CallStatus)Enum.Parse(typeof(CallStatus), "FAILED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestFAILEDShouldDeserializeToString()
        {
            CallStatus test = CallStatus.FAILED;
            string expectedValue = "FAILED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestBUSYShouldWork()
        {
            CallStatus test = CallStatus.BUSY;
            Assert.Equal(typeof(CallStatus), test.GetType());
        }

        [Fact]
        public void TestBUSYShouldSerializeToEnum()
        {
            CallStatus expectedValue = CallStatus.BUSY;
            CallStatus calculatedValue = (CallStatus)Enum.Parse(typeof(CallStatus), "BUSY");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestBUSYShouldDeserializeToString()
        {
            CallStatus test = CallStatus.BUSY;
            string expectedValue = "BUSY";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestNO_ANSWERShouldWork()
        {
            CallStatus test = CallStatus.NO_ANSWER;
            Assert.Equal(typeof(CallStatus), test.GetType());
        }

        [Fact]
        public void TestNO_ANSWERShouldSerializeToEnum()
        {
            CallStatus expectedValue = CallStatus.NO_ANSWER;
            CallStatus calculatedValue = (CallStatus)Enum.Parse(typeof(CallStatus), "NO_ANSWER");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestNO_ANSWERShouldDeserializeToString()
        {
            CallStatus test = CallStatus.NO_ANSWER;
            string expectedValue = "NO_ANSWER";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

    }
}
