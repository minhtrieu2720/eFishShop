using System;
using System.Collections.Generic;
using System.Text;

namespace eFishShop.ViewModels.Common
{
    public class PageResult<T> : PagedResultBase
    {
        public List<T> Items { set; get; }
    }
}
