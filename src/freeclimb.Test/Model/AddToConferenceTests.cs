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
    ///  Class for testing AddToConference
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AddToConferenceTests
    {
        private AddToConference instance;

        public AddToConferenceTests()
        {
            instance = new AddToConference(false, "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, "TEST_STRING", false, false, "TEST_STRING");
        }

        /// <summary>
        /// Test an instance of AddToConference
        /// </summary>
        [Fact]
        public void AddToConferenceInstanceTest()
        {
            Assert.IsType<AddToConference>(instance);
        }


        /// <summary>
        /// Test the property 'AllowCallControl'
        /// </summary>
        [Fact]
        public void AllowCallControlTest()
        {
            instance.AllowCallControl = false;
            Assert.Equal(false, instance.AllowCallControl);       
            
        }
        /// <summary>
        /// Test the property 'CallControlSequence'
        /// </summary>
        [Fact]
        public void CallControlSequenceTest()
        {
            instance.CallControlSequence = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.CallControlSequence);
            
        }
        /// <summary>
        /// Test the property 'CallControlUrl'
        /// </summary>
        [Fact]
        public void CallControlUrlTest()
        {
            instance.CallControlUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.CallControlUrl);
            
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
        /// Test the property 'LeaveConferenceUrl'
        /// </summary>
        [Fact]
        public void LeaveConferenceUrlTest()
        {
            instance.LeaveConferenceUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.LeaveConferenceUrl);
            
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
        /// Test the property 'NotificationUrl'
        /// </summary>
        [Fact]
        public void NotificationUrlTest()
        {
            instance.NotificationUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.NotificationUrl);
            
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
        AddToConference test1 = new AddToConference(false, "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, "TEST_STRING", false, false, "TEST_STRING");
         test1.AllowCallControl = true;
         test1.CallControlSequence = "TS";
         test1.CallControlUrl = "TS";
         test1.ConferenceId = "TS";
         test1.CallId = "TS";
         test1.LeaveConferenceUrl = "TS";
         test1.Listen = true;
         test1.NotificationUrl = "TS";
         test1.StartConfOnEnter = true;
         test1.Talk = true;

        AddToConference test2 = new AddToConference(false, "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, "TEST_STRING", false, false, "TEST_STRING");
         test2.AllowCallControl = true;
         test2.CallControlSequence = "TS";
         test2.CallControlUrl = "TS";
         test2.ConferenceId = "TS";
         test2.CallId = "TS";
         test2.LeaveConferenceUrl = "TS";
         test2.Listen = true;
         test2.NotificationUrl = "TS";
         test2.StartConfOnEnter = true;
         test2.Talk = true;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        AddToConference test1 = new AddToConference(false, "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, "TEST_STRING", false, false, "TEST_STRING");
         test1.AllowCallControl = true;
         test1.CallControlSequence = "TS";
         test1.CallControlUrl = "TS";
         test1.ConferenceId = "TS";
         test1.CallId = "TS";
         test1.LeaveConferenceUrl = "TS";
         test1.Listen = true;
         test1.NotificationUrl = "TS";
         test1.StartConfOnEnter = true;
         test1.Talk = true;

        AddToConference test2 = new AddToConference(false, "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, "TEST_STRING", false, false, "TEST_STRING");
         test2.AllowCallControl = false;
         test2.CallControlSequence = "ts";
         test2.CallControlUrl = "ts";
         test2.ConferenceId = "ts";
         test2.CallId = "ts";
         test2.LeaveConferenceUrl = "ts";
         test2.Listen = false;
         test2.NotificationUrl = "ts";
         test2.StartConfOnEnter = false;
         test2.Talk = false;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        AddToConference test1 = new AddToConference(false, "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, "TEST_STRING", false, false, "TEST_STRING");
         test1.AllowCallControl = true;
         test1.CallControlSequence = "TS";
         test1.CallControlUrl = "TS";
         test1.ConferenceId = "TS";
         test1.CallId = "TS";
         test1.LeaveConferenceUrl = "TS";
         test1.Listen = true;
         test1.NotificationUrl = "TS";
         test1.StartConfOnEnter = true;
         test1.Talk = true;

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        AddToConference test1 = new AddToConference(false, "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, "TEST_STRING", false, false, "TEST_STRING");
         test1.AllowCallControl = true;
         test1.CallControlSequence = "TS";
         test1.CallControlUrl = "TS";
         test1.ConferenceId = "TS";
         test1.CallId = "TS";
         test1.LeaveConferenceUrl = "TS";
         test1.Listen = true;
         test1.NotificationUrl = "TS";
         test1.StartConfOnEnter = true;
         test1.Talk = true;

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        AddToConference test1 = new AddToConference(false, "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, "TEST_STRING", false, false, "TEST_STRING");
         test1.AllowCallControl = true;
         test1.CallControlSequence = "TS";
         test1.CallControlUrl = "TS";
         test1.ConferenceId = "TS";
         test1.CallId = "TS";
         test1.LeaveConferenceUrl = "TS";
         test1.Listen = true;
         test1.NotificationUrl = "TS";
         test1.StartConfOnEnter = true;
         test1.Talk = true;

        AddToConference test2 = new AddToConference(false, "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, "TEST_STRING", false, false, "TEST_STRING");
         test2.AllowCallControl = true;
         test2.CallControlSequence = "TS";
         test2.CallControlUrl = "TS";
         test2.ConferenceId = "TS";
         test2.CallId = "TS";
         test2.LeaveConferenceUrl = "TS";
         test2.Listen = true;
         test2.NotificationUrl = "TS";
         test2.StartConfOnEnter = true;
         test2.Talk = true;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        AddToConference test1 = new AddToConference(false, "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, "TEST_STRING", false, false, "TEST_STRING");
         test1.AllowCallControl = true;
         test1.CallControlSequence = "TS";
         test1.CallControlUrl = "TS";
         test1.ConferenceId = "TS";
         test1.CallId = "TS";
         test1.LeaveConferenceUrl = "TS";
         test1.Listen = true;
         test1.NotificationUrl = "TS";
         test1.StartConfOnEnter = true;
         test1.Talk = true;

        AddToConference test2 = new AddToConference(false, "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, "TEST_STRING", false, false, "TEST_STRING");
         test2.AllowCallControl = true;
         test2.CallControlSequence = "TS";
         test2.CallControlUrl = "TS";
         test2.ConferenceId = "TS";
         test2.CallId = "TS";
         test2.LeaveConferenceUrl = "TS";
         test2.Listen = true;
         test2.NotificationUrl = "TS";
         test2.StartConfOnEnter = true;
         test2.Talk = true;

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        AddToConference test1 = new AddToConference(false, "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, "TEST_STRING", false, false, "TEST_STRING");
         test1.AllowCallControl = true;
         test1.CallControlSequence = "TS";
         test1.CallControlUrl = "TS";
         test1.ConferenceId = "TS";
         test1.CallId = "TS";
         test1.LeaveConferenceUrl = "TS";
         test1.Listen = true;
         test1.NotificationUrl = "TS";
         test1.StartConfOnEnter = true;
         test1.Talk = true;
        JsonSerializer jsonSerializer = JsonSerializer.Create();
        jsonSerializer.NullValueHandling = NullValueHandling.Ignore;
        StringBuilder strb = new StringBuilder();
        jsonSerializer.Serialize(new StringWriter(strb), test1);

        AddToConference test2 = new AddToConference(false, "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", false, "TEST_STRING", false, false, "TEST_STRING");
         test2.AllowCallControl = true;
         test2.CallControlSequence = "TS";
         test2.CallControlUrl = "TS";
         test2.ConferenceId = "TS";
         test2.CallId = "TS";
         test2.LeaveConferenceUrl = "TS";
         test2.Listen = true;
         test2.NotificationUrl = "TS";
         test2.StartConfOnEnter = true;
         test2.Talk = true;

        Assert.True(strb.Equals(JsonConvert.SerializeObject(test2)));
        }
    }
}
