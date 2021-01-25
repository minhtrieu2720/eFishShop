using eFishShop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eFishShop.ViewModels.System
{
    public class GetUserPagingRequest: PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
