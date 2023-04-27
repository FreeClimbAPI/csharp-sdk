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

namespace freeclimb.Model
{
    /// <summary>
    /// ConferenceResult
    /// </summary>
    [DataContract(Name = "ConferenceResult")]
    public partial class ConferenceResult : IEquatable<ConferenceResult>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets PlayBeep
        /// </summary>
        [DataMember(Name = "playBeep", EmitDefaultValue = true)]
        public PlayBeep? PlayBeep { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public ConferenceStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConferenceResult" /> class.
        /// </summary>
        /// <param name="uri">The URI for this resource, relative to /apiserver..</param>
        /// <param name="dateCreated">The date that this resource was created (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT)..</param>
        /// <param name="dateUpdated">The date that this resource was last updated (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT)..</param>
        /// <param name="revision">Revision count for the resource. This count is set to 1 on creation and is incremented every time it is updated..</param>
        /// <param name="conferenceId">A string that uniquely identifies this Conference resource..</param>
        /// <param name="accountId">ID of the account that created this Conference..</param>
        /// <param name="alias">A description for this Conference..</param>
        /// <param name="playBeep">playBeep.</param>
        /// <param name="record">Flag indicating whether recording is enabled for this Conference..</param>
        /// <param name="status">status.</param>
        /// <param name="waitUrl">URL referencing the audio file to be used as default wait music for the Conference when it is in the populated state..</param>
        /// <param name="actionUrl">URL invoked once the Conference is successfully created..</param>
        /// <param name="statusCallbackUrl">URL to inform that the Conference status has changed..</param>
        /// <param name="subresourceUris">The list of subresources for this Conference. This includes participants and/or recordings..</param>
        public ConferenceResult(string uri = default(string), string dateCreated = default(string), string dateUpdated = default(string), int revision = default(int), string conferenceId = default(string), string accountId = default(string), string alias = default(string), PlayBeep? playBeep = default(PlayBeep?), bool? record = default(bool?), ConferenceStatus? status = default(ConferenceStatus?), string waitUrl = default(string), string actionUrl = default(string), string statusCallbackUrl = default(string), Object subresourceUris = default(Object))
        {
            this.Uri = uri;
            this.DateCreated = dateCreated;
            this.DateUpdated = dateUpdated;
            this.Revision = revision;
            this.ConferenceId = conferenceId;
            this.AccountId = accountId;
            this.Alias = alias;
            this.PlayBeep = playBeep;
            this.Record = record;
            this.Status = status;
            this.WaitUrl = waitUrl;
            this.ActionUrl = actionUrl;
            this.StatusCallbackUrl = statusCallbackUrl;
            this.SubresourceUris = subresourceUris;
        }

        /// <summary>
        /// The URI for this resource, relative to /apiserver.
        /// </summary>
        /// <value>The URI for this resource, relative to /apiserver.</value>
        [DataMember(Name = "uri", EmitDefaultValue = false)]
        public string Uri { get; set; }

        /// <summary>
        /// The date that this resource was created (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT).
        /// </summary>
        /// <value>The date that this resource was created (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT).</value>
        [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
        public string DateCreated { get; set; }

        /// <summary>
        /// The date that this resource was last updated (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT).
        /// </summary>
        /// <value>The date that this resource was last updated (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT).</value>
        [DataMember(Name = "dateUpdated", EmitDefaultValue = false)]
        public string DateUpdated { get; set; }

        /// <summary>
        /// Revision count for the resource. This count is set to 1 on creation and is incremented every time it is updated.
        /// </summary>
        /// <value>Revision count for the resource. This count is set to 1 on creation and is incremented every time it is updated.</value>
        [DataMember(Name = "revision", EmitDefaultValue = false)]
        public int Revision { get; set; }

        /// <summary>
        /// A string that uniquely identifies this Conference resource.
        /// </summary>
        /// <value>A string that uniquely identifies this Conference resource.</value>
        [DataMember(Name = "conferenceId", EmitDefaultValue = true)]
        public string ConferenceId { get; set; }

        /// <summary>
        /// ID of the account that created this Conference.
        /// </summary>
        /// <value>ID of the account that created this Conference.</value>
        [DataMember(Name = "accountId", EmitDefaultValue = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// A description for this Conference.
        /// </summary>
        /// <value>A description for this Conference.</value>
        [DataMember(Name = "alias", EmitDefaultValue = true)]
        public string Alias { get; set; }

        /// <summary>
        /// Flag indicating whether recording is enabled for this Conference.
        /// </summary>
        /// <value>Flag indicating whether recording is enabled for this Conference.</value>
        [DataMember(Name = "record", EmitDefaultValue = true)]
        public bool? Record { get; set; }

        /// <summary>
        /// URL referencing the audio file to be used as default wait music for the Conference when it is in the populated state.
        /// </summary>
        /// <value>URL referencing the audio file to be used as default wait music for the Conference when it is in the populated state.</value>
        [DataMember(Name = "waitUrl", EmitDefaultValue = true)]
        public string WaitUrl { get; set; }

        /// <summary>
        /// URL invoked once the Conference is successfully created.
        /// </summary>
        /// <value>URL invoked once the Conference is successfully created.</value>
        [DataMember(Name = "actionUrl", EmitDefaultValue = true)]
        public string ActionUrl { get; set; }

        /// <summary>
        /// URL to inform that the Conference status has changed.
        /// </summary>
        /// <value>URL to inform that the Conference status has changed.</value>
        [DataMember(Name = "statusCallbackUrl", EmitDefaultValue = true)]
        public string StatusCallbackUrl { get; set; }

        /// <summary>
        /// The list of subresources for this Conference. This includes participants and/or recordings.
        /// </summary>
        /// <value>The list of subresources for this Conference. This includes participants and/or recordings.</value>
        [DataMember(Name = "subresourceUris", EmitDefaultValue = true)]
        public Object SubresourceUris { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConferenceResult {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateUpdated: ").Append(DateUpdated).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  ConferenceId: ").Append(ConferenceId).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  PlayBeep: ").Append(PlayBeep).Append("\n");
            sb.Append("  Record: ").Append(Record).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  WaitUrl: ").Append(WaitUrl).Append("\n");
            sb.Append("  ActionUrl: ").Append(ActionUrl).Append("\n");
            sb.Append("  StatusCallbackUrl: ").Append(StatusCallbackUrl).Append("\n");
            sb.Append("  SubresourceUris: ").Append(SubresourceUris).Append("\n");
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
        /// Retrieve the KVP Dictionary for the ConferenceResult instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public virtual IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("uri", Uri);          
            props.Add("dateCreated", DateCreated);          
            props.Add("dateUpdated", DateUpdated);          
            props.Add("revision", Revision);          
            props.Add("conferenceId", ConferenceId);          
            props.Add("accountId", AccountId);          
            props.Add("alias", Alias);          
            props.Add("playBeep", PlayBeep);          
            props.Add("record", Record);          
            props.Add("status", Status);          
            props.Add("waitUrl", WaitUrl);          
            props.Add("actionUrl", ActionUrl);          
            props.Add("statusCallbackUrl", StatusCallbackUrl);          
            props.Add("subresourceUris", SubresourceUris);          
            return props;
        }
        
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConferenceResult);
        }

        /// <summary>
        /// Returns true if ConferenceResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ConferenceResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConferenceResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.DateCreated == input.DateCreated ||
                    (this.DateCreated != null &&
                    this.DateCreated.Equals(input.DateCreated))
                ) && 
                (
                    this.DateUpdated == input.DateUpdated ||
                    (this.DateUpdated != null &&
                    this.DateUpdated.Equals(input.DateUpdated))
                ) && 
                (
                    this.Revision == input.Revision ||
                    this.Revision.Equals(input.Revision)
                ) && 
                (
                    this.ConferenceId == input.ConferenceId ||
                    (this.ConferenceId != null &&
                    this.ConferenceId.Equals(input.ConferenceId))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.PlayBeep == input.PlayBeep ||
                    this.PlayBeep.Equals(input.PlayBeep)
                ) && 
                (
                    this.Record == input.Record ||
                    (this.Record != null &&
                    this.Record.Equals(input.Record))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.WaitUrl == input.WaitUrl ||
                    (this.WaitUrl != null &&
                    this.WaitUrl.Equals(input.WaitUrl))
                ) && 
                (
                    this.ActionUrl == input.ActionUrl ||
                    (this.ActionUrl != null &&
                    this.ActionUrl.Equals(input.ActionUrl))
                ) && 
                (
                    this.StatusCallbackUrl == input.StatusCallbackUrl ||
                    (this.StatusCallbackUrl != null &&
                    this.StatusCallbackUrl.Equals(input.StatusCallbackUrl))
                ) && 
                (
                    this.SubresourceUris == input.SubresourceUris ||
                    (this.SubresourceUris != null &&
                    this.SubresourceUris.Equals(input.SubresourceUris))
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
                if (this.Uri != null)
                {
                    hashCode = (hashCode * 59) + this.Uri.GetHashCode();
                }
                if (this.DateCreated != null)
                {
                    hashCode = (hashCode * 59) + this.DateCreated.GetHashCode();
                }
                if (this.DateUpdated != null)
                {
                    hashCode = (hashCode * 59) + this.DateUpdated.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Revision.GetHashCode();
                if (this.ConferenceId != null)
                {
                    hashCode = (hashCode * 59) + this.ConferenceId.GetHashCode();
                }
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.Alias != null)
                {
                    hashCode = (hashCode * 59) + this.Alias.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PlayBeep.GetHashCode();
                if (this.Record != null)
                {
                    hashCode = (hashCode * 59) + this.Record.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.WaitUrl != null)
                {
                    hashCode = (hashCode * 59) + this.WaitUrl.GetHashCode();
                }
                if (this.ActionUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ActionUrl.GetHashCode();
                }
                if (this.StatusCallbackUrl != null)
                {
                    hashCode = (hashCode * 59) + this.StatusCallbackUrl.GetHashCode();
                }
                if (this.SubresourceUris != null)
                {
                    hashCode = (hashCode * 59) + this.SubresourceUris.GetHashCode();
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
