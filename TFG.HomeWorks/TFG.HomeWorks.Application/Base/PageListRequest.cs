using System.ComponentModel.DataAnnotations;

namespace TFG.HomeWorks.Application.Base
{
    public class PageListRequest<TOrderBy> where TOrderBy : struct
    {
        [Required]
        public int Page { get; set; }

        [Required]
        public int PageSize { get; set; }
        public TOrderBy OrderBy { get; set; }
        public SortDirection SortDirection { get; set; }
    }
}
