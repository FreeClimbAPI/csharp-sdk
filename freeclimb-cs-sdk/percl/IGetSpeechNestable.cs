using System.Collections.Generic;

namespace com.freeclimb.percl
{
    /// <summary>
    /// General GetSpeech nestable interface
    /// </summary>
    public interface IGetSpeechNestable
    {
        /// <summary>
        /// Interface for converstion to JSON string method.
        /// </summary>
        /// <returns>JSON string</returns>
        string toJson();

        /// <summary>
        /// Interface for converstion to dictionary object of key value pairs.
        /// </summary>
        /// <returns>Dictionary object</returns>
        IDictionary<string, object> toKvp();
    }
}
