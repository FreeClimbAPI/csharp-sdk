using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.persephony.api
{
    /// <summary>
    /// fields that are used across many different API request message bodies.
    /// </summary>
    public class CommonFields
    {
        /// <summary>
        /// The requestId for a request starting with prefix "RQ" followed by 40 hexadecimal characters. 
        /// </summary>
        [JsonProperty(PropertyName = "requestId")]
        private string requestId = string.Empty;
        private bool requestIdFlag = false;

        /// <summary>
        /// get the requestId property from the current request object
        /// </summary>
        public string getRequestId { get { return this.requestId; } }


        /// <summary>
        /// sets the requestId property of the current request object
        /// </summary>
        /// <param name="requestId"></param>
        public void setRequestId(string requestId)
        {
            this.requestId = requestId;
            this.requestIdFlag = true;
        }

        /// <summary>
        /// Used to help properly serialize a request object. Need to return a dictionary containing all properties that are part of this class when
        /// a property has been set by the user of the class instance (request object). There is a flag that tells if the user set each corresponding property
        /// The flag property is only used on optional properties. If there is a required property, it should always be added to the dictionary
        /// </summary>
        /// <returns></returns>
        protected IDictionary<string, object> toDict()
        {
            IDictionary<string, object> dict = new Dictionary<string, object>();
            if (requestIdFlag)
            {
                dict.Add("requestId", getRequestId);
            }
            return dict;
        }
    }
}
