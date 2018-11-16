using Newtonsoft.Json;
using System;

namespace com.persephony.api
{
    /// <summary>
    /// The PersyError represents the error messages that the Persephony API often replies with.
    /// </summary>
    [JsonObject]
    public class PersyError
    {
        [JsonProperty(PropertyName = "status")]
        private readonly int status;

        [JsonProperty(PropertyName = "message")]
        private readonly string message;

        [JsonProperty(PropertyName = "code")]
        private readonly int code;

        [JsonProperty(PropertyName = "info")]
        private readonly string info;

        /// <summary>
        /// Creates a PersyError. 
        /// </summary>
        /// <param name="status">The HTTP status code for the response.</param>
        /// <param name="message">A descriptive message about the error.</param>
        /// <param name="code">A Persephony specific code about the error.</param>
        /// <param name="info">A URL to the relevant Persephony documentation.</param>
        public PersyError(int status, String message, int code, String info)
        {
            this.status = status;
            this.message = message;
            this.code = code;
            this.info = info;
        }

        /// <summary>
        /// Retrieve status value from object.
        /// </summary>
        /// <returns>The status value of the object.</returns>
        public int getStatus { get { return this.status; } }

        /// <summary>
        /// Retrieve message value from object.
        /// </summary>
        /// <returns>The message value of the object.</returns>
        public string getMessage { get { return this.message; } }

        /// <summary>
        /// Retrieve code value from object.
        /// </summary>
        /// <returns>The code value of the object.</returns>
        public int getCode { get { return this.code; } }

        /// <summary>
        /// Retrieve info value from object.
        /// </summary>
        /// <returns>The info value of the object.</returns>
        public string getInfo { get { return this.info; } } 
    }
}
