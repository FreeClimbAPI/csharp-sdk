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
    ///  Class for testing BuyIncomingNumberRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class BuyIncomingNumberRequestTests
    {
        private BuyIncomingNumberRequest instance;

        public BuyIncomingNumberRequestTests()
        {
            instance = new BuyIncomingNumberRequest("TEST_STRING", "TEST_STRING", "TEST_STRING");
        }

        /// <summary>
        /// Test an instance of BuyIncomingNumberRequest
        /// </summary>
        [Fact]
        public void BuyIncomingNumberRequestInstanceTest()
        {
            Assert.IsType<BuyIncomingNumberRequest>(instance);
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
        /// Test the property 'ApplicationId'
        /// </summary>
        [Fact]
        public void ApplicationIdTest()
        {
            instance.ApplicationId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.ApplicationId);
            
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        BuyIncomingNumberRequest test1 = new BuyIncomingNumberRequest("TEST_STRING", "TEST_STRING", "TEST_STRING");
         test1.PhoneNumber = "TS";
         test1.Alias = "TS";
         test1.ApplicationId = "TS";

        BuyIncomingNumberRequest test2 = new BuyIncomingNumberRequest("TEST_STRING", "TEST_STRING", "TEST_STRING");
         test2.PhoneNumber = "TS";
         test2.Alias = "TS";
         test2.ApplicationId = "TS";

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        BuyIncomingNumberRequest test1 = new BuyIncomingNumberRequest("TEST_STRING", "TEST_STRING", "TEST_STRING");
         test1.PhoneNumber = "TS";
         test1.Alias = "TS";
         test1.ApplicationId = "TS";

        BuyIncomingNumberRequest test2 = new BuyIncomingNumberRequest("TEST_STRING", "TEST_STRING", "TEST_STRING");
         test2.PhoneNumber = "ts";
         test2.Alias = "ts";
         test2.ApplicationId = "ts";

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        BuyIncomingNumberRequest test1 = new BuyIncomingNumberRequest("TEST_STRING", "TEST_STRING", "TEST_STRING");
         test1.PhoneNumber = "TS";
         test1.Alias = "TS";
         test1.ApplicationId = "TS";

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        BuyIncomingNumberRequest test1 = new BuyIncomingNumberRequest("TEST_STRING", "TEST_STRING", "TEST_STRING");
         test1.PhoneNumber = "TS";
         test1.Alias = "TS";
         test1.ApplicationId = "TS";

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        BuyIncomingNumberRequest test1 = new BuyIncomingNumberRequest("TEST_STRING", "TEST_STRING", "TEST_STRING");
         test1.PhoneNumber = "TS";
         test1.Alias = "TS";
         test1.ApplicationId = "TS";

        BuyIncomingNumberRequest test2 = new BuyIncomingNumberRequest("TEST_STRING", "TEST_STRING", "TEST_STRING");
         test2.PhoneNumber = "TS";
         test2.Alias = "TS";
         test2.ApplicationId = "TS";

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        BuyIncomingNumberRequest test1 = new BuyIncomingNumberRequest("TEST_STRING", "TEST_STRING", "TEST_STRING");
         test1.PhoneNumber = "TS";
         test1.Alias = "TS";
         test1.ApplicationId = "TS";

        BuyIncomingNumberRequest test2 = new BuyIncomingNumberRequest("TEST_STRING", "TEST_STRING", "TEST_STRING");
         test2.PhoneNumber = "TS";
         test2.Alias = "TS";
         test2.ApplicationId = "TS";

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        BuyIncomingNumberRequest test1 = new BuyIncomingNumberRequest("TEST_STRING", "TEST_STRING", "TEST_STRING");
         test1.PhoneNumber = "TS";
         test1.Alias = "TS";
         test1.ApplicationId = "TS";
         string jsonStr = JsonConvert.SerializeObject(test1, Newtonsoft.Json.Formatting.Indented);

        BuyIncomingNumberRequest test2 = new BuyIncomingNumberRequest("TEST_STRING", "TEST_STRING", "TEST_STRING");
         test2.PhoneNumber = "TS";
         test2.Alias = "TS";
         test2.ApplicationId = "TS";

        Assert.True(jsonStr.Equals(test2.ToJson()));
        }
    }
}
