﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace com.freeclimb.api
{
    /// <summary>
    /// Base class for representing a list of resources returned by the FreeClimb
    /// API. Resources are kept in an ArrayList which the user is given limited
    /// access to. Subclasses for each type of resource that can be returned in
    /// FreeClimb API's paginated lists should be made to wrap around this.
    /// </summary>
    public abstract class FreeClimbList : APIRequester
    {
        private Int32 page;
        private Int32 numPages;
        private Int32 pageSize;
        private Int32 start;
        private Int32 end;

        private int total;
        private string nextPageUri;

        private LinkedList<IFreeClimbCommon> list;
        private readonly string listField;

        /// <summary>
        /// Creates a FreeClimbList based on the JSON list returned by the FreeClimb API (rawPage).
        /// </summary>
        /// <param name="accountId">The accountId to use for credentials with the FreeClimb API when pulling new pages of the list.</param>
        /// <param name="apiKey">The apiKey to use for credentials with the FreeClimb API when pulling new pages of the list.</param>
        /// <param name="rawPage">The JSON string representing the first page of the list.</param>
        /// <param name="listField">The name of the array of resources within the raw JSON list. For example, for lists of Call resources the field is called "calls" and for Queues it's called "queues".</param>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        protected FreeClimbList(string accountId, string apiKey, string rawPage, string listField) : base(accountId, apiKey)
        {
		    this.list = new LinkedList<IFreeClimbCommon>();
		    this.listField = listField;
		    this.buildFromJson(rawPage);
        }

        /// <summary>
        /// Retrieve total size of the results list including what is still in non-downloaded pages.
        /// </summary>
        /// <returns>Total size of the results list including what is still in non-downloaded pages.</returns>
        public int getTotalSize {  get { return this.total; } }

        /// <summary>
        /// Retrieve the size of the underlying List.
        /// </summary>
        /// <returns>The size of the underlying List.</returns>
        public int getLocalSize { get { return this.list.Count; } }

        /// <summary>
        /// Retrieve the ith item in the local list.
        /// </summary>
        /// <param name="i">List index.</param>
        /// <returns>The ith item in the local list.</returns>
        public IFreeClimbCommon get(int i) { return this.list.ElementAtOrDefault(i); }

        /// <summary>
        /// Retrieve copy of the underlying list.
        /// </summary>
        /// <returns>Copy of the underlying list.</returns>
        public LinkedList<IFreeClimbCommon> export()
        {
            return new LinkedList<IFreeClimbCommon>(this.list);
        }

        /// <summary>
        /// Method that should be implemented with code to build the type of resource that a subclass represents.
        /// </summary>
        /// <param name="element">A JSON string representing a FreeClimb object.</param>
        /// <returns>An equivalent object to the one represented by the inputted JSON string.</returns>
        protected abstract IFreeClimbCommon constructElement(string element);

        /// <summary>
        /// Loads the next page of the list into the local array
        /// </summary>
        /// <exception cref="FreeClimbJSONException">Thrown upon failed request.</exception>
        public void loadNextPage()
        {
            string rawPage = this.fetchNextPage();
		    this.buildFromJson(rawPage);
        }

        /// <summary>
        /// Update the FreeClimbList with the data from the provided next page.
        /// </summary>
        /// <param name="rawPage">The raw JSON string representing a page of a list.</param>
        /// <exception cref="FreeClimbJSONException">Thrown upon failed to parse.</exception>
        protected void buildFromJson(string rawPage)
        {
            try
            {
                JObject jObject = JObject.Parse(rawPage);

                this.page = (jObject.GetValue("page")).Value<int>();
                this.numPages = (jObject.GetValue("numPages")).Value<int>();
                this.pageSize = (jObject.GetValue("pageSize")).Value<int>();
                this.start = (jObject.GetValue("start")).Value<int>();
                this.end = (jObject.GetValue("end")).Value<int>();
                this.total = (jObject.GetValue("total")).Value<int>();

                JToken jToken = jObject.GetValue("nextPageUri");
                this.nextPageUri = (jToken.Type == JTokenType.Null) ? null : jToken.ToString();

                JArray listFieldArray = (JArray)jObject[this.listField];
                foreach (JToken element in listFieldArray.ToArray<JToken>())
                {
                    this.list.AddLast(this.constructElement(element.ToString()));
                }
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <summary>
        /// Use the internal APIRequester to return the next page of the list.
        /// </summary>
        /// <returns>The raw JSON string representing the next page of the list.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        private string fetchNextPage()
        {
            string result = null;
		    if(this.nextPageUri != null)
            {
                result = base.GET(this.nextPageUri);
            }

		    return result;
        }
    }
}
