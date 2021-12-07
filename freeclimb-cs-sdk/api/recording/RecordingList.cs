using Newtonsoft.Json;

namespace com.freeclimb.api.recording
{
    /// <summary>
    /// Represents a paginated list of FreeClimb Recording instances. This object will
    /// be automatically created by RecordingsRequester.
    /// </summary>
    public sealed class RecordingList : FreeClimbList
    {
        /// <summary>
        /// Creates a new RecordingList.
        /// </summary>
        /// <param name="accountId">The accountId to use in requests for subsequent pages.</param>
        /// <param name="apiKey">The apiKey to use in requests for subsequent pages.</param>
        /// <param name="rawPage">The raw JSON string representing a page of a recording list from the FreeClimb API.</param>
        public RecordingList(string accountId, string apiKey, string rawPage) : base(accountId, apiKey, rawPage, "recordings")
        { }

        /// <summary>
        /// Used by QueueList to create Recording objects from the JSON list.
        /// </summary>
        /// <param name="element">A JSON string representing a FreeClimb recording instance.</param>
        /// <returns>An equivalent recording object to the one represented by the inputted JSON string.</returns>
        protected override IFreeClimbCommon constructElement(string element)
        {
            return JsonConvert.DeserializeObject<Recording>(element);
        }
    }
}
