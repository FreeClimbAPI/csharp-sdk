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
    ///  Class for testing SMSTenDLCBrandEntityType
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>

    public class SMSTenDLCBrandEntityTypeTests : IDisposable
    {
        private SMSTenDLCBrandEntityType instance;

        public SMSTenDLCBrandEntityTypeTests()
        {
            instance = new SMSTenDLCBrandEntityType();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SMSTenDLCBrandEntityType
        /// </summary>
        [Fact]
        public void SMSTenDLCBrandEntityTypeInstanceTest()
        {
            Assert.IsType<SMSTenDLCBrandEntityType>(instance);
        }

        [Fact]
        public void TestPRIVATE_PROFITShouldWork()
        {
            SMSTenDLCBrandEntityType test = SMSTenDLCBrandEntityType.PRIVATE_PROFIT;
            Assert.Equal(typeof(SMSTenDLCBrandEntityType), test.GetType());
        }

        [Fact]
        public void TestPRIVATE_PROFITShouldSerializeToEnum()
        {
            SMSTenDLCBrandEntityType expectedValue = SMSTenDLCBrandEntityType.PRIVATE_PROFIT;
            SMSTenDLCBrandEntityType calculatedValue = (SMSTenDLCBrandEntityType)
                Enum.Parse(typeof(SMSTenDLCBrandEntityType), "PRIVATE_PROFIT");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestPRIVATE_PROFITShouldDeserializeToString()
        {
            SMSTenDLCBrandEntityType test = SMSTenDLCBrandEntityType.PRIVATE_PROFIT;
            string expectedValue = "PRIVATE_PROFIT";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestPUBLIC_PROFITShouldWork()
        {
            SMSTenDLCBrandEntityType test = SMSTenDLCBrandEntityType.PUBLIC_PROFIT;
            Assert.Equal(typeof(SMSTenDLCBrandEntityType), test.GetType());
        }

        [Fact]
        public void TestPUBLIC_PROFITShouldSerializeToEnum()
        {
            SMSTenDLCBrandEntityType expectedValue = SMSTenDLCBrandEntityType.PUBLIC_PROFIT;
            SMSTenDLCBrandEntityType calculatedValue = (SMSTenDLCBrandEntityType)
                Enum.Parse(typeof(SMSTenDLCBrandEntityType), "PUBLIC_PROFIT");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestPUBLIC_PROFITShouldDeserializeToString()
        {
            SMSTenDLCBrandEntityType test = SMSTenDLCBrandEntityType.PUBLIC_PROFIT;
            string expectedValue = "PUBLIC_PROFIT";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestNON_PROFITShouldWork()
        {
            SMSTenDLCBrandEntityType test = SMSTenDLCBrandEntityType.NON_PROFIT;
            Assert.Equal(typeof(SMSTenDLCBrandEntityType), test.GetType());
        }

        [Fact]
        public void TestNON_PROFITShouldSerializeToEnum()
        {
            SMSTenDLCBrandEntityType expectedValue = SMSTenDLCBrandEntityType.NON_PROFIT;
            SMSTenDLCBrandEntityType calculatedValue = (SMSTenDLCBrandEntityType)
                Enum.Parse(typeof(SMSTenDLCBrandEntityType), "NON_PROFIT");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestNON_PROFITShouldDeserializeToString()
        {
            SMSTenDLCBrandEntityType test = SMSTenDLCBrandEntityType.NON_PROFIT;
            string expectedValue = "NON_PROFIT";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestGOVERNMENTShouldWork()
        {
            SMSTenDLCBrandEntityType test = SMSTenDLCBrandEntityType.GOVERNMENT;
            Assert.Equal(typeof(SMSTenDLCBrandEntityType), test.GetType());
        }

        [Fact]
        public void TestGOVERNMENTShouldSerializeToEnum()
        {
            SMSTenDLCBrandEntityType expectedValue = SMSTenDLCBrandEntityType.GOVERNMENT;
            SMSTenDLCBrandEntityType calculatedValue = (SMSTenDLCBrandEntityType)
                Enum.Parse(typeof(SMSTenDLCBrandEntityType), "GOVERNMENT");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestGOVERNMENTShouldDeserializeToString()
        {
            SMSTenDLCBrandEntityType test = SMSTenDLCBrandEntityType.GOVERNMENT;
            string expectedValue = "GOVERNMENT";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestSOLE_PROPRIETORShouldWork()
        {
            SMSTenDLCBrandEntityType test = SMSTenDLCBrandEntityType.SOLE_PROPRIETOR;
            Assert.Equal(typeof(SMSTenDLCBrandEntityType), test.GetType());
        }

        [Fact]
        public void TestSOLE_PROPRIETORShouldSerializeToEnum()
        {
            SMSTenDLCBrandEntityType expectedValue = SMSTenDLCBrandEntityType.SOLE_PROPRIETOR;
            SMSTenDLCBrandEntityType calculatedValue = (SMSTenDLCBrandEntityType)
                Enum.Parse(typeof(SMSTenDLCBrandEntityType), "SOLE_PROPRIETOR");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestSOLE_PROPRIETORShouldDeserializeToString()
        {
            SMSTenDLCBrandEntityType test = SMSTenDLCBrandEntityType.SOLE_PROPRIETOR;
            string expectedValue = "SOLE_PROPRIETOR";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }
    }
}
