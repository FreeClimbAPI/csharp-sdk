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
    ///  Class for testing QueueResult
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class QueueResultTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for QueueResult
        private QueueResult instance;

        public QueueResultTests()
        {
            instance = new QueueResult();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of QueueResult
        /// </summary>
        [Fact]
        public void QueueResultInstanceTest()
        {
            // TODO uncomment below to test "IsType" QueueResult
            Assert.IsType<QueueResult>(instance);
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
        /// Test the property 'QueueId'
        /// </summary>
        [Fact]
        public void QueueIdTest()
        {
            instance.QueueId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.QueueId);
            
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
        /// Test the property 'MaxSize'
        /// </summary>
        [Fact]
        public void MaxSizeTest()
        {
            
            instance.MaxSize = 1;
            Assert.Equal(1, (int) instance.MaxSize);
        }
        /// <summary>
        /// Test the property 'CurrentSize'
        /// </summary>
        [Fact]
        public void CurrentSizeTest()
        {
            
            instance.CurrentSize = 1;
            Assert.Equal(1, (int) instance.CurrentSize);
        }
        /// <summary>
        /// Test the property 'AverageQueueRemovalTime'
        /// </summary>
        [Fact]
        public void AverageQueueRemovalTimeTest()
        {
            
            instance.AverageQueueRemovalTime = 1;
            Assert.Equal(1, (int) instance.AverageQueueRemovalTime);
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
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        QueueResult test1 = new QueueResult();
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         test1.AccountId = "TS";
         test1.QueueId = "TS";
         test1.Alias = "TS";
         test1.MaxSize = 1;
         test1.CurrentSize = 1;
         test1.AverageQueueRemovalTime = 1;
         object testObject = new object();
         test1.SubresourceUris = testObject;
        QueueResult test2 = new QueueResult();
         test2.Uri = "TS";
         test2.DateCreated = "TS";
         test2.DateUpdated = "TS";
         test2.Revision = 1;
         test2.AccountId = "TS";
         test2.QueueId = "TS";
         test2.Alias = "TS";
         test2.MaxSize = 1;
         test2.CurrentSize = 1;
         test2.AverageQueueRemovalTime = 1;
         object testObject2 = testObject;
         test2.SubresourceUris = testObject2;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        QueueResult test1 = new QueueResult();
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         test1.AccountId = "TS";
         test1.QueueId = "TS";
         test1.Alias = "TS";
         test1.MaxSize = 1;
         test1.CurrentSize = 1;
         test1.AverageQueueRemovalTime = 1;
         object testObject = new object();
         test1.SubresourceUris = testObject;
        QueueResult test2 = new QueueResult();
         test2.Uri = "ts";
         test2.DateCreated = "ts";
         test2.DateUpdated = "ts";
         test2.Revision = 2;
         test2.AccountId = "ts";
         test2.QueueId = "ts";
         test2.Alias = "ts";
         test2.MaxSize = 2;
         test2.CurrentSize = 2;
         test2.AverageQueueRemovalTime = 2;
         object testObject2 = new object();
         test2.SubresourceUris = testObject2;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        QueueResult test1 = new QueueResult();
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         test1.AccountId = "TS";
         test1.QueueId = "TS";
         test1.Alias = "TS";
         test1.MaxSize = 1;
         test1.CurrentSize = 1;
         test1.AverageQueueRemovalTime = 1;
         object testObject = new object();
         test1.SubresourceUris = testObject;

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        QueueResult test1 = new QueueResult();
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         test1.AccountId = "TS";
         test1.QueueId = "TS";
         test1.Alias = "TS";
         test1.MaxSize = 1;
         test1.CurrentSize = 1;
         test1.AverageQueueRemovalTime = 1;
         object testObject = new object();
         test1.SubresourceUris = testObject;

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        QueueResult test1 = new QueueResult();
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         test1.AccountId = "TS";
         test1.QueueId = "TS";
         test1.Alias = "TS";
         test1.MaxSize = 1;
         test1.CurrentSize = 1;
         test1.AverageQueueRemovalTime = 1;
         object testObject = new object();
         test1.SubresourceUris = testObject;

        QueueResult test2 = new QueueResult();
         test2.Uri = "TS";
         test2.DateCreated = "TS";
         test2.DateUpdated = "TS";
         test2.Revision = 1;
         test2.AccountId = "TS";
         test2.QueueId = "TS";
         test2.Alias = "TS";
         test2.MaxSize = 1;
         test2.CurrentSize = 1;
         test2.AverageQueueRemovalTime = 1;
         object testObject2 = new object();
         test2.SubresourceUris = testObject2;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }
    }
}
