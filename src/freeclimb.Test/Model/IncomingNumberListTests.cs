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
    ///  Class for testing IncomingNumberList
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class IncomingNumberListTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for IncomingNumberList
        private IncomingNumberList instance;

        public IncomingNumberListTests()
        {
            instance = new IncomingNumberList();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IncomingNumberList
        /// </summary>
        [Fact]
        public void IncomingNumberListInstanceTest()
        {
            // TODO uncomment below to test "IsType" IncomingNumberList
            Assert.IsType<IncomingNumberList>(instance);
        }


        /// <summary>
        /// Test the property 'Total'
        /// </summary>
        [Fact]
        public void TotalTest()
        {
            
            instance.Total = 1;
            Assert.Equal(1, (int) instance.Total);
        }
        /// <summary>
        /// Test the property 'Start'
        /// </summary>
        [Fact]
        public void StartTest()
        {
            
            instance.Start = 1;
            Assert.Equal(1, (int) instance.Start);
        }
        /// <summary>
        /// Test the property 'End'
        /// </summary>
        [Fact]
        public void EndTest()
        {
            
            instance.End = 1;
            Assert.Equal(1, (int) instance.End);
        }
        /// <summary>
        /// Test the property 'Page'
        /// </summary>
        [Fact]
        public void PageTest()
        {
            
            instance.Page = 1;
            Assert.Equal(1, (int) instance.Page);
        }
        /// <summary>
        /// Test the property 'NumPages'
        /// </summary>
        [Fact]
        public void NumPagesTest()
        {
            
            instance.NumPages = 1;
            Assert.Equal(1, (int) instance.NumPages);
        }
        /// <summary>
        /// Test the property 'PageSize'
        /// </summary>
        [Fact]
        public void PageSizeTest()
        {
            
            instance.PageSize = 1;
            Assert.Equal(1, (int) instance.PageSize);
        }
        /// <summary>
        /// Test the property 'NextPageUri'
        /// </summary>
        [Fact]
        public void NextPageUriTest()
        {
            instance.NextPageUri = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.NextPageUri);
            
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
        IncomingNumberList test1 = new IncomingNumberList();
         test1.Total = 1;
         test1.Start = 1;
         test1.End = 1;
         test1.Page = 1;
         test1.NumPages = 1;
         test1.PageSize = 1;
         test1.NextPageUri = "TS";
         List<IncomingNumberResult> testList = new List<IncomingNumberResult>();
         test1.IncomingPhoneNumbers = testList;
        IncomingNumberList test2 = new IncomingNumberList();
         test2.Total = 1;
         test2.Start = 1;
         test2.End = 1;
         test2.Page = 1;
         test2.NumPages = 1;
         test2.PageSize = 1;
         test2.NextPageUri = "TS";
         List<IncomingNumberResult> testList2 = new List<IncomingNumberResult>();
         test2.IncomingPhoneNumbers = testList2;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        IncomingNumberList test1 = new IncomingNumberList();
         test1.Total = 1;
         test1.Start = 1;
         test1.End = 1;
         test1.Page = 1;
         test1.NumPages = 1;
         test1.PageSize = 1;
         test1.NextPageUri = "TS";
         List<IncomingNumberResult> testList = new List<IncomingNumberResult>();
         test1.IncomingPhoneNumbers = testList;
        IncomingNumberList test2 = new IncomingNumberList();
         test2.Total = 1;
         test2.Start = 1;
         test2.End = 1;
         test2.Page = 1;
         test2.NumPages = 1;
         test2.PageSize = 1;
         test2.NextPageUri = "ts";
         List<IncomingNumberResult> testList2 = null;
         test2.IncomingPhoneNumbers = testList2;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        IncomingNumberList test1 = new IncomingNumberList();
         test1.Total = 1;
         test1.Start = 1;
         test1.End = 1;
         test1.Page = 1;
         test1.NumPages = 1;
         test1.PageSize = 1;
         test1.NextPageUri = "TS";
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
        IncomingNumberList test1 = new IncomingNumberList();
         test1.Total = 1;
         test1.Start = 1;
         test1.End = 1;
         test1.Page = 1;
         test1.NumPages = 1;
         test1.PageSize = 1;
         test1.NextPageUri = "TS";
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
        IncomingNumberList test1 = new IncomingNumberList();
         test1.Total = 1;
         test1.Start = 1;
         test1.End = 1;
         test1.Page = 1;
         test1.NumPages = 1;
         test1.PageSize = 1;
         test1.NextPageUri = "TS";
         List<IncomingNumberResult> testList = new List<IncomingNumberResult>();
         test1.IncomingPhoneNumbers = testList;

        IncomingNumberList test2 = new IncomingNumberList();
         test2.Total = 1;
         test2.Start = 1;
         test2.End = 1;
         test2.Page = 1;
         test2.NumPages = 1;
         test2.PageSize = 1;
         test2.NextPageUri = "TS";
         List<IncomingNumberResult> testList2 = new List<IncomingNumberResult>();
         test2.IncomingPhoneNumbers = testList2;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }
    }
}
