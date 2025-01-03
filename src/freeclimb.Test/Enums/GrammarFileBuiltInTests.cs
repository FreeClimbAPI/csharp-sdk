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
    ///  Class for testing GrammarFileBuiltIn
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>

    public class GrammarFileBuiltInTests : IDisposable
    {
        private GrammarFileBuiltIn instance;

        public GrammarFileBuiltInTests()
        {
            instance = new GrammarFileBuiltIn();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GrammarFileBuiltIn
        /// </summary>
        [Fact]
        public void GrammarFileBuiltInInstanceTest()
        {
            Assert.IsType<GrammarFileBuiltIn>(instance);
        }

        [Fact]
        public void TestALPHNUM6ShouldWork()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.ALPHNUM6;
            Assert.Equal(typeof(GrammarFileBuiltIn), test.GetType());
        }

        [Fact]
        public void TestALPHNUM6ShouldSerializeToEnum()
        {
            GrammarFileBuiltIn expectedValue = GrammarFileBuiltIn.ALPHNUM6;
            GrammarFileBuiltIn calculatedValue = (GrammarFileBuiltIn)
                Enum.Parse(typeof(GrammarFileBuiltIn), "ALPHNUM6");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestALPHNUM6ShouldDeserializeToString()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.ALPHNUM6;
            string expectedValue = "ALPHNUM6";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestANY_DIGShouldWork()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.ANY_DIG;
            Assert.Equal(typeof(GrammarFileBuiltIn), test.GetType());
        }

        [Fact]
        public void TestANY_DIGShouldSerializeToEnum()
        {
            GrammarFileBuiltIn expectedValue = GrammarFileBuiltIn.ANY_DIG;
            GrammarFileBuiltIn calculatedValue = (GrammarFileBuiltIn)
                Enum.Parse(typeof(GrammarFileBuiltIn), "ANY_DIG");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestANY_DIGShouldDeserializeToString()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.ANY_DIG;
            string expectedValue = "ANY_DIG";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDIG1ShouldWork()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.DIG1;
            Assert.Equal(typeof(GrammarFileBuiltIn), test.GetType());
        }

        [Fact]
        public void TestDIG1ShouldSerializeToEnum()
        {
            GrammarFileBuiltIn expectedValue = GrammarFileBuiltIn.DIG1;
            GrammarFileBuiltIn calculatedValue = (GrammarFileBuiltIn)
                Enum.Parse(typeof(GrammarFileBuiltIn), "DIG1");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDIG1ShouldDeserializeToString()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.DIG1;
            string expectedValue = "DIG1";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDIG2ShouldWork()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.DIG2;
            Assert.Equal(typeof(GrammarFileBuiltIn), test.GetType());
        }

        [Fact]
        public void TestDIG2ShouldSerializeToEnum()
        {
            GrammarFileBuiltIn expectedValue = GrammarFileBuiltIn.DIG2;
            GrammarFileBuiltIn calculatedValue = (GrammarFileBuiltIn)
                Enum.Parse(typeof(GrammarFileBuiltIn), "DIG2");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDIG2ShouldDeserializeToString()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.DIG2;
            string expectedValue = "DIG2";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDIG3ShouldWork()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.DIG3;
            Assert.Equal(typeof(GrammarFileBuiltIn), test.GetType());
        }

        [Fact]
        public void TestDIG3ShouldSerializeToEnum()
        {
            GrammarFileBuiltIn expectedValue = GrammarFileBuiltIn.DIG3;
            GrammarFileBuiltIn calculatedValue = (GrammarFileBuiltIn)
                Enum.Parse(typeof(GrammarFileBuiltIn), "DIG3");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDIG3ShouldDeserializeToString()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.DIG3;
            string expectedValue = "DIG3";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDIG4ShouldWork()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.DIG4;
            Assert.Equal(typeof(GrammarFileBuiltIn), test.GetType());
        }

        [Fact]
        public void TestDIG4ShouldSerializeToEnum()
        {
            GrammarFileBuiltIn expectedValue = GrammarFileBuiltIn.DIG4;
            GrammarFileBuiltIn calculatedValue = (GrammarFileBuiltIn)
                Enum.Parse(typeof(GrammarFileBuiltIn), "DIG4");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDIG4ShouldDeserializeToString()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.DIG4;
            string expectedValue = "DIG4";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDIG5ShouldWork()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.DIG5;
            Assert.Equal(typeof(GrammarFileBuiltIn), test.GetType());
        }

        [Fact]
        public void TestDIG5ShouldSerializeToEnum()
        {
            GrammarFileBuiltIn expectedValue = GrammarFileBuiltIn.DIG5;
            GrammarFileBuiltIn calculatedValue = (GrammarFileBuiltIn)
                Enum.Parse(typeof(GrammarFileBuiltIn), "DIG5");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDIG5ShouldDeserializeToString()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.DIG5;
            string expectedValue = "DIG5";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDIG6ShouldWork()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.DIG6;
            Assert.Equal(typeof(GrammarFileBuiltIn), test.GetType());
        }

        [Fact]
        public void TestDIG6ShouldSerializeToEnum()
        {
            GrammarFileBuiltIn expectedValue = GrammarFileBuiltIn.DIG6;
            GrammarFileBuiltIn calculatedValue = (GrammarFileBuiltIn)
                Enum.Parse(typeof(GrammarFileBuiltIn), "DIG6");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDIG6ShouldDeserializeToString()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.DIG6;
            string expectedValue = "DIG6";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDIG7ShouldWork()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.DIG7;
            Assert.Equal(typeof(GrammarFileBuiltIn), test.GetType());
        }

        [Fact]
        public void TestDIG7ShouldSerializeToEnum()
        {
            GrammarFileBuiltIn expectedValue = GrammarFileBuiltIn.DIG7;
            GrammarFileBuiltIn calculatedValue = (GrammarFileBuiltIn)
                Enum.Parse(typeof(GrammarFileBuiltIn), "DIG7");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDIG7ShouldDeserializeToString()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.DIG7;
            string expectedValue = "DIG7";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDIG8ShouldWork()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.DIG8;
            Assert.Equal(typeof(GrammarFileBuiltIn), test.GetType());
        }

        [Fact]
        public void TestDIG8ShouldSerializeToEnum()
        {
            GrammarFileBuiltIn expectedValue = GrammarFileBuiltIn.DIG8;
            GrammarFileBuiltIn calculatedValue = (GrammarFileBuiltIn)
                Enum.Parse(typeof(GrammarFileBuiltIn), "DIG8");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDIG8ShouldDeserializeToString()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.DIG8;
            string expectedValue = "DIG8";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDIG9ShouldWork()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.DIG9;
            Assert.Equal(typeof(GrammarFileBuiltIn), test.GetType());
        }

        [Fact]
        public void TestDIG9ShouldSerializeToEnum()
        {
            GrammarFileBuiltIn expectedValue = GrammarFileBuiltIn.DIG9;
            GrammarFileBuiltIn calculatedValue = (GrammarFileBuiltIn)
                Enum.Parse(typeof(GrammarFileBuiltIn), "DIG9");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDIG9ShouldDeserializeToString()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.DIG9;
            string expectedValue = "DIG9";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDIG10ShouldWork()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.DIG10;
            Assert.Equal(typeof(GrammarFileBuiltIn), test.GetType());
        }

        [Fact]
        public void TestDIG10ShouldSerializeToEnum()
        {
            GrammarFileBuiltIn expectedValue = GrammarFileBuiltIn.DIG10;
            GrammarFileBuiltIn calculatedValue = (GrammarFileBuiltIn)
                Enum.Parse(typeof(GrammarFileBuiltIn), "DIG10");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDIG10ShouldDeserializeToString()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.DIG10;
            string expectedValue = "DIG10";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDIG11ShouldWork()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.DIG11;
            Assert.Equal(typeof(GrammarFileBuiltIn), test.GetType());
        }

        [Fact]
        public void TestDIG11ShouldSerializeToEnum()
        {
            GrammarFileBuiltIn expectedValue = GrammarFileBuiltIn.DIG11;
            GrammarFileBuiltIn calculatedValue = (GrammarFileBuiltIn)
                Enum.Parse(typeof(GrammarFileBuiltIn), "DIG11");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestDIG11ShouldDeserializeToString()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.DIG11;
            string expectedValue = "DIG11";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestUP_TO_20_DIGIT_SEQUENCEShouldWork()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.UP_TO_20_DIGIT_SEQUENCE;
            Assert.Equal(typeof(GrammarFileBuiltIn), test.GetType());
        }

        [Fact]
        public void TestUP_TO_20_DIGIT_SEQUENCEShouldSerializeToEnum()
        {
            GrammarFileBuiltIn expectedValue = GrammarFileBuiltIn.UP_TO_20_DIGIT_SEQUENCE;
            GrammarFileBuiltIn calculatedValue = (GrammarFileBuiltIn)
                Enum.Parse(typeof(GrammarFileBuiltIn), "UP_TO_20_DIGIT_SEQUENCE");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestUP_TO_20_DIGIT_SEQUENCEShouldDeserializeToString()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.UP_TO_20_DIGIT_SEQUENCE;
            string expectedValue = "UP_TO_20_DIGIT_SEQUENCE";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestVERSAY_YESNOShouldWork()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.VERSAY_YESNO;
            Assert.Equal(typeof(GrammarFileBuiltIn), test.GetType());
        }

        [Fact]
        public void TestVERSAY_YESNOShouldSerializeToEnum()
        {
            GrammarFileBuiltIn expectedValue = GrammarFileBuiltIn.VERSAY_YESNO;
            GrammarFileBuiltIn calculatedValue = (GrammarFileBuiltIn)
                Enum.Parse(typeof(GrammarFileBuiltIn), "VERSAY_YESNO");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestVERSAY_YESNOShouldDeserializeToString()
        {
            GrammarFileBuiltIn test = GrammarFileBuiltIn.VERSAY_YESNO;
            string expectedValue = "VERSAY_YESNO";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }
    }
}
