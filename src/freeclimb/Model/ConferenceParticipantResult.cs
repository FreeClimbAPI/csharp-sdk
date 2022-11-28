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
    /// ConferenceParticipantResult
    /// </summary>
    [DataContract(Name = "ConferenceParticipantResult")]
    public partial class ConferenceParticipantResult : IEquatable<ConferenceParticipantResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConferenceParticipantResult" /> class.
        /// </summary>
        /// <param name="uri">The URI for this resource, relative to /apiserver..</param>
        /// <param name="dateCreated">The date that this resource was created (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT)..</param>
        /// <param name="dateUpdated">The date that this resource was last updated (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT)..</param>
        /// <param name="revision">Revision count for the resource. This count is set to 1 on creation and is incremented every time it is updated..</param>
        /// <param name="accountId">ID of the account that created this participant..</param>
        /// <param name="conferenceId">ID of the conference this participant is in..</param>
        /// <param name="callId">ID of the Call associated with this Participant..</param>
        /// <param name="talk">True if this Participant has talk privileges in the Conference. False otherwise..</param>
        /// <param name="listen">True if this Participant has listen privileges in the Conference. False otherwise..</param>
        /// <param name="startConfOnEnter">True if this Participant joining the Conference caused the Conference to start (status &#x3D; inProgress). False otherwise..</param>
        public ConferenceParticipantResult(string uri = default(string), string dateCreated = default(string), string dateUpdated = default(string), int revision = default(int), string accountId = default(string), string conferenceId = default(string), string callId = default(string), bool? talk = default(bool?), bool? listen = default(bool?), bool? startConfOnEnter = default(bool?))
        {
            this.Uri = uri;
            this.DateCreated = dateCreated;
            this.DateUpdated = dateUpdated;
            this.Revision = revision;
            this.AccountId = accountId;
            this.ConferenceId = conferenceId;
            this.CallId = callId;
            this.Talk = talk;
            this.Listen = listen;
            this.StartConfOnEnter = startConfOnEnter;
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
        /// ID of the account that created this participant.
        /// </summary>
        /// <value>ID of the account that created this participant.</value>
        [DataMember(Name = "accountId", EmitDefaultValue = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// ID of the conference this participant is in.
        /// </summary>
        /// <value>ID of the conference this participant is in.</value>
        [DataMember(Name = "conferenceId", EmitDefaultValue = true)]
        public string ConferenceId { get; set; }

        /// <summary>
        /// ID of the Call associated with this Participant.
        /// </summary>
        /// <value>ID of the Call associated with this Participant.</value>
        [DataMember(Name = "callId", EmitDefaultValue = true)]
        public string CallId { get; set; }

        /// <summary>
        /// True if this Participant has talk privileges in the Conference. False otherwise.
        /// </summary>
        /// <value>True if this Participant has talk privileges in the Conference. False otherwise.</value>
        [DataMember(Name = "talk", EmitDefaultValue = true)]
        public bool? Talk { get; set; }

        /// <summary>
        /// True if this Participant has listen privileges in the Conference. False otherwise.
        /// </summary>
        /// <value>True if this Participant has listen privileges in the Conference. False otherwise.</value>
        [DataMember(Name = "listen", EmitDefaultValue = true)]
        public bool? Listen { get; set; }

        /// <summary>
        /// True if this Participant joining the Conference caused the Conference to start (status &#x3D; inProgress). False otherwise.
        /// </summary>
        /// <value>True if this Participant joining the Conference caused the Conference to start (status &#x3D; inProgress). False otherwise.</value>
        [DataMember(Name = "startConfOnEnter", EmitDefaultValue = true)]
        public bool? StartConfOnEnter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConferenceParticipantResult {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateUpdated: ").Append(DateUpdated).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ConferenceId: ").Append(ConferenceId).Append("\n");
            sb.Append("  CallId: ").Append(CallId).Append("\n");
            sb.Append("  Talk: ").Append(Talk).Append("\n");
            sb.Append("  Listen: ").Append(Listen).Append("\n");
            sb.Append("  StartConfOnEnter: ").Append(StartConfOnEnter).Append("\n");
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
        /// Retrieve the KVP Dictionary for the ConferenceParticipantResult instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public virtual IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("uri", Uri);          
            props.Add("dateCreated", DateCreated);          
            props.Add("dateUpdated", DateUpdated);          
            props.Add("revision", Revision);          
            props.Add("accountId", AccountId);          
            props.Add("conferenceId", ConferenceId);          
            props.Add("callId", CallId);          
            props.Add("talk", Talk);          
            props.Add("listen", Listen);          
            props.Add("startConfOnEnter", StartConfOnEnter);          
            return props;
        }
        
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConferenceParticipantResult);
        }

        /// <summary>
        /// Returns true if ConferenceParticipantResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ConferenceParticipantResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConferenceParticipantResult input)
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
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.ConferenceId == input.ConferenceId ||
                    (this.ConferenceId != null &&
                    this.ConferenceId.Equals(input.ConferenceId))
                ) && 
                (
                    this.CallId == input.CallId ||
                    (this.CallId != null &&
                    this.CallId.Equals(input.CallId))
                ) && 
                (
                    this.Talk == input.Talk ||
                    (this.Talk != null &&
                    this.Talk.Equals(input.Talk))
                ) && 
                (
                    this.Listen == input.Listen ||
                    (this.Listen != null &&
                    this.Listen.Equals(input.Listen))
                ) && 
                (
                    this.StartConfOnEnter == input.StartConfOnEnter ||
                    (this.StartConfOnEnter != null &&
                    this.StartConfOnEnter.Equals(input.StartConfOnEnter))
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.ConferenceId != null)
                {
                    hashCode = (hashCode * 59) + this.ConferenceId.GetHashCode();
                }
                if (this.CallId != null)
                {
                    hashCode = (hashCode * 59) + this.CallId.GetHashCode();
                }
                if (this.Talk != null)
                {
                    hashCode = (hashCode * 59) + this.Talk.GetHashCode();
                }
                if (this.Listen != null)
                {
                    hashCode = (hashCode * 59) + this.Listen.GetHashCode();
                }
                if (this.StartConfOnEnter != null)
                {
                    hashCode = (hashCode * 59) + this.StartConfOnEnter.GetHashCode();
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
