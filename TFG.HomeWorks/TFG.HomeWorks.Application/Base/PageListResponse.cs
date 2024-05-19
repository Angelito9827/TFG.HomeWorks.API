namespace TFG.HomeWorks.Application.Base
{
    public class PageListResponse<TElement> where TElement : class
    {
        public IEnumerable<TElement> Elements { get; set; } = Enumerable.Empty<TElement>();
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
    }
}
