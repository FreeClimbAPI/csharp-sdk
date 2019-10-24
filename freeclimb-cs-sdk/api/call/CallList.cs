using Newtonsoft.Json;

namespace com.freeclimb.api.call
{
    /// <summary>
    /// Represents a paginated list of FreeClimb Call instances. This object will
    /// be automatically created by CallsRequester.
    /// </summary>
    public sealed class CallList : FreeClimbList
    {
        /// <summary>
        /// Creates a new CallList.
        /// </summary>
        /// <param name="accountId">The accountId to use in requests for subsequent pages.</param>
        /// <param name="authToken">The authToken to use in requests for subsequent pages.</param>
        /// <param name="rawPage">The raw JSON string representing a page of a calls list from the FreeClimb API.</param>
        public CallList(string accountId, string authToken, string rawPage) : base(accountId, authToken, rawPage, "calls")
        { }

        /// <summary>
        /// Used by CallList to create Call objects from the JSON list.
        /// </summary>
        /// <param name="element">A JSON string representing a FreeClimb call instance.</param>
        /// <returns>An equivalent call object to the one represented by the inputted JSON string.</returns>
        protected override IFreeClimbCommon constructElement(string element)
        {
            return JsonConvert.DeserializeObject<Call>(element);
        }
    }
}
