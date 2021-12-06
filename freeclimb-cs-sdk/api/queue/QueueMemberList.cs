using Newtonsoft.Json;

namespace com.freeclimb.api.queue
{
    /// <summary>
    /// Represents a paginated list of FreeClimb QueueMember instances. This object will
    /// be automatically created by QueuesRequester.
    /// </summary>
    public sealed class QueueMemberList : FreeClimbList
    {
        /// <summary>
        /// Creates a new QueueMemberList.
        /// </summary>
        /// <param name="accountId">The accountId to use in requests for subsequent pages.</param>
        /// <param name="apiKey">The apiKey to use in requests for subsequent pages.</param>
        /// <param name="rawPage">The raw JSON string representing a page of a queue member list from the FreeClimb API.</param>
        public QueueMemberList(string accountId, string apiKey, string rawPage) : base(accountId, apiKey, rawPage, "queueMembers")
        { }

        /// <summary>
        /// Used by QueueMemberList to create QueueMember objects from the JSON list.
        /// </summary>
        /// <param name="element">A JSON string representing a FreeClimb queue member instance.</param>
        /// <returns>An equivalent queue member object to the one represented by the inputted JSON string.</returns>
        protected override IFreeClimbCommon constructElement(string element)
        {
            return JsonConvert.DeserializeObject<QueueMember>(element);
        }
    }
}
