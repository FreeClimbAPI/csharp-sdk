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
    ///  Class for testing RejectAllOf
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RejectAllOfTests
    {
        private RejectAllOf instance;

        public RejectAllOfTests()
        {
            instance = new RejectAllOf();
        }

        /// <summary>
        /// Test an instance of RejectAllOf
        /// </summary>
        [Fact]
        public void RejectAllOfInstanceTest()
        {
            Assert.IsType<RejectAllOf>(instance);
        }


        /// <summary>
        /// Test the property 'Reason'
        /// </summary>
        [Fact]
        public void ReasonTest()
        {
            instance.Reason = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Reason);
            
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        RejectAllOf test1 = new RejectAllOf();
         test1.Reason = "TS";

        RejectAllOf test2 = new RejectAllOf();
         test2.Reason = "TS";

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        RejectAllOf test1 = new RejectAllOf();
         test1.Reason = "TS";

        RejectAllOf test2 = new RejectAllOf();
         test2.Reason = "ts";

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        RejectAllOf test1 = new RejectAllOf();
         test1.Reason = "TS";

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        RejectAllOf test1 = new RejectAllOf();
         test1.Reason = "TS";

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        RejectAllOf test1 = new RejectAllOf();
         test1.Reason = "TS";

        RejectAllOf test2 = new RejectAllOf();
         test2.Reason = "TS";

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        RejectAllOf test1 = new RejectAllOf();
         test1.Reason = "TS";

        RejectAllOf test2 = new RejectAllOf();
         test2.Reason = "TS";

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        RejectAllOf test1 = new RejectAllOf();
         test1.Reason = "TS";
         string jsonStr = JsonConvert.SerializeObject(test1, Newtonsoft.Json.Formatting.Indented);

        RejectAllOf test2 = new RejectAllOf();
         test2.Reason = "TS";

        Assert.True(jsonStr.Equals(test2.ToJson()));
        }
    }
}
