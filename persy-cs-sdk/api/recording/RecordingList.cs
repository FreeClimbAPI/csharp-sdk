using Newtonsoft.Json;

namespace com.persephony.api.recording
{
    /// <summary>
    /// Represents a paginated list of Persephony Recording instances. This object will
    /// be automatically created by RecordingsRequester.
    /// </summary>
    public sealed class RecordingList : PersyList
    {
        /// <summary>
        /// Creates a new RecordingList.
        /// </summary>
        /// <param name="accountId">The accountId to use in requests for subsequent pages.</param>
        /// <param name="authToken">The authToken to use in requests for subsequent pages.</param>
        /// <param name="rawPage">The raw JSON string representing a page of a recording list from the Persephony API.</param>
        public RecordingList(string accountId, string authToken, string rawPage) : base(accountId, authToken, rawPage, "recordings")
        { }

        /// <summary>
        /// Used by QueueList to create Recording objects from the JSON list.
        /// </summary>
        /// <param name="element">A JSON string representing a Persephony recording instance.</param>
        /// <returns>An equivalent recording object to the one represented by the inputted JSON string.</returns>
        protected override IPersyCommon constructElement(string element)
        {
            return JsonConvert.DeserializeObject<Recording>(element);
        }
    }
}
