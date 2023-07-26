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


namespace freeclimb.Test.Model
{
    /// <summary>
    ///  Class for testing IncomingNumberResultAllOf
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class IncomingNumberResultAllOfTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for IncomingNumberResultAllOf
        private IncomingNumberResultAllOf instance;

        public IncomingNumberResultAllOfTests()
        {
            instance = new IncomingNumberResultAllOf();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IncomingNumberResultAllOf
        /// </summary>
        [Fact]
        public void IncomingNumberResultAllOfInstanceTest()
        {
            // TODO uncomment below to test "IsType" IncomingNumberResultAllOf
            Assert.IsType<IncomingNumberResultAllOf>(instance);
        }


        /// <summary>
        /// Test the property 'Capabilities'
        /// </summary>
        [Fact]
        public void CapabilitiesTest()
        {
            //Capabilities object = new Capabilities();
            //instance.Capabilities = object;
            //Assert.AreEqual(object.getType(), Capabilities.getType());
            
        }
        /// <summary>
        /// Test the property 'CampaignId'
        /// </summary>
        [Fact]
        public void CampaignIdTest()
        {
            instance.CampaignId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.CampaignId);
            
        }
        /// <summary>
        /// Test the property 'PhoneNumberId'
        /// </summary>
        [Fact]
        public void PhoneNumberIdTest()
        {
            instance.PhoneNumberId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.PhoneNumberId);
            
        }
        /// <summary>
        /// Test the property 'AccountId'
        /// </summary>
        [Fact]
        public void AccountIdTest()
        {
            instance.AccountId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.AccountId);
            
        }
        /// <summary>
        /// Test the property 'ApplicationId'
        /// </summary>
        [Fact]
        public void ApplicationIdTest()
        {
            instance.ApplicationId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.ApplicationId);
            
        }
        /// <summary>
        /// Test the property 'PhoneNumber'
        /// </summary>
        [Fact]
        public void PhoneNumberTest()
        {
            instance.PhoneNumber = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.PhoneNumber);
            
        }
        /// <summary>
        /// Test the property 'Alias'
        /// </summary>
        [Fact]
        public void AliasTest()
        {
            instance.Alias = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Alias);
            
        }
        /// <summary>
        /// Test the property 'Region'
        /// </summary>
        [Fact]
        public void RegionTest()
        {
            instance.Region = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Region);
            
        }
        /// <summary>
        /// Test the property 'Country'
        /// </summary>
        [Fact]
        public void CountryTest()
        {
            instance.Country = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Country);
            
        }
        /// <summary>
        /// Test the property 'VoiceEnabled'
        /// </summary>
        [Fact]
        public void VoiceEnabledTest()
        {
            instance.VoiceEnabled = false;
            Assert.Equal(false, instance.VoiceEnabled);       
            
        }
        /// <summary>
        /// Test the property 'SmsEnabled'
        /// </summary>
        [Fact]
        public void SmsEnabledTest()
        {
            instance.SmsEnabled = false;
            Assert.Equal(false, instance.SmsEnabled);       
            
        }
        /// <summary>
        /// Test the property 'Offnet'
        /// </summary>
        [Fact]
        public void OffnetTest()
        {
            instance.Offnet = false;
            Assert.Equal(false, instance.Offnet);       
            
        }
    }
}
