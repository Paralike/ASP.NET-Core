using System;
using System.Collections.Generic;
using System.Text;

namespace PubErtekelo.BLL.Filters
{
    public class PagedFilter{
        public int Skip { get; set; }
        public int Take { get; set; } = 10;
    }
}
