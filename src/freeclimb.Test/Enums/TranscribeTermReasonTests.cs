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
    ///  Class for testing TranscribeTermReason
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>

    public class TranscribeTermReasonTests : IDisposable
    {
        private TranscribeTermReason instance;

        public TranscribeTermReasonTests()
        {
            instance = new TranscribeTermReason();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TranscribeTermReason
        /// </summary>
        [Fact]
        public void TranscribeTermReasonInstanceTest()
        {
            Assert.IsType<TranscribeTermReason>(instance);
        }

        [Fact]
        public void TestERRORShouldWork()
        {
            TranscribeTermReason test = TranscribeTermReason.ERROR;
            Assert.Equal(typeof(TranscribeTermReason), test.GetType());
        }

        [Fact]
        public void TestERRORShouldSerializeToEnum()
        {
            TranscribeTermReason expectedValue = TranscribeTermReason.ERROR;
            TranscribeTermReason calculatedValue = (TranscribeTermReason)
                Enum.Parse(typeof(TranscribeTermReason), "ERROR");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestERRORShouldDeserializeToString()
        {
            TranscribeTermReason test = TranscribeTermReason.ERROR;
            string expectedValue = "ERROR";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestCOMPLETEDShouldWork()
        {
            TranscribeTermReason test = TranscribeTermReason.COMPLETED;
            Assert.Equal(typeof(TranscribeTermReason), test.GetType());
        }

        [Fact]
        public void TestCOMPLETEDShouldSerializeToEnum()
        {
            TranscribeTermReason expectedValue = TranscribeTermReason.COMPLETED;
            TranscribeTermReason calculatedValue = (TranscribeTermReason)
                Enum.Parse(typeof(TranscribeTermReason), "COMPLETED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestCOMPLETEDShouldDeserializeToString()
        {
            TranscribeTermReason test = TranscribeTermReason.COMPLETED;
            string expectedValue = "COMPLETED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }
    }
}