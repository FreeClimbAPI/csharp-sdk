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


namespace freeclimb.Test.Enums
{
    /// <summary>
    ///  Class for testing AccountType
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AccountTypeTests
    {
        private AccountType instance;

        public AccountTypeTests()
        {
            instance = new AccountType();
        }

        /// <summary>
        /// Test an instance of AccountType
        /// </summary>
        [Fact]
        public void AccountTypeInstanceTest()
        {
            Assert.IsType<AccountType>(instance);
        }


        [Fact]
        public void TestTRIALShouldWork()
        {
            AccountType test = AccountType.TRIAL;
            Assert.Equal(typeof(AccountType), test.GetType());
        }

        [Fact]
        public void TestTRIALShouldSerializeToEnum()
        {
            AccountType expectedValue = AccountType.TRIAL;
            AccountType calculatedValue = (AccountType)Enum.Parse(typeof(AccountType), "TRIAL");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestTRIALShouldDeserializeToString()
        {
            AccountType test = AccountType.TRIAL;
            string expectedValue = "TRIAL";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestFULLShouldWork()
        {
            AccountType test = AccountType.FULL;
            Assert.Equal(typeof(AccountType), test.GetType());
        }

        [Fact]
        public void TestFULLShouldSerializeToEnum()
        {
            AccountType expectedValue = AccountType.FULL;
            AccountType calculatedValue = (AccountType)Enum.Parse(typeof(AccountType), "FULL");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestFULLShouldDeserializeToString()
        {
            AccountType test = AccountType.FULL;
            string expectedValue = "FULL";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

    }
}
