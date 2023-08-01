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
    ///  Class for testing GetSpeech
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GetSpeechTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GetSpeech
        private GetSpeech instance;

        public GetSpeechTests()
        {
            instance = new GetSpeech("https://a.com", GrammarType.URL, "TEST_STRING", "TEST_STRING", false, new List<PerclCommand>(), 1, 1, 1, 1, 1, 1, false, "TEST_STRING");
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GetSpeech
        /// </summary>
        [Fact]
        public void GetSpeechInstanceTest()
        {
            // TODO uncomment below to test "IsType" GetSpeech
            Assert.IsType<GetSpeech>(instance);
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
        /// Test the property 'GrammarType'
        /// </summary>
        [Fact]
        public void GrammarTypeTest()
        {
            instance.GrammarType = GrammarType.URL;
            Assert.Equal(instance.GrammarType,GrammarType.URL);
            instance.GrammarType = GrammarType.BUILT_IN;
            Assert.Equal(instance.GrammarType,GrammarType.BUILT_IN);
            
        }
        /// <summary>
        /// Test the property 'GrammarFile'
        /// </summary>
        [Fact]
        public void GrammarFileTest()
        {
            instance.GrammarFile = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.GrammarFile);
            
        }
        /// <summary>
        /// Test the property 'GrammarRule'
        /// </summary>
        [Fact]
        public void GrammarRuleTest()
        {
            instance.GrammarRule = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.GrammarRule);
            
        }
        /// <summary>
        /// Test the property 'PlayBeep'
        /// </summary>
        [Fact]
        public void PlayBeepTest()
        {
            instance.PlayBeep = false;
            Assert.Equal(false, instance.PlayBeep);       
            
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
        /// Test the property 'NoInputTimeoutMs'
        /// </summary>
        [Fact]
        public void NoInputTimeoutMsTest()
        {
            
            instance.NoInputTimeoutMs = 1;
            Assert.Equal(1, (int) instance.NoInputTimeoutMs);
        }
        /// <summary>
        /// Test the property 'RecognitionTimeoutMs'
        /// </summary>
        [Fact]
        public void RecognitionTimeoutMsTest()
        {
            
            instance.RecognitionTimeoutMs = 1;
            Assert.Equal(1, (int) instance.RecognitionTimeoutMs);
        }
        /// <summary>
        /// Test the property 'ConfidenceThreshold'
        /// </summary>
        [Fact]
        public void ConfidenceThresholdTest()
        {
            instance.ConfidenceThreshold = new decimal(1.0);
            Assert.Equal(new decimal(1.0), instance.ConfidenceThreshold);
            
        }
        /// <summary>
        /// Test the property 'SensitivityLevel'
        /// </summary>
        [Fact]
        public void SensitivityLevelTest()
        {
            instance.SensitivityLevel = new decimal(1.0);
            Assert.Equal(new decimal(1.0), instance.SensitivityLevel);
            
        }
        /// <summary>
        /// Test the property 'SpeechCompleteTimeoutMs'
        /// </summary>
        [Fact]
        public void SpeechCompleteTimeoutMsTest()
        {
            
            instance.SpeechCompleteTimeoutMs = 1;
            Assert.Equal(1, (int) instance.SpeechCompleteTimeoutMs);
        }
        /// <summary>
        /// Test the property 'SpeechIncompleteTimeoutMs'
        /// </summary>
        [Fact]
        public void SpeechIncompleteTimeoutMsTest()
        {
            
            instance.SpeechIncompleteTimeoutMs = 1;
            Assert.Equal(1, (int) instance.SpeechIncompleteTimeoutMs);
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
        GetSpeech test1 = new GetSpeech("https://a.com", GrammarType.URL, "TEST_STRING", "TEST_STRING", false, new List<PerclCommand>(), 1, 1, 1, 1, 1, 1, false, "TEST_STRING");
        try {
            Uri uri = new Uri("https://a.com");
            instance.ActionUrl = uri.ToString();
            Assert.Equal(uri.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }
         test1.GrammarType = GrammarType.URL;
         test1.GrammarType = GrammarType.URL;
         test1.GrammarFile = "TS";
         test1.GrammarRule = "TS";
         test1.PlayBeep = true;
         List<PerclCommand> testList = new List<PerclCommand>();
         test1.Prompts = testList;
         test1.NoInputTimeoutMs = 1;
         test1.RecognitionTimeoutMs = 1;
         test1.SpeechCompleteTimeoutMs = 1;
         test1.SpeechIncompleteTimeoutMs = 1;
         test1.PrivacyMode = true;
        GetSpeech test2 = new GetSpeech("https://a.com", GrammarType.URL, "TEST_STRING", "TEST_STRING", false, new List<PerclCommand>(), 1, 1, 1, 1, 1, 1, false, "TEST_STRING");
        try {
            Uri uri2 = new Uri("https://a.com");
            instance.ActionUrl = uri2.ToString();
            Assert.Equal(uri2.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }
         test2.GrammarType = GrammarType.URL;
         test2.GrammarType = GrammarType.URL;
         test2.GrammarFile = "TS";
         test2.GrammarRule = "TS";
         test2.PlayBeep = true;
         List<PerclCommand> testList2 = new List<PerclCommand>();
         test2.Prompts = testList2;
         test2.NoInputTimeoutMs = 1;
         test2.RecognitionTimeoutMs = 1;
         test2.SpeechCompleteTimeoutMs = 1;
         test2.SpeechIncompleteTimeoutMs = 1;
         test2.PrivacyMode = true;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        GetSpeech test1 = new GetSpeech("https://a.com", GrammarType.URL, "TEST_STRING", "TEST_STRING", false, new List<PerclCommand>(), 1, 1, 1, 1, 1, 1, false, "TEST_STRING");
        try {
            Uri uri = new Uri("https://a.com");
            instance.ActionUrl = uri.ToString();
            Assert.Equal(uri.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }
         test1.GrammarType = GrammarType.URL;
         test1.GrammarType = GrammarType.URL;
         test1.GrammarFile = "TS";
         test1.GrammarRule = "TS";
         test1.PlayBeep = true;
         List<PerclCommand> testList = new List<PerclCommand>();
         test1.Prompts = testList;
         test1.NoInputTimeoutMs = 1;
         test1.RecognitionTimeoutMs = 1;
         test1.SpeechCompleteTimeoutMs = 1;
         test1.SpeechIncompleteTimeoutMs = 1;
         test1.PrivacyMode = true;
        GetSpeech test2 = new GetSpeech("https://a.com", GrammarType.URL, "TEST_STRING", "TEST_STRING", false, new List<PerclCommand>(), 1, 1, 1, 1, 1, 1, false, "TEST_STRING");
         try {
            Uri uri2 = new Uri("https://a.com");
            instance.ActionUrl = uri2.ToString();
            Assert.Equal(uri2.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }
         test2.GrammarType = GrammarType.URL;
         test2.GrammarType = GrammarType.URL;
         test2.GrammarFile = "ts";
         test2.GrammarRule = "ts";
         test2.PlayBeep = false;
         List<PerclCommand> testList2 = null;
         test2.Prompts = testList2;
         test2.NoInputTimeoutMs = 1;
         test2.RecognitionTimeoutMs = 1;
         test2.SpeechCompleteTimeoutMs = 1;
         test2.SpeechIncompleteTimeoutMs = 1;
         test2.PrivacyMode = false;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        GetSpeech test1 = new GetSpeech("https://a.com", GrammarType.URL, "TEST_STRING", "TEST_STRING", false, new List<PerclCommand>(), 1, 1, 1, 1, 1, 1, false, "TEST_STRING");
         try {
            Uri uri = new Uri("https://a.com");
            instance.ActionUrl = uri.ToString();
            Assert.Equal(uri.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }
         test1.GrammarType = GrammarType.URL;
         test1.GrammarType = GrammarType.URL;
         test1.GrammarFile = "TS";
         test1.GrammarRule = "TS";
         test1.PlayBeep = true;
         List<PerclCommand> testList = new List<PerclCommand>();
         test1.Prompts = testList;
         test1.NoInputTimeoutMs = 1;
         test1.RecognitionTimeoutMs = 1;
         test1.SpeechCompleteTimeoutMs = 1;
         test1.SpeechIncompleteTimeoutMs = 1;
         test1.PrivacyMode = true;

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        GetSpeech test1 = new GetSpeech("https://a.com", GrammarType.URL, "TEST_STRING", "TEST_STRING", false, new List<PerclCommand>(), 1, 1, 1, 1, 1, 1, false, "TEST_STRING");
         try {
            Uri uri = new Uri("https://a.com");
            instance.ActionUrl = uri.ToString();
            Assert.Equal(uri.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }
         test1.GrammarType = GrammarType.URL;
         test1.GrammarType = GrammarType.URL;
         test1.GrammarFile = "TS";
         test1.GrammarRule = "TS";
         test1.PlayBeep = true;
         List<PerclCommand> testList = new List<PerclCommand>();
         test1.Prompts = testList;
         test1.NoInputTimeoutMs = 1;
         test1.RecognitionTimeoutMs = 1;
         test1.SpeechCompleteTimeoutMs = 1;
         test1.SpeechIncompleteTimeoutMs = 1;
         test1.PrivacyMode = true;

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        GetSpeech test1 = new GetSpeech("https://a.com", GrammarType.URL, "TEST_STRING", "TEST_STRING", false, new List<PerclCommand>(), 1, 1, 1, 1, 1, 1, false, "TEST_STRING");
         try {
            Uri uri = new Uri("https://a.com");
            instance.ActionUrl = uri.ToString();
            Assert.Equal(uri.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }
         test1.GrammarType = GrammarType.URL;
         test1.GrammarType = GrammarType.URL;
         test1.GrammarFile = "TS";
         test1.GrammarRule = "TS";
         test1.PlayBeep = true;
         List<PerclCommand> testList = new List<PerclCommand>();
         test1.Prompts = testList;
         test1.NoInputTimeoutMs = 1;
         test1.RecognitionTimeoutMs = 1;
         test1.SpeechCompleteTimeoutMs = 1;
         test1.SpeechIncompleteTimeoutMs = 1;
         test1.PrivacyMode = true;

        GetSpeech test2 = new GetSpeech("https://a.com", GrammarType.URL, "TEST_STRING", "TEST_STRING", false, new List<PerclCommand>(), 1, 1, 1, 1, 1, 1, false, "TEST_STRING");
         try {
            Uri uri2 = new Uri("https://a.com");
            instance.ActionUrl = uri2.ToString();
            Assert.Equal(uri2.ToString(), instance.ActionUrl);
            } catch (Exception ) {
            Console.WriteLine("Something went wrong.");
            }
         test2.GrammarType = GrammarType.URL;
         test2.GrammarType = GrammarType.URL;
         test2.GrammarFile = "TS";
         test2.GrammarRule = "TS";
         test2.PlayBeep = true;
         List<PerclCommand> testList2 = new List<PerclCommand>();
         test2.Prompts = testList2;
         test2.NoInputTimeoutMs = 1;
         test2.RecognitionTimeoutMs = 1;
         test2.SpeechCompleteTimeoutMs = 1;
         test2.SpeechIncompleteTimeoutMs = 1;
         test2.PrivacyMode = true;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }
    }
}
