using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utils.DTO
{
    public class PaginationDto<TEntity>
    {
        public int PageSize { get; set; }

        public int Page { get; set; }

        public string Sort { get; set; }

        public string SortDirection { get; set; }

        public string Filter { get; set; }

        //   public FilterValueClass FilterValue { get; set; }

        public int PagesQuantity { get; set; }

        public IEnumerable<TEntity> Data { get; set; }

        public int TotalRows { get; set; }

    }
}
