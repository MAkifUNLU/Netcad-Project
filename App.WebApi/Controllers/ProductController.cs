using App.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;
        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet(Name = "productlist")]
        public IActionResult Get()
        {
            var list = _productService.GetProductList();
            return Ok(list);
        }
        //[HttpPost("add")]
        //public IActionResult Add(product)
        //{
        //    var result = _productService.Add(product);
        //}

        //[HttpPost("delete")]//[HttpDelete("delete")]  böyle de olabilir
        //public IActionResult Delete()
        //{
        //    var result = _productService.Delete(product);
        //}

        //[HttpPost("update")]//[HttpPut("update")]  böyle de olabilir
        //public IActionResult Update()
        //{
        //    var result = _productService.Update(product);
        //}
    }
}
