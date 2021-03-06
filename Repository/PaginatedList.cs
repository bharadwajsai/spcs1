using System;
using System.Collections.Generic;

namespace Repository
{
    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; }

        public int TotalPages { get; }

        public PaginatedList(IEnumerable<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            AddRange(items);
        }

        public bool HasPreviousPage => (PageIndex > 1);

        public bool HasNextPage => (PageIndex < TotalPages);
    }
}