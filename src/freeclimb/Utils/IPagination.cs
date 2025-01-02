using System;

namespace freeclimb.Utils
{
    public interface IPagination
    {
        int? Total { get; set; }
        int? Start { get; set; }
        int? End { get; set; }
        int? Page { get; set; }
        int? NumPages { get; set; }
        int? PageSize { get; set; }
        string? NextPageUri { get; set; }
    }
}
