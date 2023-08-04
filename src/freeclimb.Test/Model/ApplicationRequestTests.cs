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


namespace freeclimb.Test.Model
{
    /// <summary>
    ///  Class for testing ApplicationRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ApplicationRequestTests
    {
        private ApplicationRequest instance;

        public ApplicationRequestTests()
        {
            instance = new ApplicationRequest();
        }

        /// <summary>
        /// Test an instance of ApplicationRequest
        /// </summary>
        [Fact]
        public void ApplicationRequestInstanceTest()
        {
            Assert.IsType<ApplicationRequest>(instance);
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
        /// Test the property 'VoiceUrl'
        /// </summary>
        [Fact]
        public void VoiceUrlTest()
        {
            instance.VoiceUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.VoiceUrl);
            
        }
        /// <summary>
        /// Test the property 'VoiceFallbackUrl'
        /// </summary>
        [Fact]
        public void VoiceFallbackUrlTest()
        {
            instance.VoiceFallbackUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.VoiceFallbackUrl);
            
        }
        /// <summary>
        /// Test the property 'CallConnectUrl'
        /// </summary>
        [Fact]
        public void CallConnectUrlTest()
        {
            instance.CallConnectUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.CallConnectUrl);
            
        }
        /// <summary>
        /// Test the property 'StatusCallbackUrl'
        /// </summary>
        [Fact]
        public void StatusCallbackUrlTest()
        {
            instance.StatusCallbackUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.StatusCallbackUrl);
            
        }
        /// <summary>
        /// Test the property 'SmsUrl'
        /// </summary>
        [Fact]
        public void SmsUrlTest()
        {
            instance.SmsUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.SmsUrl);
            
        }
        /// <summary>
        /// Test the property 'SmsFallbackUrl'
        /// </summary>
        [Fact]
        public void SmsFallbackUrlTest()
        {
            instance.SmsFallbackUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.SmsFallbackUrl);
            
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        ApplicationRequest test1 = new ApplicationRequest();
         test1.Alias = "TS";
         test1.VoiceUrl = "TS";
         test1.VoiceFallbackUrl = "TS";
         test1.CallConnectUrl = "TS";
         test1.StatusCallbackUrl = "TS";
         test1.SmsUrl = "TS";
         test1.SmsFallbackUrl = "TS";

        ApplicationRequest test2 = new ApplicationRequest();
         test2.Alias = "TS";
         test2.VoiceUrl = "TS";
         test2.VoiceFallbackUrl = "TS";
         test2.CallConnectUrl = "TS";
         test2.StatusCallbackUrl = "TS";
         test2.SmsUrl = "TS";
         test2.SmsFallbackUrl = "TS";

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        ApplicationRequest test1 = new ApplicationRequest();
         test1.Alias = "TS";
         test1.VoiceUrl = "TS";
         test1.VoiceFallbackUrl = "TS";
         test1.CallConnectUrl = "TS";
         test1.StatusCallbackUrl = "TS";
         test1.SmsUrl = "TS";
         test1.SmsFallbackUrl = "TS";

        ApplicationRequest test2 = new ApplicationRequest();
         test2.Alias = "ts";
         test2.VoiceUrl = "ts";
         test2.VoiceFallbackUrl = "ts";
         test2.CallConnectUrl = "ts";
         test2.StatusCallbackUrl = "ts";
         test2.SmsUrl = "ts";
         test2.SmsFallbackUrl = "ts";

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        ApplicationRequest test1 = new ApplicationRequest();
         test1.Alias = "TS";
         test1.VoiceUrl = "TS";
         test1.VoiceFallbackUrl = "TS";
         test1.CallConnectUrl = "TS";
         test1.StatusCallbackUrl = "TS";
         test1.SmsUrl = "TS";
         test1.SmsFallbackUrl = "TS";

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        ApplicationRequest test1 = new ApplicationRequest();
         test1.Alias = "TS";
         test1.VoiceUrl = "TS";
         test1.VoiceFallbackUrl = "TS";
         test1.CallConnectUrl = "TS";
         test1.StatusCallbackUrl = "TS";
         test1.SmsUrl = "TS";
         test1.SmsFallbackUrl = "TS";

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        ApplicationRequest test1 = new ApplicationRequest();
         test1.Alias = "TS";
         test1.VoiceUrl = "TS";
         test1.VoiceFallbackUrl = "TS";
         test1.CallConnectUrl = "TS";
         test1.StatusCallbackUrl = "TS";
         test1.SmsUrl = "TS";
         test1.SmsFallbackUrl = "TS";

        ApplicationRequest test2 = new ApplicationRequest();
         test2.Alias = "TS";
         test2.VoiceUrl = "TS";
         test2.VoiceFallbackUrl = "TS";
         test2.CallConnectUrl = "TS";
         test2.StatusCallbackUrl = "TS";
         test2.SmsUrl = "TS";
         test2.SmsFallbackUrl = "TS";

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        ApplicationRequest test1 = new ApplicationRequest();
         test1.Alias = "TS";
         test1.VoiceUrl = "TS";
         test1.VoiceFallbackUrl = "TS";
         test1.CallConnectUrl = "TS";
         test1.StatusCallbackUrl = "TS";
         test1.SmsUrl = "TS";
         test1.SmsFallbackUrl = "TS";

        ApplicationRequest test2 = new ApplicationRequest();
         test2.Alias = "TS";
         test2.VoiceUrl = "TS";
         test2.VoiceFallbackUrl = "TS";
         test2.CallConnectUrl = "TS";
         test2.StatusCallbackUrl = "TS";
         test2.SmsUrl = "TS";
         test2.SmsFallbackUrl = "TS";

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        ApplicationRequest test1 = new ApplicationRequest();
         test1.Alias = "TS";
         test1.VoiceUrl = "TS";
         test1.VoiceFallbackUrl = "TS";
         test1.CallConnectUrl = "TS";
         test1.StatusCallbackUrl = "TS";
         test1.SmsUrl = "TS";
         test1.SmsFallbackUrl = "TS";
         string jsonStr = JsonConvert.SerializeObject(test1, Newtonsoft.Json.Formatting.Indented);

        ApplicationRequest test2 = new ApplicationRequest();
         test2.Alias = "TS";
         test2.VoiceUrl = "TS";
         test2.VoiceFallbackUrl = "TS";
         test2.CallConnectUrl = "TS";
         test2.StatusCallbackUrl = "TS";
         test2.SmsUrl = "TS";
         test2.SmsFallbackUrl = "TS";

        Assert.True(jsonStr.Equals(test2.ToJson()));
        }
    }
}
