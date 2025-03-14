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
    ///  Class for testing AccountResult
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>

    public class AccountResultTests : IDisposable
    {
        private AccountResult instance;

        public AccountResultTests()
        {
            instance = new AccountResult(
                uri: (string)TestHelpers.getTestValue(typeof(string)),
                dateCreated: (string)TestHelpers.getTestValue(typeof(string)),
                dateUpdated: (string)TestHelpers.getTestValue(typeof(string)),
                revision: (int)TestHelpers.getTestValue(typeof(int)),
                accountId: (string)TestHelpers.getTestValue(typeof(string)),
                apiKey: (string)TestHelpers.getTestValue(typeof(string)),
                alias: (string)TestHelpers.getTestValue(typeof(string)),
                label: (string)TestHelpers.getTestValue(typeof(string)),
                type: (AccountType)TestHelpers.getTestValue(typeof(AccountType)),
                status: (AccountStatus)TestHelpers.getTestValue(typeof(AccountStatus)),
                subresourceUris: (Object)TestHelpers.getTestValue(typeof(Object))
            );
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AccountResult
        /// </summary>
        [Fact]
        public void AccountResultInstanceTest()
        {
            Assert.IsType<AccountResult>(instance);
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
            Assert.Equal(1, (int)instance.Revision);
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
        /// Test the property 'ApiKey'
        /// </summary>
        [Fact]
        public void ApiKeyTest()
        {
            instance.ApiKey = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.ApiKey);
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
        /// Test the property 'Label'
        /// </summary>
        [Fact]
        public void LabelTest()
        {
            instance.Label = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Label);
        }

        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            instance.Type = AccountType.TRIAL;
            Assert.Equal(AccountType.TRIAL, instance.Type);
            instance.Type = AccountType.FULL;
            Assert.Equal(AccountType.FULL, instance.Type);
        }

        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            instance.Status = AccountStatus.CLOSED;
            Assert.Equal(AccountStatus.CLOSED, instance.Status);
            instance.Status = AccountStatus.SUSPENDED;
            Assert.Equal(AccountStatus.SUSPENDED, instance.Status);
            instance.Status = AccountStatus.ACTIVE;
            Assert.Equal(AccountStatus.ACTIVE, instance.Status);
        }

        /// <summary>
        /// Test the property 'SubresourceUris'
        /// </summary>
        [Fact]
        public void SubresourceUrisTest()
        {
            Object testObject = (Object)TestHelpers.getTestValue(typeof(Object));
            instance.SubresourceUris = testObject;
            Assert.Equal(testObject, instance.SubresourceUris);
        }
    }
}
