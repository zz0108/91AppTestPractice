using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _91APPtest.Repository;
using _91APPtest.ViewModels.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _91APPtest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository<ProductListViewModels> _product;
        public ProductController(IProductRepository<ProductListViewModels> product)
        {
            _product = product;
        }
        [HttpGet("api/ProductGet")]
        public List<ProductViewModels> OrderGet(string ProductId)
        {
            var obj = _product.GetProducts(ProductId).Items;
            return obj;
        }
    }
}
