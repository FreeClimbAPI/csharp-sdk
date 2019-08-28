using Newtonsoft.Json;

namespace com.persephony.api.queue
{
    /// <summary>
    /// Represents a paginated list of Persephony QueueMember instances. This object will
    /// be automatically created by QueuesRequester.
    /// </summary>
    public sealed class QueueMemberList : PersyList
    {
        /// <summary>
        /// Creates a new QueueMemberList.
        /// </summary>
        /// <param name="accountId">The accountId to use in requests for subsequent pages.</param>
        /// <param name="authToken">The authToken to use in requests for subsequent pages.</param>
        /// <param name="rawPage">The raw JSON string representing a page of a queue member list from the Persephony API.</param>
        public QueueMemberList(string accountId, string authToken, string rawPage) : base(accountId, authToken, rawPage, "queueMembers")
        { }

        /// <summary>
        /// Used by QueueMemberList to create QueueMember objects from the JSON list.
        /// </summary>
        /// <param name="element">A JSON string representing a Persephony queue member instance.</param>
        /// <returns>An equivalent queue member object to the one represented by the inputted JSON string.</returns>
        protected override IPersyCommon constructElement(string element)
        {
            return JsonConvert.DeserializeObject<QueueMember>(element);
        }
    }
}
