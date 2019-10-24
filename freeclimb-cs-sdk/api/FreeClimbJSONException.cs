using System;

namespace com.freeclimb.api
{
    /// <summary>
    /// Raised when there is a problem interpretting JSON or converting an object to JSON.
    /// </summary>
    [Serializable]
    public class FreeClimbJSONException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the FreeClimbJSONException class with a specified string contents.
        /// </summary>
        /// <param name="message">Error Message</param>
        public FreeClimbJSONException(string message) : base(String.Format("JSONException::{0}",message))
        {
        }
    }
}
