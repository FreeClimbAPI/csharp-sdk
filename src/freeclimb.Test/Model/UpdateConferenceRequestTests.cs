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
    ///  Class for testing UpdateConferenceRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UpdateConferenceRequestTests
    {
        private UpdateConferenceRequest instance;

        public UpdateConferenceRequestTests()
        {
            instance = new UpdateConferenceRequest();
        }

        /// <summary>
        /// Test an instance of UpdateConferenceRequest
        /// </summary>
        [Fact]
        public void UpdateConferenceRequestInstanceTest()
        {
            Assert.IsType<UpdateConferenceRequest>(instance);
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
        /// Test the property 'PlayBeep'
        /// </summary>
        [Fact]
        public void PlayBeepTest()
        {
            instance.PlayBeep = PlayBeep.ALWAYS;
            Assert.Equal(instance.PlayBeep,PlayBeep.ALWAYS);
            instance.PlayBeep = PlayBeep.NEVER;
            Assert.Equal(instance.PlayBeep,PlayBeep.NEVER);
            instance.PlayBeep = PlayBeep.ENTRY_ONLY;
            Assert.Equal(instance.PlayBeep,PlayBeep.ENTRY_ONLY);
            instance.PlayBeep = PlayBeep.EXIT_ONLY;
            Assert.Equal(instance.PlayBeep,PlayBeep.EXIT_ONLY);
            
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            instance.Status = UpdateConferenceRequestStatus.EMPTY;
            Assert.Equal(instance.Status,UpdateConferenceRequestStatus.EMPTY);
            instance.Status = UpdateConferenceRequestStatus.TERMINATED;
            Assert.Equal(instance.Status,UpdateConferenceRequestStatus.TERMINATED);
            
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        UpdateConferenceRequest test1 = new UpdateConferenceRequest();
         test1.Alias = "TS";
         test1.PlayBeep = PlayBeep.ALWAYS;
         test1.Status = UpdateConferenceRequestStatus.EMPTY;

        UpdateConferenceRequest test2 = new UpdateConferenceRequest();
         test2.Alias = "TS";
         test2.PlayBeep = PlayBeep.ALWAYS;
         test2.Status = UpdateConferenceRequestStatus.EMPTY;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        UpdateConferenceRequest test1 = new UpdateConferenceRequest();
         test1.Alias = "TS";
         test1.PlayBeep = PlayBeep.ALWAYS;
         test1.Status = UpdateConferenceRequestStatus.EMPTY;

        UpdateConferenceRequest test2 = new UpdateConferenceRequest();
         test2.Alias = "ts";
         test2.PlayBeep = PlayBeep.NEVER;
         test2.Status = UpdateConferenceRequestStatus.TERMINATED;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        UpdateConferenceRequest test1 = new UpdateConferenceRequest();
         test1.Alias = "TS";
         test1.PlayBeep = PlayBeep.ALWAYS;
         test1.Status = UpdateConferenceRequestStatus.EMPTY;

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        UpdateConferenceRequest test1 = new UpdateConferenceRequest();
         test1.Alias = "TS";
         test1.PlayBeep = PlayBeep.ALWAYS;
         test1.Status = UpdateConferenceRequestStatus.EMPTY;

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        UpdateConferenceRequest test1 = new UpdateConferenceRequest();
         test1.Alias = "TS";
         test1.PlayBeep = PlayBeep.ALWAYS;
         test1.Status = UpdateConferenceRequestStatus.EMPTY;

        UpdateConferenceRequest test2 = new UpdateConferenceRequest();
         test2.Alias = "TS";
         test2.PlayBeep = PlayBeep.ALWAYS;
         test2.Status = UpdateConferenceRequestStatus.EMPTY;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        UpdateConferenceRequest test1 = new UpdateConferenceRequest();
         test1.Alias = "TS";
         test1.PlayBeep = PlayBeep.ALWAYS;
         test1.Status = UpdateConferenceRequestStatus.EMPTY;

        UpdateConferenceRequest test2 = new UpdateConferenceRequest();
         test2.Alias = "TS";
         test2.PlayBeep = PlayBeep.ALWAYS;
         test2.Status = UpdateConferenceRequestStatus.EMPTY;

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        UpdateConferenceRequest test1 = new UpdateConferenceRequest();
         test1.Alias = "TS";
         test1.PlayBeep = PlayBeep.ALWAYS;
         test1.Status = UpdateConferenceRequestStatus.EMPTY;
         string jsonStr = JsonConvert.SerializeObject(test1, Newtonsoft.Json.Formatting.Indented);

        UpdateConferenceRequest test2 = new UpdateConferenceRequest();
         test2.Alias = "TS";
         test2.PlayBeep = PlayBeep.ALWAYS;
         test2.Status = UpdateConferenceRequestStatus.EMPTY;

        Assert.True(jsonStr.Equals(test2.ToJson()));
        }
    }
}
