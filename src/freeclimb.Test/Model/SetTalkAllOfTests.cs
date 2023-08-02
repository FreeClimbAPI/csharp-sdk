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
    ///  Class for testing SetTalkAllOf
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SetTalkAllOfTests
    {
        private SetTalkAllOf instance;

        public SetTalkAllOfTests()
        {
            instance = new SetTalkAllOf("TEST_STRING", false);
        }

        /// <summary>
        /// Test an instance of SetTalkAllOf
        /// </summary>
        [Fact]
        public void SetTalkAllOfInstanceTest()
        {
            Assert.IsType<SetTalkAllOf>(instance);
        }


        /// <summary>
        /// Test the property 'CallId'
        /// </summary>
        [Fact]
        public void CallIdTest()
        {
            instance.CallId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.CallId);
            
        }
        /// <summary>
        /// Test the property 'Talk'
        /// </summary>
        [Fact]
        public void TalkTest()
        {
            instance.Talk = false;
            Assert.Equal(false, instance.Talk);       
            
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        SetTalkAllOf test1 = new SetTalkAllOf("TEST_STRING", false);
         test1.CallId = "TS";
         test1.Talk = true;
        SetTalkAllOf test2 = new SetTalkAllOf("TEST_STRING", false);
         test2.CallId = "TS";
         test2.Talk = true;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        SetTalkAllOf test1 = new SetTalkAllOf("TEST_STRING", false);
         test1.CallId = "TS";
         test1.Talk = true;
        SetTalkAllOf test2 = new SetTalkAllOf("TEST_STRING", false);
         test2.CallId = "ts";
         test2.Talk = false;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        SetTalkAllOf test1 = new SetTalkAllOf("TEST_STRING", false);
         test1.CallId = "TS";
         test1.Talk = true;

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        SetTalkAllOf test1 = new SetTalkAllOf("TEST_STRING", false);
         test1.CallId = "TS";
         test1.Talk = true;

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        SetTalkAllOf test1 = new SetTalkAllOf("TEST_STRING", false);
         test1.CallId = "TS";
         test1.Talk = true;

        SetTalkAllOf test2 = new SetTalkAllOf("TEST_STRING", false);
         test2.CallId = "TS";
         test2.Talk = true;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }
    }
}
