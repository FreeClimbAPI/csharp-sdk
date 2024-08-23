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
    ///  Class for testing MutableResourceModel
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MutableResourceModelTests
    {
        private MutableResourceModel instance;

        public MutableResourceModelTests()
        {
            
            instance = new MutableResourceModel("TEST_STRING", "TEST_STRING", "TEST_STRING", 1);
            
        }

        /// <summary>
        /// Test an instance of MutableResourceModel
        /// </summary>
        [Fact]
        public void MutableResourceModelInstanceTest()
        {
            Assert.IsType<MutableResourceModel>(instance);
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
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        MutableResourceModel test1 = new MutableResourceModel("TEST_STRING", "TEST_STRING", "TEST_STRING", 1);
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;

        MutableResourceModel test2 = new MutableResourceModel("TEST_STRING", "TEST_STRING", "TEST_STRING", 1);
         test2.Uri = "TS";
         test2.DateCreated = "TS";
         test2.DateUpdated = "TS";
         test2.Revision = 1;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        MutableResourceModel test1 = new MutableResourceModel("TEST_STRING", "TEST_STRING", "TEST_STRING", 1);
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;

        MutableResourceModel test2 = new MutableResourceModel("TEST_STRING", "TEST_STRING", "TEST_STRING", 1);
         test2.Uri = "ts";
         test2.DateCreated = "ts";
         test2.DateUpdated = "ts";
         test2.Revision = 2;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        MutableResourceModel test1 = new MutableResourceModel("TEST_STRING", "TEST_STRING", "TEST_STRING", 1);
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        MutableResourceModel test1 = new MutableResourceModel("TEST_STRING", "TEST_STRING", "TEST_STRING", 1);
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        MutableResourceModel test1 = new MutableResourceModel("TEST_STRING", "TEST_STRING", "TEST_STRING", 1);
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;

        MutableResourceModel test2 = new MutableResourceModel("TEST_STRING", "TEST_STRING", "TEST_STRING", 1);
         test2.Uri = "TS";
         test2.DateCreated = "TS";
         test2.DateUpdated = "TS";
         test2.Revision = 1;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        MutableResourceModel test1 = new MutableResourceModel("TEST_STRING", "TEST_STRING", "TEST_STRING", 1);
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;

        MutableResourceModel test2 = new MutableResourceModel("TEST_STRING", "TEST_STRING", "TEST_STRING", 1);
         test2.Uri = "TS";
         test2.DateCreated = "TS";
         test2.DateUpdated = "TS";
         test2.Revision = 1;

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        MutableResourceModel test1 = new MutableResourceModel("TEST_STRING", "TEST_STRING", "TEST_STRING", 1);
         test1.Uri = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
        JsonSerializer jsonSerializer = JsonSerializer.Create();
        jsonSerializer.NullValueHandling = NullValueHandling.Ignore;
        StringBuilder strb = new StringBuilder();
        jsonSerializer.Serialize(new StringWriter(strb), test1);

        MutableResourceModel test2 = new MutableResourceModel("TEST_STRING", "TEST_STRING", "TEST_STRING", 1);
         test2.Uri = "TS";
         test2.DateCreated = "TS";
         test2.DateUpdated = "TS";
         test2.Revision = 1;

        Assert.True(strb.Equals(JsonConvert.SerializeObject(test2)));
        }
    }
}
