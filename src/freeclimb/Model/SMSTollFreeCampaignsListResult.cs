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
using freeclimb.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = freeclimb.Client.OpenAPIDateConverter;

namespace freeclimb.Model
{
    /// <summary>
    /// SMSTollFreeCampaignsListResult
    /// </summary>
    [DataContract(Name = "SMSTollFreeCampaignsListResult")]
    public partial class SMSTollFreeCampaignsListResult : IValidatableObject, IPagination
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SMSTollFreeCampaignsListResult" /> class.
        /// </summary>
        /// <param name="total">Total amount of requested resource..</param>
        /// <param name="start">Resource index at start of current page.</param>
        /// <param name="end">Resource index at end of current page.</param>
        /// <param name="page">Current page.</param>
        /// <param name="numPages">Total number of pages.</param>
        /// <param name="pageSize">Number of items per page.</param>
        /// <param name="nextPageUri">Uri to retrieve the next page of items.</param>
        /// <param name="brands">brands.</param>
        public SMSTollFreeCampaignsListResult(
            int? total = default(int?),
            int? start = default(int?),
            int? end = default(int?),
            int? page = default(int?),
            int? numPages = default(int?),
            int? pageSize = default(int?),
            string nextPageUri = default(string),
            List<SMSTollFreeCampaign> brands = default(List<SMSTollFreeCampaign>)
        )
        {
            this.Total = total;

            this.Start = start;

            this.End = end;

            this.Page = page;

            this.NumPages = numPages;

            this.PageSize = pageSize;

            this.NextPageUri = nextPageUri;

            this.Brands = brands;
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
        /// Gets or Sets Brands
        /// </summary>
        [DataMember(Name = "brands", EmitDefaultValue = true)]
        public List<SMSTollFreeCampaign> Brands { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SMSTollFreeCampaignsListResult {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  NumPages: ").Append(NumPages).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  NextPageUri: ").Append(NextPageUri).Append("\n");
            sb.Append("  Brands: ").Append(Brands).Append("\n");
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
        /// Retrieve the KVP Dictionary for the SMSTollFreeCampaignsListResult instance.
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
            foreach (var item in Brands)
            {
                nested.Add(item);
            }
            props.Add("brands", nested);
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
