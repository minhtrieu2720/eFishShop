using eFishShop.ViewModels.Catalog.Products;
using eFishShop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eFishShop.AdminApp.Service
{
    public interface IProductApiClient
    {
        Task<PageResult<ProductViewModel>> GetPagings(GetManageProductPagingRequest request);
    }
}
