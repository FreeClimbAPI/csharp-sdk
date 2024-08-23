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
    ///  Class for testing UpdateCallRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UpdateCallRequestTests
    {
        private UpdateCallRequest instance;

        public UpdateCallRequestTests()
        {
            
            instance = new UpdateCallRequest(UpdateCallRequestStatus.CANCELED);
            
        }

        /// <summary>
        /// Test an instance of UpdateCallRequest
        /// </summary>
        [Fact]
        public void UpdateCallRequestInstanceTest()
        {
            Assert.IsType<UpdateCallRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            instance.Status = UpdateCallRequestStatus.CANCELED;
            Assert.Equal(instance.Status,UpdateCallRequestStatus.CANCELED);
            instance.Status = UpdateCallRequestStatus.COMPLETED;
            Assert.Equal(instance.Status,UpdateCallRequestStatus.COMPLETED);
            
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        UpdateCallRequest test1 = new UpdateCallRequest(UpdateCallRequestStatus.CANCELED);
         test1.Status = UpdateCallRequestStatus.CANCELED;

        UpdateCallRequest test2 = new UpdateCallRequest(UpdateCallRequestStatus.CANCELED);
         test2.Status = UpdateCallRequestStatus.CANCELED;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        UpdateCallRequest test1 = new UpdateCallRequest(UpdateCallRequestStatus.CANCELED);
         test1.Status = UpdateCallRequestStatus.CANCELED;

        UpdateCallRequest test2 = new UpdateCallRequest(UpdateCallRequestStatus.CANCELED);
         test2.Status = UpdateCallRequestStatus.COMPLETED;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        UpdateCallRequest test1 = new UpdateCallRequest(UpdateCallRequestStatus.CANCELED);
         test1.Status = UpdateCallRequestStatus.CANCELED;

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        UpdateCallRequest test1 = new UpdateCallRequest(UpdateCallRequestStatus.CANCELED);
         test1.Status = UpdateCallRequestStatus.CANCELED;

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        UpdateCallRequest test1 = new UpdateCallRequest(UpdateCallRequestStatus.CANCELED);
         test1.Status = UpdateCallRequestStatus.CANCELED;

        UpdateCallRequest test2 = new UpdateCallRequest(UpdateCallRequestStatus.CANCELED);
         test2.Status = UpdateCallRequestStatus.CANCELED;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        UpdateCallRequest test1 = new UpdateCallRequest(UpdateCallRequestStatus.CANCELED);
         test1.Status = UpdateCallRequestStatus.CANCELED;

        UpdateCallRequest test2 = new UpdateCallRequest(UpdateCallRequestStatus.CANCELED);
         test2.Status = UpdateCallRequestStatus.CANCELED;

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        UpdateCallRequest test1 = new UpdateCallRequest(UpdateCallRequestStatus.CANCELED);
         test1.Status = UpdateCallRequestStatus.CANCELED;
        JsonSerializer jsonSerializer = JsonSerializer.Create();
        jsonSerializer.NullValueHandling = NullValueHandling.Ignore;
        StringBuilder strb = new StringBuilder();
        jsonSerializer.Serialize(new StringWriter(strb), test1);

        UpdateCallRequest test2 = new UpdateCallRequest(UpdateCallRequestStatus.CANCELED);
         test2.Status = UpdateCallRequestStatus.CANCELED;

        Assert.True(strb.Equals(JsonConvert.SerializeObject(test2)));
        }
    }
}
