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
    ///  Class for testing CallResult
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CallResultTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CallResult
        private CallResult instance;

        public CallResultTests()
        {
            instance = new CallResult();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CallResult
        /// </summary>
        [Fact]
        public void CallResultInstanceTest()
        {
            // TODO uncomment below to test "IsType" CallResult
            Assert.IsType<CallResult>(instance);
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
    }
}
