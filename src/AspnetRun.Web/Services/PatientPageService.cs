using AspnetRun.Application.Interfaces;
using AspnetRun.Application.Models;
using AspnetRun.Web.Interfaces;
using AspnetRun.Web.ViewModels;
using AutoMapper;
using Kolgraph.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspnetRun.Web.Services
{
    public class PatientPageService : IPatientPageService
    {
        private readonly IPatientService _patientAppService;
        private readonly IMapper _mapper;
        private readonly ILogger<PatientPageService> _logger;

        public PatientPageService(IPatientService patientAppService, IMapper mapper, ILogger<PatientPageService> logger)
        {
            _patientAppService = patientAppService ?? throw new ArgumentNullException(nameof(patientAppService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<IEnumerable<PatientViewModel>> GetPatients(string patientName, int pageIndex)
        {
            if (string.IsNullOrWhiteSpace(patientName))
            {
                var list = await _patientAppService.GetPatientList(pageIndex);
                var mapped = _mapper.Map<IEnumerable<PatientViewModel>>(list);
                return mapped;
            }

            var listByName = await _patientAppService.GetPatientByName(patientName, pageIndex);
            var mappedByName = _mapper.Map<IEnumerable<PatientViewModel>>(listByName);
            return mappedByName;
        }

        public async Task<PatientViewModel> GetPatientById(int patientId)
        {
            var patient = await _patientAppService.GetPatientById(patientId);
            var mapped = _mapper.Map<PatientViewModel>(patient);
            return mapped;
        }

        public async Task<PatientViewModel> CreatePatient(PatientViewModel patientViewModel)
        {
            var mapped = _mapper.Map<PatientModel>(patientViewModel);
            if (mapped == null)
                throw new Exception($"Entity could not be mapped.");

            var entityDto = await _patientAppService.Create(mapped);
            _logger.LogInformation($"Entity successfully added - IndexPageService");

            var mappedViewModel = _mapper.Map<PatientViewModel>(entityDto);
            return mappedViewModel;
        }

        public async Task UpdatePatient(PatientViewModel patientViewModel)
        {
            var mapped = _mapper.Map<PatientModel>(patientViewModel);
            if (mapped == null)
                throw new Exception($"Entity could not be mapped.");

            await _patientAppService.Update(mapped);
            _logger.LogInformation($"Entity successfully updated - IndexPageService");
        }

        public async Task DeletePatient(PatientViewModel productViewModel)
        {
            var mapped = _mapper.Map<PatientModel>(productViewModel);
            if (mapped == null)
                throw new Exception($"Entity could not be mapped.");

            await _patientAppService.Delete(mapped);
            _logger.LogInformation($"Entity successfully added - IndexPageService");
        }
    }
}

