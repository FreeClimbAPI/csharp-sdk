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
    ///  Class for testing SMSTenDLCCampaignStatus
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>

    public class SMSTenDLCCampaignStatusTests : IDisposable
    {
        private SMSTenDLCCampaignStatus instance;

        public SMSTenDLCCampaignStatusTests()
        {
            instance = new SMSTenDLCCampaignStatus();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SMSTenDLCCampaignStatus
        /// </summary>
        [Fact]
        public void SMSTenDLCCampaignStatusInstanceTest()
        {
            Assert.IsType<SMSTenDLCCampaignStatus>(instance);
        }

        [Fact]
        public void TestACTIVEShouldWork()
        {
            SMSTenDLCCampaignStatus test = SMSTenDLCCampaignStatus.ACTIVE;
            Assert.Equal(typeof(SMSTenDLCCampaignStatus), test.GetType());
        }

        [Fact]
        public void TestACTIVEShouldSerializeToEnum()
        {
            SMSTenDLCCampaignStatus expectedValue = SMSTenDLCCampaignStatus.ACTIVE;
            SMSTenDLCCampaignStatus calculatedValue = (SMSTenDLCCampaignStatus)
                Enum.Parse(typeof(SMSTenDLCCampaignStatus), "ACTIVE");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestACTIVEShouldDeserializeToString()
        {
            SMSTenDLCCampaignStatus test = SMSTenDLCCampaignStatus.ACTIVE;
            string expectedValue = "ACTIVE";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestEXPIREDShouldWork()
        {
            SMSTenDLCCampaignStatus test = SMSTenDLCCampaignStatus.EXPIRED;
            Assert.Equal(typeof(SMSTenDLCCampaignStatus), test.GetType());
        }

        [Fact]
        public void TestEXPIREDShouldSerializeToEnum()
        {
            SMSTenDLCCampaignStatus expectedValue = SMSTenDLCCampaignStatus.EXPIRED;
            SMSTenDLCCampaignStatus calculatedValue = (SMSTenDLCCampaignStatus)
                Enum.Parse(typeof(SMSTenDLCCampaignStatus), "EXPIRED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestEXPIREDShouldDeserializeToString()
        {
            SMSTenDLCCampaignStatus test = SMSTenDLCCampaignStatus.EXPIRED;
            string expectedValue = "EXPIRED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }
    }
}
