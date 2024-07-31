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
    ///  Class for testing ApplicationList
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ApplicationListTests
    {
        private ApplicationList instance;

        public ApplicationListTests()
        {
            instance = new ApplicationList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<ApplicationResult>());
        }

        /// <summary>
        /// Test an instance of ApplicationList
        /// </summary>
        [Fact]
        public void ApplicationListInstanceTest()
        {
            Assert.IsType<ApplicationList>(instance);
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
        /// Test the property 'Applications'
        /// </summary>
        [Fact]
        public void ApplicationsTest()
        {
            
            List<ApplicationResult> testList = new List<ApplicationResult>();
            instance.Applications = testList;
            Assert.Equal(testList, instance.Applications); 
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        ApplicationList test1 = new ApplicationList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<ApplicationResult>());
         test1.Total = 1;
         test1.Start = 1;
         test1.End = 1;
         test1.Page = 1;
         test1.NumPages = 1;
         test1.PageSize = 1;
         test1.NextPageUri = "TS";
         List<ApplicationResult> testList = new List<ApplicationResult>();
         test1.Applications = testList;

        ApplicationList test2 = new ApplicationList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<ApplicationResult>());
         test2.Total = 1;
         test2.Start = 1;
         test2.End = 1;
         test2.Page = 1;
         test2.NumPages = 1;
         test2.PageSize = 1;
         test2.NextPageUri = "TS";
         List<ApplicationResult> testList2 = new List<ApplicationResult>();
         test2.Applications = testList2;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        ApplicationList test1 = new ApplicationList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<ApplicationResult>());
         test1.Total = 1;
         test1.Start = 1;
         test1.End = 1;
         test1.Page = 1;
         test1.NumPages = 1;
         test1.PageSize = 1;
         test1.NextPageUri = "TS";
         List<ApplicationResult> testList = new List<ApplicationResult>();
         test1.Applications = testList;

        ApplicationList test2 = new ApplicationList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<ApplicationResult>());
         test2.Total = 2;
         test2.Start = 2;
         test2.End = 2;
         test2.Page = 2;
         test2.NumPages = 2;
         test2.PageSize = 2;
         test2.NextPageUri = "ts";
         List<ApplicationResult> testList2 = null;
         test2.Applications = testList2;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        ApplicationList test1 = new ApplicationList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<ApplicationResult>());
         test1.Total = 1;
         test1.Start = 1;
         test1.End = 1;
         test1.Page = 1;
         test1.NumPages = 1;
         test1.PageSize = 1;
         test1.NextPageUri = "TS";
         List<ApplicationResult> testList = new List<ApplicationResult>();
         test1.Applications = testList;

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        ApplicationList test1 = new ApplicationList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<ApplicationResult>());
         test1.Total = 1;
         test1.Start = 1;
         test1.End = 1;
         test1.Page = 1;
         test1.NumPages = 1;
         test1.PageSize = 1;
         test1.NextPageUri = "TS";
         List<ApplicationResult> testList = new List<ApplicationResult>();
         test1.Applications = testList;

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        ApplicationList test1 = new ApplicationList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<ApplicationResult>());
         test1.Total = 1;
         test1.Start = 1;
         test1.End = 1;
         test1.Page = 1;
         test1.NumPages = 1;
         test1.PageSize = 1;
         test1.NextPageUri = "TS";
         List<ApplicationResult> testList = new List<ApplicationResult>();
         test1.Applications = testList;

        ApplicationList test2 = new ApplicationList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<ApplicationResult>());
         test2.Total = 1;
         test2.Start = 1;
         test2.End = 1;
         test2.Page = 1;
         test2.NumPages = 1;
         test2.PageSize = 1;
         test2.NextPageUri = "TS";
         List<ApplicationResult> testList2 = new List<ApplicationResult>();
         test2.Applications = testList2;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        ApplicationList test1 = new ApplicationList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<ApplicationResult>());
         test1.Total = 1;
         test1.Start = 1;
         test1.End = 1;
         test1.Page = 1;
         test1.NumPages = 1;
         test1.PageSize = 1;
         test1.NextPageUri = "TS";
         List<ApplicationResult> testList = new List<ApplicationResult>();
         test1.Applications = testList;

        ApplicationList test2 = new ApplicationList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<ApplicationResult>());
         test2.Total = 1;
         test2.Start = 1;
         test2.End = 1;
         test2.Page = 1;
         test2.NumPages = 1;
         test2.PageSize = 1;
         test2.NextPageUri = "TS";
         List<ApplicationResult> testList2 = new List<ApplicationResult>();
         test2.Applications = testList2;

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        ApplicationList test1 = new ApplicationList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<ApplicationResult>());
         test1.Total = 1;
         test1.Start = 1;
         test1.End = 1;
         test1.Page = 1;
         test1.NumPages = 1;
         test1.PageSize = 1;
         test1.NextPageUri = "TS";
         List<ApplicationResult> testList = new List<ApplicationResult>();
         test1.Applications = testList;
         string jsonStr = JsonConvert.SerializeObject(test1, Newtonsoft.Json.Formatting.Indented);

        ApplicationList test2 = new ApplicationList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<ApplicationResult>());
         test2.Total = 1;
         test2.Start = 1;
         test2.End = 1;
         test2.Page = 1;
         test2.NumPages = 1;
         test2.PageSize = 1;
         test2.NextPageUri = "TS";
         List<ApplicationResult> testList2 = new List<ApplicationResult>();
         test2.Applications = testList2;

        Assert.True(jsonStr.Equals(test2.ToJson()));
        }
    }
}
