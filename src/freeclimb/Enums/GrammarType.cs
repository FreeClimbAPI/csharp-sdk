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
    /// The grammar file type to use for speech recognition. A value of &#39;URL&#39; indicates the grammarFile attribute specifies a URL that points to the grammar file. A value of &#x60;BUILTIN&#x60; indicates the grammarFile attribute specifies the name of one of the platform built-in grammar files.
    /// </summary>
    /// <value>The grammar file type to use for speech recognition. A value of &#39;URL&#39; indicates the grammarFile attribute specifies a URL that points to the grammar file. A value of &#x60;BUILTIN&#x60; indicates the grammarFile attribute specifies the name of one of the platform built-in grammar files.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GrammarType
    {
        /// <summary>
        /// Enum URL for value: URL
        /// </summary>
        [EnumMember(Value = "URL")]
        URL = 1,

        /// <summary>
        /// Enum BUILT_IN for value: BUILTIN
        /// </summary>
        [EnumMember(Value = "BUILTIN")]
        BUILT_IN = 2,
    }

    /// <summary>
    /// Converts <see cref="GrammarType"/> to and from the JSON value
    /// </summary>
    public static class GrammarTypeValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="GrammarType"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static GrammarType FromString(string value)
        {
            if (value.Equals("URL"))
                return GrammarType.URL;

            if (value.Equals("BUILTIN"))
                return GrammarType.BUILT_IN;

            throw new NotImplementedException(
                $"Could not convert value to type GrammarType: '{value}'"
            );
        }

        /// <summary>
        /// Parses a given value to <see cref="GrammarType"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static GrammarType? FromStringOrDefault(string value)
        {
            if (value.Equals("URL"))
                return GrammarType.URL;

            if (value.Equals("BUILTIN"))
                return GrammarType.BUILT_IN;

            return null;
        }
    }
}
