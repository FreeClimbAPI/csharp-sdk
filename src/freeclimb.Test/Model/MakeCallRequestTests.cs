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
    ///  Class for testing MakeCallRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MakeCallRequestTests
    {
        private MakeCallRequest instance;

        public MakeCallRequestTests()
        {
            instance = new MakeCallRequest("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", false, "TEST_STRING");
        }

        /// <summary>
        /// Test an instance of MakeCallRequest
        /// </summary>
        [Fact]
        public void MakeCallRequestInstanceTest()
        {
            Assert.IsType<MakeCallRequest>(instance);
        }


        /// <summary>
        /// Test the property 'From'
        /// </summary>
        [Fact]
        public void FromTest()
        {
            instance.From = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.From);
            
        }
        /// <summary>
        /// Test the property 'To'
        /// </summary>
        [Fact]
        public void ToTest()
        {
            instance.To = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.To);
            
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
        /// Test the property 'SendDigits'
        /// </summary>
        [Fact]
        public void SendDigitsTest()
        {
            instance.SendDigits = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.SendDigits);
            
        }
        /// <summary>
        /// Test the property 'IfMachine'
        /// </summary>
        [Fact]
        public void IfMachineTest()
        {
            instance.IfMachine = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.IfMachine);
            
        }
        /// <summary>
        /// Test the property 'IfMachineUrl'
        /// </summary>
        [Fact]
        public void IfMachineUrlTest()
        {
            instance.IfMachineUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.IfMachineUrl);
            
        }
        /// <summary>
        /// Test the property 'Timeout'
        /// </summary>
        [Fact]
        public void TimeoutTest()
        {
            
            instance.Timeout = 1;
            Assert.Equal(1, (int) instance.Timeout);
        }
        /// <summary>
        /// Test the property 'ParentCallId'
        /// </summary>
        [Fact]
        public void ParentCallIdTest()
        {
            instance.ParentCallId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.ParentCallId);
            
        }
        /// <summary>
        /// Test the property 'PrivacyMode'
        /// </summary>
        [Fact]
        public void PrivacyModeTest()
        {
            instance.PrivacyMode = false;
            Assert.Equal(false, instance.PrivacyMode);       
            
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
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        MakeCallRequest test1 = new MakeCallRequest("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", false, "TEST_STRING");
         test1.From = "TS";
         test1.To = "TS";
         test1.ApplicationId = "TS";
         test1.SendDigits = "TS";
         test1.IfMachine = "TS";
         test1.IfMachineUrl = "TS";
         test1.Timeout = 1;
         test1.ParentCallId = "TS";
         test1.PrivacyMode = true;
         test1.CallConnectUrl = "TS";

        MakeCallRequest test2 = new MakeCallRequest("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", false, "TEST_STRING");
         test2.From = "TS";
         test2.To = "TS";
         test2.ApplicationId = "TS";
         test2.SendDigits = "TS";
         test2.IfMachine = "TS";
         test2.IfMachineUrl = "TS";
         test2.Timeout = 1;
         test2.ParentCallId = "TS";
         test2.PrivacyMode = true;
         test2.CallConnectUrl = "TS";

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        MakeCallRequest test1 = new MakeCallRequest("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", false, "TEST_STRING");
         test1.From = "TS";
         test1.To = "TS";
         test1.ApplicationId = "TS";
         test1.SendDigits = "TS";
         test1.IfMachine = "TS";
         test1.IfMachineUrl = "TS";
         test1.Timeout = 1;
         test1.ParentCallId = "TS";
         test1.PrivacyMode = true;
         test1.CallConnectUrl = "TS";

        MakeCallRequest test2 = new MakeCallRequest("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", false, "TEST_STRING");
         test2.From = "ts";
         test2.To = "ts";
         test2.ApplicationId = "ts";
         test2.SendDigits = "ts";
         test2.IfMachine = "ts";
         test2.IfMachineUrl = "ts";
         test2.Timeout = 2;
         test2.ParentCallId = "ts";
         test2.PrivacyMode = false;
         test2.CallConnectUrl = "ts";

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        MakeCallRequest test1 = new MakeCallRequest("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", false, "TEST_STRING");
         test1.From = "TS";
         test1.To = "TS";
         test1.ApplicationId = "TS";
         test1.SendDigits = "TS";
         test1.IfMachine = "TS";
         test1.IfMachineUrl = "TS";
         test1.Timeout = 1;
         test1.ParentCallId = "TS";
         test1.PrivacyMode = true;
         test1.CallConnectUrl = "TS";

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        MakeCallRequest test1 = new MakeCallRequest("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", false, "TEST_STRING");
         test1.From = "TS";
         test1.To = "TS";
         test1.ApplicationId = "TS";
         test1.SendDigits = "TS";
         test1.IfMachine = "TS";
         test1.IfMachineUrl = "TS";
         test1.Timeout = 1;
         test1.ParentCallId = "TS";
         test1.PrivacyMode = true;
         test1.CallConnectUrl = "TS";

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        MakeCallRequest test1 = new MakeCallRequest("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", false, "TEST_STRING");
         test1.From = "TS";
         test1.To = "TS";
         test1.ApplicationId = "TS";
         test1.SendDigits = "TS";
         test1.IfMachine = "TS";
         test1.IfMachineUrl = "TS";
         test1.Timeout = 1;
         test1.ParentCallId = "TS";
         test1.PrivacyMode = true;
         test1.CallConnectUrl = "TS";

        MakeCallRequest test2 = new MakeCallRequest("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", false, "TEST_STRING");
         test2.From = "TS";
         test2.To = "TS";
         test2.ApplicationId = "TS";
         test2.SendDigits = "TS";
         test2.IfMachine = "TS";
         test2.IfMachineUrl = "TS";
         test2.Timeout = 1;
         test2.ParentCallId = "TS";
         test2.PrivacyMode = true;
         test2.CallConnectUrl = "TS";

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        MakeCallRequest test1 = new MakeCallRequest("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", false, "TEST_STRING");
         test1.From = "TS";
         test1.To = "TS";
         test1.ApplicationId = "TS";
         test1.SendDigits = "TS";
         test1.IfMachine = "TS";
         test1.IfMachineUrl = "TS";
         test1.Timeout = 1;
         test1.ParentCallId = "TS";
         test1.PrivacyMode = true;
         test1.CallConnectUrl = "TS";

        MakeCallRequest test2 = new MakeCallRequest("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", false, "TEST_STRING");
         test2.From = "TS";
         test2.To = "TS";
         test2.ApplicationId = "TS";
         test2.SendDigits = "TS";
         test2.IfMachine = "TS";
         test2.IfMachineUrl = "TS";
         test2.Timeout = 1;
         test2.ParentCallId = "TS";
         test2.PrivacyMode = true;
         test2.CallConnectUrl = "TS";

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        MakeCallRequest test1 = new MakeCallRequest("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", false, "TEST_STRING");
         test1.From = "TS";
         test1.To = "TS";
         test1.ApplicationId = "TS";
         test1.SendDigits = "TS";
         test1.IfMachine = "TS";
         test1.IfMachineUrl = "TS";
         test1.Timeout = 1;
         test1.ParentCallId = "TS";
         test1.PrivacyMode = true;
         test1.CallConnectUrl = "TS";
         string jsonStr = JsonConvert.SerializeObject(test1, Newtonsoft.Json.Formatting.Indented);

        MakeCallRequest test2 = new MakeCallRequest("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", false, "TEST_STRING");
         test2.From = "TS";
         test2.To = "TS";
         test2.ApplicationId = "TS";
         test2.SendDigits = "TS";
         test2.IfMachine = "TS";
         test2.IfMachineUrl = "TS";
         test2.Timeout = 1;
         test2.ParentCallId = "TS";
         test2.PrivacyMode = true;
         test2.CallConnectUrl = "TS";

        Assert.True(jsonStr.Equals(test2.ToJson()));
        }
    }
}
