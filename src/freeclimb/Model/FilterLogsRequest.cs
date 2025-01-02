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

namespace freeclimb.Model
{
    /// <summary>
    /// FilterLogsRequest
    /// </summary>
    [DataContract(Name = "FilterLogsRequest")]
    public partial class FilterLogsRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterLogsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FilterLogsRequest() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterLogsRequest" /> class.
        /// </summary>
        /// <param name="pql">The filter query for retrieving logs. See **Performance Query Language** below. (required).</param>
        public FilterLogsRequest(string pql = default(string))
        {
            // to ensure "pql" is required (not null)
            if (pql == null)
            {
                throw new ArgumentNullException(
                    "pql is a required property for FilterLogsRequest and cannot be null"
                );
            }
            this.Pql = pql;
        }

        /// <summary>
        /// The filter query for retrieving logs. See **Performance Query Language** below.
        /// </summary>
        /// <value>The filter query for retrieving logs. See **Performance Query Language** below.</value>
        [DataMember(Name = "pql", IsRequired = true, EmitDefaultValue = true)]
        public string Pql { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FilterLogsRequest {\n");
            sb.Append("  Pql: ").Append(Pql).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                Newtonsoft.Json.Formatting.Indented
            );
        }

        /// <summary>
        /// Retrieve the KVP Dictionary for the FilterLogsRequest instance.
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public virtual IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("pql", Pql);
            return props;
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext
        )
        {
            yield break;
        }
    }
}
