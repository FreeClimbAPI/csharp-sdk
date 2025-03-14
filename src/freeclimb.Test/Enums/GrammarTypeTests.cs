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
    ///  Class for testing GrammarType
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>

    public class GrammarTypeTests : IDisposable
    {
        private GrammarType instance;

        public GrammarTypeTests()
        {
            instance = new GrammarType();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GrammarType
        /// </summary>
        [Fact]
        public void GrammarTypeInstanceTest()
        {
            Assert.IsType<GrammarType>(instance);
        }

        [Fact]
        public void TestURLShouldWork()
        {
            GrammarType test = GrammarType.URL;
            Assert.Equal(typeof(GrammarType), test.GetType());
        }

        [Fact]
        public void TestURLShouldSerializeToEnum()
        {
            GrammarType expectedValue = GrammarType.URL;
            GrammarType calculatedValue = (GrammarType)Enum.Parse(typeof(GrammarType), "URL");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestURLShouldDeserializeToString()
        {
            GrammarType test = GrammarType.URL;
            string expectedValue = "URL";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestBUILT_INShouldWork()
        {
            GrammarType test = GrammarType.BUILT_IN;
            Assert.Equal(typeof(GrammarType), test.GetType());
        }

        [Fact]
        public void TestBUILT_INShouldSerializeToEnum()
        {
            GrammarType expectedValue = GrammarType.BUILT_IN;
            GrammarType calculatedValue = (GrammarType)Enum.Parse(typeof(GrammarType), "BUILT_IN");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestBUILT_INShouldDeserializeToString()
        {
            GrammarType test = GrammarType.BUILT_IN;
            string expectedValue = "BUILT_IN";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }
    }
}
