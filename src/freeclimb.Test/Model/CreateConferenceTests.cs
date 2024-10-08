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
    ///  Class for testing CreateConference
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CreateConferenceTests
    {
        private CreateConference instance;

        public CreateConferenceTests()
        {
            
            instance = new CreateConference("TEST_STRING", false, PlayBeep.ALWAYS, false, "TEST_STRING", "TEST_STRING", "TEST_STRING");
            
        }

        /// <summary>
        /// Test an instance of CreateConference
        /// </summary>
        [Fact]
        public void CreateConferenceInstanceTest()
        {
            Assert.IsType<CreateConference>(instance);
        }


        /// <summary>
        /// Test the property 'ActionUrl'
        /// </summary>
        [Fact]
        public void ActionUrlTest()
        {
            
            instance.ActionUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.ActionUrl);
        }
        /// <summary>
        /// Test the property 'Alias'
        /// </summary>
        [Fact]
        public void AliasTest()
        {
            instance.Alias = false;
            Assert.Equal(false, instance.Alias);       
            
        }
        /// <summary>
        /// Test the property 'PlayBeep'
        /// </summary>
        [Fact]
        public void PlayBeepTest()
        {
            instance.PlayBeep = PlayBeep.ALWAYS;
            Assert.Equal(instance.PlayBeep,PlayBeep.ALWAYS);
            instance.PlayBeep = PlayBeep.NEVER;
            Assert.Equal(instance.PlayBeep,PlayBeep.NEVER);
            instance.PlayBeep = PlayBeep.ENTRY_ONLY;
            Assert.Equal(instance.PlayBeep,PlayBeep.ENTRY_ONLY);
            instance.PlayBeep = PlayBeep.EXIT_ONLY;
            Assert.Equal(instance.PlayBeep,PlayBeep.EXIT_ONLY);
            
        }
        /// <summary>
        /// Test the property 'Record'
        /// </summary>
        [Fact]
        public void RecordTest()
        {
            instance.Record = false;
            Assert.Equal(false, instance.Record);       
            
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
        /// Test the property 'WaitUrl'
        /// </summary>
        [Fact]
        public void WaitUrlTest()
        {
            instance.WaitUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.WaitUrl);
            
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        CreateConference test1 = new CreateConference("TEST_STRING", false, PlayBeep.ALWAYS, false, "TEST_STRING", "TEST_STRING", "TEST_STRING");
         test1.ActionUrl = "TS";
         test1.Alias = true;
         test1.PlayBeep = PlayBeep.ALWAYS;
         test1.Record = true;
         test1.StatusCallbackUrl = "TS";
         test1.WaitUrl = "TS";

        CreateConference test2 = new CreateConference("TEST_STRING", false, PlayBeep.ALWAYS, false, "TEST_STRING", "TEST_STRING", "TEST_STRING");
         test2.ActionUrl = "TS";
         test2.Alias = true;
         test2.PlayBeep = PlayBeep.ALWAYS;
         test2.Record = true;
         test2.StatusCallbackUrl = "TS";
         test2.WaitUrl = "TS";

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        CreateConference test1 = new CreateConference("TEST_STRING", false, PlayBeep.ALWAYS, false, "TEST_STRING", "TEST_STRING", "TEST_STRING");
         test1.ActionUrl = "TS";
         test1.Alias = true;
         test1.PlayBeep = PlayBeep.ALWAYS;
         test1.Record = true;
         test1.StatusCallbackUrl = "TS";
         test1.WaitUrl = "TS";

        CreateConference test2 = new CreateConference("TEST_STRING", false, PlayBeep.ALWAYS, false, "TEST_STRING", "TEST_STRING", "TEST_STRING");
         test2.ActionUrl = "ts";
         test2.Alias = false;
         test2.PlayBeep = PlayBeep.NEVER;
         test2.Record = false;
         test2.StatusCallbackUrl = "ts";
         test2.WaitUrl = "ts";

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        CreateConference test1 = new CreateConference("TEST_STRING", false, PlayBeep.ALWAYS, false, "TEST_STRING", "TEST_STRING", "TEST_STRING");
         test1.ActionUrl = "TS";
         test1.Alias = true;
         test1.PlayBeep = PlayBeep.ALWAYS;
         test1.Record = true;
         test1.StatusCallbackUrl = "TS";
         test1.WaitUrl = "TS";

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        CreateConference test1 = new CreateConference("TEST_STRING", false, PlayBeep.ALWAYS, false, "TEST_STRING", "TEST_STRING", "TEST_STRING");
         test1.ActionUrl = "TS";
         test1.Alias = true;
         test1.PlayBeep = PlayBeep.ALWAYS;
         test1.Record = true;
         test1.StatusCallbackUrl = "TS";
         test1.WaitUrl = "TS";

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        CreateConference test1 = new CreateConference("TEST_STRING", false, PlayBeep.ALWAYS, false, "TEST_STRING", "TEST_STRING", "TEST_STRING");
         test1.ActionUrl = "TS";
         test1.Alias = true;
         test1.PlayBeep = PlayBeep.ALWAYS;
         test1.Record = true;
         test1.StatusCallbackUrl = "TS";
         test1.WaitUrl = "TS";

        CreateConference test2 = new CreateConference("TEST_STRING", false, PlayBeep.ALWAYS, false, "TEST_STRING", "TEST_STRING", "TEST_STRING");
         test2.ActionUrl = "TS";
         test2.Alias = true;
         test2.PlayBeep = PlayBeep.ALWAYS;
         test2.Record = true;
         test2.StatusCallbackUrl = "TS";
         test2.WaitUrl = "TS";

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        CreateConference test1 = new CreateConference("TEST_STRING", false, PlayBeep.ALWAYS, false, "TEST_STRING", "TEST_STRING", "TEST_STRING");
         test1.ActionUrl = "TS";
         test1.Alias = true;
         test1.PlayBeep = PlayBeep.ALWAYS;
         test1.Record = true;
         test1.StatusCallbackUrl = "TS";
         test1.WaitUrl = "TS";

        CreateConference test2 = new CreateConference("TEST_STRING", false, PlayBeep.ALWAYS, false, "TEST_STRING", "TEST_STRING", "TEST_STRING");
         test2.ActionUrl = "TS";
         test2.Alias = true;
         test2.PlayBeep = PlayBeep.ALWAYS;
         test2.Record = true;
         test2.StatusCallbackUrl = "TS";
         test2.WaitUrl = "TS";

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        CreateConference test1 = new CreateConference("TEST_STRING", false, PlayBeep.ALWAYS, false, "TEST_STRING", "TEST_STRING", "TEST_STRING");
         test1.ActionUrl = "TS";
         test1.Alias = true;
         test1.PlayBeep = PlayBeep.ALWAYS;
         test1.Record = true;
         test1.StatusCallbackUrl = "TS";
         test1.WaitUrl = "TS";
        JsonSerializer jsonSerializer = JsonSerializer.Create();
        jsonSerializer.NullValueHandling = NullValueHandling.Ignore;
        StringBuilder strb = new StringBuilder();
        jsonSerializer.Serialize(new StringWriter(strb), test1);

        CreateConference test2 = new CreateConference("TEST_STRING", false, PlayBeep.ALWAYS, false, "TEST_STRING", "TEST_STRING", "TEST_STRING");
         test2.ActionUrl = "TS";
         test2.Alias = true;
         test2.PlayBeep = PlayBeep.ALWAYS;
         test2.Record = true;
         test2.StatusCallbackUrl = "TS";
         test2.WaitUrl = "TS";

        Assert.True(strb.Equals(JsonConvert.SerializeObject(test2)));
        }
    }
}
