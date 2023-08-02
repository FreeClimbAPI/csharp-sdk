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
    ///  Class for testing RecordingListAllOf
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RecordingListAllOfTests
    {
        private RecordingListAllOf instance;

        public RecordingListAllOfTests()
        {
            instance = new RecordingListAllOf();
        }

        /// <summary>
        /// Test an instance of RecordingListAllOf
        /// </summary>
        [Fact]
        public void RecordingListAllOfInstanceTest()
        {
            Assert.IsType<RecordingListAllOf>(instance);
        }


        /// <summary>
        /// Test the property 'Recordings'
        /// </summary>
        [Fact]
        public void RecordingsTest()
        {
            
            List<RecordingResult> testList = new List<RecordingResult>();
            instance.Recordings = testList;
            Assert.Equal(testList, instance.Recordings); 
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        RecordingListAllOf test1 = new RecordingListAllOf();
         List<RecordingResult> testList = new List<RecordingResult>();
         test1.Recordings = testList;
        RecordingListAllOf test2 = new RecordingListAllOf();
         List<RecordingResult> testList2 = new List<RecordingResult>();
         test2.Recordings = testList2;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        RecordingListAllOf test1 = new RecordingListAllOf();
         List<RecordingResult> testList = new List<RecordingResult>();
         test1.Recordings = testList;
        RecordingListAllOf test2 = new RecordingListAllOf();
         List<RecordingResult> testList2 = null;
         test2.Recordings = testList2;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        RecordingListAllOf test1 = new RecordingListAllOf();
         List<RecordingResult> testList = new List<RecordingResult>();
         test1.Recordings = testList;

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        RecordingListAllOf test1 = new RecordingListAllOf();
         List<RecordingResult> testList = new List<RecordingResult>();
         test1.Recordings = testList;

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        RecordingListAllOf test1 = new RecordingListAllOf();
         List<RecordingResult> testList = new List<RecordingResult>();
         test1.Recordings = testList;

        RecordingListAllOf test2 = new RecordingListAllOf();
         List<RecordingResult> testList2 = new List<RecordingResult>();
         test2.Recordings = testList2;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }
    }
}
