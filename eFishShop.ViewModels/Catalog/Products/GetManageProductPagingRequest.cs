using eFishShop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eFishShop.ViewModels.Catalog.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public int? CategoryIds { get; set; }
        public string LanguageId { get; set; }
    }
}
