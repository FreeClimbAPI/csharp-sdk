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
    ///  Class for testing IncomingNumberListAllOf
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class IncomingNumberListAllOfTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for IncomingNumberListAllOf
        private IncomingNumberListAllOf instance;

        public IncomingNumberListAllOfTests()
        {
            instance = new IncomingNumberListAllOf();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IncomingNumberListAllOf
        /// </summary>
        [Fact]
        public void IncomingNumberListAllOfInstanceTest()
        {
            // TODO uncomment below to test "IsType" IncomingNumberListAllOf
            Assert.IsType<IncomingNumberListAllOf>(instance);
        }


        /// <summary>
        /// Test the property 'IncomingPhoneNumbers'
        /// </summary>
        [Fact]
        public void IncomingPhoneNumbersTest()
        {
            
            List<IncomingNumberResult> testList = new List<IncomingNumberResult>();
            instance.IncomingPhoneNumbers = testList;
            Assert.Equal(testList, instance.IncomingPhoneNumbers); 
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        IncomingNumberListAllOf test1 = new IncomingNumberListAllOf();
         List<IncomingNumberResult> testList = new List<IncomingNumberResult>();
         test1.IncomingPhoneNumbers = testList;
        IncomingNumberListAllOf test2 = new IncomingNumberListAllOf();
         List<IncomingNumberResult> testList2 = new List<IncomingNumberResult>();
         test2.IncomingPhoneNumbers = testList2;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        IncomingNumberListAllOf test1 = new IncomingNumberListAllOf();
         List<IncomingNumberResult> testList = new List<IncomingNumberResult>();
         test1.IncomingPhoneNumbers = testList;
        IncomingNumberListAllOf test2 = new IncomingNumberListAllOf();
         List<IncomingNumberResult> testList2 = null;
         test2.IncomingPhoneNumbers = testList2;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        IncomingNumberListAllOf test1 = new IncomingNumberListAllOf();
         List<IncomingNumberResult> testList = new List<IncomingNumberResult>();
         test1.IncomingPhoneNumbers = testList;

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        IncomingNumberListAllOf test1 = new IncomingNumberListAllOf();
         List<IncomingNumberResult> testList = new List<IncomingNumberResult>();
         test1.IncomingPhoneNumbers = testList;

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        IncomingNumberListAllOf test1 = new IncomingNumberListAllOf();
         List<IncomingNumberResult> testList = new List<IncomingNumberResult>();
         test1.IncomingPhoneNumbers = testList;

        IncomingNumberListAllOf test2 = new IncomingNumberListAllOf();
         List<IncomingNumberResult> testList2 = new List<IncomingNumberResult>();
         test2.IncomingPhoneNumbers = testList2;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }
    }
}
