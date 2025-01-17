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
    ///  Class for testing SMSTollFreeCampaignRegistrationStatus
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>

    public class SMSTollFreeCampaignRegistrationStatusTests : IDisposable
    {
        private SMSTollFreeCampaignRegistrationStatus instance;

        public SMSTollFreeCampaignRegistrationStatusTests()
        {
            instance = new SMSTollFreeCampaignRegistrationStatus();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SMSTollFreeCampaignRegistrationStatus
        /// </summary>
        [Fact]
        public void SMSTollFreeCampaignRegistrationStatusInstanceTest()
        {
            Assert.IsType<SMSTollFreeCampaignRegistrationStatus>(instance);
        }

        [Fact]
        public void TestUNREGISTEREDShouldWork()
        {
            SMSTollFreeCampaignRegistrationStatus test =
                SMSTollFreeCampaignRegistrationStatus.UNREGISTERED;
            Assert.Equal(typeof(SMSTollFreeCampaignRegistrationStatus), test.GetType());
        }

        [Fact]
        public void TestUNREGISTEREDShouldSerializeToEnum()
        {
            SMSTollFreeCampaignRegistrationStatus expectedValue =
                SMSTollFreeCampaignRegistrationStatus.UNREGISTERED;
            SMSTollFreeCampaignRegistrationStatus calculatedValue =
                (SMSTollFreeCampaignRegistrationStatus)
                    Enum.Parse(typeof(SMSTollFreeCampaignRegistrationStatus), "UNREGISTERED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestUNREGISTEREDShouldDeserializeToString()
        {
            SMSTollFreeCampaignRegistrationStatus test =
                SMSTollFreeCampaignRegistrationStatus.UNREGISTERED;
            string expectedValue = "UNREGISTERED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestINITIATEDShouldWork()
        {
            SMSTollFreeCampaignRegistrationStatus test =
                SMSTollFreeCampaignRegistrationStatus.INITIATED;
            Assert.Equal(typeof(SMSTollFreeCampaignRegistrationStatus), test.GetType());
        }

        [Fact]
        public void TestINITIATEDShouldSerializeToEnum()
        {
            SMSTollFreeCampaignRegistrationStatus expectedValue =
                SMSTollFreeCampaignRegistrationStatus.INITIATED;
            SMSTollFreeCampaignRegistrationStatus calculatedValue =
                (SMSTollFreeCampaignRegistrationStatus)
                    Enum.Parse(typeof(SMSTollFreeCampaignRegistrationStatus), "INITIATED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestINITIATEDShouldDeserializeToString()
        {
            SMSTollFreeCampaignRegistrationStatus test =
                SMSTollFreeCampaignRegistrationStatus.INITIATED;
            string expectedValue = "INITIATED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestPENDINGShouldWork()
        {
            SMSTollFreeCampaignRegistrationStatus test =
                SMSTollFreeCampaignRegistrationStatus.PENDING;
            Assert.Equal(typeof(SMSTollFreeCampaignRegistrationStatus), test.GetType());
        }

        [Fact]
        public void TestPENDINGShouldSerializeToEnum()
        {
            SMSTollFreeCampaignRegistrationStatus expectedValue =
                SMSTollFreeCampaignRegistrationStatus.PENDING;
            SMSTollFreeCampaignRegistrationStatus calculatedValue =
                (SMSTollFreeCampaignRegistrationStatus)
                    Enum.Parse(typeof(SMSTollFreeCampaignRegistrationStatus), "PENDING");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestPENDINGShouldDeserializeToString()
        {
            SMSTollFreeCampaignRegistrationStatus test =
                SMSTollFreeCampaignRegistrationStatus.PENDING;
            string expectedValue = "PENDING";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDECLINEDShouldWork()
        {
            SMSTollFreeCampaignRegistrationStatus test =
                SMSTollFreeCampaignRegistrationStatus.DECLINED;
            Assert.Equal(typeof(SMSTollFreeCampaignRegistrationStatus), test.GetType());
        }

        [Fact]
        public void TestDECLINEDShouldSerializeToEnum()
        {
            SMSTollFreeCampaignRegistrationStatus expectedValue =
                SMSTollFreeCampaignRegistrationStatus.DECLINED;
            SMSTollFreeCampaignRegistrationStatus calculatedValue =
                (SMSTollFreeCampaignRegistrationStatus)
                    Enum.Parse(typeof(SMSTollFreeCampaignRegistrationStatus), "DECLINED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDECLINEDShouldDeserializeToString()
        {
            SMSTollFreeCampaignRegistrationStatus test =
                SMSTollFreeCampaignRegistrationStatus.DECLINED;
            string expectedValue = "DECLINED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestREGISTEREDShouldWork()
        {
            SMSTollFreeCampaignRegistrationStatus test =
                SMSTollFreeCampaignRegistrationStatus.REGISTERED;
            Assert.Equal(typeof(SMSTollFreeCampaignRegistrationStatus), test.GetType());
        }

        [Fact]
        public void TestREGISTEREDShouldSerializeToEnum()
        {
            SMSTollFreeCampaignRegistrationStatus expectedValue =
                SMSTollFreeCampaignRegistrationStatus.REGISTERED;
            SMSTollFreeCampaignRegistrationStatus calculatedValue =
                (SMSTollFreeCampaignRegistrationStatus)
                    Enum.Parse(typeof(SMSTollFreeCampaignRegistrationStatus), "REGISTERED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestREGISTEREDShouldDeserializeToString()
        {
            SMSTollFreeCampaignRegistrationStatus test =
                SMSTollFreeCampaignRegistrationStatus.REGISTERED;
            string expectedValue = "REGISTERED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }
    }
}
