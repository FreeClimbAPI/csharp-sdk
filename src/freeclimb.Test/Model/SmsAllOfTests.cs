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
    ///  Class for testing SmsAllOf
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SmsAllOfTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SmsAllOf
        private SmsAllOf instance;

        public SmsAllOfTests()
        {
            instance = new SmsAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING");
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SmsAllOf
        /// </summary>
        [Fact]
        public void SmsAllOfInstanceTest()
        {
            // TODO uncomment below to test "IsType" SmsAllOf
            Assert.IsType<SmsAllOf>(instance);
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
        /// Test the property 'Text'
        /// </summary>
        [Fact]
        public void TextTest()
        {
            instance.Text = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Text);
            
        }
        /// <summary>
        /// Test the property 'NotificationUrl'
        /// </summary>
        [Fact]
        public void NotificationUrlTest()
        {
            instance.NotificationUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.NotificationUrl);
            
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        SmsAllOf test1 = new SmsAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING");
         test1.To = "TS";
         test1.From = "TS";
         test1.Text = "TS";
         test1.NotificationUrl = "TS";
        SmsAllOf test2 = new SmsAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING");
         test2.To = "TS";
         test2.From = "TS";
         test2.Text = "TS";
         test2.NotificationUrl = "TS";

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        SmsAllOf test1 = new SmsAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING");
         test1.To = "TS";
         test1.From = "TS";
         test1.Text = "TS";
         test1.NotificationUrl = "TS";
        SmsAllOf test2 = new SmsAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING");
         test2.To = "ts";
         test2.From = "ts";
         test2.Text = "ts";
         test2.NotificationUrl = "ts";

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        SmsAllOf test1 = new SmsAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING");
         test1.To = "TS";
         test1.From = "TS";
         test1.Text = "TS";
         test1.NotificationUrl = "TS";

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        SmsAllOf test1 = new SmsAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING");
         test1.To = "TS";
         test1.From = "TS";
         test1.Text = "TS";
         test1.NotificationUrl = "TS";

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        SmsAllOf test1 = new SmsAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING");
         test1.To = "TS";
         test1.From = "TS";
         test1.Text = "TS";
         test1.NotificationUrl = "TS";

        SmsAllOf test2 = new SmsAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING");
         test2.To = "TS";
         test2.From = "TS";
         test2.Text = "TS";
         test2.NotificationUrl = "TS";

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }
    }
}
