using AspnetRun.Web.Interfaces;
using AspnetRun.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public class PatientsController : ControllerBase
    {
        private readonly IPatientPageService _patientPageService;
        private readonly ILogger<PatientsController> _logger;

        public PatientsController(IPatientPageService patientPageService, ILogger<PatientsController> logger)
        {
            _patientPageService = patientPageService ?? throw new ArgumentNullException(nameof(patientPageService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        // GET: api/<PatientsController>
        [HttpGet]
        public async Task<IEnumerable<PatientViewModel>> Get([FromQuery] string patientName, [FromQuery] int pageIndex)
        {
            var list = await _patientPageService.GetPatients(patientName, pageIndex);
            return list;
        }

        // GET api/<PatientsController>/5
        [HttpGet("{id}")]
        public async Task<PatientViewModel> Get(int id)
        {
            var patient = await _patientPageService.GetPatientById(id);
            return patient;
        }

        // POST api/<PatientsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        //PUT api/<PatientsController>/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody] PatientViewModel patientToModify)
        {
            await _patientPageService.UpdatePatient(patientToModify);
        }

        // DELETE api/<PatientsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private bool PatientExists(int id)
        {
            var patient = _patientPageService.GetPatientById(id);
            return patient != null;
        }
    }
}
