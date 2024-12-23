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
    ///  Class for testing SetDTMFPassThrough
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SetDTMFPassThroughTests
    {
        private SetDTMFPassThrough instance;

        public SetDTMFPassThroughTests()
        {
            
            instance = new SetDTMFPassThrough(false, "TEST_STRING");
            
        }

        /// <summary>
        /// Test an instance of SetDTMFPassThrough
        /// </summary>
        [Fact]
        public void SetDTMFPassThroughInstanceTest()
        {
            Assert.IsType<SetDTMFPassThrough>(instance);
        }


        /// <summary>
        /// Test the property 'DtmfPassThrough'
        /// </summary>
        [Fact]
        public void DtmfPassThroughTest()
        {
            instance.DtmfPassThrough = false;
            Assert.Equal(false, instance.DtmfPassThrough);       
            
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        SetDTMFPassThrough test1 = new SetDTMFPassThrough(false, "TEST_STRING");
         test1.DtmfPassThrough = true;

        SetDTMFPassThrough test2 = new SetDTMFPassThrough(false, "TEST_STRING");
         test2.DtmfPassThrough = true;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        SetDTMFPassThrough test1 = new SetDTMFPassThrough(false, "TEST_STRING");
         test1.DtmfPassThrough = true;

        SetDTMFPassThrough test2 = new SetDTMFPassThrough(false, "TEST_STRING");
         test2.DtmfPassThrough = false;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        SetDTMFPassThrough test1 = new SetDTMFPassThrough(false, "TEST_STRING");
         test1.DtmfPassThrough = true;

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        SetDTMFPassThrough test1 = new SetDTMFPassThrough(false, "TEST_STRING");
         test1.DtmfPassThrough = true;

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        SetDTMFPassThrough test1 = new SetDTMFPassThrough(false, "TEST_STRING");
         test1.DtmfPassThrough = true;

        SetDTMFPassThrough test2 = new SetDTMFPassThrough(false, "TEST_STRING");
         test2.DtmfPassThrough = true;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        SetDTMFPassThrough test1 = new SetDTMFPassThrough(false, "TEST_STRING");
         test1.DtmfPassThrough = true;

        SetDTMFPassThrough test2 = new SetDTMFPassThrough(false, "TEST_STRING");
         test2.DtmfPassThrough = true;

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        SetDTMFPassThrough test1 = new SetDTMFPassThrough(false, "TEST_STRING");
         test1.DtmfPassThrough = true;
        JsonSerializer jsonSerializer = JsonSerializer.Create();
        jsonSerializer.NullValueHandling = NullValueHandling.Ignore;
        StringBuilder strb = new StringBuilder();
        jsonSerializer.Serialize(new StringWriter(strb), test1);

        SetDTMFPassThrough test2 = new SetDTMFPassThrough(false, "TEST_STRING");
         test2.DtmfPassThrough = true;

        Assert.True(strb.Equals(JsonConvert.SerializeObject(test2)));
        }
    }
}
