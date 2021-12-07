using Newtonsoft.Json;

namespace com.freeclimb.api.queue
{
    /// <summary>
    /// Represents a paginated list of FreeClimb Queue instances. This object will
    /// be automatically created by QueuesRequester.
    /// </summary>
    public sealed class QueueList : FreeClimbList
    {
        /// <summary>
        /// Creates a new QueueList.
        /// </summary>
        /// <param name="accountId">The accountId to use in requests for subsequent pages.</param>
        /// <param name="apiKey">The apiKey to use in requests for subsequent pages.</param>
        /// <param name="rawPage">The raw JSON string representing a page of a queue list from the FreeClimb API.</param>
        public QueueList(string accountId, string apiKey, string rawPage) : base(accountId, apiKey, rawPage, "queues")
        { }

        /// <summary>
        /// Used by QueueList to create Queue objects from the JSON list.
        /// </summary>
        /// <param name="element">A JSON string representing a FreeClimb queue instance.</param>
        /// <returns>An equivalent queue object to the one represented by the inputted JSON string.</returns>
        protected override IFreeClimbCommon constructElement(string element)
        {
            return JsonConvert.DeserializeObject<Queue>(element);
        }
    }
}
