using eFishShop.ViewModels.Catalog.Categories;
using eFishShop.ViewModels.Catalog.Products;
using eFishShop.ViewModels.Common;
using eFishShop.ViewModels.Utilities.Slides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eFishShop.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryVm Category { get; set; }

        public PageResult<ProductViewModel> Products { get; set; }
    }
}
