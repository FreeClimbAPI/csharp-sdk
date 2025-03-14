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
    ///  Class for testing SMSTenDLCBrandAltBusinessIdType
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>

    public class SMSTenDLCBrandAltBusinessIdTypeTests : IDisposable
    {
        private SMSTenDLCBrandAltBusinessIdType instance;

        public SMSTenDLCBrandAltBusinessIdTypeTests()
        {
            instance = new SMSTenDLCBrandAltBusinessIdType();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SMSTenDLCBrandAltBusinessIdType
        /// </summary>
        [Fact]
        public void SMSTenDLCBrandAltBusinessIdTypeInstanceTest()
        {
            Assert.IsType<SMSTenDLCBrandAltBusinessIdType>(instance);
        }

        [Fact]
        public void TestNONEShouldWork()
        {
            SMSTenDLCBrandAltBusinessIdType test = SMSTenDLCBrandAltBusinessIdType.NONE;
            Assert.Equal(typeof(SMSTenDLCBrandAltBusinessIdType), test.GetType());
        }

        [Fact]
        public void TestNONEShouldSerializeToEnum()
        {
            SMSTenDLCBrandAltBusinessIdType expectedValue = SMSTenDLCBrandAltBusinessIdType.NONE;
            SMSTenDLCBrandAltBusinessIdType calculatedValue = (SMSTenDLCBrandAltBusinessIdType)
                Enum.Parse(typeof(SMSTenDLCBrandAltBusinessIdType), "NONE");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestNONEShouldDeserializeToString()
        {
            SMSTenDLCBrandAltBusinessIdType test = SMSTenDLCBrandAltBusinessIdType.NONE;
            string expectedValue = "NONE";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDUNSShouldWork()
        {
            SMSTenDLCBrandAltBusinessIdType test = SMSTenDLCBrandAltBusinessIdType.DUNS;
            Assert.Equal(typeof(SMSTenDLCBrandAltBusinessIdType), test.GetType());
        }

        [Fact]
        public void TestDUNSShouldSerializeToEnum()
        {
            SMSTenDLCBrandAltBusinessIdType expectedValue = SMSTenDLCBrandAltBusinessIdType.DUNS;
            SMSTenDLCBrandAltBusinessIdType calculatedValue = (SMSTenDLCBrandAltBusinessIdType)
                Enum.Parse(typeof(SMSTenDLCBrandAltBusinessIdType), "DUNS");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDUNSShouldDeserializeToString()
        {
            SMSTenDLCBrandAltBusinessIdType test = SMSTenDLCBrandAltBusinessIdType.DUNS;
            string expectedValue = "DUNS";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestGIINShouldWork()
        {
            SMSTenDLCBrandAltBusinessIdType test = SMSTenDLCBrandAltBusinessIdType.GIIN;
            Assert.Equal(typeof(SMSTenDLCBrandAltBusinessIdType), test.GetType());
        }

        [Fact]
        public void TestGIINShouldSerializeToEnum()
        {
            SMSTenDLCBrandAltBusinessIdType expectedValue = SMSTenDLCBrandAltBusinessIdType.GIIN;
            SMSTenDLCBrandAltBusinessIdType calculatedValue = (SMSTenDLCBrandAltBusinessIdType)
                Enum.Parse(typeof(SMSTenDLCBrandAltBusinessIdType), "GIIN");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestGIINShouldDeserializeToString()
        {
            SMSTenDLCBrandAltBusinessIdType test = SMSTenDLCBrandAltBusinessIdType.GIIN;
            string expectedValue = "GIIN";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestLEIShouldWork()
        {
            SMSTenDLCBrandAltBusinessIdType test = SMSTenDLCBrandAltBusinessIdType.LEI;
            Assert.Equal(typeof(SMSTenDLCBrandAltBusinessIdType), test.GetType());
        }

        [Fact]
        public void TestLEIShouldSerializeToEnum()
        {
            SMSTenDLCBrandAltBusinessIdType expectedValue = SMSTenDLCBrandAltBusinessIdType.LEI;
            SMSTenDLCBrandAltBusinessIdType calculatedValue = (SMSTenDLCBrandAltBusinessIdType)
                Enum.Parse(typeof(SMSTenDLCBrandAltBusinessIdType), "LEI");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestLEIShouldDeserializeToString()
        {
            SMSTenDLCBrandAltBusinessIdType test = SMSTenDLCBrandAltBusinessIdType.LEI;
            string expectedValue = "LEI";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }
    }
}
