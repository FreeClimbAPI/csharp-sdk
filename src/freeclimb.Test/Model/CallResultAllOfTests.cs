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
    ///  Class for testing CallResultAllOf
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CallResultAllOfTests
    {
        private CallResultAllOf instance;

        public CallResultAllOfTests()
        {
            
            instance = new CallResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", CallStatus.QUEUED, "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, 1, CallDirection.INBOUND, AnsweredBy.HUMAN, new object(), "TEST_STRING");
            
        }

        /// <summary>
        /// Test an instance of CallResultAllOf
        /// </summary>
        [Fact]
        public void CallResultAllOfInstanceTest()
        {
            Assert.IsType<CallResultAllOf>(instance);
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
        /// Test the property 'ParentCallId'
        /// </summary>
        [Fact]
        public void ParentCallIdTest()
        {
            instance.ParentCallId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.ParentCallId);
            
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
        /// Test the property 'From'
        /// </summary>
        [Fact]
        public void FromTest()
        {
            instance.From = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.From);
            
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
        /// Test the property 'PhoneNumberId'
        /// </summary>
        [Fact]
        public void PhoneNumberIdTest()
        {
            instance.PhoneNumberId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.PhoneNumberId);
            
        }
        /// <summary>
        /// Test the property 'CallStatus'
        /// </summary>
        [Fact]
        public void CallStatusTest()
        {
            instance.CallStatus = CallStatus.QUEUED;
            Assert.Equal(instance.CallStatus,CallStatus.QUEUED);
            instance.CallStatus = CallStatus.RINGING;
            Assert.Equal(instance.CallStatus,CallStatus.RINGING);
            instance.CallStatus = CallStatus.IN_PROGRESS;
            Assert.Equal(instance.CallStatus,CallStatus.IN_PROGRESS);
            instance.CallStatus = CallStatus.CANCELED;
            Assert.Equal(instance.CallStatus,CallStatus.CANCELED);
            instance.CallStatus = CallStatus.COMPLETED;
            Assert.Equal(instance.CallStatus,CallStatus.COMPLETED);
            instance.CallStatus = CallStatus.FAILED;
            Assert.Equal(instance.CallStatus,CallStatus.FAILED);
            instance.CallStatus = CallStatus.BUSY;
            Assert.Equal(instance.CallStatus,CallStatus.BUSY);
            instance.CallStatus = CallStatus.NO_ANSWER;
            Assert.Equal(instance.CallStatus,CallStatus.NO_ANSWER);
            
        }
        /// <summary>
        /// Test the property 'StartTime'
        /// </summary>
        [Fact]
        public void StartTimeTest()
        {
            instance.StartTime = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.StartTime);
            
        }
        /// <summary>
        /// Test the property 'ConnectTime'
        /// </summary>
        [Fact]
        public void ConnectTimeTest()
        {
            instance.ConnectTime = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.ConnectTime);
            
        }
        /// <summary>
        /// Test the property 'EndTime'
        /// </summary>
        [Fact]
        public void EndTimeTest()
        {
            instance.EndTime = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.EndTime);
            
        }
        /// <summary>
        /// Test the property 'Duration'
        /// </summary>
        [Fact]
        public void DurationTest()
        {
            
            instance.Duration = 1;
            Assert.Equal(1, (int) instance.Duration);
        }
        /// <summary>
        /// Test the property 'ConnectDuration'
        /// </summary>
        [Fact]
        public void ConnectDurationTest()
        {
            
            instance.ConnectDuration = 1;
            Assert.Equal(1, (int) instance.ConnectDuration);
        }
        /// <summary>
        /// Test the property 'Direction'
        /// </summary>
        [Fact]
        public void DirectionTest()
        {
            instance.Direction = CallDirection.INBOUND;
            Assert.Equal(instance.Direction,CallDirection.INBOUND);
            instance.Direction = CallDirection.OUTBOUND_API;
            Assert.Equal(instance.Direction,CallDirection.OUTBOUND_API);
            instance.Direction = CallDirection.OUTBOUND_DIAL;
            Assert.Equal(instance.Direction,CallDirection.OUTBOUND_DIAL);
            
        }
        /// <summary>
        /// Test the property 'AnsweredBy'
        /// </summary>
        [Fact]
        public void AnsweredByTest()
        {
            instance.AnsweredBy = AnsweredBy.HUMAN;
            Assert.Equal(instance.AnsweredBy,AnsweredBy.HUMAN);
            instance.AnsweredBy = AnsweredBy.MACHINE;
            Assert.Equal(instance.AnsweredBy,AnsweredBy.MACHINE);
            
        }
        /// <summary>
        /// Test the property 'SubresourceUris'
        /// </summary>
        [Fact]
        public void SubresourceUrisTest()
        {
            object testObject = new object();
            instance.SubresourceUris = testObject;
            Assert.Equal(testObject, instance.SubresourceUris);
            
        }
        /// <summary>
        /// Test the property 'ApplicationId'
        /// </summary>
        [Fact]
        public void ApplicationIdTest()
        {
            instance.ApplicationId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.ApplicationId);
            
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        CallResultAllOf test1 = new CallResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", CallStatus.QUEUED, "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, 1, CallDirection.INBOUND, AnsweredBy.HUMAN, new object(), "TEST_STRING");
         test1.CallId = "TS";
         test1.ParentCallId = "TS";
         test1.AccountId = "TS";
         test1.From = "TS";
         test1.To = "TS";
         test1.PhoneNumberId = "TS";
         test1.CallStatus = CallStatus.QUEUED;
         test1.StartTime = "TS";
         test1.ConnectTime = "TS";
         test1.EndTime = "TS";
         test1.Duration = 1;
         test1.ConnectDuration = 1;
         test1.Direction = CallDirection.INBOUND;
         test1.AnsweredBy = AnsweredBy.HUMAN;
         object testObject = new object();
         test1.SubresourceUris = testObject;
         test1.ApplicationId = "TS";

        CallResultAllOf test2 = new CallResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", CallStatus.QUEUED, "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, 1, CallDirection.INBOUND, AnsweredBy.HUMAN, new object(), "TEST_STRING");
         test2.CallId = "TS";
         test2.ParentCallId = "TS";
         test2.AccountId = "TS";
         test2.From = "TS";
         test2.To = "TS";
         test2.PhoneNumberId = "TS";
         test2.CallStatus = CallStatus.QUEUED;
         test2.StartTime = "TS";
         test2.ConnectTime = "TS";
         test2.EndTime = "TS";
         test2.Duration = 1;
         test2.ConnectDuration = 1;
         test2.Direction = CallDirection.INBOUND;
         test2.AnsweredBy = AnsweredBy.HUMAN;
         object testObject2 = testObject;
         test2.SubresourceUris = testObject2;
         test2.ApplicationId = "TS";

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        CallResultAllOf test1 = new CallResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", CallStatus.QUEUED, "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, 1, CallDirection.INBOUND, AnsweredBy.HUMAN, new object(), "TEST_STRING");
         test1.CallId = "TS";
         test1.ParentCallId = "TS";
         test1.AccountId = "TS";
         test1.From = "TS";
         test1.To = "TS";
         test1.PhoneNumberId = "TS";
         test1.CallStatus = CallStatus.QUEUED;
         test1.StartTime = "TS";
         test1.ConnectTime = "TS";
         test1.EndTime = "TS";
         test1.Duration = 1;
         test1.ConnectDuration = 1;
         test1.Direction = CallDirection.INBOUND;
         test1.AnsweredBy = AnsweredBy.HUMAN;
         object testObject = new object();
         test1.SubresourceUris = testObject;
         test1.ApplicationId = "TS";

        CallResultAllOf test2 = new CallResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", CallStatus.QUEUED, "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, 1, CallDirection.INBOUND, AnsweredBy.HUMAN, new object(), "TEST_STRING");
         test2.CallId = "ts";
         test2.ParentCallId = "ts";
         test2.AccountId = "ts";
         test2.From = "ts";
         test2.To = "ts";
         test2.PhoneNumberId = "ts";
         test2.CallStatus = CallStatus.RINGING;
         test2.StartTime = "ts";
         test2.ConnectTime = "ts";
         test2.EndTime = "ts";
         test2.Duration = 2;
         test2.ConnectDuration = 2;
         test2.Direction = CallDirection.OUTBOUND_API;
         test2.AnsweredBy = AnsweredBy.MACHINE;
         object testObject2 = new object();
         test2.SubresourceUris = testObject2;
         test2.ApplicationId = "ts";

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        CallResultAllOf test1 = new CallResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", CallStatus.QUEUED, "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, 1, CallDirection.INBOUND, AnsweredBy.HUMAN, new object(), "TEST_STRING");
         test1.CallId = "TS";
         test1.ParentCallId = "TS";
         test1.AccountId = "TS";
         test1.From = "TS";
         test1.To = "TS";
         test1.PhoneNumberId = "TS";
         test1.CallStatus = CallStatus.QUEUED;
         test1.StartTime = "TS";
         test1.ConnectTime = "TS";
         test1.EndTime = "TS";
         test1.Duration = 1;
         test1.ConnectDuration = 1;
         test1.Direction = CallDirection.INBOUND;
         test1.AnsweredBy = AnsweredBy.HUMAN;
         object testObject = new object();
         test1.SubresourceUris = testObject;
         test1.ApplicationId = "TS";

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        CallResultAllOf test1 = new CallResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", CallStatus.QUEUED, "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, 1, CallDirection.INBOUND, AnsweredBy.HUMAN, new object(), "TEST_STRING");
         test1.CallId = "TS";
         test1.ParentCallId = "TS";
         test1.AccountId = "TS";
         test1.From = "TS";
         test1.To = "TS";
         test1.PhoneNumberId = "TS";
         test1.CallStatus = CallStatus.QUEUED;
         test1.StartTime = "TS";
         test1.ConnectTime = "TS";
         test1.EndTime = "TS";
         test1.Duration = 1;
         test1.ConnectDuration = 1;
         test1.Direction = CallDirection.INBOUND;
         test1.AnsweredBy = AnsweredBy.HUMAN;
         object testObject = new object();
         test1.SubresourceUris = testObject;
         test1.ApplicationId = "TS";

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        CallResultAllOf test1 = new CallResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", CallStatus.QUEUED, "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, 1, CallDirection.INBOUND, AnsweredBy.HUMAN, new object(), "TEST_STRING");
         test1.CallId = "TS";
         test1.ParentCallId = "TS";
         test1.AccountId = "TS";
         test1.From = "TS";
         test1.To = "TS";
         test1.PhoneNumberId = "TS";
         test1.CallStatus = CallStatus.QUEUED;
         test1.StartTime = "TS";
         test1.ConnectTime = "TS";
         test1.EndTime = "TS";
         test1.Duration = 1;
         test1.ConnectDuration = 1;
         test1.Direction = CallDirection.INBOUND;
         test1.AnsweredBy = AnsweredBy.HUMAN;
         object testObject = new object();
         test1.SubresourceUris = testObject;
         test1.ApplicationId = "TS";

        CallResultAllOf test2 = new CallResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", CallStatus.QUEUED, "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, 1, CallDirection.INBOUND, AnsweredBy.HUMAN, new object(), "TEST_STRING");
         test2.CallId = "TS";
         test2.ParentCallId = "TS";
         test2.AccountId = "TS";
         test2.From = "TS";
         test2.To = "TS";
         test2.PhoneNumberId = "TS";
         test2.CallStatus = CallStatus.QUEUED;
         test2.StartTime = "TS";
         test2.ConnectTime = "TS";
         test2.EndTime = "TS";
         test2.Duration = 1;
         test2.ConnectDuration = 1;
         test2.Direction = CallDirection.INBOUND;
         test2.AnsweredBy = AnsweredBy.HUMAN;
         object testObject2 = new object();
         test2.SubresourceUris = testObject2;
         test2.ApplicationId = "TS";

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        CallResultAllOf test1 = new CallResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", CallStatus.QUEUED, "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, 1, CallDirection.INBOUND, AnsweredBy.HUMAN, new object(), "TEST_STRING");
         test1.CallId = "TS";
         test1.ParentCallId = "TS";
         test1.AccountId = "TS";
         test1.From = "TS";
         test1.To = "TS";
         test1.PhoneNumberId = "TS";
         test1.CallStatus = CallStatus.QUEUED;
         test1.StartTime = "TS";
         test1.ConnectTime = "TS";
         test1.EndTime = "TS";
         test1.Duration = 1;
         test1.ConnectDuration = 1;
         test1.Direction = CallDirection.INBOUND;
         test1.AnsweredBy = AnsweredBy.HUMAN;
         object testObject = new object();
         test1.SubresourceUris = testObject;
         test1.ApplicationId = "TS";

        CallResultAllOf test2 = new CallResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", CallStatus.QUEUED, "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, 1, CallDirection.INBOUND, AnsweredBy.HUMAN, new object(), "TEST_STRING");
         test2.CallId = "TS";
         test2.ParentCallId = "TS";
         test2.AccountId = "TS";
         test2.From = "TS";
         test2.To = "TS";
         test2.PhoneNumberId = "TS";
         test2.CallStatus = CallStatus.QUEUED;
         test2.StartTime = "TS";
         test2.ConnectTime = "TS";
         test2.EndTime = "TS";
         test2.Duration = 1;
         test2.ConnectDuration = 1;
         test2.Direction = CallDirection.INBOUND;
         test2.AnsweredBy = AnsweredBy.HUMAN;
         object testObject2 = testObject;
         test2.SubresourceUris = testObject2;
         test2.ApplicationId = "TS";

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        CallResultAllOf test1 = new CallResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", CallStatus.QUEUED, "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, 1, CallDirection.INBOUND, AnsweredBy.HUMAN, new object(), "TEST_STRING");
         test1.CallId = "TS";
         test1.ParentCallId = "TS";
         test1.AccountId = "TS";
         test1.From = "TS";
         test1.To = "TS";
         test1.PhoneNumberId = "TS";
         test1.CallStatus = CallStatus.QUEUED;
         test1.StartTime = "TS";
         test1.ConnectTime = "TS";
         test1.EndTime = "TS";
         test1.Duration = 1;
         test1.ConnectDuration = 1;
         test1.Direction = CallDirection.INBOUND;
         test1.AnsweredBy = AnsweredBy.HUMAN;
         object testObject = new object();
         test1.SubresourceUris = testObject;
         test1.ApplicationId = "TS";
        JsonSerializer jsonSerializer = JsonSerializer.Create();
        jsonSerializer.NullValueHandling = NullValueHandling.Ignore;
        StringBuilder strb = new StringBuilder();
        jsonSerializer.Serialize(new StringWriter(strb), test1);

        CallResultAllOf test2 = new CallResultAllOf("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", CallStatus.QUEUED, "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, 1, CallDirection.INBOUND, AnsweredBy.HUMAN, new object(), "TEST_STRING");
         test2.CallId = "TS";
         test2.ParentCallId = "TS";
         test2.AccountId = "TS";
         test2.From = "TS";
         test2.To = "TS";
         test2.PhoneNumberId = "TS";
         test2.CallStatus = CallStatus.QUEUED;
         test2.StartTime = "TS";
         test2.ConnectTime = "TS";
         test2.EndTime = "TS";
         test2.Duration = 1;
         test2.ConnectDuration = 1;
         test2.Direction = CallDirection.INBOUND;
         test2.AnsweredBy = AnsweredBy.HUMAN;
         object testObject2 = testObject;
         test2.SubresourceUris = testObject2;
         test2.ApplicationId = "TS";

        Assert.True(strb.Equals(JsonConvert.SerializeObject(test2)));
        }
    }
}
