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
    /// Defines TranscribeReason
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TranscribeReason
    {
        /// <summary>
        /// Enum INTERNAL_ERROR for value: internalError
        /// </summary>
        [EnumMember(Value = "internalError")]
        INTERNAL_ERROR = 1,

        /// <summary>
        /// Enum HANGUP for value: hangup
        /// </summary>
        [EnumMember(Value = "hangup")]
        HANGUP = 2,

        /// <summary>
        /// Enum MAX_LENGTH for value: maxLength
        /// </summary>
        [EnumMember(Value = "maxLength")]
        MAX_LENGTH = 3,

        /// <summary>
        /// Enum DIGIT for value: digit
        /// </summary>
        [EnumMember(Value = "digit")]
        DIGIT = 4,

        /// <summary>
        /// Enum NO_INPUT for value: noInput
        /// </summary>
        [EnumMember(Value = "noInput")]
        NO_INPUT = 5,
    }

    /// <summary>
    /// Converts <see cref="TranscribeReason"/> to and from the JSON value
    /// </summary>
    public static class TranscribeReasonValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="TranscribeReason"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TranscribeReason FromString(string value)
        {
            if (value.Equals("internalError"))
                return TranscribeReason.INTERNAL_ERROR;

            if (value.Equals("hangup"))
                return TranscribeReason.HANGUP;

            if (value.Equals("maxLength"))
                return TranscribeReason.MAX_LENGTH;

            if (value.Equals("digit"))
                return TranscribeReason.DIGIT;

            if (value.Equals("noInput"))
                return TranscribeReason.NO_INPUT;

            throw new NotImplementedException(
                $"Could not convert value to type TranscribeReason: '{value}'"
            );
        }

        /// <summary>
        /// Parses a given value to <see cref="TranscribeReason"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TranscribeReason? FromStringOrDefault(string value)
        {
            if (value.Equals("internalError"))
                return TranscribeReason.INTERNAL_ERROR;

            if (value.Equals("hangup"))
                return TranscribeReason.HANGUP;

            if (value.Equals("maxLength"))
                return TranscribeReason.MAX_LENGTH;

            if (value.Equals("digit"))
                return TranscribeReason.DIGIT;

            if (value.Equals("noInput"))
                return TranscribeReason.NO_INPUT;

            return null;
        }
    }
}