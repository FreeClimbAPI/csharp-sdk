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
    ///  Class for testing BuyIncomingNumberRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>

    public class BuyIncomingNumberRequestTests : IDisposable
    {
        private BuyIncomingNumberRequest instance;

        public BuyIncomingNumberRequestTests()
        {
            instance = new BuyIncomingNumberRequest(
                phoneNumber: (string)TestHelpers.getTestValue(typeof(string)),
                alias: (string)TestHelpers.getTestValue(typeof(string)),
                applicationId: (string)TestHelpers.getTestValue(typeof(string))
            );
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BuyIncomingNumberRequest
        /// </summary>
        [Fact]
        public void BuyIncomingNumberRequestInstanceTest()
        {
            Assert.IsType<BuyIncomingNumberRequest>(instance);
        }

        /// <summary>
        /// Test the property 'PhoneNumber'
        /// </summary>
        [Fact]
        public void PhoneNumberTest()
        {
            instance.PhoneNumber = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.PhoneNumber);
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
        /// Test the property 'ApplicationId'
        /// </summary>
        [Fact]
        public void ApplicationIdTest()
        {
            instance.ApplicationId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.ApplicationId);
        }
    }
}
