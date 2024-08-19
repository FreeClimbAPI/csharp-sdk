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
    ///  Class for testing QueueList
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class QueueListTests
    {
        private QueueList instance;

        public QueueListTests()
        {
            instance = new QueueList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<QueueResult>());
        }

        /// <summary>
        /// Test an instance of QueueList
        /// </summary>
        [Fact]
        public void QueueListInstanceTest()
        {
            Assert.IsType<QueueList>(instance);
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
        /// Test the property 'Queues'
        /// </summary>
        [Fact]
        public void QueuesTest()
        {
            
            List<QueueResult> testList = new List<QueueResult>();
            instance.Queues = testList;
            Assert.Equal(testList, instance.Queues); 
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        QueueList test1 = new QueueList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<QueueResult>());
         test1.Total = 1;
         test1.Start = 1;
         test1.End = 1;
         test1.Page = 1;
         test1.NumPages = 1;
         test1.PageSize = 1;
         test1.NextPageUri = "TS";
         List<QueueResult> testList = new List<QueueResult>();
         test1.Queues = testList;

        QueueList test2 = new QueueList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<QueueResult>());
         test2.Total = 1;
         test2.Start = 1;
         test2.End = 1;
         test2.Page = 1;
         test2.NumPages = 1;
         test2.PageSize = 1;
         test2.NextPageUri = "TS";
         List<QueueResult> testList2 = new List<QueueResult>();
         test2.Queues = testList2;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        QueueList test1 = new QueueList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<QueueResult>());
         test1.Total = 1;
         test1.Start = 1;
         test1.End = 1;
         test1.Page = 1;
         test1.NumPages = 1;
         test1.PageSize = 1;
         test1.NextPageUri = "TS";
         List<QueueResult> testList = new List<QueueResult>();
         test1.Queues = testList;

        QueueList test2 = new QueueList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<QueueResult>());
         test2.Total = 2;
         test2.Start = 2;
         test2.End = 2;
         test2.Page = 2;
         test2.NumPages = 2;
         test2.PageSize = 2;
         test2.NextPageUri = "ts";
         List<QueueResult> testList2 = null;
         test2.Queues = testList2;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        QueueList test1 = new QueueList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<QueueResult>());
         test1.Total = 1;
         test1.Start = 1;
         test1.End = 1;
         test1.Page = 1;
         test1.NumPages = 1;
         test1.PageSize = 1;
         test1.NextPageUri = "TS";
         List<QueueResult> testList = new List<QueueResult>();
         test1.Queues = testList;

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        QueueList test1 = new QueueList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<QueueResult>());
         test1.Total = 1;
         test1.Start = 1;
         test1.End = 1;
         test1.Page = 1;
         test1.NumPages = 1;
         test1.PageSize = 1;
         test1.NextPageUri = "TS";
         List<QueueResult> testList = new List<QueueResult>();
         test1.Queues = testList;

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        QueueList test1 = new QueueList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<QueueResult>());
         test1.Total = 1;
         test1.Start = 1;
         test1.End = 1;
         test1.Page = 1;
         test1.NumPages = 1;
         test1.PageSize = 1;
         test1.NextPageUri = "TS";
         List<QueueResult> testList = new List<QueueResult>();
         test1.Queues = testList;

        QueueList test2 = new QueueList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<QueueResult>());
         test2.Total = 1;
         test2.Start = 1;
         test2.End = 1;
         test2.Page = 1;
         test2.NumPages = 1;
         test2.PageSize = 1;
         test2.NextPageUri = "TS";
         List<QueueResult> testList2 = new List<QueueResult>();
         test2.Queues = testList2;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        QueueList test1 = new QueueList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<QueueResult>());
         test1.Total = 1;
         test1.Start = 1;
         test1.End = 1;
         test1.Page = 1;
         test1.NumPages = 1;
         test1.PageSize = 1;
         test1.NextPageUri = "TS";
         List<QueueResult> testList = new List<QueueResult>();
         test1.Queues = testList;

        QueueList test2 = new QueueList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<QueueResult>());
         test2.Total = 1;
         test2.Start = 1;
         test2.End = 1;
         test2.Page = 1;
         test2.NumPages = 1;
         test2.PageSize = 1;
         test2.NextPageUri = "TS";
         List<QueueResult> testList2 = new List<QueueResult>();
         test2.Queues = testList2;

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        QueueList test1 = new QueueList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<QueueResult>());
         test1.Total = 1;
         test1.Start = 1;
         test1.End = 1;
         test1.Page = 1;
         test1.NumPages = 1;
         test1.PageSize = 1;
         test1.NextPageUri = "TS";
         List<QueueResult> testList = new List<QueueResult>();
         test1.Queues = testList;
        JsonSerializer jsonSerializer = JsonSerializer.Create();
        jsonSerializer.NullValueHandling = NullValueHandling.Ignore;
        StringBuilder strb = new StringBuilder();
        jsonSerializer.Serialize(new StringWriter(strb), test1);

        QueueList test2 = new QueueList(1, 1, 1, 1, 1, 1, "TEST_STRING", new List<QueueResult>());
         test2.Total = 1;
         test2.Start = 1;
         test2.End = 1;
         test2.Page = 1;
         test2.NumPages = 1;
         test2.PageSize = 1;
         test2.NextPageUri = "TS";
         List<QueueResult> testList2 = new List<QueueResult>();
         test2.Queues = testList2;

        Assert.True(strb.Equals(JsonConvert.SerializeObject(test2)));
        }
    }
}
