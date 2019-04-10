using com.persephony.api;
using com.persephony.webhooks;
using Newtonsoft.Json;
using System;

namespace com.persephony.webhooks.application
{
    /// <summary>
    /// A MessageDelivery represents the JSON object that is sent to the webhooks
    /// for incoming messages. URL specified in smsUrl, smsFallbackUrl of Application
    /// </summary>
    [JsonObject]
    public class MessageDelivery : PersyRequest
    {
#pragma warning disable 0649 // default value compiler warning

        [JsonProperty(PropertyName = "status")]
        private readonly EMessageStatus status;

        [JsonProperty(PropertyName = "messageId")]
        private readonly string messageId;

        [JsonProperty(PropertyName = "direction")]
        private readonly EMessageDirection direction;

        [JsonProperty(PropertyName = "text")]
        private readonly string text;

        [JsonProperty(PropertyName = "applicationId")]
        private readonly string applicationId;

        [JsonProperty(PropertyName = "phoneNumberId")]
        private readonly string phoneNumberId;

#pragma warning restore 0649

        /// <summary>
        /// Helper method to build a MessageDelivery object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a MessageDelivery instance.</param>
        /// <returns>A MessageDelivery object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public new static MessageDelivery fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<MessageDelivery>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve status value from the object.
        /// </summary>
        /// <returns>The status value.</returns>
        ///<see cref="EMessageStatus">MessageStatus enumeration.</see>
        public EMessageStatus getStatus { get { return this.status; } }

        /// <summary>
        /// Retrieve messageId value from the object.
        /// </summary>
        /// <returns>The messageId value.</returns>
        public string getMessageId { get { return this.messageId; } }

        /// <summary>
        /// Retrieve direction value from the object.
        /// </summary>
        /// <returns>The direction value.</returns>
        ///<see cref="EMessageDirection">Direction enumeration.</see>
        public EMessageDirection getDirection { get { return this.direction; } }

        /// <summary>
        /// Retrieve text value from the object.
        /// </summary>
        /// <returns>The text value.</returns>
        public string getText { get { return this.text; } }

        /// <summary>
        /// Retrieve applicationId value from the object.
        /// </summary>
        /// <returns>The applicationId value.</returns>
        public string getApplicationId { get { return this.applicationId; } }

        /// <summary>
        /// Retrieve phoneNumberId value from the object.
        /// </summary>
        /// <returns>The phoneNumberId value.</returns>
        public string getPhoneNumberId { get { return this.phoneNumberId; } }

    }
}
