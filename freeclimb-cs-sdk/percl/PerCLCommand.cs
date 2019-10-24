using Newtonsoft.Json;
using System.Collections.Generic;

namespace com.freeclimb.percl
{
    /// <summary>
    /// The PerCLCommand class is a base class from which classes representing various
    /// PerCL commands can be built.
    /// </summary>
    public abstract class PerCLCommand
    {
        /// <summary>
        /// Virtual method to convert object into a JSON string.
        /// </summary>
        /// <returns>JSON string</returns>
        /// <see cref = "Newtonsoft.Json" />
        public virtual string toJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        /// <summary>
        /// Virtual method to convert object into a KVP Dictionary.
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public virtual IDictionary<string, object> toKvp()
        {
            return new Dictionary<string, object>();
        }
    }
}
