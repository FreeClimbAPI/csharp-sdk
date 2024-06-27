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
    ///  Class for testing TFN
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TFNTests
    {
        private TFN instance;

        public TFNTests()
        {
            instance = new TFN("TEST_STRING");
        }

        /// <summary>
        /// Test an instance of TFN
        /// </summary>
        [Fact]
        public void TFNInstanceTest()
        {
            Assert.IsType<TFN>(instance);
        }


        /// <summary>
        /// Test the property 'CampaignId'
        /// </summary>
        [Fact]
        public void CampaignIdTest()
        {
            instance.CampaignId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.CampaignId);

        }


        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>

        [Fact]
        public void equalsTrueTest()
        {
            TFN test1 = new TFN("TEST_STRING");
            test1.CampaignId = "TS";

            TFN test2 = new TFN("TEST_STRING");
            test2.CampaignId = "TS";

            Assert.Equal(test1, test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>

        [Fact]
        public void equalsFalseTest()
        {
            TFN test1 = new TFN("TEST_STRING");
            test1.CampaignId = "TS";

            TFN test2 = new TFN("TEST_STRING");
            test2.CampaignId = "ts";

            Assert.NotEqual(test1, test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>

        [Fact]
        public void hashCodeTypeTest()
        {
            TFN test1 = new TFN("TEST_STRING");
            test1.CampaignId = "TS";

            int hashCode1 = test1.GetHashCode();
            Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>

        [Fact]
        public void ToStringTypeTest()
        {
            TFN test1 = new TFN("TEST_STRING");
            test1.CampaignId = "TS";

            string toString1 = test1.ToString();
            Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>

        [Fact]
        public void ToStringEqualsTest()
        {
            TFN test1 = new TFN("TEST_STRING");
            test1.CampaignId = "TS";

            TFN test2 = new TFN("TEST_STRING");
            test2.CampaignId = "TS";

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
            TFN test1 = new TFN("TEST_STRING");
            test1.CampaignId = "TS";

            TFN test2 = new TFN("TEST_STRING");
            test2.CampaignId = "TS";

            Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>

        [Fact]
        public void ToJsonTest()
        {
            TFN test1 = new TFN("TEST_STRING");
            test1.CampaignId = "TS";
            string jsonStr = JsonConvert.SerializeObject(test1, Newtonsoft.Json.Formatting.Indented);

            TFN test2 = new TFN("TEST_STRING");
            test2.CampaignId = "TS";

            Assert.True(jsonStr.Equals(test2.ToJson()));
        }
    }
}
