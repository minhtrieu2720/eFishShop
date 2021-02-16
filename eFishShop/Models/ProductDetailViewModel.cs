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
    public class ProductDetailViewModel
    {
        public CategoryVm Category { get; set; }

        public ProductViewModel Product { get; set; }

        public List<ProductViewModel> RelatedProducts { get; set; }

        //public List<ProductImageViewModel> ProductImages { get; set; }
    }
}
