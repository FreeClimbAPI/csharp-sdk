using System;

namespace freeclimb.Utils
{
    /// <summary>
    /// Interface for pagination - used by all list based responses
    /// </summary>
    public interface IPagination
    {
        /// <summary>
        /// Total number of items in each page. Max will be 10,000.
        /// </summary>
        /// <value>Total number of items in each page. Max will be 10,000.</value>
        int? Total { get; set; }

        /// <summary>
        /// Position in the overall list of the first item on the current page.
        /// </summary>
        /// <value>Position in the overall list of the first item on the current page.</value>
        int? Start { get; set; }

        /// <summary>
        /// Position in the overall list of the last item on the current page.
        /// </summary>
        /// <value>Position in the overall list of the last item on the current page.</value>
        int? End { get; set; }

        /// <summary>
        /// Current page number. Zero-indexed, so the first page is 0.
        /// </summary>
        /// <value>Current page number. Zero-indexed, so the first page is 0.</value>
        int? Page { get; set; }

        /// <summary>
        /// Total number of pages.
        /// </summary>
        /// <value>Total number of pages.</value>
        int? NumPages { get; set; }

        /// <summary>
        /// Number of resources returned in this page.
        /// </summary>
        /// <value>Number of resources returned in this page.</value>
        int? PageSize { get; set; }

        /// <summary>
        /// URI for the next page of the resource.
        /// </summary>
        /// <value>URI for the next page of the resource.</value>
        string? NextPageUri { get; set; }
    }
}
