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

using freeclimb.Enums;

namespace freeclimb.Test.Enums
{
    /// <summary>
    ///  Class for testing Language
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LanguageTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Language
        private Language instance;

        public LanguageTests()
        {
            instance = LanguageInstanceValue();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Language
        /// </summary>
        [Fact]
        public void LanguageInstanceTest()
        {
            // TODO uncomment below to test "IsType" Language
            //Assert.IsType<Language>(instance);
        }


        [Fact]
        public void EnumToStringValueTest()
        {
            string expectedValue = StringValueLanguageTestValue();
            string calculatedValue = Extensions.GetMemberValue(instance);
            Assert.Equal(expectedValue, calculatedValue);
        }
        [Fact]
        public void StringToEnumValueTest()
        {
            string expectedValue = StringValueLanguageTestValue();
            Language calculatedValue = Reflection.GetEnumByValue<Language>(expectedValue);
            Assert.Equal(instance, calculatedValue);
        }
        private Language LanguageInstanceValue()
        {
            return Reflection.GetEnumByValue<Language>(StringValueLanguageTestValue());
        }
        private string StringValueAccountStatusTestValue()
        {
            return "active";
        }
        private string StringValueAccountTypeTestValue()
        {
            return "trial";
        }
        private string StringValueAnsweredByTestValue()
        {
            return "human";
        }
        private string StringValueCallDirectionTestValue()
        {
            return "inbound";
        }
        private string StringValueCallStatusTestValue()
        {
            return "queued";
        }
        private string StringValueConferenceStatusTestValue()
        {
            return "populated";
        }
        private string StringValueGetSpeechReasonTestValue()
        {
            return "digit";
        }
        private string StringValueGrammarFileBuiltInTestValue()
        {
            return "ALPHNUM6";
        }
        private string StringValueGrammarTypeTestValue()
        {
            return "URL";
        }
        private string StringValueIfMachineTestValue()
        {
            return "redirect";
        }
        private string StringValueLanguageTestValue()
        {
            return "ca-ES";
        }
        private string StringValueLogLevelTestValue()
        {
            return "info";
        }
        private string StringValueMachineTypeTestValue()
        {
            return "answeringMachine";
        }
        private string StringValueMessageDirectionTestValue()
        {
            return "inbound";
        }
        private string StringValueMessageStatusTestValue()
        {
            return "new";
        }
        private string StringValuePlayBeepTestValue()
        {
            return "always";
        }
        private string StringValueQueueResultStatusTestValue()
        {
            return "queueFull";
        }
        private string StringValueRecordUtteranceTermReasonTestValue()
        {
            return "finishKey";
        }
        private string StringValueRequestTypeTestValue()
        {
            return "inboundCall";
        }
        private string StringValueUpdateCallRequestStatusTestValue()
        {
            return "completed";
        }
        private string StringValueUpdateConferenceRequestStatusTestValue()
        {
            return "empty";
        }
    }
}
