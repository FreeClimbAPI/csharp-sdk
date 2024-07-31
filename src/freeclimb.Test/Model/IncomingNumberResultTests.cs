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
    ///  Class for testing IncomingNumberResult
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class IncomingNumberResultTests
    {
        private IncomingNumberResult instance;

        public IncomingNumberResultTests()
        {
            instance = new IncomingNumberResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, new Capabilities(), "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false, new TFN());
        }

        /// <summary>
        /// Test an instance of IncomingNumberResult
        /// </summary>
        [Fact]
        public void IncomingNumberResultInstanceTest()
        {
            Assert.IsType<IncomingNumberResult>(instance);
        }


        /// <summary>
        /// Test the property 'Uri'
        /// </summary>
        [Fact]
        public void UriTest()
        {
            instance.Uri = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Uri);
            
        }
        /// <summary>
        /// Test the property 'DateCreated'
        /// </summary>
        [Fact]
        public void DateCreatedTest()
        {
            instance.DateCreated = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.DateCreated);
            
        }
        /// <summary>
        /// Test the property 'DateUpdated'
        /// </summary>
        [Fact]
        public void DateUpdatedTest()
        {
            instance.DateUpdated = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.DateUpdated);
            
        }
        /// <summary>
        /// Test the property 'Revision'
        /// </summary>
        [Fact]
        public void RevisionTest()
        {
            
            instance.Revision = 1;
            Assert.Equal(1, (int) instance.Revision);
        }
        /// <summary>
        /// Test the property 'Capabilities'
        /// </summary>
        [Fact]
        public void CapabilitiesTest()
        {
            Capabilities testObject = new Capabilities();
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
        /// <summary>
        /// Test the property 'Tfn'
        /// </summary>
        [Fact]
        public void TfnTest()
        {
            TFN testObject = new TFN();
            instance.Tfn = testObject;
            Assert.Equal(testObject, instance.Tfn);
            
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        IncomingNumberResult test1 = new IncomingNumberResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, new Capabilities(), "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false, new TFN());
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         Capabilities CapabilitiestestObject = new Capabilities();
         test1.Capabilities = CapabilitiestestObject;
         test1.CampaignId = "TS";
         test1.PhoneNumberId = "TS";
         test1.AccountId = "TS";
         test1.ApplicationId = "TS";
         test1.PhoneNumber = "TS";
         test1.Alias = "TS";
         test1.Region = "TS";
         test1.Country = "TS";
         test1.VoiceEnabled = true;
         test1.SmsEnabled = true;
         test1.Offnet = true;
         TFN TfntestObject = new TFN();
         test1.Tfn = TfntestObject;

        IncomingNumberResult test2 = new IncomingNumberResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, new Capabilities(), "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false, new TFN());
         test2.Uri = "TS";
         test2.DateCreated = "TS";
         test2.DateUpdated = "TS";
         test2.Revision = 1;
         Capabilities CapabilitiestestObject2 = new Capabilities();
         test2.Capabilities = CapabilitiestestObject2;
         test2.CampaignId = "TS";
         test2.PhoneNumberId = "TS";
         test2.AccountId = "TS";
         test2.ApplicationId = "TS";
         test2.PhoneNumber = "TS";
         test2.Alias = "TS";
         test2.Region = "TS";
         test2.Country = "TS";
         test2.VoiceEnabled = true;
         test2.SmsEnabled = true;
         test2.Offnet = true;
         TFN TfntestObject2 = new TFN();
         test2.Tfn = TfntestObject2;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        IncomingNumberResult test1 = new IncomingNumberResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, new Capabilities(), "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false, new TFN());
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         Capabilities CapabilitiestestObject = new Capabilities();
         test1.Capabilities = CapabilitiestestObject;
         test1.CampaignId = "TS";
         test1.PhoneNumberId = "TS";
         test1.AccountId = "TS";
         test1.ApplicationId = "TS";
         test1.PhoneNumber = "TS";
         test1.Alias = "TS";
         test1.Region = "TS";
         test1.Country = "TS";
         test1.VoiceEnabled = true;
         test1.SmsEnabled = true;
         test1.Offnet = true;
         TFN TfntestObject = new TFN();
         test1.Tfn = TfntestObject;

        IncomingNumberResult test2 = new IncomingNumberResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, new Capabilities(), "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false, new TFN());
         test2.Uri = "ts";
         test2.DateCreated = "ts";
         test2.DateUpdated = "ts";
         test2.Revision = 2;
         Capabilities CapabilitiestestObject2 = new Capabilities();
         test2.Capabilities = CapabilitiestestObject2;
         test2.CampaignId = "ts";
         test2.PhoneNumberId = "ts";
         test2.AccountId = "ts";
         test2.ApplicationId = "ts";
         test2.PhoneNumber = "ts";
         test2.Alias = "ts";
         test2.Region = "ts";
         test2.Country = "ts";
         test2.VoiceEnabled = false;
         test2.SmsEnabled = false;
         test2.Offnet = false;
         TFN TfntestObject2 = new TFN();
         test2.Tfn = TfntestObject2;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        IncomingNumberResult test1 = new IncomingNumberResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, new Capabilities(), "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false, new TFN());
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         Capabilities CapabilitiestestObject = new Capabilities();
         test1.Capabilities = CapabilitiestestObject;
         test1.CampaignId = "TS";
         test1.PhoneNumberId = "TS";
         test1.AccountId = "TS";
         test1.ApplicationId = "TS";
         test1.PhoneNumber = "TS";
         test1.Alias = "TS";
         test1.Region = "TS";
         test1.Country = "TS";
         test1.VoiceEnabled = true;
         test1.SmsEnabled = true;
         test1.Offnet = true;
         TFN TfntestObject = new TFN();
         test1.Tfn = TfntestObject;

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        IncomingNumberResult test1 = new IncomingNumberResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, new Capabilities(), "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false, new TFN());
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         Capabilities CapabilitiestestObject = new Capabilities();
         test1.Capabilities = CapabilitiestestObject;
         test1.CampaignId = "TS";
         test1.PhoneNumberId = "TS";
         test1.AccountId = "TS";
         test1.ApplicationId = "TS";
         test1.PhoneNumber = "TS";
         test1.Alias = "TS";
         test1.Region = "TS";
         test1.Country = "TS";
         test1.VoiceEnabled = true;
         test1.SmsEnabled = true;
         test1.Offnet = true;
         TFN TfntestObject = new TFN();
         test1.Tfn = TfntestObject;

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        IncomingNumberResult test1 = new IncomingNumberResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, new Capabilities(), "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false, new TFN());
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         Capabilities CapabilitiestestObject = new Capabilities();
         test1.Capabilities = CapabilitiestestObject;
         test1.CampaignId = "TS";
         test1.PhoneNumberId = "TS";
         test1.AccountId = "TS";
         test1.ApplicationId = "TS";
         test1.PhoneNumber = "TS";
         test1.Alias = "TS";
         test1.Region = "TS";
         test1.Country = "TS";
         test1.VoiceEnabled = true;
         test1.SmsEnabled = true;
         test1.Offnet = true;
         TFN TfntestObject = new TFN();
         test1.Tfn = TfntestObject;

        IncomingNumberResult test2 = new IncomingNumberResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, new Capabilities(), "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false, new TFN());
         test2.Uri = "TS";
         test2.DateCreated = "TS";
         test2.DateUpdated = "TS";
         test2.Revision = 1;
         Capabilities CapabilitiestestObject2 = new Capabilities();
         test2.Capabilities = CapabilitiestestObject2;
         test2.CampaignId = "TS";
         test2.PhoneNumberId = "TS";
         test2.AccountId = "TS";
         test2.ApplicationId = "TS";
         test2.PhoneNumber = "TS";
         test2.Alias = "TS";
         test2.Region = "TS";
         test2.Country = "TS";
         test2.VoiceEnabled = true;
         test2.SmsEnabled = true;
         test2.Offnet = true;
         TFN TfntestObject2 = new TFN();
         test2.Tfn = TfntestObject2;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        IncomingNumberResult test1 = new IncomingNumberResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, new Capabilities(), "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false, new TFN());
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         Capabilities CapabilitiestestObject = new Capabilities();
         test1.Capabilities = CapabilitiestestObject;
         test1.CampaignId = "TS";
         test1.PhoneNumberId = "TS";
         test1.AccountId = "TS";
         test1.ApplicationId = "TS";
         test1.PhoneNumber = "TS";
         test1.Alias = "TS";
         test1.Region = "TS";
         test1.Country = "TS";
         test1.VoiceEnabled = true;
         test1.SmsEnabled = true;
         test1.Offnet = true;
         TFN TfntestObject = new TFN();
         test1.Tfn = TfntestObject;

        IncomingNumberResult test2 = new IncomingNumberResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, new Capabilities(), "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false, new TFN());
         test2.Uri = "TS";
         test2.DateCreated = "TS";
         test2.DateUpdated = "TS";
         test2.Revision = 1;
         Capabilities CapabilitiestestObject2 = new Capabilities();
         test2.Capabilities = CapabilitiestestObject2;
         test2.CampaignId = "TS";
         test2.PhoneNumberId = "TS";
         test2.AccountId = "TS";
         test2.ApplicationId = "TS";
         test2.PhoneNumber = "TS";
         test2.Alias = "TS";
         test2.Region = "TS";
         test2.Country = "TS";
         test2.VoiceEnabled = true;
         test2.SmsEnabled = true;
         test2.Offnet = true;
         TFN TfntestObject2 = new TFN();
         test2.Tfn = TfntestObject2;

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        IncomingNumberResult test1 = new IncomingNumberResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, new Capabilities(), "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false, new TFN());
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         Capabilities CapabilitiestestObject = new Capabilities();
         test1.Capabilities = CapabilitiestestObject;
         test1.CampaignId = "TS";
         test1.PhoneNumberId = "TS";
         test1.AccountId = "TS";
         test1.ApplicationId = "TS";
         test1.PhoneNumber = "TS";
         test1.Alias = "TS";
         test1.Region = "TS";
         test1.Country = "TS";
         test1.VoiceEnabled = true;
         test1.SmsEnabled = true;
         test1.Offnet = true;
         TFN TfntestObject = new TFN();
         test1.Tfn = TfntestObject;
         string jsonStr = JsonConvert.SerializeObject(test1, Newtonsoft.Json.Formatting.Indented);

        IncomingNumberResult test2 = new IncomingNumberResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, new Capabilities(), "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false, new TFN());
         test2.Uri = "TS";
         test2.DateCreated = "TS";
         test2.DateUpdated = "TS";
         test2.Revision = 1;
         Capabilities CapabilitiestestObject2 = new Capabilities();
         test2.Capabilities = CapabilitiestestObject2;
         test2.CampaignId = "TS";
         test2.PhoneNumberId = "TS";
         test2.AccountId = "TS";
         test2.ApplicationId = "TS";
         test2.PhoneNumber = "TS";
         test2.Alias = "TS";
         test2.Region = "TS";
         test2.Country = "TS";
         test2.VoiceEnabled = true;
         test2.SmsEnabled = true;
         test2.Offnet = true;
         TFN TfntestObject2 = new TFN();
         test2.Tfn = TfntestObject2;

        Assert.True(jsonStr.Equals(test2.ToJson()));
        }
    }
}
