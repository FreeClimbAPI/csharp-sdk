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
    ///  Class for testing OutDialAllOf
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class OutDialAllOfTests
    {
        private OutDialAllOf instance;

        public OutDialAllOfTests()
        {
            instance = new OutDialAllOf("https://a.com", "https://a.com", "TEST_STRING", "TEST_STRING", IfMachine.REDIRECT, "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, false);
        }

        /// <summary>
        /// Test an instance of OutDialAllOf
        /// </summary>
        [Fact]
        public void OutDialAllOfInstanceTest()
        {
            Assert.IsType<OutDialAllOf>(instance);
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
        /// Test the property 'CallConnectUrl'
        /// </summary>
        [Fact]
        public void CallConnectUrlTest()
        {
            
            try {
                Uri uri = new Uri("https://a.com");
                instance.CallConnectUrl = uri.ToString();
                Assert.Equal(uri.ToString(), instance.CallConnectUrl);
            } catch (Exception ) {
                Console.WriteLine("Something went wrong.");
            }
        }
        /// <summary>
        /// Test the property 'CallingNumber'
        /// </summary>
        [Fact]
        public void CallingNumberTest()
        {
            instance.CallingNumber = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.CallingNumber);
            
        }
        /// <summary>
        /// Test the property 'Destination'
        /// </summary>
        [Fact]
        public void DestinationTest()
        {
            instance.Destination = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Destination);
            
        }
        /// <summary>
        /// Test the property 'IfMachine'
        /// </summary>
        [Fact]
        public void IfMachineTest()
        {
            instance.IfMachine = IfMachine.REDIRECT;
            Assert.Equal(instance.IfMachine,IfMachine.REDIRECT);
            instance.IfMachine = IfMachine.HANGUP;
            Assert.Equal(instance.IfMachine,IfMachine.HANGUP);
            
        }
        /// <summary>
        /// Test the property 'IfMachineUrl'
        /// </summary>
        [Fact]
        public void IfMachineUrlTest()
        {
            instance.IfMachineUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.IfMachineUrl);
            
        }
        /// <summary>
        /// Test the property 'SendDigits'
        /// </summary>
        [Fact]
        public void SendDigitsTest()
        {
            instance.SendDigits = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.SendDigits);
            
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
        /// Test the property 'Timeout'
        /// </summary>
        [Fact]
        public void TimeoutTest()
        {
            
            instance.Timeout = 1;
            Assert.Equal(1, (int) instance.Timeout);
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
        public void equalsTrueTest() {
        OutDialAllOf test1 = new OutDialAllOf("https://a.com", "https://a.com", "TEST_STRING", "TEST_STRING", IfMachine.REDIRECT, "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, false);
        try {
            Uri uri = new Uri("https://a.com");
            instance.ActionUrl = uri.ToString();
            Assert.Equal(uri.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }
        try {
            Uri uri = new Uri("https://a.com");
            instance.CallConnectUrl = uri.ToString();
            Assert.Equal(uri.ToString(), instance.CallConnectUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }
         test1.CallingNumber = "TS";
         test1.Destination = "TS";
         test1.IfMachine = IfMachine.REDIRECT;
         test1.IfMachine = IfMachine.REDIRECT;
         test1.IfMachineUrl = "TS";
         test1.SendDigits = "TS";
         test1.StatusCallbackUrl = "TS";
         test1.Timeout = 1;
         test1.PrivacyMode = true;
        OutDialAllOf test2 = new OutDialAllOf("https://a.com", "https://a.com", "TEST_STRING", "TEST_STRING", IfMachine.REDIRECT, "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, false);
        try {
            Uri uri2 = new Uri("https://a.com");
            instance.ActionUrl = uri2.ToString();
            Assert.Equal(uri2.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }
        try {
            Uri uri2 = new Uri("https://a.com");
            instance.CallConnectUrl = uri2.ToString();
            Assert.Equal(uri2.ToString(), instance.CallConnectUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }
         test2.CallingNumber = "TS";
         test2.Destination = "TS";
         test2.IfMachine = IfMachine.REDIRECT;
         test2.IfMachine = IfMachine.REDIRECT;
         test2.IfMachineUrl = "TS";
         test2.SendDigits = "TS";
         test2.StatusCallbackUrl = "TS";
         test2.Timeout = 1;
         test2.PrivacyMode = true;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        OutDialAllOf test1 = new OutDialAllOf("https://a.com", "https://a.com", "TEST_STRING", "TEST_STRING", IfMachine.REDIRECT, "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, false);
        try {
            Uri uri = new Uri("https://a.com");
            instance.ActionUrl = uri.ToString();
            Assert.Equal(uri.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }
        try {
            Uri uri = new Uri("https://a.com");
            instance.CallConnectUrl = uri.ToString();
            Assert.Equal(uri.ToString(), instance.CallConnectUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }
         test1.CallingNumber = "TS";
         test1.Destination = "TS";
         test1.IfMachine = IfMachine.REDIRECT;
         test1.IfMachine = IfMachine.REDIRECT;
         test1.IfMachineUrl = "TS";
         test1.SendDigits = "TS";
         test1.StatusCallbackUrl = "TS";
         test1.Timeout = 1;
         test1.PrivacyMode = true;
        OutDialAllOf test2 = new OutDialAllOf("https://a.com", "https://a.com", "TEST_STRING", "TEST_STRING", IfMachine.REDIRECT, "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, false);
         try {
            Uri uri2 = new Uri("https://a.com");
            instance.ActionUrl = uri2.ToString();
            Assert.Equal(uri2.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }
         try {
            Uri uri2 = new Uri("https://a.com");
            instance.CallConnectUrl = uri2.ToString();
            Assert.Equal(uri2.ToString(), instance.CallConnectUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }
         test2.CallingNumber = "ts";
         test2.Destination = "ts";
         test2.IfMachine = IfMachine.REDIRECT;
         test2.IfMachine = IfMachine.REDIRECT;
         test2.IfMachineUrl = "ts";
         test2.SendDigits = "ts";
         test2.StatusCallbackUrl = "ts";
         test2.Timeout = 1;
         test2.PrivacyMode = false;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        OutDialAllOf test1 = new OutDialAllOf("https://a.com", "https://a.com", "TEST_STRING", "TEST_STRING", IfMachine.REDIRECT, "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, false);
         try {
            Uri uri = new Uri("https://a.com");
            instance.ActionUrl = uri.ToString();
            Assert.Equal(uri.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }
         try {
            Uri uri = new Uri("https://a.com");
            instance.CallConnectUrl = uri.ToString();
            Assert.Equal(uri.ToString(), instance.CallConnectUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }
         test1.CallingNumber = "TS";
         test1.Destination = "TS";
         test1.IfMachine = IfMachine.REDIRECT;
         test1.IfMachine = IfMachine.REDIRECT;
         test1.IfMachineUrl = "TS";
         test1.SendDigits = "TS";
         test1.StatusCallbackUrl = "TS";
         test1.Timeout = 1;
         test1.PrivacyMode = true;

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        OutDialAllOf test1 = new OutDialAllOf("https://a.com", "https://a.com", "TEST_STRING", "TEST_STRING", IfMachine.REDIRECT, "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, false);
         try {
            Uri uri = new Uri("https://a.com");
            instance.ActionUrl = uri.ToString();
            Assert.Equal(uri.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }
         try {
            Uri uri = new Uri("https://a.com");
            instance.CallConnectUrl = uri.ToString();
            Assert.Equal(uri.ToString(), instance.CallConnectUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }
         test1.CallingNumber = "TS";
         test1.Destination = "TS";
         test1.IfMachine = IfMachine.REDIRECT;
         test1.IfMachine = IfMachine.REDIRECT;
         test1.IfMachineUrl = "TS";
         test1.SendDigits = "TS";
         test1.StatusCallbackUrl = "TS";
         test1.Timeout = 1;
         test1.PrivacyMode = true;

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        OutDialAllOf test1 = new OutDialAllOf("https://a.com", "https://a.com", "TEST_STRING", "TEST_STRING", IfMachine.REDIRECT, "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, false);
         try {
            Uri uri = new Uri("https://a.com");
            instance.ActionUrl = uri.ToString();
            Assert.Equal(uri.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }
         try {
            Uri uri = new Uri("https://a.com");
            instance.CallConnectUrl = uri.ToString();
            Assert.Equal(uri.ToString(), instance.CallConnectUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }
         test1.CallingNumber = "TS";
         test1.Destination = "TS";
         test1.IfMachine = IfMachine.REDIRECT;
         test1.IfMachine = IfMachine.REDIRECT;
         test1.IfMachineUrl = "TS";
         test1.SendDigits = "TS";
         test1.StatusCallbackUrl = "TS";
         test1.Timeout = 1;
         test1.PrivacyMode = true;

        OutDialAllOf test2 = new OutDialAllOf("https://a.com", "https://a.com", "TEST_STRING", "TEST_STRING", IfMachine.REDIRECT, "TEST_STRING", "TEST_STRING", "TEST_STRING", 1, false);
         try {
            Uri uri2 = new Uri("https://a.com");
            instance.ActionUrl = uri2.ToString();
            Assert.Equal(uri2.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }
         try {
            Uri uri2 = new Uri("https://a.com");
            instance.CallConnectUrl = uri2.ToString();
            Assert.Equal(uri2.ToString(), instance.CallConnectUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }
         test2.CallingNumber = "TS";
         test2.Destination = "TS";
         test2.IfMachine = IfMachine.REDIRECT;
         test2.IfMachine = IfMachine.REDIRECT;
         test2.IfMachineUrl = "TS";
         test2.SendDigits = "TS";
         test2.StatusCallbackUrl = "TS";
         test2.Timeout = 1;
         test2.PrivacyMode = true;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }
    }
}
