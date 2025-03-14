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
    /// TFNCampaign
    /// </summary>
    [DataContract(Name = "TFNCampaign")]
    public partial class TFNCampaign : IValidatableObject
    {
        /// <summary>
        /// Gets or Sets RegistrationStatus
        /// </summary>
        [DataMember(Name = "registrationStatus", IsRequired = true, EmitDefaultValue = true)]
        public SMSTollFreeCampaignRegistrationStatus RegistrationStatus { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TFNCampaign" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TFNCampaign() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="TFNCampaign" /> class.
        /// </summary>
        /// <param name="accountId">ID of the account that created this participant. (required).</param>
        /// <param name="campaignId">TFNCampaignId (required).</param>
        /// <param name="useCase">useCase (required).</param>
        /// <param name="registrationStatus">registrationStatus (required).</param>
        /// <param name="dateCreated">dateCreated (required).</param>
        /// <param name="dateUpdated">dateUpdated (required).</param>
        /// <param name="dateCreatedISO">dateCreatedISO (required).</param>
        /// <param name="dateUpdatedISO">dateUpdatedISO (required).</param>
        /// <param name="revision">revision (required).</param>
        public TFNCampaign(
            string accountId = default(string),
            string campaignId = default(string),
            string useCase = default(string),
            SMSTollFreeCampaignRegistrationStatus registrationStatus =
                default(SMSTollFreeCampaignRegistrationStatus),
            string dateCreated = default(string),
            string dateUpdated = default(string),
            string dateCreatedISO = default(string),
            string dateUpdatedISO = default(string),
            int revision = default(int)
        )
        {
            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new ArgumentNullException(
                    "accountId is a required property for TFNCampaign and cannot be null"
                );
            }
            this.AccountId = accountId;

            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new ArgumentNullException(
                    "campaignId is a required property for TFNCampaign and cannot be null"
                );
            }
            this.CampaignId = campaignId;

            // to ensure "useCase" is required (not null)
            if (useCase == null)
            {
                throw new ArgumentNullException(
                    "useCase is a required property for TFNCampaign and cannot be null"
                );
            }
            this.UseCase = useCase;

            this.RegistrationStatus = registrationStatus;

            // to ensure "dateCreated" is required (not null)
            if (dateCreated == null)
            {
                throw new ArgumentNullException(
                    "dateCreated is a required property for TFNCampaign and cannot be null"
                );
            }
            this.DateCreated = dateCreated;

            // to ensure "dateUpdated" is required (not null)
            if (dateUpdated == null)
            {
                throw new ArgumentNullException(
                    "dateUpdated is a required property for TFNCampaign and cannot be null"
                );
            }
            this.DateUpdated = dateUpdated;

            // to ensure "dateCreatedISO" is required (not null)
            if (dateCreatedISO == null)
            {
                throw new ArgumentNullException(
                    "dateCreatedISO is a required property for TFNCampaign and cannot be null"
                );
            }
            this.DateCreatedISO = dateCreatedISO;

            // to ensure "dateUpdatedISO" is required (not null)
            if (dateUpdatedISO == null)
            {
                throw new ArgumentNullException(
                    "dateUpdatedISO is a required property for TFNCampaign and cannot be null"
                );
            }
            this.DateUpdatedISO = dateUpdatedISO;

            this.Revision = revision;
        }

        /// <summary>
        /// ID of the account that created this participant.
        /// </summary>
        /// <value>ID of the account that created this participant.</value>
        [DataMember(Name = "accountId", IsRequired = true, EmitDefaultValue = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// TFNCampaignId
        /// </summary>
        /// <value>TFNCampaignId</value>
        /*
        <example>cmptfn_387ec3f6e03b340553f35f29c8f118cdf3eae08a</example>
        */
        [DataMember(Name = "campaignId", IsRequired = true, EmitDefaultValue = true)]
        public string CampaignId { get; set; }

        /// <summary>
        /// Gets or Sets UseCase
        /// </summary>
        [DataMember(Name = "useCase", IsRequired = true, EmitDefaultValue = true)]
        public string UseCase { get; set; }

        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name = "dateCreated", IsRequired = true, EmitDefaultValue = true)]
        public string DateCreated { get; set; }

        /// <summary>
        /// Gets or Sets DateUpdated
        /// </summary>
        [DataMember(Name = "dateUpdated", IsRequired = true, EmitDefaultValue = true)]
        public string DateUpdated { get; set; }

        /// <summary>
        /// Gets or Sets DateCreatedISO
        /// </summary>
        [DataMember(Name = "dateCreatedISO", IsRequired = true, EmitDefaultValue = true)]
        public string DateCreatedISO { get; set; }

        /// <summary>
        /// Gets or Sets DateUpdatedISO
        /// </summary>
        [DataMember(Name = "dateUpdatedISO", IsRequired = true, EmitDefaultValue = true)]
        public string DateUpdatedISO { get; set; }

        /// <summary>
        /// Gets or Sets Revision
        /// </summary>
        [DataMember(Name = "revision", IsRequired = true, EmitDefaultValue = true)]
        public int Revision { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TFNCampaign {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  UseCase: ").Append(UseCase).Append("\n");
            sb.Append("  RegistrationStatus: ").Append(RegistrationStatus).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateUpdated: ").Append(DateUpdated).Append("\n");
            sb.Append("  DateCreatedISO: ").Append(DateCreatedISO).Append("\n");
            sb.Append("  DateUpdatedISO: ").Append(DateUpdatedISO).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
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
        /// Retrieve the KVP Dictionary for the TFNCampaign instance.
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public virtual IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("accountId", AccountId);
            props.Add("campaignId", CampaignId);
            props.Add("useCase", UseCase);
            props.Add("registrationStatus", RegistrationStatus);
            props.Add("dateCreated", DateCreated);
            props.Add("dateUpdated", DateUpdated);
            props.Add("dateCreatedISO", DateCreatedISO);
            props.Add("dateUpdatedISO", DateUpdatedISO);
            props.Add("revision", Revision);
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
            if (this.CampaignId != null)
            {
                // CampaignId (string) pattern
                Regex regexCampaignId = new Regex(
                    @"cmptfn_[a-fA-F0-9]{40}",
                    RegexOptions.CultureInvariant
                );
                if (!regexCampaignId.Match(this.CampaignId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult(
                        "Invalid value for CampaignId, must match a pattern of " + regexCampaignId,
                        new[] { "CampaignId" }
                    );
                }
            }

            yield break;
        }
    }
}
