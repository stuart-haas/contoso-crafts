using System.Collections.Generic;
using ContosoCrafts.Website.Models;
using ContosoCrafts.Website.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoCrafts.Website.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : Controller
    {
        public ProductsController(JsonFileProductService productService)
        {
            ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }

    }
}
