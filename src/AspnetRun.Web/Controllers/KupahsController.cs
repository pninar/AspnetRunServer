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
    public class KupahsController : ControllerBase
    {
        private readonly IKupahPageService _kupahPageService;
        private readonly ILogger<KupahsController> _logger;

        public KupahsController(IKupahPageService kupahPageService, ILogger<KupahsController> logger)
        {
            _kupahPageService = kupahPageService ?? throw new ArgumentNullException(nameof(kupahPageService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        // GET: api/<KupahsController>
        [HttpGet]
        public async Task<IEnumerable<KupahViewModel>> Get()
        {
            var list = await _kupahPageService.GetKupahs();
            return list;
        }

        // GET api/<KupahsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<KupahsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<KupahsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<KupahsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
