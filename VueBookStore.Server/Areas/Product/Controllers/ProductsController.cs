using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VueBookStore.Server.Areas.Product.Models;
using VueBookStore.Server.EF;
using VueBookStore.Server.Areas.Product.DTO;
using VueBookStore.Server.Areas.Product.Services;

namespace VueBookStore.Server.Areas.Product.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;
        
        // GET: api/products
        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductPreviewDTO>>> GetProducts()
        {
            return await _productService.GetPreviewsAsync();
        }
    }
}
