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
    ///  Class for testing TranscribeUtteranceAllOfRecord
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TranscribeUtteranceAllOfRecordTests
    {
        private TranscribeUtteranceAllOfRecord instance;

        public TranscribeUtteranceAllOfRecordTests()
        {
            
            instance = new TranscribeUtteranceAllOfRecord(false, 1, 1);
            
        }

        /// <summary>
        /// Test an instance of TranscribeUtteranceAllOfRecord
        /// </summary>
        [Fact]
        public void TranscribeUtteranceAllOfRecordInstanceTest()
        {
            Assert.IsType<TranscribeUtteranceAllOfRecord>(instance);
        }


        /// <summary>
        /// Test the property 'SaveRecording'
        /// </summary>
        [Fact]
        public void SaveRecordingTest()
        {
            instance.SaveRecording = false;
            Assert.Equal(false, instance.SaveRecording);       
            
        }
        /// <summary>
        /// Test the property 'MaxLengthSec'
        /// </summary>
        [Fact]
        public void MaxLengthSecTest()
        {
            
            instance.MaxLengthSec = 1;
            Assert.Equal(1, (int) instance.MaxLengthSec);
        }
        /// <summary>
        /// Test the property 'RcrdTerminationSilenceTimeMs'
        /// </summary>
        [Fact]
        public void RcrdTerminationSilenceTimeMsTest()
        {
            
            instance.RcrdTerminationSilenceTimeMs = 1;
            Assert.Equal(1, (int) instance.RcrdTerminationSilenceTimeMs);
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        TranscribeUtteranceAllOfRecord test1 = new TranscribeUtteranceAllOfRecord(false, 1, 1);
         test1.SaveRecording = true;
         test1.MaxLengthSec = 1;
         test1.RcrdTerminationSilenceTimeMs = 1;

        TranscribeUtteranceAllOfRecord test2 = new TranscribeUtteranceAllOfRecord(false, 1, 1);
         test2.SaveRecording = true;
         test2.MaxLengthSec = 1;
         test2.RcrdTerminationSilenceTimeMs = 1;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        TranscribeUtteranceAllOfRecord test1 = new TranscribeUtteranceAllOfRecord(false, 1, 1);
         test1.SaveRecording = true;
         test1.MaxLengthSec = 1;
         test1.RcrdTerminationSilenceTimeMs = 1;

        TranscribeUtteranceAllOfRecord test2 = new TranscribeUtteranceAllOfRecord(false, 1, 1);
         test2.SaveRecording = false;
         test2.MaxLengthSec = 2;
         test2.RcrdTerminationSilenceTimeMs = 2;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        TranscribeUtteranceAllOfRecord test1 = new TranscribeUtteranceAllOfRecord(false, 1, 1);
         test1.SaveRecording = true;
         test1.MaxLengthSec = 1;
         test1.RcrdTerminationSilenceTimeMs = 1;

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        TranscribeUtteranceAllOfRecord test1 = new TranscribeUtteranceAllOfRecord(false, 1, 1);
         test1.SaveRecording = true;
         test1.MaxLengthSec = 1;
         test1.RcrdTerminationSilenceTimeMs = 1;

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        TranscribeUtteranceAllOfRecord test1 = new TranscribeUtteranceAllOfRecord(false, 1, 1);
         test1.SaveRecording = true;
         test1.MaxLengthSec = 1;
         test1.RcrdTerminationSilenceTimeMs = 1;

        TranscribeUtteranceAllOfRecord test2 = new TranscribeUtteranceAllOfRecord(false, 1, 1);
         test2.SaveRecording = true;
         test2.MaxLengthSec = 1;
         test2.RcrdTerminationSilenceTimeMs = 1;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        TranscribeUtteranceAllOfRecord test1 = new TranscribeUtteranceAllOfRecord(false, 1, 1);
         test1.SaveRecording = true;
         test1.MaxLengthSec = 1;
         test1.RcrdTerminationSilenceTimeMs = 1;

        TranscribeUtteranceAllOfRecord test2 = new TranscribeUtteranceAllOfRecord(false, 1, 1);
         test2.SaveRecording = true;
         test2.MaxLengthSec = 1;
         test2.RcrdTerminationSilenceTimeMs = 1;

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        TranscribeUtteranceAllOfRecord test1 = new TranscribeUtteranceAllOfRecord(false, 1, 1);
         test1.SaveRecording = true;
         test1.MaxLengthSec = 1;
         test1.RcrdTerminationSilenceTimeMs = 1;
        JsonSerializer jsonSerializer = JsonSerializer.Create();
        jsonSerializer.NullValueHandling = NullValueHandling.Ignore;
        StringBuilder strb = new StringBuilder();
        jsonSerializer.Serialize(new StringWriter(strb), test1);

        TranscribeUtteranceAllOfRecord test2 = new TranscribeUtteranceAllOfRecord(false, 1, 1);
         test2.SaveRecording = true;
         test2.MaxLengthSec = 1;
         test2.RcrdTerminationSilenceTimeMs = 1;

        Assert.True(strb.Equals(JsonConvert.SerializeObject(test2)));
        }
    }
}
