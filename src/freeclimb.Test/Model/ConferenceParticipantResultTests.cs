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
    ///  Class for testing ConferenceParticipantResult
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ConferenceParticipantResultTests
    {
        private ConferenceParticipantResult instance;

        public ConferenceParticipantResultTests()
        {
            instance = new ConferenceParticipantResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false);
        }

        /// <summary>
        /// Test an instance of ConferenceParticipantResult
        /// </summary>
        [Fact]
        public void ConferenceParticipantResultInstanceTest()
        {
            Assert.IsType<ConferenceParticipantResult>(instance);
        }


        /// <summary>
        /// Test the property 'Uri'
        /// </summary>
        [Fact]
        public void UriTest()
        {
            instance.Uri = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Uri);
            
        }
        /// <summary>
        /// Test the property 'DateCreated'
        /// </summary>
        [Fact]
        public void DateCreatedTest()
        {
            instance.DateCreated = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.DateCreated);
            
        }
        /// <summary>
        /// Test the property 'DateUpdated'
        /// </summary>
        [Fact]
        public void DateUpdatedTest()
        {
            instance.DateUpdated = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.DateUpdated);
            
        }
        /// <summary>
        /// Test the property 'Revision'
        /// </summary>
        [Fact]
        public void RevisionTest()
        {
            
            instance.Revision = 1;
            Assert.Equal(1, (int) instance.Revision);
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
        /// Test the property 'ConferenceId'
        /// </summary>
        [Fact]
        public void ConferenceIdTest()
        {
            instance.ConferenceId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.ConferenceId);
            
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
        /// Test the property 'Listen'
        /// </summary>
        [Fact]
        public void ListenTest()
        {
            instance.Listen = false;
            Assert.Equal(false, instance.Listen);       
            
        }
        /// <summary>
        /// Test the property 'StartConfOnEnter'
        /// </summary>
        [Fact]
        public void StartConfOnEnterTest()
        {
            instance.StartConfOnEnter = false;
            Assert.Equal(false, instance.StartConfOnEnter);       
            
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        ConferenceParticipantResult test1 = new ConferenceParticipantResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false);
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         test1.AccountId = "TS";
         test1.ConferenceId = "TS";
         test1.CallId = "TS";
         test1.Talk = true;
         test1.Listen = true;
         test1.StartConfOnEnter = true;

        ConferenceParticipantResult test2 = new ConferenceParticipantResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false);
         test2.Uri = "TS";
         test2.DateCreated = "TS";
         test2.DateUpdated = "TS";
         test2.Revision = 1;
         test2.AccountId = "TS";
         test2.ConferenceId = "TS";
         test2.CallId = "TS";
         test2.Talk = true;
         test2.Listen = true;
         test2.StartConfOnEnter = true;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        ConferenceParticipantResult test1 = new ConferenceParticipantResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false);
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         test1.AccountId = "TS";
         test1.ConferenceId = "TS";
         test1.CallId = "TS";
         test1.Talk = true;
         test1.Listen = true;
         test1.StartConfOnEnter = true;

        ConferenceParticipantResult test2 = new ConferenceParticipantResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false);
         test2.Uri = "ts";
         test2.DateCreated = "ts";
         test2.DateUpdated = "ts";
         test2.Revision = 2;
         test2.AccountId = "ts";
         test2.ConferenceId = "ts";
         test2.CallId = "ts";
         test2.Talk = false;
         test2.Listen = false;
         test2.StartConfOnEnter = false;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        ConferenceParticipantResult test1 = new ConferenceParticipantResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false);
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         test1.AccountId = "TS";
         test1.ConferenceId = "TS";
         test1.CallId = "TS";
         test1.Talk = true;
         test1.Listen = true;
         test1.StartConfOnEnter = true;

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        ConferenceParticipantResult test1 = new ConferenceParticipantResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false);
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         test1.AccountId = "TS";
         test1.ConferenceId = "TS";
         test1.CallId = "TS";
         test1.Talk = true;
         test1.Listen = true;
         test1.StartConfOnEnter = true;

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        ConferenceParticipantResult test1 = new ConferenceParticipantResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false);
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         test1.AccountId = "TS";
         test1.ConferenceId = "TS";
         test1.CallId = "TS";
         test1.Talk = true;
         test1.Listen = true;
         test1.StartConfOnEnter = true;

        ConferenceParticipantResult test2 = new ConferenceParticipantResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false);
         test2.Uri = "TS";
         test2.DateCreated = "TS";
         test2.DateUpdated = "TS";
         test2.Revision = 1;
         test2.AccountId = "TS";
         test2.ConferenceId = "TS";
         test2.CallId = "TS";
         test2.Talk = true;
         test2.Listen = true;
         test2.StartConfOnEnter = true;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        ConferenceParticipantResult test1 = new ConferenceParticipantResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false);
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         test1.AccountId = "TS";
         test1.ConferenceId = "TS";
         test1.CallId = "TS";
         test1.Talk = true;
         test1.Listen = true;
         test1.StartConfOnEnter = true;

        ConferenceParticipantResult test2 = new ConferenceParticipantResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false);
         test2.Uri = "TS";
         test2.DateCreated = "TS";
         test2.DateUpdated = "TS";
         test2.Revision = 1;
         test2.AccountId = "TS";
         test2.ConferenceId = "TS";
         test2.CallId = "TS";
         test2.Talk = true;
         test2.Listen = true;
         test2.StartConfOnEnter = true;

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        ConferenceParticipantResult test1 = new ConferenceParticipantResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false);
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         test1.AccountId = "TS";
         test1.ConferenceId = "TS";
         test1.CallId = "TS";
         test1.Talk = true;
         test1.Listen = true;
         test1.StartConfOnEnter = true;
        JsonSerializer jsonSerializer = JsonSerializer.Create();
        jsonSerializer.NullValueHandling = NullValueHandling.Ignore;
        StringBuilder strb = new StringBuilder();
        jsonSerializer.Serialize(new StringWriter(strb), test1);

        ConferenceParticipantResult test2 = new ConferenceParticipantResult("TEST_STRING", "TEST_STRING", "TEST_STRING", 1, "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false);
         test2.Uri = "TS";
         test2.DateCreated = "TS";
         test2.DateUpdated = "TS";
         test2.Revision = 1;
         test2.AccountId = "TS";
         test2.ConferenceId = "TS";
         test2.CallId = "TS";
         test2.Talk = true;
         test2.Listen = true;
         test2.StartConfOnEnter = true;

        Assert.True(strb.Equals(JsonConvert.SerializeObject(test2)));
        }
    }
}
