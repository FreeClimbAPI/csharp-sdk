using System;

namespace com.persephony.api
{
    /// <summary>
    /// Raised when there is a problem interpretting JSON or converting an object to JSON.
    /// </summary>
    [Serializable]
    public class PersyJSONException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the PersyJSONException class with a specified string contents.
        /// </summary>
        /// <param name="message">Error Message</param>
        public PersyJSONException(string message) : base(String.Format("JSONException::{0}",message))
        {
        }
    }
}
