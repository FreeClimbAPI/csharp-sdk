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
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = freeclimb.Client.OpenAPIDateConverter;
using freeclimb.Enums;
using freeclimb.Utils;

namespace freeclimb.Model
{
    /// <summary>
    /// IncomingNumberList
    /// </summary>
    [DataContract(Name = "IncomingNumberList")]
    public partial class IncomingNumberList : IPagination, IEquatable<IncomingNumberList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IncomingNumberList" /> class.
        /// </summary>
        /// <param name="total">Total amount of requested resource..</param>
        /// <param name="start">Resource index at start of current page.</param>
        /// <param name="end">Resource index at end of current page.</param>
        /// <param name="page">Current page.</param>
        /// <param name="numPages">Total number of pages.</param>
        /// <param name="pageSize">Number of items per page.</param>
        /// <param name="nextPageUri">Uri to retrieve the next page of items.</param>
        /// <param name="incomingPhoneNumbers">incomingPhoneNumbers.</param>
        public IncomingNumberList(int? total = default(int?), int? start = default(int?), int? end = default(int?), int? page = default(int?), int? numPages = default(int?), int? pageSize = default(int?), string nextPageUri = default(string), List<IncomingNumberResult> incomingPhoneNumbers = default(List<IncomingNumberResult>))
        {
            this.Total = total;
            this.Start = start;
            this.End = end;
            this.Page = page;
            this.NumPages = numPages;
            this.PageSize = pageSize;
            this.NextPageUri = nextPageUri;
            this.IncomingPhoneNumbers = incomingPhoneNumbers;
        }

        /// <summary>
        /// Total amount of requested resource.
        /// </summary>
        /// <value>Total amount of requested resource.</value>
        [DataMember(Name = "total", EmitDefaultValue = true)]
        public int? Total { get; set; }

        /// <summary>
        /// Resource index at start of current page
        /// </summary>
        /// <value>Resource index at start of current page</value>
        [DataMember(Name = "start", EmitDefaultValue = true)]
        public int? Start { get; set; }

        /// <summary>
        /// Resource index at end of current page
        /// </summary>
        /// <value>Resource index at end of current page</value>
        [DataMember(Name = "end", EmitDefaultValue = true)]
        public int? End { get; set; }

        /// <summary>
        /// Current page
        /// </summary>
        /// <value>Current page</value>
        [DataMember(Name = "page", EmitDefaultValue = true)]
        public int? Page { get; set; }

        /// <summary>
        /// Total number of pages
        /// </summary>
        /// <value>Total number of pages</value>
        [DataMember(Name = "numPages", EmitDefaultValue = true)]
        public int? NumPages { get; set; }

        /// <summary>
        /// Number of items per page
        /// </summary>
        /// <value>Number of items per page</value>
        [DataMember(Name = "pageSize", EmitDefaultValue = true)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Uri to retrieve the next page of items
        /// </summary>
        /// <value>Uri to retrieve the next page of items</value>
        [DataMember(Name = "nextPageUri", EmitDefaultValue = true)]
        public string NextPageUri { get; set; }

        /// <summary>
        /// Gets or Sets IncomingPhoneNumbers
        /// </summary>
        [DataMember(Name = "incomingPhoneNumbers", EmitDefaultValue = true)]
        public List<IncomingNumberResult> IncomingPhoneNumbers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IncomingNumberList {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  NumPages: ").Append(NumPages).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  NextPageUri: ").Append(NextPageUri).Append("\n");
            sb.Append("  IncomingPhoneNumbers: ").Append(IncomingPhoneNumbers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Retrieve the KVP Dictionary for the IncomingNumberList instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public virtual IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("total", Total);          
            props.Add("start", Start);          
            props.Add("end", End);          
            props.Add("page", Page);          
            props.Add("numPages", NumPages);          
            props.Add("pageSize", PageSize);          
            props.Add("nextPageUri", NextPageUri);          
            List<object> nested = new List<object>();
            foreach (var item in IncomingPhoneNumbers)
            {
                nested.Add(item);
            }
            props.Add("incomingPhoneNumbers", nested); 
            return props;
        }
        
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as IncomingNumberList);
        }

        /// <summary>
        /// Returns true if IncomingNumberList instances are equal
        /// </summary>
        /// <param name="input">Instance of IncomingNumberList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IncomingNumberList input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.End == input.End ||
                    (this.End != null &&
                    this.End.Equals(input.End))
                ) && 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.NumPages == input.NumPages ||
                    (this.NumPages != null &&
                    this.NumPages.Equals(input.NumPages))
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
                ) && 
                (
                    this.NextPageUri == input.NextPageUri ||
                    (this.NextPageUri != null &&
                    this.NextPageUri.Equals(input.NextPageUri))
                ) && 
                (
                    this.IncomingPhoneNumbers == input.IncomingPhoneNumbers ||
                    this.IncomingPhoneNumbers != null &&
                    input.IncomingPhoneNumbers != null &&
                    this.IncomingPhoneNumbers.SequenceEqual(input.IncomingPhoneNumbers)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Total != null)
                {
                    hashCode = (hashCode * 59) + this.Total.GetHashCode();
                }
                if (this.Start != null)
                {
                    hashCode = (hashCode * 59) + this.Start.GetHashCode();
                }
                if (this.End != null)
                {
                    hashCode = (hashCode * 59) + this.End.GetHashCode();
                }
                if (this.Page != null)
                {
                    hashCode = (hashCode * 59) + this.Page.GetHashCode();
                }
                if (this.NumPages != null)
                {
                    hashCode = (hashCode * 59) + this.NumPages.GetHashCode();
                }
                if (this.PageSize != null)
                {
                    hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                }
                if (this.NextPageUri != null)
                {
                    hashCode = (hashCode * 59) + this.NextPageUri.GetHashCode();
                }
                if (this.IncomingPhoneNumbers != null)
                {
                    hashCode = (hashCode * 59) + this.IncomingPhoneNumbers.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
