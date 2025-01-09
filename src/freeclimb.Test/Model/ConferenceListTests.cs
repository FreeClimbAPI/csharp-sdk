/*
 * FreeClimb API
 *
 * FreeClimb is a cloud-based application programming interface (API) that puts the power of the Vail platform in your hands. FreeClimb simplifies the process of creating applications that can use a full range of telephony features without requiring specialized or on-site telephony equipment. Using the FreeClimb REST API to write applications is easy! You have the option to use the language of your choice or hit the API directly. Your application can execute a command by issuing a RESTful request to the FreeClimb API. The base URL to send HTTP requests to the FreeClimb REST API is: /apiserver. FreeClimb authenticates and processes your request.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@freeclimb.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using freeclimb.Client;
using freeclimb.Enums;
using freeclimb.Model;
using freeclimb.Test;
using Newtonsoft.Json;
using Xunit;

namespace freeclimb.Test.Model
{
    /// <summary>
    ///  Class for testing ConferenceList
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>

    public class ConferenceListTests : IDisposable
    {
        private ConferenceList instance;

        public ConferenceListTests()
        {
            instance = new ConferenceList(
                total: (int?)TestHelpers.getTestValue(typeof(int?)),
                start: (int?)TestHelpers.getTestValue(typeof(int?)),
                end: (int?)TestHelpers.getTestValue(typeof(int?)),
                page: (int?)TestHelpers.getTestValue(typeof(int?)),
                numPages: (int?)TestHelpers.getTestValue(typeof(int?)),
                pageSize: (int?)TestHelpers.getTestValue(typeof(int?)),
                nextPageUri: (string)TestHelpers.getTestValue(typeof(string)),
                conferences: (List<ConferenceResult>)
                    TestHelpers.getTestValue(typeof(List<ConferenceResult>))
            );
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ConferenceList
        /// </summary>
        [Fact]
        public void ConferenceListInstanceTest()
        {
            Assert.IsType<ConferenceList>(instance);
        }

        /// <summary>
        /// Test the property 'Total'
        /// </summary>
        [Fact]
        public void TotalTest()
        {
            instance.Total = 1;
            Assert.Equal(1, (int)instance.Total);
        }

        /// <summary>
        /// Test the property 'Start'
        /// </summary>
        [Fact]
        public void StartTest()
        {
            instance.Start = 1;
            Assert.Equal(1, (int)instance.Start);
        }

        /// <summary>
        /// Test the property 'End'
        /// </summary>
        [Fact]
        public void EndTest()
        {
            instance.End = 1;
            Assert.Equal(1, (int)instance.End);
        }

        /// <summary>
        /// Test the property 'Page'
        /// </summary>
        [Fact]
        public void PageTest()
        {
            instance.Page = 1;
            Assert.Equal(1, (int)instance.Page);
        }

        /// <summary>
        /// Test the property 'NumPages'
        /// </summary>
        [Fact]
        public void NumPagesTest()
        {
            instance.NumPages = 1;
            Assert.Equal(1, (int)instance.NumPages);
        }

        /// <summary>
        /// Test the property 'PageSize'
        /// </summary>
        [Fact]
        public void PageSizeTest()
        {
            instance.PageSize = 1;
            Assert.Equal(1, (int)instance.PageSize);
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
        /// Test the property 'Conferences'
        /// </summary>
        [Fact]
        public void ConferencesTest()
        {
            List<ConferenceResult> testList = new List<ConferenceResult>();
            instance.Conferences = testList;
            Assert.Equal(instance.Conferences, testList);
        }
    }
}
