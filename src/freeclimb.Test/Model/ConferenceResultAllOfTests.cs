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
    ///  Class for testing ConferenceResultAllOf
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ConferenceResultAllOfTests
    {
        private ConferenceResultAllOf instance;

        public ConferenceResultAllOfTests()
        {
            instance = new ConferenceResultAllOf();
        }

        /// <summary>
        /// Test an instance of ConferenceResultAllOf
        /// </summary>
        [Fact]
        public void ConferenceResultAllOfInstanceTest()
        {
            Assert.IsType<ConferenceResultAllOf>(instance);
        }


        /// <summary>
        /// Test the property 'ConferenceId'
        /// </summary>
        [Fact]
        public void ConferenceIdTest()
        {
            instance.ConferenceId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.ConferenceId);
            
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
        /// Test the property 'Alias'
        /// </summary>
        [Fact]
        public void AliasTest()
        {
            instance.Alias = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Alias);
            
        }
        /// <summary>
        /// Test the property 'PlayBeep'
        /// </summary>
        [Fact]
        public void PlayBeepTest()
        {
            instance.PlayBeep = PlayBeep.ALWAYS;
            Assert.Equal(instance.PlayBeep,PlayBeep.ALWAYS);
            instance.PlayBeep = PlayBeep.NEVER;
            Assert.Equal(instance.PlayBeep,PlayBeep.NEVER);
            instance.PlayBeep = PlayBeep.ENTRY_ONLY;
            Assert.Equal(instance.PlayBeep,PlayBeep.ENTRY_ONLY);
            instance.PlayBeep = PlayBeep.EXIT_ONLY;
            Assert.Equal(instance.PlayBeep,PlayBeep.EXIT_ONLY);
            
        }
        /// <summary>
        /// Test the property 'Record'
        /// </summary>
        [Fact]
        public void RecordTest()
        {
            instance.Record = false;
            Assert.Equal(false, instance.Record);       
            
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            instance.Status = ConferenceStatus.EMPTY;
            Assert.Equal(instance.Status,ConferenceStatus.EMPTY);
            instance.Status = ConferenceStatus.POPULATED;
            Assert.Equal(instance.Status,ConferenceStatus.POPULATED);
            instance.Status = ConferenceStatus.IN_PROGRESS;
            Assert.Equal(instance.Status,ConferenceStatus.IN_PROGRESS);
            instance.Status = ConferenceStatus.TERMINATED;
            Assert.Equal(instance.Status,ConferenceStatus.TERMINATED);
            
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
        /// <summary>
        /// Test the property 'ActionUrl'
        /// </summary>
        [Fact]
        public void ActionUrlTest()
        {
            instance.ActionUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.ActionUrl);
            
        }
        /// <summary>
        /// Test the property 'StatusCallbackUrl'
        /// </summary>
        [Fact]
        public void StatusCallbackUrlTest()
        {
            instance.StatusCallbackUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.StatusCallbackUrl);
            
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
        ConferenceResultAllOf test1 = new ConferenceResultAllOf();
         test1.ConferenceId = "TS";
         test1.AccountId = "TS";
         test1.Alias = "TS";
         test1.PlayBeep = PlayBeep.ALWAYS;
         test1.Record = true;
         test1.Status = ConferenceStatus.EMPTY;
         test1.WaitUrl = "TS";
         test1.ActionUrl = "TS";
         test1.StatusCallbackUrl = "TS";
         object testObject = new object();
         test1.SubresourceUris = testObject;

        ConferenceResultAllOf test2 = new ConferenceResultAllOf();
         test2.ConferenceId = "TS";
         test2.AccountId = "TS";
         test2.Alias = "TS";
         test2.PlayBeep = PlayBeep.ALWAYS;
         test2.Record = true;
         test2.Status = ConferenceStatus.EMPTY;
         test2.WaitUrl = "TS";
         test2.ActionUrl = "TS";
         test2.StatusCallbackUrl = "TS";
         object testObject2 = testObject;
         test2.SubresourceUris = testObject2;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        ConferenceResultAllOf test1 = new ConferenceResultAllOf();
         test1.ConferenceId = "TS";
         test1.AccountId = "TS";
         test1.Alias = "TS";
         test1.PlayBeep = PlayBeep.ALWAYS;
         test1.Record = true;
         test1.Status = ConferenceStatus.EMPTY;
         test1.WaitUrl = "TS";
         test1.ActionUrl = "TS";
         test1.StatusCallbackUrl = "TS";
         object testObject = new object();
         test1.SubresourceUris = testObject;

        ConferenceResultAllOf test2 = new ConferenceResultAllOf();
         test2.ConferenceId = "ts";
         test2.AccountId = "ts";
         test2.Alias = "ts";
         test2.PlayBeep = PlayBeep.NEVER;
         test2.Record = false;
         test2.Status = ConferenceStatus.POPULATED;
         test2.WaitUrl = "ts";
         test2.ActionUrl = "ts";
         test2.StatusCallbackUrl = "ts";
         object testObject2 = new object();
         test2.SubresourceUris = testObject2;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        ConferenceResultAllOf test1 = new ConferenceResultAllOf();
         test1.ConferenceId = "TS";
         test1.AccountId = "TS";
         test1.Alias = "TS";
         test1.PlayBeep = PlayBeep.ALWAYS;
         test1.Record = true;
         test1.Status = ConferenceStatus.EMPTY;
         test1.WaitUrl = "TS";
         test1.ActionUrl = "TS";
         test1.StatusCallbackUrl = "TS";
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
        ConferenceResultAllOf test1 = new ConferenceResultAllOf();
         test1.ConferenceId = "TS";
         test1.AccountId = "TS";
         test1.Alias = "TS";
         test1.PlayBeep = PlayBeep.ALWAYS;
         test1.Record = true;
         test1.Status = ConferenceStatus.EMPTY;
         test1.WaitUrl = "TS";
         test1.ActionUrl = "TS";
         test1.StatusCallbackUrl = "TS";
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
        ConferenceResultAllOf test1 = new ConferenceResultAllOf();
         test1.ConferenceId = "TS";
         test1.AccountId = "TS";
         test1.Alias = "TS";
         test1.PlayBeep = PlayBeep.ALWAYS;
         test1.Record = true;
         test1.Status = ConferenceStatus.EMPTY;
         test1.WaitUrl = "TS";
         test1.ActionUrl = "TS";
         test1.StatusCallbackUrl = "TS";
         object testObject = new object();
         test1.SubresourceUris = testObject;

        ConferenceResultAllOf test2 = new ConferenceResultAllOf();
         test2.ConferenceId = "TS";
         test2.AccountId = "TS";
         test2.Alias = "TS";
         test2.PlayBeep = PlayBeep.ALWAYS;
         test2.Record = true;
         test2.Status = ConferenceStatus.EMPTY;
         test2.WaitUrl = "TS";
         test2.ActionUrl = "TS";
         test2.StatusCallbackUrl = "TS";
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
        ConferenceResultAllOf test1 = new ConferenceResultAllOf();
         test1.ConferenceId = "TS";
         test1.AccountId = "TS";
         test1.Alias = "TS";
         test1.PlayBeep = PlayBeep.ALWAYS;
         test1.Record = true;
         test1.Status = ConferenceStatus.EMPTY;
         test1.WaitUrl = "TS";
         test1.ActionUrl = "TS";
         test1.StatusCallbackUrl = "TS";
         object testObject = new object();
         test1.SubresourceUris = testObject;

        ConferenceResultAllOf test2 = new ConferenceResultAllOf();
         test2.ConferenceId = "TS";
         test2.AccountId = "TS";
         test2.Alias = "TS";
         test2.PlayBeep = PlayBeep.ALWAYS;
         test2.Record = true;
         test2.Status = ConferenceStatus.EMPTY;
         test2.WaitUrl = "TS";
         test2.ActionUrl = "TS";
         test2.StatusCallbackUrl = "TS";
         object testObject2 = testObject;
         test2.SubresourceUris = testObject2;

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        ConferenceResultAllOf test1 = new ConferenceResultAllOf();
         test1.ConferenceId = "TS";
         test1.AccountId = "TS";
         test1.Alias = "TS";
         test1.PlayBeep = PlayBeep.ALWAYS;
         test1.Record = true;
         test1.Status = ConferenceStatus.EMPTY;
         test1.WaitUrl = "TS";
         test1.ActionUrl = "TS";
         test1.StatusCallbackUrl = "TS";
         object testObject = new object();
         test1.SubresourceUris = testObject;
         string jsonStr = JsonConvert.SerializeObject(test1, Newtonsoft.Json.Formatting.Indented);

        ConferenceResultAllOf test2 = new ConferenceResultAllOf();
         test2.ConferenceId = "TS";
         test2.AccountId = "TS";
         test2.Alias = "TS";
         test2.PlayBeep = PlayBeep.ALWAYS;
         test2.Record = true;
         test2.Status = ConferenceStatus.EMPTY;
         test2.WaitUrl = "TS";
         test2.ActionUrl = "TS";
         test2.StatusCallbackUrl = "TS";
         object testObject2 = testObject;
         test2.SubresourceUris = testObject2;

        Assert.True(jsonStr.Equals(test2.ToJson()));
        }
    }
}
