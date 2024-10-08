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
    ///  Class for testing CreateWebRTCToken
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CreateWebRTCTokenTests
    {
        private CreateWebRTCToken instance;

        public CreateWebRTCTokenTests()
        {
            
            instance = new CreateWebRTCToken("TEST_STRING", "TEST_STRING", 1);
            
        }

        /// <summary>
        /// Test an instance of CreateWebRTCToken
        /// </summary>
        [Fact]
        public void CreateWebRTCTokenInstanceTest()
        {
            Assert.IsType<CreateWebRTCToken>(instance);
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
        /// Test the property 'From'
        /// </summary>
        [Fact]
        public void FromTest()
        {
            instance.From = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.From);
            
        }
        /// <summary>
        /// Test the property 'Uses'
        /// </summary>
        [Fact]
        public void UsesTest()
        {
            
            instance.Uses = 1;
            Assert.Equal(1, (int) instance.Uses);
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        CreateWebRTCToken test1 = new CreateWebRTCToken("TEST_STRING", "TEST_STRING", 1);
         test1.To = "TS";
         test1.From = "TS";
         test1.Uses = 1;

        CreateWebRTCToken test2 = new CreateWebRTCToken("TEST_STRING", "TEST_STRING", 1);
         test2.To = "TS";
         test2.From = "TS";
         test2.Uses = 1;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        CreateWebRTCToken test1 = new CreateWebRTCToken("TEST_STRING", "TEST_STRING", 1);
         test1.To = "TS";
         test1.From = "TS";
         test1.Uses = 1;

        CreateWebRTCToken test2 = new CreateWebRTCToken("TEST_STRING", "TEST_STRING", 1);
         test2.To = "ts";
         test2.From = "ts";
         test2.Uses = 2;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        CreateWebRTCToken test1 = new CreateWebRTCToken("TEST_STRING", "TEST_STRING", 1);
         test1.To = "TS";
         test1.From = "TS";
         test1.Uses = 1;

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        CreateWebRTCToken test1 = new CreateWebRTCToken("TEST_STRING", "TEST_STRING", 1);
         test1.To = "TS";
         test1.From = "TS";
         test1.Uses = 1;

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        CreateWebRTCToken test1 = new CreateWebRTCToken("TEST_STRING", "TEST_STRING", 1);
         test1.To = "TS";
         test1.From = "TS";
         test1.Uses = 1;

        CreateWebRTCToken test2 = new CreateWebRTCToken("TEST_STRING", "TEST_STRING", 1);
         test2.To = "TS";
         test2.From = "TS";
         test2.Uses = 1;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        CreateWebRTCToken test1 = new CreateWebRTCToken("TEST_STRING", "TEST_STRING", 1);
         test1.To = "TS";
         test1.From = "TS";
         test1.Uses = 1;

        CreateWebRTCToken test2 = new CreateWebRTCToken("TEST_STRING", "TEST_STRING", 1);
         test2.To = "TS";
         test2.From = "TS";
         test2.Uses = 1;

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        CreateWebRTCToken test1 = new CreateWebRTCToken("TEST_STRING", "TEST_STRING", 1);
         test1.To = "TS";
         test1.From = "TS";
         test1.Uses = 1;
        JsonSerializer jsonSerializer = JsonSerializer.Create();
        jsonSerializer.NullValueHandling = NullValueHandling.Ignore;
        StringBuilder strb = new StringBuilder();
        jsonSerializer.Serialize(new StringWriter(strb), test1);

        CreateWebRTCToken test2 = new CreateWebRTCToken("TEST_STRING", "TEST_STRING", 1);
         test2.To = "TS";
         test2.From = "TS";
         test2.Uses = 1;

        Assert.True(strb.Equals(JsonConvert.SerializeObject(test2)));
        }
    }
}
