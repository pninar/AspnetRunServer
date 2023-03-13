using AspnetRun.Web.Interfaces;
using AspnetRun.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspnetRun.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductPageService _productPageService;
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(IProductPageService productPageService, ILogger<ProductsController> logger)
        {
            _productPageService = productPageService ?? throw new ArgumentNullException(nameof(productPageService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IEnumerable<ProductViewModel>> Get([FromQuery] string productName)
        {
            var list = await _productPageService.GetProducts(productName);
            return list;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<ProductViewModel> Get(int id)
        {
            var product = await _productPageService.GetProductById(id);
            return product;
        }

        // POST api/<ProductController>
        [HttpPost]
        public async void Post([FromBody] ProductViewModel productToCreate)
        {
            await _productPageService.CreateProduct(productToCreate);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody] ProductViewModel productToModify)
        {
            await _productPageService.UpdateProduct(productToModify);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            var product = await _productPageService.GetProductById(id);
            await _productPageService.DeleteProduct(product);
        }
    }
}