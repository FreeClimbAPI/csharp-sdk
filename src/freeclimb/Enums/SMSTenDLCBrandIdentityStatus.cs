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
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using freeclimb.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = freeclimb.Client.OpenAPIDateConverter;

namespace freeclimb.Enums
{
    /// <summary>
    /// TCR assessment of the brand identification status.
    /// </summary>
    /// <value>TCR assessment of the brand identification status.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SMSTenDLCBrandIdentityStatus
    {
        /// <summary>
        /// Enum SELF_DECLARED for value: SELF_DECLARED
        /// </summary>
        [EnumMember(Value = "SELF_DECLARED")]
        SELF_DECLARED = 1,

        /// <summary>
        /// Enum UNVERIFIED for value: UNVERIFIED
        /// </summary>
        [EnumMember(Value = "UNVERIFIED")]
        UNVERIFIED = 2,

        /// <summary>
        /// Enum VERIFIED for value: VERIFIED
        /// </summary>
        [EnumMember(Value = "VERIFIED")]
        VERIFIED = 3,

        /// <summary>
        /// Enum VETTED_VERIFIED for value: VETTED_VERIFIED
        /// </summary>
        [EnumMember(Value = "VETTED_VERIFIED")]
        VETTED_VERIFIED = 4,
    }

    /// <summary>
    /// Converts <see cref="SMSTenDLCBrandIdentityStatus"/> to and from the JSON value
    /// </summary>
    public static class SMSTenDLCBrandIdentityStatusValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="SMSTenDLCBrandIdentityStatus"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static SMSTenDLCBrandIdentityStatus FromString(string value)
        {
            if (value.Equals("SELF_DECLARED"))
                return SMSTenDLCBrandIdentityStatus.SELF_DECLARED;

            if (value.Equals("UNVERIFIED"))
                return SMSTenDLCBrandIdentityStatus.UNVERIFIED;

            if (value.Equals("VERIFIED"))
                return SMSTenDLCBrandIdentityStatus.VERIFIED;

            if (value.Equals("VETTED_VERIFIED"))
                return SMSTenDLCBrandIdentityStatus.VETTED_VERIFIED;

            throw new NotImplementedException(
                $"Could not convert value to type SMSTenDLCBrandIdentityStatus: '{value}'"
            );
        }

        /// <summary>
        /// Parses a given value to <see cref="SMSTenDLCBrandIdentityStatus"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static SMSTenDLCBrandIdentityStatus? FromStringOrDefault(string value)
        {
            if (value.Equals("SELF_DECLARED"))
                return SMSTenDLCBrandIdentityStatus.SELF_DECLARED;

            if (value.Equals("UNVERIFIED"))
                return SMSTenDLCBrandIdentityStatus.UNVERIFIED;

            if (value.Equals("VERIFIED"))
                return SMSTenDLCBrandIdentityStatus.VERIFIED;

            if (value.Equals("VETTED_VERIFIED"))
                return SMSTenDLCBrandIdentityStatus.VETTED_VERIFIED;

            return null;
        }
    }
}