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
    ///  Class for testing SayAllOf
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SayAllOfTests
    {
        private SayAllOf instance;

        public SayAllOfTests()
        {
            
            instance = new SayAllOf("TEST_STRING", "TEST_STRING", 1, false);
            
        }

        /// <summary>
        /// Test an instance of SayAllOf
        /// </summary>
        [Fact]
        public void SayAllOfInstanceTest()
        {
            Assert.IsType<SayAllOf>(instance);
        }


        /// <summary>
        /// Test the property 'Text'
        /// </summary>
        [Fact]
        public void TextTest()
        {
            instance.Text = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Text);
            
        }
        /// <summary>
        /// Test the property 'Language'
        /// </summary>
        [Fact]
        public void LanguageTest()
        {
            instance.Language = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Language);
            
        }
        /// <summary>
        /// Test the property 'Loop'
        /// </summary>
        [Fact]
        public void LoopTest()
        {
            
            instance.Loop = 1;
            Assert.Equal(1, (int) instance.Loop);
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
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        SayAllOf test1 = new SayAllOf("TEST_STRING", "TEST_STRING", 1, false);
         test1.Text = "TS";
         test1.Language = "TS";
         test1.Loop = 1;
         test1.PrivacyMode = true;

        SayAllOf test2 = new SayAllOf("TEST_STRING", "TEST_STRING", 1, false);
         test2.Text = "TS";
         test2.Language = "TS";
         test2.Loop = 1;
         test2.PrivacyMode = true;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        SayAllOf test1 = new SayAllOf("TEST_STRING", "TEST_STRING", 1, false);
         test1.Text = "TS";
         test1.Language = "TS";
         test1.Loop = 1;
         test1.PrivacyMode = true;

        SayAllOf test2 = new SayAllOf("TEST_STRING", "TEST_STRING", 1, false);
         test2.Text = "ts";
         test2.Language = "ts";
         test2.Loop = 2;
         test2.PrivacyMode = false;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        SayAllOf test1 = new SayAllOf("TEST_STRING", "TEST_STRING", 1, false);
         test1.Text = "TS";
         test1.Language = "TS";
         test1.Loop = 1;
         test1.PrivacyMode = true;

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        SayAllOf test1 = new SayAllOf("TEST_STRING", "TEST_STRING", 1, false);
         test1.Text = "TS";
         test1.Language = "TS";
         test1.Loop = 1;
         test1.PrivacyMode = true;

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        SayAllOf test1 = new SayAllOf("TEST_STRING", "TEST_STRING", 1, false);
         test1.Text = "TS";
         test1.Language = "TS";
         test1.Loop = 1;
         test1.PrivacyMode = true;

        SayAllOf test2 = new SayAllOf("TEST_STRING", "TEST_STRING", 1, false);
         test2.Text = "TS";
         test2.Language = "TS";
         test2.Loop = 1;
         test2.PrivacyMode = true;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        SayAllOf test1 = new SayAllOf("TEST_STRING", "TEST_STRING", 1, false);
         test1.Text = "TS";
         test1.Language = "TS";
         test1.Loop = 1;
         test1.PrivacyMode = true;

        SayAllOf test2 = new SayAllOf("TEST_STRING", "TEST_STRING", 1, false);
         test2.Text = "TS";
         test2.Language = "TS";
         test2.Loop = 1;
         test2.PrivacyMode = true;

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        SayAllOf test1 = new SayAllOf("TEST_STRING", "TEST_STRING", 1, false);
         test1.Text = "TS";
         test1.Language = "TS";
         test1.Loop = 1;
         test1.PrivacyMode = true;
        JsonSerializer jsonSerializer = JsonSerializer.Create();
        jsonSerializer.NullValueHandling = NullValueHandling.Ignore;
        StringBuilder strb = new StringBuilder();
        jsonSerializer.Serialize(new StringWriter(strb), test1);

        SayAllOf test2 = new SayAllOf("TEST_STRING", "TEST_STRING", 1, false);
         test2.Text = "TS";
         test2.Language = "TS";
         test2.Loop = 1;
         test2.PrivacyMode = true;

        Assert.True(strb.Equals(JsonConvert.SerializeObject(test2)));
        }
    }
}
