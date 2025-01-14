/*
 * FreeClimb API
 *
 * FreeClimb is a cloud-based application programming interface (API) that puts the power of the Vail platform in your hands. FreeClimb simplifies the process of creating applications that can use a full range of telephony features without requiring specialized or on-site telephony equipment. Using the FreeClimb REST API to write applications is easy! You have the option to use the language of your choice or hit the API directly. Your application can execute a command by issuing a RESTful request to the FreeClimb API. The base URL to send HTTP requests to the FreeClimb REST API is: /apiserver. FreeClimb authenticates and processes your request.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@freeclimb.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using freeclimb.Client;
using freeclimb.Enums;
using freeclimb.Model;
using freeclimb.Test;
using Newtonsoft.Json;
using Xunit;

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
        private Language instance;

        public LanguageTests()
        {
            instance = new Language();
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
            Assert.IsType<Language>(instance);
        }

        [Fact]
        public void TestCATALANShouldWork()
        {
            Language test = Language.CATALAN;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestCATALANShouldSerializeToEnum()
        {
            Language expectedValue = Language.CATALAN;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "CATALAN");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestCATALANShouldDeserializeToString()
        {
            Language test = Language.CATALAN;
            string expectedValue = "CATALAN";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDANISHShouldWork()
        {
            Language test = Language.DANISH;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestDANISHShouldSerializeToEnum()
        {
            Language expectedValue = Language.DANISH;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "DANISH");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDANISHShouldDeserializeToString()
        {
            Language test = Language.DANISH;
            string expectedValue = "DANISH";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestGERMANShouldWork()
        {
            Language test = Language.GERMAN;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestGERMANShouldSerializeToEnum()
        {
            Language expectedValue = Language.GERMAN;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "GERMAN");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestGERMANShouldDeserializeToString()
        {
            Language test = Language.GERMAN;
            string expectedValue = "GERMAN";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestENGLISH_AUShouldWork()
        {
            Language test = Language.ENGLISH_AU;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestENGLISH_AUShouldSerializeToEnum()
        {
            Language expectedValue = Language.ENGLISH_AU;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "ENGLISH_AU");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestENGLISH_AUShouldDeserializeToString()
        {
            Language test = Language.ENGLISH_AU;
            string expectedValue = "ENGLISH_AU";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestENGLISH_CAShouldWork()
        {
            Language test = Language.ENGLISH_CA;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestENGLISH_CAShouldSerializeToEnum()
        {
            Language expectedValue = Language.ENGLISH_CA;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "ENGLISH_CA");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestENGLISH_CAShouldDeserializeToString()
        {
            Language test = Language.ENGLISH_CA;
            string expectedValue = "ENGLISH_CA";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestENGLISH_UKShouldWork()
        {
            Language test = Language.ENGLISH_UK;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestENGLISH_UKShouldSerializeToEnum()
        {
            Language expectedValue = Language.ENGLISH_UK;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "ENGLISH_UK");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestENGLISH_UKShouldDeserializeToString()
        {
            Language test = Language.ENGLISH_UK;
            string expectedValue = "ENGLISH_UK";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestENGLISH_INShouldWork()
        {
            Language test = Language.ENGLISH_IN;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestENGLISH_INShouldSerializeToEnum()
        {
            Language expectedValue = Language.ENGLISH_IN;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "ENGLISH_IN");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestENGLISH_INShouldDeserializeToString()
        {
            Language test = Language.ENGLISH_IN;
            string expectedValue = "ENGLISH_IN";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestENGLISH_USShouldWork()
        {
            Language test = Language.ENGLISH_US;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestENGLISH_USShouldSerializeToEnum()
        {
            Language expectedValue = Language.ENGLISH_US;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "ENGLISH_US");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestENGLISH_USShouldDeserializeToString()
        {
            Language test = Language.ENGLISH_US;
            string expectedValue = "ENGLISH_US";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestENGLISH_ESShouldWork()
        {
            Language test = Language.ENGLISH_ES;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestENGLISH_ESShouldSerializeToEnum()
        {
            Language expectedValue = Language.ENGLISH_ES;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "ENGLISH_ES");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestENGLISH_ESShouldDeserializeToString()
        {
            Language test = Language.ENGLISH_ES;
            string expectedValue = "ENGLISH_ES";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestENGLISH_MXShouldWork()
        {
            Language test = Language.ENGLISH_MX;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestENGLISH_MXShouldSerializeToEnum()
        {
            Language expectedValue = Language.ENGLISH_MX;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "ENGLISH_MX");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestENGLISH_MXShouldDeserializeToString()
        {
            Language test = Language.ENGLISH_MX;
            string expectedValue = "ENGLISH_MX";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestFINNISHShouldWork()
        {
            Language test = Language.FINNISH;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestFINNISHShouldSerializeToEnum()
        {
            Language expectedValue = Language.FINNISH;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "FINNISH");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestFINNISHShouldDeserializeToString()
        {
            Language test = Language.FINNISH;
            string expectedValue = "FINNISH";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestFRENCH_CAShouldWork()
        {
            Language test = Language.FRENCH_CA;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestFRENCH_CAShouldSerializeToEnum()
        {
            Language expectedValue = Language.FRENCH_CA;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "FRENCH_CA");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestFRENCH_CAShouldDeserializeToString()
        {
            Language test = Language.FRENCH_CA;
            string expectedValue = "FRENCH_CA";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestFRENCH_FRShouldWork()
        {
            Language test = Language.FRENCH_FR;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestFRENCH_FRShouldSerializeToEnum()
        {
            Language expectedValue = Language.FRENCH_FR;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "FRENCH_FR");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestFRENCH_FRShouldDeserializeToString()
        {
            Language test = Language.FRENCH_FR;
            string expectedValue = "FRENCH_FR";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestITALIANShouldWork()
        {
            Language test = Language.ITALIAN;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestITALIANShouldSerializeToEnum()
        {
            Language expectedValue = Language.ITALIAN;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "ITALIAN");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestITALIANShouldDeserializeToString()
        {
            Language test = Language.ITALIAN;
            string expectedValue = "ITALIAN";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestJAPANESEShouldWork()
        {
            Language test = Language.JAPANESE;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestJAPANESEShouldSerializeToEnum()
        {
            Language expectedValue = Language.JAPANESE;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "JAPANESE");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestJAPANESEShouldDeserializeToString()
        {
            Language test = Language.JAPANESE;
            string expectedValue = "JAPANESE";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestKOREANShouldWork()
        {
            Language test = Language.KOREAN;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestKOREANShouldSerializeToEnum()
        {
            Language expectedValue = Language.KOREAN;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "KOREAN");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestKOREANShouldDeserializeToString()
        {
            Language test = Language.KOREAN;
            string expectedValue = "KOREAN";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestNORWEGIANShouldWork()
        {
            Language test = Language.NORWEGIAN;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestNORWEGIANShouldSerializeToEnum()
        {
            Language expectedValue = Language.NORWEGIAN;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "NORWEGIAN");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestNORWEGIANShouldDeserializeToString()
        {
            Language test = Language.NORWEGIAN;
            string expectedValue = "NORWEGIAN";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDUTCHShouldWork()
        {
            Language test = Language.DUTCH;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestDUTCHShouldSerializeToEnum()
        {
            Language expectedValue = Language.DUTCH;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "DUTCH");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDUTCHShouldDeserializeToString()
        {
            Language test = Language.DUTCH;
            string expectedValue = "DUTCH";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestPOLISHShouldWork()
        {
            Language test = Language.POLISH;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestPOLISHShouldSerializeToEnum()
        {
            Language expectedValue = Language.POLISH;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "POLISH");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestPOLISHShouldDeserializeToString()
        {
            Language test = Language.POLISH;
            string expectedValue = "POLISH";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestPORTUGESE_BRShouldWork()
        {
            Language test = Language.PORTUGESE_BR;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestPORTUGESE_BRShouldSerializeToEnum()
        {
            Language expectedValue = Language.PORTUGESE_BR;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "PORTUGESE_BR");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestPORTUGESE_BRShouldDeserializeToString()
        {
            Language test = Language.PORTUGESE_BR;
            string expectedValue = "PORTUGESE_BR";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestPORTUGESE_PTShouldWork()
        {
            Language test = Language.PORTUGESE_PT;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestPORTUGESE_PTShouldSerializeToEnum()
        {
            Language expectedValue = Language.PORTUGESE_PT;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "PORTUGESE_PT");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestPORTUGESE_PTShouldDeserializeToString()
        {
            Language test = Language.PORTUGESE_PT;
            string expectedValue = "PORTUGESE_PT";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestRUSSIANShouldWork()
        {
            Language test = Language.RUSSIAN;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestRUSSIANShouldSerializeToEnum()
        {
            Language expectedValue = Language.RUSSIAN;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "RUSSIAN");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestRUSSIANShouldDeserializeToString()
        {
            Language test = Language.RUSSIAN;
            string expectedValue = "RUSSIAN";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestSWEDISHShouldWork()
        {
            Language test = Language.SWEDISH;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestSWEDISHShouldSerializeToEnum()
        {
            Language expectedValue = Language.SWEDISH;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "SWEDISH");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestSWEDISHShouldDeserializeToString()
        {
            Language test = Language.SWEDISH;
            string expectedValue = "SWEDISH";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestCHINESE_CNShouldWork()
        {
            Language test = Language.CHINESE_CN;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestCHINESE_CNShouldSerializeToEnum()
        {
            Language expectedValue = Language.CHINESE_CN;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "CHINESE_CN");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestCHINESE_CNShouldDeserializeToString()
        {
            Language test = Language.CHINESE_CN;
            string expectedValue = "CHINESE_CN";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestCHINESE_HKShouldWork()
        {
            Language test = Language.CHINESE_HK;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestCHINESE_HKShouldSerializeToEnum()
        {
            Language expectedValue = Language.CHINESE_HK;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "CHINESE_HK");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestCHINESE_HKShouldDeserializeToString()
        {
            Language test = Language.CHINESE_HK;
            string expectedValue = "CHINESE_HK";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestCHINESE_TWShouldWork()
        {
            Language test = Language.CHINESE_TW;
            Assert.Equal(typeof(Language), test.GetType());
        }

        [Fact]
        public void TestCHINESE_TWShouldSerializeToEnum()
        {
            Language expectedValue = Language.CHINESE_TW;
            Language calculatedValue = (Language)Enum.Parse(typeof(Language), "CHINESE_TW");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestCHINESE_TWShouldDeserializeToString()
        {
            Language test = Language.CHINESE_TW;
            string expectedValue = "CHINESE_TW";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }
    }
}
