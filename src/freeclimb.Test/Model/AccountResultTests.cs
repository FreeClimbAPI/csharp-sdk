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
    ///  Class for testing AccountResult
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AccountResultTests
    {
        private AccountResult instance;

        public AccountResultTests()
        {
            instance = new AccountResult();
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
            Assert.Equal(instance.Type,AccountType.TRIAL);
            instance.Type = AccountType.FULL;
            Assert.Equal(instance.Type,AccountType.FULL);
            
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            instance.Status = AccountStatus.CLOSED;
            Assert.Equal(instance.Status,AccountStatus.CLOSED);
            instance.Status = AccountStatus.SUSPENDED;
            Assert.Equal(instance.Status,AccountStatus.SUSPENDED);
            instance.Status = AccountStatus.ACTIVE;
            Assert.Equal(instance.Status,AccountStatus.ACTIVE);
            
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
        AccountResult test1 = new AccountResult();
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         test1.AccountId = "TS";
         test1.ApiKey = "TS";
         test1.Alias = "TS";
         test1.Label = "TS";
         test1.Type = AccountType.TRIAL;
         test1.Status = AccountStatus.CLOSED;
         object testObject = new object();
         test1.SubresourceUris = testObject;

        AccountResult test2 = new AccountResult();
         test2.Uri = "TS";
         test2.DateCreated = "TS";
         test2.DateUpdated = "TS";
         test2.Revision = 1;
         test2.AccountId = "TS";
         test2.ApiKey = "TS";
         test2.Alias = "TS";
         test2.Label = "TS";
         test2.Type = AccountType.TRIAL;
         test2.Status = AccountStatus.CLOSED;
         object testObject2 = testObject;
         test2.SubresourceUris = testObject2;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        AccountResult test1 = new AccountResult();
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         test1.AccountId = "TS";
         test1.ApiKey = "TS";
         test1.Alias = "TS";
         test1.Label = "TS";
         test1.Type = AccountType.TRIAL;
         test1.Status = AccountStatus.CLOSED;
         object testObject = new object();
         test1.SubresourceUris = testObject;

        AccountResult test2 = new AccountResult();
         test2.Uri = "ts";
         test2.DateCreated = "ts";
         test2.DateUpdated = "ts";
         test2.Revision = 2;
         test2.AccountId = "ts";
         test2.ApiKey = "ts";
         test2.Alias = "ts";
         test2.Label = "ts";
         test2.Type = AccountType.FULL;
         test2.Status = AccountStatus.SUSPENDED;
         object testObject2 = new object();
         test2.SubresourceUris = testObject2;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        AccountResult test1 = new AccountResult();
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         test1.AccountId = "TS";
         test1.ApiKey = "TS";
         test1.Alias = "TS";
         test1.Label = "TS";
         test1.Type = AccountType.TRIAL;
         test1.Status = AccountStatus.CLOSED;
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
        AccountResult test1 = new AccountResult();
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         test1.AccountId = "TS";
         test1.ApiKey = "TS";
         test1.Alias = "TS";
         test1.Label = "TS";
         test1.Type = AccountType.TRIAL;
         test1.Status = AccountStatus.CLOSED;
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
        AccountResult test1 = new AccountResult();
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         test1.AccountId = "TS";
         test1.ApiKey = "TS";
         test1.Alias = "TS";
         test1.Label = "TS";
         test1.Type = AccountType.TRIAL;
         test1.Status = AccountStatus.CLOSED;
         object testObject = new object();
         test1.SubresourceUris = testObject;

        AccountResult test2 = new AccountResult();
         test2.Uri = "TS";
         test2.DateCreated = "TS";
         test2.DateUpdated = "TS";
         test2.Revision = 1;
         test2.AccountId = "TS";
         test2.ApiKey = "TS";
         test2.Alias = "TS";
         test2.Label = "TS";
         test2.Type = AccountType.TRIAL;
         test2.Status = AccountStatus.CLOSED;
         object testObject2 = new object();
         test2.SubresourceUris = testObject2;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        AccountResult test1 = new AccountResult();
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         test1.AccountId = "TS";
         test1.ApiKey = "TS";
         test1.Alias = "TS";
         test1.Label = "TS";
         test1.Type = AccountType.TRIAL;
         test1.Status = AccountStatus.CLOSED;
         object testObject = new object();
         test1.SubresourceUris = testObject;

        AccountResult test2 = new AccountResult();
         test2.Uri = "TS";
         test2.DateCreated = "TS";
         test2.DateUpdated = "TS";
         test2.Revision = 1;
         test2.AccountId = "TS";
         test2.ApiKey = "TS";
         test2.Alias = "TS";
         test2.Label = "TS";
         test2.Type = AccountType.TRIAL;
         test2.Status = AccountStatus.CLOSED;
         object testObject2 = testObject;
         test2.SubresourceUris = testObject2;

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        AccountResult test1 = new AccountResult();
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
         test1.AccountId = "TS";
         test1.ApiKey = "TS";
         test1.Alias = "TS";
         test1.Label = "TS";
         test1.Type = AccountType.TRIAL;
         test1.Status = AccountStatus.CLOSED;
         object testObject = new object();
         test1.SubresourceUris = testObject;
         string jsonStr = JsonConvert.SerializeObject(test1, Newtonsoft.Json.Formatting.Indented);

        AccountResult test2 = new AccountResult();
         test2.Uri = "TS";
         test2.DateCreated = "TS";
         test2.DateUpdated = "TS";
         test2.Revision = 1;
         test2.AccountId = "TS";
         test2.ApiKey = "TS";
         test2.Alias = "TS";
         test2.Label = "TS";
         test2.Type = AccountType.TRIAL;
         test2.Status = AccountStatus.CLOSED;
         object testObject2 = testObject;
         test2.SubresourceUris = testObject2;

        Assert.True(jsonStr.Equals(test2.ToJson()));
        }
    }
}
