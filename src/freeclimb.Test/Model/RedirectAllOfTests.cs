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
    ///  Class for testing RedirectAllOf
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class RedirectAllOfTests
    {
        private RedirectAllOf instance;

        public RedirectAllOfTests()
        {
            instance = new RedirectAllOf(new Uri("https://a.com"));
        }

        /// <summary>
        /// Test an instance of RedirectAllOf
        /// </summary>
        [Fact]
        public void RedirectAllOfInstanceTest()
        {
            Assert.IsType<RedirectAllOf>(instance);
        }


        /// <summary>
        /// Test the property 'ActionUrl'
        /// </summary>
        [Fact]
        public void ActionUrlTest()
        {
            
            try {
                Uri uri = new Uri("https://a.com");
                instance.ActionUrl = uri.ToString();
                Assert.Equal(uri.ToString(), instance.ActionUrl);
            } catch (Exception ) {
                Console.WriteLine("Something went wrong.");
            }
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        RedirectAllOf test1 = new RedirectAllOf(new Uri("https://a.com"));
        try {
            Uri uri = new Uri("https://a.com");
            instance.ActionUrl = uri.ToString();
            Assert.Equal(uri.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }

        RedirectAllOf test2 = new RedirectAllOf(new Uri("https://a.com"));
        try {
            Uri uri2 = new Uri("https://a.com");
            instance.ActionUrl = uri2.ToString();
            Assert.Equal(uri2.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        RedirectAllOf test1 = new RedirectAllOf(new Uri("https://a.com"));
        try {
            Uri uri = new Uri("https://a.com");
            instance.ActionUrl = uri.ToString();
            Assert.Equal(uri.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }

        RedirectAllOf test2 = new RedirectAllOf(new Uri("https://a.com"));
         try {
            Uri uri2 = new Uri("https://abc.com");
            instance.ActionUrl = uri2.ToString();
            Assert.Equal(uri2.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        RedirectAllOf test1 = new RedirectAllOf(new Uri("https://a.com"));
         try {
            Uri uri = new Uri("https://a.com");
            instance.ActionUrl = uri.ToString();
            Assert.Equal(uri.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        RedirectAllOf test1 = new RedirectAllOf(new Uri("https://a.com"));
         try {
            Uri uri = new Uri("https://a.com");
            instance.ActionUrl = uri.ToString();
            Assert.Equal(uri.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        RedirectAllOf test1 = new RedirectAllOf(new Uri("https://a.com"));
         try {
            Uri uri = new Uri("https://a.com");
            instance.ActionUrl = uri.ToString();
            Assert.Equal(uri.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }

        RedirectAllOf test2 = new RedirectAllOf(new Uri("https://a.com"));
         try {
            Uri uri2 = new Uri("https://a.com");
            instance.ActionUrl = uri2.ToString();
            Assert.Equal(uri2.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        RedirectAllOf test1 = new RedirectAllOf(new Uri("https://a.com"));
        try {
            Uri uri = new Uri("https://a.com");
            instance.ActionUrl = uri.ToString();
            Assert.Equal(uri.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }

        RedirectAllOf test2 = new RedirectAllOf(new Uri("https://a.com"));
        try {
            Uri uri2 = new Uri("https://a.com");
            instance.ActionUrl = uri2.ToString();
            Assert.Equal(uri2.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        RedirectAllOf test1 = new RedirectAllOf(new Uri("https://a.com"));
        try {
            Uri uri = new Uri("https://a.com");
            instance.ActionUrl = uri.ToString();
            Assert.Equal(uri.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }
         string jsonStr = JsonConvert.SerializeObject(test1, Newtonsoft.Json.Formatting.Indented);

        RedirectAllOf test2 = new RedirectAllOf(new Uri("https://a.com"));
        try {
            Uri uri2 = new Uri("https://abc.com");
            instance.ActionUrl = uri2.ToString();
            Assert.Equal(uri2.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }

        Assert.True(jsonStr.Equals(test2.ToJson()));
        }
    }
}
