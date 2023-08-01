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
    ///  Class for testing SMSTenDLCPartnerCampaign
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SMSTenDLCPartnerCampaignTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SMSTenDLCPartnerCampaign
        private SMSTenDLCPartnerCampaign instance;

        public SMSTenDLCPartnerCampaignTests()
        {
            string jsonData = @"
            {
                ""campaignId"":""TEST_STRING"",
                ""usecase"":""PRIVATE_PROFIT"",
                ""description"": ""TEST_STRING"",
                ""brandId"": ""TEST_STRING"",
                ""phone"":""TEST_STRING"",
            }
            ";
            instance = JsonConvert.DeserializeObject<SMSTenDLCPartnerCampaign>(jsonData);

            instance = new SMSTenDLCPartnerCampaign("TEST_STRING", "TEST_STRING", SMSTenDLCPartnerCampaign.StatusEnum.ACTIVE, DateTime.Parse("2022-07-05T15:17:05+00:00"), "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false, false, false, false, false, false, false, "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new SMSTenDLCPartnerCampaignBrand("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new Dictionary<string, object>(), 1));

        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SMSTenDLCPartnerCampaign
        /// </summary>
        [Fact]
        public void SMSTenDLCPartnerCampaignInstanceTest()
        {
            // TODO uncomment below to test "IsType" SMSTenDLCPartnerCampaign
            Assert.IsType<SMSTenDLCPartnerCampaign>(instance);
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
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            instance.Status = SMSTenDLCPartnerCampaign.StatusEnum.ACTIVE;
            Assert.Equal(instance.Status,SMSTenDLCPartnerCampaign.StatusEnum.ACTIVE);
            
            instance.Status = SMSTenDLCPartnerCampaign.StatusEnum.EXPIRED;
            Assert.Equal(instance.Status,SMSTenDLCPartnerCampaign.StatusEnum.EXPIRED);
        }
        /// <summary>
        /// Test the property 'CreateDate'
        /// </summary>
        [Fact]
        public void CreateDateTest()
        {
            instance.CreateDate = DateTime.Parse("2022-07-05T15:17:05+00:00");
            Assert.Equal(DateTime.Parse("2022-07-05T15:17:05+00:00"), instance.CreateDate);
            
        }
        /// <summary>
        /// Test the property 'BrandId'
        /// </summary>
        [Fact]
        public void BrandIdTest()
        {
            instance.BrandId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.BrandId);
            
        }
        /// <summary>
        /// Test the property 'Usecase'
        /// </summary>
        [Fact]
        public void UsecaseTest()
        {
            instance.Usecase = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Usecase);
            
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            instance.Description = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Description);
            
        }
        /// <summary>
        /// Test the property 'EmbeddedLink'
        /// </summary>
        [Fact]
        public void EmbeddedLinkTest()
        {
            instance.EmbeddedLink = false;
            Assert.Equal(false, instance.EmbeddedLink);       
            
        }
        /// <summary>
        /// Test the property 'EmbeddedPhone'
        /// </summary>
        [Fact]
        public void EmbeddedPhoneTest()
        {
            instance.EmbeddedPhone = false;
            Assert.Equal(false, instance.EmbeddedPhone);       
            
        }
        /// <summary>
        /// Test the property 'AffiliateMarketing'
        /// </summary>
        [Fact]
        public void AffiliateMarketingTest()
        {
            instance.AffiliateMarketing = false;
            Assert.Equal(false, instance.AffiliateMarketing);       
            
        }
        /// <summary>
        /// Test the property 'NumberPool'
        /// </summary>
        [Fact]
        public void NumberPoolTest()
        {
            instance.NumberPool = false;
            Assert.Equal(false, instance.NumberPool);       
            
        }
        /// <summary>
        /// Test the property 'AgeGated'
        /// </summary>
        [Fact]
        public void AgeGatedTest()
        {
            instance.AgeGated = false;
            Assert.Equal(false, instance.AgeGated);       
            
        }
        /// <summary>
        /// Test the property 'DirectLending'
        /// </summary>
        [Fact]
        public void DirectLendingTest()
        {
            instance.DirectLending = false;
            Assert.Equal(false, instance.DirectLending);       
            
        }
        /// <summary>
        /// Test the property 'SubscriberOptin'
        /// </summary>
        [Fact]
        public void SubscriberOptinTest()
        {
            instance.SubscriberOptin = false;
            Assert.Equal(false, instance.SubscriberOptin);       
            
        }
        /// <summary>
        /// Test the property 'SubscriberOptout'
        /// </summary>
        [Fact]
        public void SubscriberOptoutTest()
        {
            instance.SubscriberOptout = false;
            Assert.Equal(false, instance.SubscriberOptout);       
            
        }
        /// <summary>
        /// Test the property 'SubscriberHelp'
        /// </summary>
        [Fact]
        public void SubscriberHelpTest()
        {
            instance.SubscriberHelp = false;
            Assert.Equal(false, instance.SubscriberHelp);       
            
        }
        /// <summary>
        /// Test the property 'Sample1'
        /// </summary>
        [Fact]
        public void Sample1Test()
        {
            instance.Sample1 = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Sample1);
            
        }
        /// <summary>
        /// Test the property 'Sample2'
        /// </summary>
        [Fact]
        public void Sample2Test()
        {
            instance.Sample2 = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Sample2);
            
        }
        /// <summary>
        /// Test the property 'Sample3'
        /// </summary>
        [Fact]
        public void Sample3Test()
        {
            instance.Sample3 = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Sample3);
            
        }
        /// <summary>
        /// Test the property 'Sample4'
        /// </summary>
        [Fact]
        public void Sample4Test()
        {
            instance.Sample4 = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Sample4);
            
        }
        /// <summary>
        /// Test the property 'Sample5'
        /// </summary>
        [Fact]
        public void Sample5Test()
        {
            instance.Sample5 = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Sample5);
            
        }
        /// <summary>
        /// Test the property 'MessageFlow'
        /// </summary>
        [Fact]
        public void MessageFlowTest()
        {
            instance.MessageFlow = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.MessageFlow);
            
        }
        /// <summary>
        /// Test the property 'HelpMessage'
        /// </summary>
        [Fact]
        public void HelpMessageTest()
        {
            instance.HelpMessage = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.HelpMessage);
            
        }
        /// <summary>
        /// Test the property 'OptinKeywords'
        /// </summary>
        [Fact]
        public void OptinKeywordsTest()
        {
            instance.OptinKeywords = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.OptinKeywords);
            
        }
        /// <summary>
        /// Test the property 'OptoutKeywords'
        /// </summary>
        [Fact]
        public void OptoutKeywordsTest()
        {
            instance.OptoutKeywords = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.OptoutKeywords);
            
        }
        /// <summary>
        /// Test the property 'HelpKeywords'
        /// </summary>
        [Fact]
        public void HelpKeywordsTest()
        {
            instance.HelpKeywords = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.HelpKeywords);
            
        }
        /// <summary>
        /// Test the property 'OptinMessage'
        /// </summary>
        [Fact]
        public void OptinMessageTest()
        {
            instance.OptinMessage = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.OptinMessage);
            
        }
        /// <summary>
        /// Test the property 'OptoutMessage'
        /// </summary>
        [Fact]
        public void OptoutMessageTest()
        {
            instance.OptoutMessage = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.OptoutMessage);
            
        }
        /// <summary>
        /// Test the property 'Brand'
        /// </summary>
        [Fact]
        public void BrandTest()
        {
            SMSTenDLCPartnerCampaignBrand testObject = new SMSTenDLCPartnerCampaignBrand("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new Dictionary<string, object>(), 1);
            instance.Brand = testObject;
            Assert.Equal(testObject, instance.Brand);
            
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        SMSTenDLCPartnerCampaign test1 = new SMSTenDLCPartnerCampaign("TEST_STRING", "TEST_STRING", SMSTenDLCPartnerCampaign.StatusEnum.ACTIVE, DateTime.Parse("2022-07-05T15:17:05+00:00"), "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false, false, false, false, false, false, false, "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new SMSTenDLCPartnerCampaignBrand("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new Dictionary<string, object>(), 1));
         test1.AccountId = "TS";
         test1.CampaignId = "TS";
         test1.CreateDate = DateTime.Parse("2022-07-05T15:17:05+00:00");
         test1.BrandId = "TS";
         test1.Usecase = "TS";
         test1.Description = "TS";
         test1.EmbeddedLink = true;
         test1.EmbeddedPhone = true;
         test1.AffiliateMarketing = true;
         test1.NumberPool = true;
         test1.AgeGated = true;
         test1.DirectLending = true;
         test1.SubscriberOptin = true;
         test1.SubscriberOptout = true;
         test1.SubscriberHelp = true;
         test1.Sample1 = "TS";
         test1.Sample2 = "TS";
         test1.Sample3 = "TS";
         test1.Sample4 = "TS";
         test1.Sample5 = "TS";
         test1.MessageFlow = "TS";
         test1.HelpMessage = "TS";
         test1.OptinKeywords = "TS";
         test1.OptoutKeywords = "TS";
         test1.HelpKeywords = "TS";
         test1.OptinMessage = "TS";
         test1.OptoutMessage = "TS";
         SMSTenDLCPartnerCampaignBrand testObject = new SMSTenDLCPartnerCampaignBrand("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new Dictionary<string, object>(), 1);
         test1.Brand = testObject;
        SMSTenDLCPartnerCampaign test2 = new SMSTenDLCPartnerCampaign("TEST_STRING", "TEST_STRING", SMSTenDLCPartnerCampaign.StatusEnum.ACTIVE, DateTime.Parse("2022-07-05T15:17:05+00:00"), "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false, false, false, false, false, false, false, "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new SMSTenDLCPartnerCampaignBrand("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new Dictionary<string, object>(), 1));
         test2.AccountId = "TS";
         test2.CampaignId = "TS";
         test2.CreateDate = DateTime.Parse("2022-07-05T15:17:05+00:00");
         test2.BrandId = "TS";
         test2.Usecase = "TS";
         test2.Description = "TS";
         test2.EmbeddedLink = true;
         test2.EmbeddedPhone = true;
         test2.AffiliateMarketing = true;
         test2.NumberPool = true;
         test2.AgeGated = true;
         test2.DirectLending = true;
         test2.SubscriberOptin = true;
         test2.SubscriberOptout = true;
         test2.SubscriberHelp = true;
         test2.Sample1 = "TS";
         test2.Sample2 = "TS";
         test2.Sample3 = "TS";
         test2.Sample4 = "TS";
         test2.Sample5 = "TS";
         test2.MessageFlow = "TS";
         test2.HelpMessage = "TS";
         test2.OptinKeywords = "TS";
         test2.OptoutKeywords = "TS";
         test2.HelpKeywords = "TS";
         test2.OptinMessage = "TS";
         test2.OptoutMessage = "TS";
         SMSTenDLCPartnerCampaignBrand testObject2 = new SMSTenDLCPartnerCampaignBrand("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new Dictionary<string, object>(), 1);
         test2.Brand = testObject2;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        SMSTenDLCPartnerCampaign test1 = new SMSTenDLCPartnerCampaign("TEST_STRING", "TEST_STRING", SMSTenDLCPartnerCampaign.StatusEnum.ACTIVE, DateTime.Parse("2022-07-05T15:17:05+00:00"), "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false, false, false, false, false, false, false, "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new SMSTenDLCPartnerCampaignBrand("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new Dictionary<string, object>(), 1));
         test1.AccountId = "TS";
         test1.CampaignId = "TS";
         test1.CreateDate = DateTime.Parse("2022-07-05T15:17:05+00:00");
         test1.BrandId = "TS";
         test1.Usecase = "TS";
         test1.Description = "TS";
         test1.EmbeddedLink = true;
         test1.EmbeddedPhone = true;
         test1.AffiliateMarketing = true;
         test1.NumberPool = true;
         test1.AgeGated = true;
         test1.DirectLending = true;
         test1.SubscriberOptin = true;
         test1.SubscriberOptout = true;
         test1.SubscriberHelp = true;
         test1.Sample1 = "TS";
         test1.Sample2 = "TS";
         test1.Sample3 = "TS";
         test1.Sample4 = "TS";
         test1.Sample5 = "TS";
         test1.MessageFlow = "TS";
         test1.HelpMessage = "TS";
         test1.OptinKeywords = "TS";
         test1.OptoutKeywords = "TS";
         test1.HelpKeywords = "TS";
         test1.OptinMessage = "TS";
         test1.OptoutMessage = "TS";
         SMSTenDLCPartnerCampaignBrand testObject = new SMSTenDLCPartnerCampaignBrand("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new Dictionary<string, object>(), 1);
         test1.Brand = testObject;
        SMSTenDLCPartnerCampaign test2 = new SMSTenDLCPartnerCampaign("TEST_STRING", "TEST_STRING", SMSTenDLCPartnerCampaign.StatusEnum.ACTIVE, DateTime.Parse("2022-07-05T15:17:05+00:00"), "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false, false, false, false, false, false, false, "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new SMSTenDLCPartnerCampaignBrand("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new Dictionary<string, object>(), 1));
         test2.AccountId = "ts";
         test2.CampaignId = "ts";
         test2.CreateDate = DateTime.Parse("2022-07-05T15:17:05+00:00");
         test2.BrandId = "ts";
         test2.Usecase = "ts";
         test2.Description = "ts";
         test2.EmbeddedLink = false;
         test2.EmbeddedPhone = false;
         test2.AffiliateMarketing = false;
         test2.NumberPool = false;
         test2.AgeGated = false;
         test2.DirectLending = false;
         test2.SubscriberOptin = false;
         test2.SubscriberOptout = false;
         test2.SubscriberHelp = false;
         test2.Sample1 = "ts";
         test2.Sample2 = "ts";
         test2.Sample3 = "ts";
         test2.Sample4 = "ts";
         test2.Sample5 = "ts";
         test2.MessageFlow = "ts";
         test2.HelpMessage = "ts";
         test2.OptinKeywords = "ts";
         test2.OptoutKeywords = "ts";
         test2.HelpKeywords = "ts";
         test2.OptinMessage = "ts";
         test2.OptoutMessage = "ts";
         SMSTenDLCPartnerCampaignBrand testObject2 = new SMSTenDLCPartnerCampaignBrand("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new Dictionary<string, object>(), 1);
         test2.Brand = testObject2;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        SMSTenDLCPartnerCampaign test1 = new SMSTenDLCPartnerCampaign("TEST_STRING", "TEST_STRING", SMSTenDLCPartnerCampaign.StatusEnum.ACTIVE, DateTime.Parse("2022-07-05T15:17:05+00:00"), "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false, false, false, false, false, false, false, "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new SMSTenDLCPartnerCampaignBrand("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new Dictionary<string, object>(), 1));
         test1.AccountId = "TS";
         test1.CampaignId = "TS";
         test1.CreateDate = DateTime.Parse("2022-07-05T15:17:05+00:00");
         test1.BrandId = "TS";
         test1.Usecase = "TS";
         test1.Description = "TS";
         test1.EmbeddedLink = true;
         test1.EmbeddedPhone = true;
         test1.AffiliateMarketing = true;
         test1.NumberPool = true;
         test1.AgeGated = true;
         test1.DirectLending = true;
         test1.SubscriberOptin = true;
         test1.SubscriberOptout = true;
         test1.SubscriberHelp = true;
         test1.Sample1 = "TS";
         test1.Sample2 = "TS";
         test1.Sample3 = "TS";
         test1.Sample4 = "TS";
         test1.Sample5 = "TS";
         test1.MessageFlow = "TS";
         test1.HelpMessage = "TS";
         test1.OptinKeywords = "TS";
         test1.OptoutKeywords = "TS";
         test1.HelpKeywords = "TS";
         test1.OptinMessage = "TS";
         test1.OptoutMessage = "TS";
         SMSTenDLCPartnerCampaignBrand testObject = new SMSTenDLCPartnerCampaignBrand("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new Dictionary<string, object>(), 1);
         test1.Brand = testObject;

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        SMSTenDLCPartnerCampaign test1 = new SMSTenDLCPartnerCampaign("TEST_STRING", "TEST_STRING", SMSTenDLCPartnerCampaign.StatusEnum.ACTIVE, DateTime.Parse("2022-07-05T15:17:05+00:00"), "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false, false, false, false, false, false, false, "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new SMSTenDLCPartnerCampaignBrand("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new Dictionary<string, object>(), 1));
         test1.AccountId = "TS";
         test1.CampaignId = "TS";
         test1.CreateDate = DateTime.Parse("2022-07-05T15:17:05+00:00");
         test1.BrandId = "TS";
         test1.Usecase = "TS";
         test1.Description = "TS";
         test1.EmbeddedLink = true;
         test1.EmbeddedPhone = true;
         test1.AffiliateMarketing = true;
         test1.NumberPool = true;
         test1.AgeGated = true;
         test1.DirectLending = true;
         test1.SubscriberOptin = true;
         test1.SubscriberOptout = true;
         test1.SubscriberHelp = true;
         test1.Sample1 = "TS";
         test1.Sample2 = "TS";
         test1.Sample3 = "TS";
         test1.Sample4 = "TS";
         test1.Sample5 = "TS";
         test1.MessageFlow = "TS";
         test1.HelpMessage = "TS";
         test1.OptinKeywords = "TS";
         test1.OptoutKeywords = "TS";
         test1.HelpKeywords = "TS";
         test1.OptinMessage = "TS";
         test1.OptoutMessage = "TS";
         SMSTenDLCPartnerCampaignBrand testObject = new SMSTenDLCPartnerCampaignBrand("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new Dictionary<string, object>(), 1);
         test1.Brand = testObject;

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        SMSTenDLCPartnerCampaign test1 = new SMSTenDLCPartnerCampaign("TEST_STRING", "TEST_STRING", SMSTenDLCPartnerCampaign.StatusEnum.ACTIVE, DateTime.Parse("2022-07-05T15:17:05+00:00"), "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false, false, false, false, false, false, false, "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new SMSTenDLCPartnerCampaignBrand("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new Dictionary<string, object>(), 1));
         test1.AccountId = "TS";
         test1.CampaignId = "TS";
         test1.CreateDate = DateTime.Parse("2022-07-05T15:17:05+00:00");
         test1.BrandId = "TS";
         test1.Usecase = "TS";
         test1.Description = "TS";
         test1.EmbeddedLink = true;
         test1.EmbeddedPhone = true;
         test1.AffiliateMarketing = true;
         test1.NumberPool = true;
         test1.AgeGated = true;
         test1.DirectLending = true;
         test1.SubscriberOptin = true;
         test1.SubscriberOptout = true;
         test1.SubscriberHelp = true;
         test1.Sample1 = "TS";
         test1.Sample2 = "TS";
         test1.Sample3 = "TS";
         test1.Sample4 = "TS";
         test1.Sample5 = "TS";
         test1.MessageFlow = "TS";
         test1.HelpMessage = "TS";
         test1.OptinKeywords = "TS";
         test1.OptoutKeywords = "TS";
         test1.HelpKeywords = "TS";
         test1.OptinMessage = "TS";
         test1.OptoutMessage = "TS";
         SMSTenDLCPartnerCampaignBrand testObject = new SMSTenDLCPartnerCampaignBrand("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new Dictionary<string, object>(), 1);
         test1.Brand = testObject;

        SMSTenDLCPartnerCampaign test2 = new SMSTenDLCPartnerCampaign("TEST_STRING", "TEST_STRING", SMSTenDLCPartnerCampaign.StatusEnum.ACTIVE, DateTime.Parse("2022-07-05T15:17:05+00:00"), "TEST_STRING", "TEST_STRING", "TEST_STRING", false, false, false, false, false, false, false, false, false, "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new SMSTenDLCPartnerCampaignBrand("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new Dictionary<string, object>(), 1));
         test2.AccountId = "TS";
         test2.CampaignId = "TS";
         test2.CreateDate = DateTime.Parse("2022-07-05T15:17:05+00:00");
         test2.BrandId = "TS";
         test2.Usecase = "TS";
         test2.Description = "TS";
         test2.EmbeddedLink = true;
         test2.EmbeddedPhone = true;
         test2.AffiliateMarketing = true;
         test2.NumberPool = true;
         test2.AgeGated = true;
         test2.DirectLending = true;
         test2.SubscriberOptin = true;
         test2.SubscriberOptout = true;
         test2.SubscriberHelp = true;
         test2.Sample1 = "TS";
         test2.Sample2 = "TS";
         test2.Sample3 = "TS";
         test2.Sample4 = "TS";
         test2.Sample5 = "TS";
         test2.MessageFlow = "TS";
         test2.HelpMessage = "TS";
         test2.OptinKeywords = "TS";
         test2.OptoutKeywords = "TS";
         test2.HelpKeywords = "TS";
         test2.OptinMessage = "TS";
         test2.OptoutMessage = "TS";
         SMSTenDLCPartnerCampaignBrand testObject2 = new SMSTenDLCPartnerCampaignBrand("TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", "TEST_STRING", new Dictionary<string, object>(), 1);
         test2.Brand = testObject2;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }
    }
}
