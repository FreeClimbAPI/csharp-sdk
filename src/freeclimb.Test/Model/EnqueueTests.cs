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


namespace freeclimb.Test.Model
{
    /// <summary>
    ///  Class for testing Enqueue
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EnqueueTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Enqueue
        private Enqueue instance;

        public EnqueueTests()
        {
            instance = new Enqueue("https://a.com", "https://a.com", "TEST_STRING", "https://a.com");
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Enqueue
        /// </summary>
        [Fact]
        public void EnqueueInstanceTest()
        {
            // TODO uncomment below to test "IsType" Enqueue
            Assert.IsType<Enqueue>(instance);
        }


        /// <summary>
        /// Test the property 'ActionUrl'
        /// </summary>
        [Fact]
        public void ActionUrlTest()
        {
            
            try {
                Uri uri = new Uri("https://a.com");
                instance.ActionUrl = uri.ToString();
                Assert.Equal(uri.ToString(), instance.ActionUrl);
            } catch (Exception ) {
                Console.WriteLine("Something went wrong.");
            }
        }
        /// <summary>
        /// Test the property 'NotificationUrl'
        /// </summary>
        [Fact]
        public void NotificationUrlTest()
        {
            
            try {
                Uri uri = new Uri("https://a.com");
                instance.NotificationUrl = uri.ToString();
                Assert.Equal(uri.ToString(), instance.NotificationUrl);
            } catch (Exception ) {
                Console.WriteLine("Something went wrong.");
            }
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
        /// Test the property 'WaitUrl'
        /// </summary>
        [Fact]
        public void WaitUrlTest()
        {
            instance.WaitUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.WaitUrl);
            
        }
    }
}
