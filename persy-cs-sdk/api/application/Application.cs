using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace com.persephony.api.application
{
    /// <summary>
    /// This class represents a Persephony Application instance. Application objects 
    /// can be created by the ApplicationRequester inside a PersyClient instance, or using the portal.
    /// </summary>
    /// <remarks>
    /// Applications are immutable and intended only to be used to read information
    /// returned from the API in a language accessible way.
    /// </remarks>
    public class Application: PersyCommon, IEquatable<Application>
    {

#pragma warning disable 0649 // default value compiler warning
        /// <summary>
        /// Alias of app
        /// </summary>
        [JsonProperty(PropertyName = "alias")]
        private readonly string alias;
        /// <summary>
        /// A string that uniquely identifies this resource.
        /// </summary>
        [JsonProperty(PropertyName = "applicationId")]
        private readonly string applicationId;
        /// <summary>
        /// the account ID the application belongs to
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        private readonly string accountId;
        /// <summary>
        /// The URL Persephony will request when a phone number assigned to this application receives a call.
        /// </summary>
        [JsonProperty(PropertyName = "voiceUrl")]
        private readonly string voiceUrl;
        /// <summary>
        /// The URL that Persephony will request if an error occurs retrieving or executing the VCL requested by voiceUrl.
        /// </summary>
        [JsonProperty(PropertyName = "voiceFallbackUrl")]
        private readonly string voiceFallbackUrl;
        /// <summary>
        /// The URL Persephony will request when a phone number assigned to this application receives an SMS message.
        /// </summary>
        [JsonProperty(PropertyName = "smsUrl")]
        private readonly string smsUrl;
        /// <summary>
        /// The URL that Persephony will request if an error occurs retrieving or executing the VCL requested by smsUrl.
        /// </summary>
        [JsonProperty(PropertyName = "smsFallbackUrl")]
        private readonly string smsFallbackUrl;
        /// <summary>
        /// The URL that Persephony will POST  request informing the result of the outbound request.
        /// </summary>
        [JsonProperty(PropertyName = "callConnectUrl")]
        private readonly string callConnectUrl;
        /// <summary>
        /// The URL that Persephony will request to pass status parameters (such as call ended) to our application.
        /// </summary>
        [JsonProperty(PropertyName = "statusCallbackUrl")]
        private readonly string statusCallbackUrl;

#pragma warning restore 0649

        /// <summary>
	    /// Helper method to build an Application object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing an application instance.</param>
        /// <returns>An Application object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static Application fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<Application>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve  the alias for this application from the object.
        /// </summary>
        /// <returns>The alias for this application.</returns>
        public string getAlias { get { return this.alias; } }
        /// <summary>
        /// Retrieve  the applicationId for this application from the object.
        /// </summary>
        /// <returns>The applicationId for this application.</returns>
        public string getApplicationId { get { return this.applicationId; } }
        /// <summary>
        /// Retrieve  the accountId for this application from the object.
        /// </summary>
        /// <returns>The accountId for this application.</returns>
        public string getAccountId { get { return this.accountId; } }
        /// <summary>
        /// Retrieve  the voiceUrl for this application from the object.
        /// </summary>
        /// <returns>The voiceUrl for this application.</returns>
        public string getVoiceUrl { get { return this.voiceUrl; } }
        /// <summary>
        /// Retrieve  the voiceFallbackUrl for this application from the object.
        /// </summary>
        /// <returns>The voiceFallbackUrl for this application.</returns>
        public string getVoiceFallbackUrl { get { return this.voiceFallbackUrl; } }
        /// <summary>
        /// Retrieve  the smsUrl for this application from the object.
        /// </summary>
        /// <returns>The smsUrl for this application.</returns>
        public string getSmsUrl { get { return this.smsUrl; } }
        /// <summary>
        /// Retrieve  the smsFallbackUrl for this application from the object.
        /// </summary>
        /// <returns>The smsFallbackUrl for this application.</returns>
        public string getSmsFallbackUrl { get { return this.smsFallbackUrl; } }
        /// <summary>
        /// Retrieve  the callConnectUrl for this application from the object.
        /// </summary>
        /// <returns>The callConnectUrl for this application.</returns>
        public string getCallConnectUrl { get { return this.callConnectUrl; } }
        /// <summary>
        /// Retrieve  the statusCallbackUrl for this application from the object.
        /// </summary>
        /// <returns>The statusCallbackUrl for this application.</returns>
        public string getStatusCallbackUrl { get { return this.statusCallbackUrl; } }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        /// <see>System.IEquatable interface.</see>
        public override int GetHashCode()
        {
            int hash = 0;
            hash ^= this.getAlias.GetHashCode();
            hash ^= this.getApplicationId.GetHashCode();
            hash ^= this.getAccountId.GetHashCode();
            hash ^= this.getVoiceUrl.GetHashCode();
            hash ^= this.getVoiceFallbackUrl.GetHashCode();
            hash ^= this.getSmsUrl.GetHashCode();
            hash ^= this.getSmsFallbackUrl.GetHashCode();
            hash ^= this.callConnectUrl.GetHashCode();
            hash ^= this.statusCallbackUrl.GetHashCode();

            hash ^= base.GetHashCode();

            return hash;
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="obj">Object of type Application.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        /// <see>System.IEquatable interface.</see>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Application b = obj as Application;
            if ((object)b == null)
            {
                return false;
            }

            return Equal(this, b);
        }

        /// <summary>
        /// Application equality operator.
        /// </summary>
        /// <param name="a">Application object.</param>
        /// <param name="b">Application object.</param>
        /// <returns>true if equal otherwise false.</returns>
        public static bool operator ==(Application a, Application b)
        {
            return Equal(a, b);
        }

        /// <summary>
        /// Application inequality operator.
        /// </summary>
        /// <param name="a">Application object.</param>
        /// <param name="b">Application object.</param>
        /// <returns>true if not equal otherwise false.</returns>
        public static bool operator !=(Application a, Application b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Helper method to deep compare two Application instances.
        /// </summary>
        /// <param name="a">Application instance one.</param>
        /// <param name="b">Application instance two.</param>
        /// <returns>True is a == b, otherwise false.</returns>
        public static bool Equal(Application a, Application b)
        {
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            // Return true if the fields match:
            return String.Equals(a.getAlias, b.getAlias, StringComparison.Ordinal) &&
                   String.Equals(a.getApplicationId, b.getApplicationId, StringComparison.Ordinal) &&
                   String.Equals(a.getAccountId, b.getAccountId, StringComparison.Ordinal) &&
                   String.Equals(a.getVoiceUrl, b.getVoiceUrl, StringComparison.Ordinal) &&
                   String.Equals(a.getVoiceFallbackUrl, b.getVoiceFallbackUrl, StringComparison.Ordinal) &&
                   String.Equals(a.getSmsUrl, b.getSmsUrl, StringComparison.Ordinal) &&
                   String.Equals(a.getSmsFallbackUrl, b.getSmsFallbackUrl, StringComparison.Ordinal) &&
                   String.Equals(a.getCallConnectUrl, b.getCallConnectUrl, StringComparison.Ordinal) &&
                   String.Equals(a.getStatusCallbackUrl, b.getStatusCallbackUrl, StringComparison.Ordinal) &&

                   PersyCommon.Equal(a, b);
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="other">Application object.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        /// <see>System.IEquatable interface.</see>
        public bool Equals(Application other)
        {
            if (other == null)
            {
                return false;
            }

            return Equal(this, other);
        }

        
    }
}