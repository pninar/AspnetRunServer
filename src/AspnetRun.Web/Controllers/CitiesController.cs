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
    public class CitiesController : ControllerBase
    {
        private readonly ICityPageService _cityPageService;
        private readonly ILogger<CitiesController> _logger;

        public CitiesController(ICityPageService cityPageService, ILogger<CitiesController> logger)
        {
            _cityPageService = cityPageService ?? throw new ArgumentNullException(nameof(cityPageService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        // GET: api/<CitiesController>
        [HttpGet]
        public async Task<IEnumerable<CityViewModel>> Get()
        {
            var list = await _cityPageService.GetCities();
            return list;
        }

        // GET api/<CitiesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CitiesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CitiesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CitiesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
