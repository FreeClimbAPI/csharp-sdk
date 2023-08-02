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


namespace freeclimb.Test.Model
{
    /// <summary>
    ///  Class for testing AvailableNumberListAllOf
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AvailableNumberListAllOfTests
    {
        private AvailableNumberListAllOf instance;

        public AvailableNumberListAllOfTests()
        {
            instance = new AvailableNumberListAllOf();
        }

        /// <summary>
        /// Test an instance of AvailableNumberListAllOf
        /// </summary>
        [Fact]
        public void AvailableNumberListAllOfInstanceTest()
        {
            Assert.IsType<AvailableNumberListAllOf>(instance);
        }


        /// <summary>
        /// Test the property 'AvailablePhoneNumbers'
        /// </summary>
        [Fact]
        public void AvailablePhoneNumbersTest()
        {
            
            List<AvailableNumber> testList = new List<AvailableNumber>();
            instance.AvailablePhoneNumbers = testList;
            Assert.Equal(testList, instance.AvailablePhoneNumbers); 
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        AvailableNumberListAllOf test1 = new AvailableNumberListAllOf();
         List<AvailableNumber> testList = new List<AvailableNumber>();
         test1.AvailablePhoneNumbers = testList;
        AvailableNumberListAllOf test2 = new AvailableNumberListAllOf();
         List<AvailableNumber> testList2 = new List<AvailableNumber>();
         test2.AvailablePhoneNumbers = testList2;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        AvailableNumberListAllOf test1 = new AvailableNumberListAllOf();
         List<AvailableNumber> testList = new List<AvailableNumber>();
         test1.AvailablePhoneNumbers = testList;
        AvailableNumberListAllOf test2 = new AvailableNumberListAllOf();
         List<AvailableNumber> testList2 = null;
         test2.AvailablePhoneNumbers = testList2;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        AvailableNumberListAllOf test1 = new AvailableNumberListAllOf();
         List<AvailableNumber> testList = new List<AvailableNumber>();
         test1.AvailablePhoneNumbers = testList;

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        AvailableNumberListAllOf test1 = new AvailableNumberListAllOf();
         List<AvailableNumber> testList = new List<AvailableNumber>();
         test1.AvailablePhoneNumbers = testList;

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        AvailableNumberListAllOf test1 = new AvailableNumberListAllOf();
         List<AvailableNumber> testList = new List<AvailableNumber>();
         test1.AvailablePhoneNumbers = testList;

        AvailableNumberListAllOf test2 = new AvailableNumberListAllOf();
         List<AvailableNumber> testList2 = new List<AvailableNumber>();
         test2.AvailablePhoneNumbers = testList2;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }
    }
}
