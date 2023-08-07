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
    ///  Class for testing SMSTenDLCBrandsListResultAllOf
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SMSTenDLCBrandsListResultAllOfTests
    {
        private SMSTenDLCBrandsListResultAllOf instance;

        public SMSTenDLCBrandsListResultAllOfTests()
        {
            instance = new SMSTenDLCBrandsListResultAllOf();
        }

        /// <summary>
        /// Test an instance of SMSTenDLCBrandsListResultAllOf
        /// </summary>
        [Fact]
        public void SMSTenDLCBrandsListResultAllOfInstanceTest()
        {
            Assert.IsType<SMSTenDLCBrandsListResultAllOf>(instance);
        }


        /// <summary>
        /// Test the property 'Brands'
        /// </summary>
        [Fact]
        public void BrandsTest()
        {
            
            List<SMSTenDLCBrand> testList = new List<SMSTenDLCBrand>();
            instance.Brands = testList;
            Assert.Equal(testList, instance.Brands); 
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        SMSTenDLCBrandsListResultAllOf test1 = new SMSTenDLCBrandsListResultAllOf();
         List<SMSTenDLCBrand> testList = new List<SMSTenDLCBrand>();
         test1.Brands = testList;

        SMSTenDLCBrandsListResultAllOf test2 = new SMSTenDLCBrandsListResultAllOf();
         List<SMSTenDLCBrand> testList2 = new List<SMSTenDLCBrand>();
         test2.Brands = testList2;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        SMSTenDLCBrandsListResultAllOf test1 = new SMSTenDLCBrandsListResultAllOf();
         List<SMSTenDLCBrand> testList = new List<SMSTenDLCBrand>();
         test1.Brands = testList;

        SMSTenDLCBrandsListResultAllOf test2 = new SMSTenDLCBrandsListResultAllOf();
         List<SMSTenDLCBrand> testList2 = null;
         test2.Brands = testList2;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        SMSTenDLCBrandsListResultAllOf test1 = new SMSTenDLCBrandsListResultAllOf();
         List<SMSTenDLCBrand> testList = new List<SMSTenDLCBrand>();
         test1.Brands = testList;

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        SMSTenDLCBrandsListResultAllOf test1 = new SMSTenDLCBrandsListResultAllOf();
         List<SMSTenDLCBrand> testList = new List<SMSTenDLCBrand>();
         test1.Brands = testList;

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        SMSTenDLCBrandsListResultAllOf test1 = new SMSTenDLCBrandsListResultAllOf();
         List<SMSTenDLCBrand> testList = new List<SMSTenDLCBrand>();
         test1.Brands = testList;

        SMSTenDLCBrandsListResultAllOf test2 = new SMSTenDLCBrandsListResultAllOf();
         List<SMSTenDLCBrand> testList2 = new List<SMSTenDLCBrand>();
         test2.Brands = testList2;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        SMSTenDLCBrandsListResultAllOf test1 = new SMSTenDLCBrandsListResultAllOf();
         List<SMSTenDLCBrand> testList = new List<SMSTenDLCBrand>();
         test1.Brands = testList;

        SMSTenDLCBrandsListResultAllOf test2 = new SMSTenDLCBrandsListResultAllOf();
         List<SMSTenDLCBrand> testList2 = new List<SMSTenDLCBrand>();
         test2.Brands = testList2;

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        SMSTenDLCBrandsListResultAllOf test1 = new SMSTenDLCBrandsListResultAllOf();
         List<SMSTenDLCBrand> testList = new List<SMSTenDLCBrand>();
         test1.Brands = testList;
         string jsonStr = JsonConvert.SerializeObject(test1, Newtonsoft.Json.Formatting.Indented);

        SMSTenDLCBrandsListResultAllOf test2 = new SMSTenDLCBrandsListResultAllOf();
         List<SMSTenDLCBrand> testList2 = new List<SMSTenDLCBrand>();
         test2.Brands = testList2;

        Assert.True(jsonStr.Equals(test2.ToJson()));
        }
    }
}
