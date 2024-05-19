using System.ComponentModel.DataAnnotations;

namespace TFG.HomeWorks.Application.Base
{
    public class PageListRequest<TOrderBy> where TOrderBy : struct
    {
        public TOrderBy OrderBy { get; set; }

        [Required]
        public int Page { get; set; }

        [Required]
        public int PageSize { get; set; }
        public SortDirection SortDirection { get; set; } = SortDirection.Desc;
    }
}
