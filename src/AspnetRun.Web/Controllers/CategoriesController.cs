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
    public class CategoriesController : ControllerBase
    {

        private readonly ICategoryPageService _categoryPageService;
        private readonly ILogger<CategoriesController> _logger;

        public CategoriesController(ICategoryPageService categoryPageService, ILogger<CategoriesController> logger)
        {
            _categoryPageService = categoryPageService ?? throw new ArgumentNullException(nameof(categoryPageService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public async Task<IEnumerable<CategoryViewModel>> Get()
        {
            var list = await _categoryPageService.GetCategories();
            return list;
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CategoryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
