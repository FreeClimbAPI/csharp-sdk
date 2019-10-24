using Newtonsoft.Json;

namespace com.freeclimb.api.conference
{
    /// <summary>
    /// Represents a paginated list of FreeClimb participant instances. This object will
    /// be automatically created by ConferencesRequester.
    /// </summary>
    public sealed class ParticipantList : FreeClimbList
    {
        /// <summary>
        /// Creates a new ConferenceList.
        /// </summary>
        /// <param name="accountId">The accountId to use in requests for subsequent pages.</param>
        /// <param name="authToken">The authToken to use in requests for subsequent pages.</param>
        /// <param name="rawPage">The raw JSON string representing a page of a queue list from the FreeClimb API.</param>
        public ParticipantList(string accountId, string authToken, string rawPage) : base(accountId, authToken, rawPage, "participants")
        { }

        /// <summary>
        /// Used by ConferenceList to create Conference objects from the JSON list.
        /// </summary>
        /// <param name="element">A JSON string representing a FreeClimb conference instance.</param>
        /// <returns>An equivalent conference object to the one represented by the inputted JSON string.</returns>
        protected override IFreeClimbCommon constructElement(string element)
        {
            return JsonConvert.DeserializeObject<Participant>(element);
        }
    }
}
