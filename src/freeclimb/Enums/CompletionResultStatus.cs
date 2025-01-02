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
    /// Completion result status. Possible values: success, no_context
    /// </summary>
    /// <value>Completion result status. Possible values: success, no_context</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CompletionResultStatus
    {
        /// <summary>
        /// Enum SUCCESS for value: success
        /// </summary>
        [EnumMember(Value = "success")]
        SUCCESS = 1,

        /// <summary>
        /// Enum NO_CONTEXT for value: no_context
        /// </summary>
        [EnumMember(Value = "no_context")]
        NO_CONTEXT = 2,
    }

    /// <summary>
    /// Converts <see cref="CompletionResultStatus"/> to and from the JSON value
    /// </summary>
    public static class CompletionResultStatusValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="CompletionResultStatus"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CompletionResultStatus FromString(string value)
        {
            if (value.Equals("success"))
                return CompletionResultStatus.SUCCESS;

            if (value.Equals("no_context"))
                return CompletionResultStatus.NO_CONTEXT;

            throw new NotImplementedException(
                $"Could not convert value to type CompletionResultStatus: '{value}'"
            );
        }

        /// <summary>
        /// Parses a given value to <see cref="CompletionResultStatus"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CompletionResultStatus? FromStringOrDefault(string value)
        {
            if (value.Equals("success"))
                return CompletionResultStatus.SUCCESS;

            if (value.Equals("no_context"))
                return CompletionResultStatus.NO_CONTEXT;

            return null;
        }
    }
}
