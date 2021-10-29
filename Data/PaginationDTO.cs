using System;
using System.Collections.Generic;
using System.Text;

namespace blalogin.Data
{
    public class PaginationDTO
    {
        public int Page { get; set; } = 1;
        public int QuantityPerPage { get; set; } = 10;
    }
}
