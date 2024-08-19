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
    ///  Class for testing TranscribeUtteranceAllOf
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TranscribeUtteranceAllOfTests
    {
        private TranscribeUtteranceAllOf instance;

        public TranscribeUtteranceAllOfTests()
        {
            instance = new TranscribeUtteranceAllOf("TEST_STRING", false, new TranscribeUtteranceAllOfRecord(), false, false, new List<Object>());
        }

        /// <summary>
        /// Test an instance of TranscribeUtteranceAllOf
        /// </summary>
        [Fact]
        public void TranscribeUtteranceAllOfInstanceTest()
        {
            Assert.IsType<TranscribeUtteranceAllOf>(instance);
        }


        /// <summary>
        /// Test the property 'ActionUrl'
        /// </summary>
        [Fact]
        public void ActionUrlTest()
        {
            instance.ActionUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.ActionUrl);
            
        }
        /// <summary>
        /// Test the property 'PlayBeep'
        /// </summary>
        [Fact]
        public void PlayBeepTest()
        {
            instance.PlayBeep = false;
            Assert.Equal(false, instance.PlayBeep);       
            
        }
        /// <summary>
        /// Test the property 'Record'
        /// </summary>
        [Fact]
        public void RecordTest()
        {
            TranscribeUtteranceAllOfRecord testObject = new TranscribeUtteranceAllOfRecord();
            instance.Record = testObject;
            Assert.Equal(testObject, instance.Record);
            
        }
        /// <summary>
        /// Test the property 'PrivacyForLogging'
        /// </summary>
        [Fact]
        public void PrivacyForLoggingTest()
        {
            instance.PrivacyForLogging = false;
            Assert.Equal(false, instance.PrivacyForLogging);       
            
        }
        /// <summary>
        /// Test the property 'PrivacyForRecording'
        /// </summary>
        [Fact]
        public void PrivacyForRecordingTest()
        {
            instance.PrivacyForRecording = false;
            Assert.Equal(false, instance.PrivacyForRecording);       
            
        }
        /// <summary>
        /// Test the property 'Prompts'
        /// </summary>
        [Fact]
        public void PromptsTest()
        {
            
            List<Object> testList = new List<Object>();
            instance.Prompts = testList;
            Assert.Equal(testList, instance.Prompts); 
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        TranscribeUtteranceAllOf test1 = new TranscribeUtteranceAllOf("TEST_STRING", false, new TranscribeUtteranceAllOfRecord(), false, false, new List<Object>());
         test1.ActionUrl = "TS";
         test1.PlayBeep = true;
         TranscribeUtteranceAllOfRecord RecordtestObject = new TranscribeUtteranceAllOfRecord();
         test1.Record = RecordtestObject;
         test1.PrivacyForLogging = true;
         test1.PrivacyForRecording = true;
         List<Object> testList = new List<Object>();
         test1.Prompts = testList;

        TranscribeUtteranceAllOf test2 = new TranscribeUtteranceAllOf("TEST_STRING", false, new TranscribeUtteranceAllOfRecord(), false, false, new List<Object>());
         test2.ActionUrl = "TS";
         test2.PlayBeep = true;
         TranscribeUtteranceAllOfRecord RecordtestObject2 = new TranscribeUtteranceAllOfRecord();
         test2.Record = RecordtestObject2;
         test2.PrivacyForLogging = true;
         test2.PrivacyForRecording = true;
         List<Object> testList2 = new List<Object>();
         test2.Prompts = testList2;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        TranscribeUtteranceAllOf test1 = new TranscribeUtteranceAllOf("TEST_STRING", false, new TranscribeUtteranceAllOfRecord(), false, false, new List<Object>());
         test1.ActionUrl = "TS";
         test1.PlayBeep = true;
         TranscribeUtteranceAllOfRecord RecordtestObject = new TranscribeUtteranceAllOfRecord();
         test1.Record = RecordtestObject;
         test1.PrivacyForLogging = true;
         test1.PrivacyForRecording = true;
         List<Object> testList = new List<Object>();
         test1.Prompts = testList;

        TranscribeUtteranceAllOf test2 = new TranscribeUtteranceAllOf("TEST_STRING", false, new TranscribeUtteranceAllOfRecord(), false, false, new List<Object>());
         test2.ActionUrl = "ts";
         test2.PlayBeep = false;
         TranscribeUtteranceAllOfRecord RecordtestObject2 = new TranscribeUtteranceAllOfRecord();
         test2.Record = RecordtestObject2;
         test2.PrivacyForLogging = false;
         test2.PrivacyForRecording = false;
         List<Object> testList2 = null;
         test2.Prompts = testList2;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        TranscribeUtteranceAllOf test1 = new TranscribeUtteranceAllOf("TEST_STRING", false, new TranscribeUtteranceAllOfRecord(), false, false, new List<Object>());
         test1.ActionUrl = "TS";
         test1.PlayBeep = true;
         TranscribeUtteranceAllOfRecord RecordtestObject = new TranscribeUtteranceAllOfRecord();
         test1.Record = RecordtestObject;
         test1.PrivacyForLogging = true;
         test1.PrivacyForRecording = true;
         List<Object> testList = new List<Object>();
         test1.Prompts = testList;

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        TranscribeUtteranceAllOf test1 = new TranscribeUtteranceAllOf("TEST_STRING", false, new TranscribeUtteranceAllOfRecord(), false, false, new List<Object>());
         test1.ActionUrl = "TS";
         test1.PlayBeep = true;
         TranscribeUtteranceAllOfRecord RecordtestObject = new TranscribeUtteranceAllOfRecord();
         test1.Record = RecordtestObject;
         test1.PrivacyForLogging = true;
         test1.PrivacyForRecording = true;
         List<Object> testList = new List<Object>();
         test1.Prompts = testList;

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        TranscribeUtteranceAllOf test1 = new TranscribeUtteranceAllOf("TEST_STRING", false, new TranscribeUtteranceAllOfRecord(), false, false, new List<Object>());
         test1.ActionUrl = "TS";
         test1.PlayBeep = true;
         TranscribeUtteranceAllOfRecord RecordtestObject = new TranscribeUtteranceAllOfRecord();
         test1.Record = RecordtestObject;
         test1.PrivacyForLogging = true;
         test1.PrivacyForRecording = true;
         List<Object> testList = new List<Object>();
         test1.Prompts = testList;

        TranscribeUtteranceAllOf test2 = new TranscribeUtteranceAllOf("TEST_STRING", false, new TranscribeUtteranceAllOfRecord(), false, false, new List<Object>());
         test2.ActionUrl = "TS";
         test2.PlayBeep = true;
         TranscribeUtteranceAllOfRecord RecordtestObject2 = new TranscribeUtteranceAllOfRecord();
         test2.Record = RecordtestObject2;
         test2.PrivacyForLogging = true;
         test2.PrivacyForRecording = true;
         List<Object> testList2 = new List<Object>();
         test2.Prompts = testList2;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        TranscribeUtteranceAllOf test1 = new TranscribeUtteranceAllOf("TEST_STRING", false, new TranscribeUtteranceAllOfRecord(), false, false, new List<Object>());
         test1.ActionUrl = "TS";
         test1.PlayBeep = true;
         TranscribeUtteranceAllOfRecord RecordtestObject = new TranscribeUtteranceAllOfRecord();
         test1.Record = RecordtestObject;
         test1.PrivacyForLogging = true;
         test1.PrivacyForRecording = true;
         List<Object> testList = new List<Object>();
         test1.Prompts = testList;

        TranscribeUtteranceAllOf test2 = new TranscribeUtteranceAllOf("TEST_STRING", false, new TranscribeUtteranceAllOfRecord(), false, false, new List<Object>());
         test2.ActionUrl = "TS";
         test2.PlayBeep = true;
         TranscribeUtteranceAllOfRecord RecordtestObject2 = new TranscribeUtteranceAllOfRecord();
         test2.Record = RecordtestObject2;
         test2.PrivacyForLogging = true;
         test2.PrivacyForRecording = true;
         List<Object> testList2 = new List<Object>();
         test2.Prompts = testList2;

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        TranscribeUtteranceAllOf test1 = new TranscribeUtteranceAllOf("TEST_STRING", false, new TranscribeUtteranceAllOfRecord(), false, false, new List<Object>());
         test1.ActionUrl = "TS";
         test1.PlayBeep = true;
         TranscribeUtteranceAllOfRecord RecordtestObject = new TranscribeUtteranceAllOfRecord();
         test1.Record = RecordtestObject;
         test1.PrivacyForLogging = true;
         test1.PrivacyForRecording = true;
         List<Object> testList = new List<Object>();
         test1.Prompts = testList;
        JsonSerializer jsonSerializer = JsonSerializer.Create();
        jsonSerializer.NullValueHandling = NullValueHandling.Ignore;
        StringBuilder strb = new StringBuilder();
        jsonSerializer.Serialize(new StringWriter(strb), test1);

        TranscribeUtteranceAllOf test2 = new TranscribeUtteranceAllOf("TEST_STRING", false, new TranscribeUtteranceAllOfRecord(), false, false, new List<Object>());
         test2.ActionUrl = "TS";
         test2.PlayBeep = true;
         TranscribeUtteranceAllOfRecord RecordtestObject2 = new TranscribeUtteranceAllOfRecord();
         test2.Record = RecordtestObject2;
         test2.PrivacyForLogging = true;
         test2.PrivacyForRecording = true;
         List<Object> testList2 = new List<Object>();
         test2.Prompts = testList2;

        Assert.True(strb.Equals(JsonConvert.SerializeObject(test2)));
        }
    }
}
