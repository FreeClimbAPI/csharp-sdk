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


namespace freeclimb.Test.Model
{
    /// <summary>
    ///  Class for testing AvailableNumber
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AvailableNumberTests
    {
        private AvailableNumber instance;

        public AvailableNumberTests()
        {
            
            instance = new AvailableNumber(new Capabilities(false, false, false, false, false), "TEST_STRING", "TEST_STRING", false, false, "TEST_STRING", "TEST_STRING");
            
        }

        /// <summary>
        /// Test an instance of AvailableNumber
        /// </summary>
        [Fact]
        public void AvailableNumberInstanceTest()
        {
            Assert.IsType<AvailableNumber>(instance);
        }


        /// <summary>
        /// Test the property 'Capabilities'
        /// </summary>
        [Fact]
        public void CapabilitiesTest()
        {
            Capabilities testObject = new Capabilities(false, false, false, false, false);
            instance.Capabilities = testObject;
            Assert.Equal(testObject, instance.Capabilities);
            
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
        /// Test the property 'PhoneNumber'
        /// </summary>
        [Fact]
        public void PhoneNumberTest()
        {
            instance.PhoneNumber = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.PhoneNumber);
            
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
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        AvailableNumber test1 = new AvailableNumber(new Capabilities(false, false, false, false, false), "TEST_STRING", "TEST_STRING", false, false, "TEST_STRING", "TEST_STRING");
         Capabilities CapabilitiestestObject = new Capabilities(false, false, false, false, false);
         test1.Capabilities = CapabilitiestestObject;
         test1.CampaignId = "TS";
         test1.PhoneNumber = "TS";
         test1.VoiceEnabled = true;
         test1.SmsEnabled = true;
         test1.Region = "TS";
         test1.Country = "TS";

        AvailableNumber test2 = new AvailableNumber(new Capabilities(false, false, false, false, false), "TEST_STRING", "TEST_STRING", false, false, "TEST_STRING", "TEST_STRING");
         Capabilities CapabilitiestestObject2 = new Capabilities(false, false, false, false, false);
         test2.Capabilities = CapabilitiestestObject2;
         test2.CampaignId = "TS";
         test2.PhoneNumber = "TS";
         test2.VoiceEnabled = true;
         test2.SmsEnabled = true;
         test2.Region = "TS";
         test2.Country = "TS";

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        AvailableNumber test1 = new AvailableNumber(new Capabilities(false, false, false, false, false), "TEST_STRING", "TEST_STRING", false, false, "TEST_STRING", "TEST_STRING");
         Capabilities CapabilitiestestObject = new Capabilities(false, false, false, false, false);
         test1.Capabilities = CapabilitiestestObject;
         test1.CampaignId = "TS";
         test1.PhoneNumber = "TS";
         test1.VoiceEnabled = true;
         test1.SmsEnabled = true;
         test1.Region = "TS";
         test1.Country = "TS";

        AvailableNumber test2 = new AvailableNumber(new Capabilities(false, false, false, false, false), "TEST_STRING", "TEST_STRING", false, false, "TEST_STRING", "TEST_STRING");
         Capabilities CapabilitiestestObject2 = new Capabilities(false, false, false, false, false);
         test2.Capabilities = CapabilitiestestObject2;
         test2.CampaignId = "ts";
         test2.PhoneNumber = "ts";
         test2.VoiceEnabled = false;
         test2.SmsEnabled = false;
         test2.Region = "ts";
         test2.Country = "ts";

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        AvailableNumber test1 = new AvailableNumber(new Capabilities(false, false, false, false, false), "TEST_STRING", "TEST_STRING", false, false, "TEST_STRING", "TEST_STRING");
         Capabilities CapabilitiestestObject = new Capabilities(false, false, false, false, false);
         test1.Capabilities = CapabilitiestestObject;
         test1.CampaignId = "TS";
         test1.PhoneNumber = "TS";
         test1.VoiceEnabled = true;
         test1.SmsEnabled = true;
         test1.Region = "TS";
         test1.Country = "TS";

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        AvailableNumber test1 = new AvailableNumber(new Capabilities(false, false, false, false, false), "TEST_STRING", "TEST_STRING", false, false, "TEST_STRING", "TEST_STRING");
         Capabilities CapabilitiestestObject = new Capabilities(false, false, false, false, false);
         test1.Capabilities = CapabilitiestestObject;
         test1.CampaignId = "TS";
         test1.PhoneNumber = "TS";
         test1.VoiceEnabled = true;
         test1.SmsEnabled = true;
         test1.Region = "TS";
         test1.Country = "TS";

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        AvailableNumber test1 = new AvailableNumber(new Capabilities(false, false, false, false, false), "TEST_STRING", "TEST_STRING", false, false, "TEST_STRING", "TEST_STRING");
         Capabilities CapabilitiestestObject = new Capabilities(false, false, false, false, false);
         test1.Capabilities = CapabilitiestestObject;
         test1.CampaignId = "TS";
         test1.PhoneNumber = "TS";
         test1.VoiceEnabled = true;
         test1.SmsEnabled = true;
         test1.Region = "TS";
         test1.Country = "TS";

        AvailableNumber test2 = new AvailableNumber(new Capabilities(false, false, false, false, false), "TEST_STRING", "TEST_STRING", false, false, "TEST_STRING", "TEST_STRING");
         Capabilities CapabilitiestestObject2 = new Capabilities(false, false, false, false, false);
         test2.Capabilities = CapabilitiestestObject2;
         test2.CampaignId = "TS";
         test2.PhoneNumber = "TS";
         test2.VoiceEnabled = true;
         test2.SmsEnabled = true;
         test2.Region = "TS";
         test2.Country = "TS";

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        AvailableNumber test1 = new AvailableNumber(new Capabilities(false, false, false, false, false), "TEST_STRING", "TEST_STRING", false, false, "TEST_STRING", "TEST_STRING");
         Capabilities CapabilitiestestObject = new Capabilities(false, false, false, false, false);
         test1.Capabilities = CapabilitiestestObject;
         test1.CampaignId = "TS";
         test1.PhoneNumber = "TS";
         test1.VoiceEnabled = true;
         test1.SmsEnabled = true;
         test1.Region = "TS";
         test1.Country = "TS";

        AvailableNumber test2 = new AvailableNumber(new Capabilities(false, false, false, false, false), "TEST_STRING", "TEST_STRING", false, false, "TEST_STRING", "TEST_STRING");
         Capabilities CapabilitiestestObject2 = new Capabilities(false, false, false, false, false);
         test2.Capabilities = CapabilitiestestObject2;
         test2.CampaignId = "TS";
         test2.PhoneNumber = "TS";
         test2.VoiceEnabled = true;
         test2.SmsEnabled = true;
         test2.Region = "TS";
         test2.Country = "TS";

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        AvailableNumber test1 = new AvailableNumber(new Capabilities(false, false, false, false, false), "TEST_STRING", "TEST_STRING", false, false, "TEST_STRING", "TEST_STRING");
         Capabilities CapabilitiestestObject = new Capabilities(false, false, false, false, false);
         test1.Capabilities = CapabilitiestestObject;
         test1.CampaignId = "TS";
         test1.PhoneNumber = "TS";
         test1.VoiceEnabled = true;
         test1.SmsEnabled = true;
         test1.Region = "TS";
         test1.Country = "TS";
        JsonSerializer jsonSerializer = JsonSerializer.Create();
        jsonSerializer.NullValueHandling = NullValueHandling.Ignore;
        StringBuilder strb = new StringBuilder();
        jsonSerializer.Serialize(new StringWriter(strb), test1);

        AvailableNumber test2 = new AvailableNumber(new Capabilities(false, false, false, false, false), "TEST_STRING", "TEST_STRING", false, false, "TEST_STRING", "TEST_STRING");
         Capabilities CapabilitiestestObject2 = new Capabilities(false, false, false, false, false);
         test2.Capabilities = CapabilitiestestObject2;
         test2.CampaignId = "TS";
         test2.PhoneNumber = "TS";
         test2.VoiceEnabled = true;
         test2.SmsEnabled = true;
         test2.Region = "TS";
         test2.Country = "TS";

        Assert.True(strb.Equals(JsonConvert.SerializeObject(test2)));
        }
    }
}
