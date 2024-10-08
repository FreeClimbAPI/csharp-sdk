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
    ///  Class for testing SMSTollFreeCampaign
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SMSTollFreeCampaignTests
    {
        private SMSTollFreeCampaign instance;

        public SMSTollFreeCampaignTests()
        {
            
            instance = new SMSTollFreeCampaign("TEST_STRING", "TEST_STRING", "TEST_STRING", SMSTollFreeCampaign.RegistrationStatusEnum.UNREGISTERED, "TEST_STRING", "TEST_STRING", 1);
            
        }

        /// <summary>
        /// Test an instance of SMSTollFreeCampaign
        /// </summary>
        [Fact]
        public void SMSTollFreeCampaignInstanceTest()
        {
            Assert.IsType<SMSTollFreeCampaign>(instance);
        }


        /// <summary>
        /// Test the property 'AccountId'
        /// </summary>
        [Fact]
        public void AccountIdTest()
        {
            instance.AccountId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.AccountId);
            
        }
        /// <summary>
        /// Test the property 'CampaignId'
        /// </summary>
        [Fact]
        public void CampaignIdTest()
        {
            instance.CampaignId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.CampaignId);
            
        }
        /// <summary>
        /// Test the property 'UseCase'
        /// </summary>
        [Fact]
        public void UseCaseTest()
        {
            instance.UseCase = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.UseCase);
            
        }
        /// <summary>
        /// Test the property 'RegistrationStatus'
        /// </summary>
        [Fact]
        public void RegistrationStatusTest()
        {
            
            instance.RegistrationStatus = SMSTollFreeCampaign.RegistrationStatusEnum.UNREGISTERED;
            Assert.Equal(instance.RegistrationStatus,SMSTollFreeCampaign.RegistrationStatusEnum.UNREGISTERED);
            
            instance.RegistrationStatus = SMSTollFreeCampaign.RegistrationStatusEnum.INITIATED;
            Assert.Equal(instance.RegistrationStatus,SMSTollFreeCampaign.RegistrationStatusEnum.INITIATED);
            
            instance.RegistrationStatus = SMSTollFreeCampaign.RegistrationStatusEnum.PENDING;
            Assert.Equal(instance.RegistrationStatus,SMSTollFreeCampaign.RegistrationStatusEnum.PENDING);
            
            instance.RegistrationStatus = SMSTollFreeCampaign.RegistrationStatusEnum.DECLINED;
            Assert.Equal(instance.RegistrationStatus,SMSTollFreeCampaign.RegistrationStatusEnum.DECLINED);
            
            instance.RegistrationStatus = SMSTollFreeCampaign.RegistrationStatusEnum.REGISTERED;
            Assert.Equal(instance.RegistrationStatus,SMSTollFreeCampaign.RegistrationStatusEnum.REGISTERED);
            
        }
        /// <summary>
        /// Test the property 'DateCreated'
        /// </summary>
        [Fact]
        public void DateCreatedTest()
        {
            instance.DateCreated = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.DateCreated);
            
        }
        /// <summary>
        /// Test the property 'DateUpdated'
        /// </summary>
        [Fact]
        public void DateUpdatedTest()
        {
            instance.DateUpdated = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.DateUpdated);
            
        }
        /// <summary>
        /// Test the property 'Revision'
        /// </summary>
        [Fact]
        public void RevisionTest()
        {
            
            instance.Revision = 1;
            Assert.Equal(1, (int) instance.Revision);
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        SMSTollFreeCampaign test1 = new SMSTollFreeCampaign("TEST_STRING", "TEST_STRING", "TEST_STRING", SMSTollFreeCampaign.RegistrationStatusEnum.UNREGISTERED, "TEST_STRING", "TEST_STRING", 1);
         test1.AccountId = "TS";
         test1.CampaignId = "TS";
         test1.UseCase = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;

        SMSTollFreeCampaign test2 = new SMSTollFreeCampaign("TEST_STRING", "TEST_STRING", "TEST_STRING", SMSTollFreeCampaign.RegistrationStatusEnum.UNREGISTERED, "TEST_STRING", "TEST_STRING", 1);
         test2.AccountId = "TS";
         test2.CampaignId = "TS";
         test2.UseCase = "TS";
         test2.DateCreated = "TS";
         test2.DateUpdated = "TS";
         test2.Revision = 1;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        SMSTollFreeCampaign test1 = new SMSTollFreeCampaign("TEST_STRING", "TEST_STRING", "TEST_STRING", SMSTollFreeCampaign.RegistrationStatusEnum.UNREGISTERED, "TEST_STRING", "TEST_STRING", 1);
         test1.AccountId = "TS";
         test1.CampaignId = "TS";
         test1.UseCase = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;

        SMSTollFreeCampaign test2 = new SMSTollFreeCampaign("TEST_STRING", "TEST_STRING", "TEST_STRING", SMSTollFreeCampaign.RegistrationStatusEnum.UNREGISTERED, "TEST_STRING", "TEST_STRING", 1);
         test2.AccountId = "ts";
         test2.CampaignId = "ts";
         test2.UseCase = "ts";
         test2.DateCreated = "ts";
         test2.DateUpdated = "ts";
         test2.Revision = 2;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        SMSTollFreeCampaign test1 = new SMSTollFreeCampaign("TEST_STRING", "TEST_STRING", "TEST_STRING", SMSTollFreeCampaign.RegistrationStatusEnum.UNREGISTERED, "TEST_STRING", "TEST_STRING", 1);
         test1.AccountId = "TS";
         test1.CampaignId = "TS";
         test1.UseCase = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        SMSTollFreeCampaign test1 = new SMSTollFreeCampaign("TEST_STRING", "TEST_STRING", "TEST_STRING", SMSTollFreeCampaign.RegistrationStatusEnum.UNREGISTERED, "TEST_STRING", "TEST_STRING", 1);
         test1.AccountId = "TS";
         test1.CampaignId = "TS";
         test1.UseCase = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        SMSTollFreeCampaign test1 = new SMSTollFreeCampaign("TEST_STRING", "TEST_STRING", "TEST_STRING", SMSTollFreeCampaign.RegistrationStatusEnum.UNREGISTERED, "TEST_STRING", "TEST_STRING", 1);
         test1.AccountId = "TS";
         test1.CampaignId = "TS";
         test1.UseCase = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;

        SMSTollFreeCampaign test2 = new SMSTollFreeCampaign("TEST_STRING", "TEST_STRING", "TEST_STRING", SMSTollFreeCampaign.RegistrationStatusEnum.UNREGISTERED, "TEST_STRING", "TEST_STRING", 1);
         test2.AccountId = "TS";
         test2.CampaignId = "TS";
         test2.UseCase = "TS";
         test2.DateCreated = "TS";
         test2.DateUpdated = "TS";
         test2.Revision = 1;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        SMSTollFreeCampaign test1 = new SMSTollFreeCampaign("TEST_STRING", "TEST_STRING", "TEST_STRING", SMSTollFreeCampaign.RegistrationStatusEnum.UNREGISTERED, "TEST_STRING", "TEST_STRING", 1);
         test1.AccountId = "TS";
         test1.CampaignId = "TS";
         test1.UseCase = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;

        SMSTollFreeCampaign test2 = new SMSTollFreeCampaign("TEST_STRING", "TEST_STRING", "TEST_STRING", SMSTollFreeCampaign.RegistrationStatusEnum.UNREGISTERED, "TEST_STRING", "TEST_STRING", 1);
         test2.AccountId = "TS";
         test2.CampaignId = "TS";
         test2.UseCase = "TS";
         test2.DateCreated = "TS";
         test2.DateUpdated = "TS";
         test2.Revision = 1;

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        SMSTollFreeCampaign test1 = new SMSTollFreeCampaign("TEST_STRING", "TEST_STRING", "TEST_STRING", SMSTollFreeCampaign.RegistrationStatusEnum.UNREGISTERED, "TEST_STRING", "TEST_STRING", 1);
         test1.AccountId = "TS";
         test1.CampaignId = "TS";
         test1.UseCase = "TS";
         test1.DateCreated = "TS";
         test1.DateUpdated = "TS";
         test1.Revision = 1;
        JsonSerializer jsonSerializer = JsonSerializer.Create();
        jsonSerializer.NullValueHandling = NullValueHandling.Ignore;
        StringBuilder strb = new StringBuilder();
        jsonSerializer.Serialize(new StringWriter(strb), test1);

        SMSTollFreeCampaign test2 = new SMSTollFreeCampaign("TEST_STRING", "TEST_STRING", "TEST_STRING", SMSTollFreeCampaign.RegistrationStatusEnum.UNREGISTERED, "TEST_STRING", "TEST_STRING", 1);
         test2.AccountId = "TS";
         test2.CampaignId = "TS";
         test2.UseCase = "TS";
         test2.DateCreated = "TS";
         test2.DateUpdated = "TS";
         test2.Revision = 1;

        Assert.True(strb.Equals(JsonConvert.SerializeObject(test2)));
        }
    }
}
