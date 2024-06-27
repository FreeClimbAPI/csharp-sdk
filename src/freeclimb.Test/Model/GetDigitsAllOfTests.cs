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
    ///  Class for testing GetDigitsAllOf
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GetDigitsAllOfTests
    {
        private GetDigitsAllOf instance;

        public GetDigitsAllOfTests()
        {
            instance = new GetDigitsAllOf("https://a.com", 1, "TEST_STRING", false, 300, 1, 1, new List<PerclCommand>(), false);
        }

        /// <summary>
        /// Test an instance of GetDigitsAllOf
        /// </summary>
        [Fact]
        public void GetDigitsAllOfInstanceTest()
        {
            Assert.IsType<GetDigitsAllOf>(instance);
        }


        /// <summary>
        /// Test the property 'ActionUrl'
        /// </summary>
        [Fact]
        public void ActionUrlTest()
        {

            try
            {
                Uri uri = new Uri("https://a.com");
                instance.ActionUrl = uri.ToString();
                Assert.Equal(uri.ToString(), instance.ActionUrl);
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong.");
            }
        }
        /// <summary>
        /// Test the property 'DigitTimeoutMs'
        /// </summary>
        [Fact]
        public void DigitTimeoutMsTest()
        {

            instance.DigitTimeoutMs = 1;
            Assert.Equal(1, (int)instance.DigitTimeoutMs);
        }
        /// <summary>
        /// Test the property 'FinishOnKey'
        /// </summary>
        [Fact]
        public void FinishOnKeyTest()
        {
            instance.FinishOnKey = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.FinishOnKey);

        }
        /// <summary>
        /// Test the property 'FlushBuffer'
        /// </summary>
        [Fact]
        public void FlushBufferTest()
        {
            instance.FlushBuffer = false;
            Assert.Equal(false, instance.FlushBuffer);

        }
        /// <summary>
        /// Test the property 'InitialTimeoutMs'
        /// </summary>
        [Fact]
        public void InitialTimeoutMsTest()
        {

            instance.InitialTimeoutMs = 1;
            Assert.Equal(1, (int)instance.InitialTimeoutMs);
        }
        /// <summary>
        /// Test the property 'MaxDigits'
        /// </summary>
        [Fact]
        public void MaxDigitsTest()
        {

            instance.MaxDigits = 1;
            Assert.Equal(1, (int)instance.MaxDigits);
        }
        /// <summary>
        /// Test the property 'MinDigits'
        /// </summary>
        [Fact]
        public void MinDigitsTest()
        {

            instance.MinDigits = 1;
            Assert.Equal(1, (int)instance.MinDigits);
        }
        /// <summary>
        /// Test the property 'Prompts'
        /// </summary>
        [Fact]
        public void PromptsTest()
        {

            List<PerclCommand> testList = new List<PerclCommand>();
            instance.Prompts = testList;
            Assert.Equal(testList, instance.Prompts);
        }
        /// <summary>
        /// Test the property 'PrivacyMode'
        /// </summary>
        [Fact]
        public void PrivacyModeTest()
        {
            instance.PrivacyMode = false;
            Assert.Equal(false, instance.PrivacyMode);

        }


        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>

        [Fact]
        public void equalsTrueTest()
        {
            GetDigitsAllOf test1 = new GetDigitsAllOf("https://a.com", 1, "TEST_STRING", false, 300, 1, 1, new List<PerclCommand>(), false);
            Uri uri = new Uri("https://a.com");
            test1.ActionUrl = uri.ToString();
            test1.DigitTimeoutMs = 1;
            test1.FinishOnKey = "TS";
            test1.FlushBuffer = true;
            test1.InitialTimeoutMs = 1;
            test1.MaxDigits = 1;
            test1.MinDigits = 1;
            List<PerclCommand> testList = new List<PerclCommand>();
            test1.Prompts = testList;
            test1.PrivacyMode = true;

            GetDigitsAllOf test2 = new GetDigitsAllOf("https://a.com", 1, "TEST_STRING", false, 300, 1, 1, new List<PerclCommand>(), false);
            Uri uri2 = new Uri("https://a.com");
            test2.ActionUrl = uri2.ToString();
            test2.DigitTimeoutMs = 1;
            test2.FinishOnKey = "TS";
            test2.FlushBuffer = true;
            test2.InitialTimeoutMs = 1;
            test2.MaxDigits = 1;
            test2.MinDigits = 1;
            List<PerclCommand> testList2 = new List<PerclCommand>();
            test2.Prompts = testList2;
            test2.PrivacyMode = true;

            Assert.Equal(test1, test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>

        [Fact]
        public void equalsFalseTest()
        {
            GetDigitsAllOf test1 = new GetDigitsAllOf("https://a.com", 1, "TEST_STRING", false, 300, 1, 1, new List<PerclCommand>(), false);
            Uri uri = new Uri("https://a.com");
            test1.ActionUrl = uri.ToString();
            test1.DigitTimeoutMs = 1;
            test1.FinishOnKey = "TS";
            test1.FlushBuffer = true;
            test1.InitialTimeoutMs = 1;
            test1.MaxDigits = 1;
            test1.MinDigits = 1;
            List<PerclCommand> testList = new List<PerclCommand>();
            test1.Prompts = testList;
            test1.PrivacyMode = true;

            GetDigitsAllOf test2 = new GetDigitsAllOf("https://a.com", 1, "TEST_STRING", false, 300, 1, 1, new List<PerclCommand>(), false);
            Uri uri2 = new Uri("https://a.com");
            test2.ActionUrl = uri2.ToString();
            test2.DigitTimeoutMs = 2;
            test2.FinishOnKey = "ts";
            test2.FlushBuffer = false;
            test2.InitialTimeoutMs = 2;
            test2.MaxDigits = 2;
            test2.MinDigits = 2;
            List<PerclCommand> testList2 = null;
            test2.Prompts = testList2;
            test2.PrivacyMode = false;

            Assert.NotEqual(test1, test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>

        [Fact]
        public void hashCodeTypeTest()
        {
            GetDigitsAllOf test1 = new GetDigitsAllOf("https://a.com", 1, "TEST_STRING", false, 300, 1, 1, new List<PerclCommand>(), false);
            Uri uri = new Uri("https://a.com");
            test1.ActionUrl = uri.ToString();
            test1.DigitTimeoutMs = 1;
            test1.FinishOnKey = "TS";
            test1.FlushBuffer = true;
            test1.InitialTimeoutMs = 1;
            test1.MaxDigits = 1;
            test1.MinDigits = 1;
            List<PerclCommand> testList = new List<PerclCommand>();
            test1.Prompts = testList;
            test1.PrivacyMode = true;

            int hashCode1 = test1.GetHashCode();
            Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>

        [Fact]
        public void ToStringTypeTest()
        {
            GetDigitsAllOf test1 = new GetDigitsAllOf("https://a.com", 1, "TEST_STRING", false, 300, 1, 1, new List<PerclCommand>(), false);
            Uri uri = new Uri("https://a.com");
            test1.ActionUrl = uri.ToString();
            test1.DigitTimeoutMs = 1;
            test1.FinishOnKey = "TS";
            test1.FlushBuffer = true;
            test1.InitialTimeoutMs = 1;
            test1.MaxDigits = 1;
            test1.MinDigits = 1;
            List<PerclCommand> testList = new List<PerclCommand>();
            test1.Prompts = testList;
            test1.PrivacyMode = true;

            string toString1 = test1.ToString();
            Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>

        [Fact]
        public void ToStringEqualsTest()
        {
            GetDigitsAllOf test1 = new GetDigitsAllOf("https://a.com", 1, "TEST_STRING", false, 300, 1, 1, new List<PerclCommand>(), false);
            try
            {
                Uri uri = new Uri("https://a.com");
                instance.ActionUrl = uri.ToString();
                Assert.Equal(uri.ToString(), instance.ActionUrl);
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong.");
            }
            test1.DigitTimeoutMs = 1;
            test1.FinishOnKey = "TS";
            test1.FlushBuffer = true;
            test1.InitialTimeoutMs = 1;
            test1.MaxDigits = 1;
            test1.MinDigits = 1;
            List<PerclCommand> testList = new List<PerclCommand>();
            test1.Prompts = testList;
            test1.PrivacyMode = true;

            GetDigitsAllOf test2 = new GetDigitsAllOf("https://a.com", 1, "TEST_STRING", false, 300, 1, 1, new List<PerclCommand>(), false);
            try
            {
                Uri uri2 = new Uri("https://a.com");
                instance.ActionUrl = uri2.ToString();
                Assert.Equal(uri2.ToString(), instance.ActionUrl);
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong.");
            }
            test2.DigitTimeoutMs = 1;
            test2.FinishOnKey = "TS";
            test2.FlushBuffer = true;
            test2.InitialTimeoutMs = 1;
            test2.MaxDigits = 1;
            test2.MinDigits = 1;
            List<PerclCommand> testList2 = new List<PerclCommand>();
            test2.Prompts = testList2;
            test2.PrivacyMode = true;

            string toString1 = test1.ToString();
            string toString2 = test2.ToString();
            Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>

        [Fact]
        public void equalsTest()
        {
            GetDigitsAllOf test1 = new GetDigitsAllOf("https://a.com", 1, "TEST_STRING", false, 300, 1, 1, new List<PerclCommand>(), false);
            Uri uri = new Uri("https://a.com");
            test1.ActionUrl = uri.ToString();
            test1.DigitTimeoutMs = 1;
            test1.FinishOnKey = "TS";
            test1.FlushBuffer = true;
            test1.InitialTimeoutMs = 1;
            test1.MaxDigits = 1;
            test1.MinDigits = 1;
            List<PerclCommand> testList = new List<PerclCommand>();
            test1.Prompts = testList;
            test1.PrivacyMode = true;

            GetDigitsAllOf test2 = new GetDigitsAllOf("https://a.com", 1, "TEST_STRING", false, 300, 1, 1, new List<PerclCommand>(), false);
            Uri uri2 = new Uri("https://a.com");
            test2.ActionUrl = uri2.ToString();
            test2.DigitTimeoutMs = 1;
            test2.FinishOnKey = "TS";
            test2.FlushBuffer = true;
            test2.InitialTimeoutMs = 1;
            test2.MaxDigits = 1;
            test2.MinDigits = 1;
            List<PerclCommand> testList2 = new List<PerclCommand>();
            test2.Prompts = testList2;
            test2.PrivacyMode = true;

            Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>

        [Fact]
        public void ToJsonTest()
        {
            GetDigitsAllOf test1 = new GetDigitsAllOf("https://a.com", 1, "TEST_STRING", false, 300, 1, 1, new List<PerclCommand>(), false);
            Uri uri = new Uri("https://a.com");
            test1.ActionUrl = uri.ToString();
            test1.DigitTimeoutMs = 1;
            test1.FinishOnKey = "TS";
            test1.FlushBuffer = true;
            test1.InitialTimeoutMs = 1;
            test1.MaxDigits = 1;
            test1.MinDigits = 1;
            List<PerclCommand> testList = new List<PerclCommand>();
            test1.Prompts = testList;
            test1.PrivacyMode = true;
            string jsonStr = JsonConvert.SerializeObject(test1, Newtonsoft.Json.Formatting.Indented);

            GetDigitsAllOf test2 = new GetDigitsAllOf("https://a.com", 1, "TEST_STRING", false, 300, 1, 1, new List<PerclCommand>(), false);
            Uri uri2 = new Uri("https://a.com");
            test2.ActionUrl = uri2.ToString();
            test2.DigitTimeoutMs = 1;
            test2.FinishOnKey = "TS";
            test2.FlushBuffer = true;
            test2.InitialTimeoutMs = 1;
            test2.MaxDigits = 1;
            test2.MinDigits = 1;
            List<PerclCommand> testList2 = new List<PerclCommand>();
            test2.Prompts = testList2;
            test2.PrivacyMode = true;

            Assert.True(jsonStr.Equals(test2.ToJson()));
        }
    }
}
