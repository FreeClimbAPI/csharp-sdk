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
    ///  Class for testing RecordingResultAllOf
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RecordingResultAllOfTests
    {
        private RecordingResultAllOf instance;

        public RecordingResultAllOfTests()
        {
            
            instance = new RecordingResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING");
            
        }

        /// <summary>
        /// Test an instance of RecordingResultAllOf
        /// </summary>
        [Fact]
        public void RecordingResultAllOfInstanceTest()
        {
            Assert.IsType<RecordingResultAllOf>(instance);
        }


        /// <summary>
        /// Test the property 'RecordingId'
        /// </summary>
        [Fact]
        public void RecordingIdTest()
        {
            instance.RecordingId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.RecordingId);
            
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
        /// Test the property 'CallId'
        /// </summary>
        [Fact]
        public void CallIdTest()
        {
            instance.CallId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.CallId);
            
        }
        /// <summary>
        /// Test the property 'DurationSec'
        /// </summary>
        [Fact]
        public void DurationSecTest()
        {
            
            instance.DurationSec = 1;
            Assert.Equal(1, (int) instance.DurationSec);
        }
        /// <summary>
        /// Test the property 'ConferenceId'
        /// </summary>
        [Fact]
        public void ConferenceIdTest()
        {
            instance.ConferenceId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.ConferenceId);
            
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        RecordingResultAllOf test1 = new RecordingResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING");
         test1.RecordingId = "TS";
         test1.AccountId = "TS";
         test1.CallId = "TS";
         test1.DurationSec = 1;
         test1.ConferenceId = "TS";

        RecordingResultAllOf test2 = new RecordingResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING");
         test2.RecordingId = "TS";
         test2.AccountId = "TS";
         test2.CallId = "TS";
         test2.DurationSec = 1;
         test2.ConferenceId = "TS";

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        RecordingResultAllOf test1 = new RecordingResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING");
         test1.RecordingId = "TS";
         test1.AccountId = "TS";
         test1.CallId = "TS";
         test1.DurationSec = 1;
         test1.ConferenceId = "TS";

        RecordingResultAllOf test2 = new RecordingResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING");
         test2.RecordingId = "ts";
         test2.AccountId = "ts";
         test2.CallId = "ts";
         test2.DurationSec = 2;
         test2.ConferenceId = "ts";

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        RecordingResultAllOf test1 = new RecordingResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING");
         test1.RecordingId = "TS";
         test1.AccountId = "TS";
         test1.CallId = "TS";
         test1.DurationSec = 1;
         test1.ConferenceId = "TS";

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        RecordingResultAllOf test1 = new RecordingResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING");
         test1.RecordingId = "TS";
         test1.AccountId = "TS";
         test1.CallId = "TS";
         test1.DurationSec = 1;
         test1.ConferenceId = "TS";

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        RecordingResultAllOf test1 = new RecordingResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING");
         test1.RecordingId = "TS";
         test1.AccountId = "TS";
         test1.CallId = "TS";
         test1.DurationSec = 1;
         test1.ConferenceId = "TS";

        RecordingResultAllOf test2 = new RecordingResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING");
         test2.RecordingId = "TS";
         test2.AccountId = "TS";
         test2.CallId = "TS";
         test2.DurationSec = 1;
         test2.ConferenceId = "TS";

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        RecordingResultAllOf test1 = new RecordingResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING");
         test1.RecordingId = "TS";
         test1.AccountId = "TS";
         test1.CallId = "TS";
         test1.DurationSec = 1;
         test1.ConferenceId = "TS";

        RecordingResultAllOf test2 = new RecordingResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING");
         test2.RecordingId = "TS";
         test2.AccountId = "TS";
         test2.CallId = "TS";
         test2.DurationSec = 1;
         test2.ConferenceId = "TS";

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        RecordingResultAllOf test1 = new RecordingResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING");
         test1.RecordingId = "TS";
         test1.AccountId = "TS";
         test1.CallId = "TS";
         test1.DurationSec = 1;
         test1.ConferenceId = "TS";
        JsonSerializer jsonSerializer = JsonSerializer.Create();
        jsonSerializer.NullValueHandling = NullValueHandling.Ignore;
        StringBuilder strb = new StringBuilder();
        jsonSerializer.Serialize(new StringWriter(strb), test1);

        RecordingResultAllOf test2 = new RecordingResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING");
         test2.RecordingId = "TS";
         test2.AccountId = "TS";
         test2.CallId = "TS";
         test2.DurationSec = 1;
         test2.ConferenceId = "TS";

        Assert.True(strb.Equals(JsonConvert.SerializeObject(test2)));
        }
    }
}
