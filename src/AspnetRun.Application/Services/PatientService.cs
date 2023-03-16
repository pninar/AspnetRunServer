using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspnetRun.Core.Entities;
using AspnetRun.Core.Interfaces;
using AspnetRun.Core.Repositories;
using AspnetRun.Application.Models;
using AspnetRun.Application.Mapper;
using AspnetRun.Application.Interfaces;

namespace AspnetRun.Application.Services
{
    // TODO : add validation , authorization, logging, exception handling etc. -- cross cutting activities in here.
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IAppLogger<PatientService> _logger;

        public PatientService(IPatientRepository patientRepository, IAppLogger<PatientService> logger)
        {
            _patientRepository = patientRepository ?? throw new ArgumentNullException(nameof(patientRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<IEnumerable<PatientModel>> GetPatientList(int pageIndex)
        {
            var patientList = await _patientRepository.GetPatientListAsync(pageIndex);
            var mapped = ObjectMapper.Mapper.Map<IEnumerable<PatientModel>>(patientList);
            return mapped;
        }

        public async Task<PatientModel> GetPatientById(int patientId)
        {
            var patient = await _patientRepository.GetByIdAsync(patientId);
            var mapped = ObjectMapper.Mapper.Map<PatientModel>(patient);
            return mapped;
        }

        public async Task<IEnumerable<PatientModel>> GetPatientByName(string patientName, int pageIndex)
        {
            var patientList = await _patientRepository.GetPatientByNameAsync(patientName);
            var mapped = ObjectMapper.Mapper.Map<IEnumerable<PatientModel>>(patientList);
            return mapped;
        }

        public async Task<PatientModel> Create(PatientModel patientModel)
        {
            await ValidatePatientIfExist(patientModel);

            var mappedEntity = ObjectMapper.Mapper.Map<Patient>(patientModel);
            if (mappedEntity == null)
                throw new ApplicationException($"Entity could not be mapped.");

            var newEntity = await _patientRepository.AddAsync(mappedEntity);
            _logger.LogInformation($"Entity successfully added - AspnetRunAppService");

            var newMappedEntity = ObjectMapper.Mapper.Map<PatientModel>(newEntity);
            return newMappedEntity;
        }

        public async Task Update(PatientModel patientModel)
        {
            await ValidatePatientIfNotExist(patientModel);

            var editPatient = await _patientRepository.GetByIdAsync(patientModel.Id);
            if (editPatient == null)
                throw new ApplicationException($"Entity could not be loaded.");

            ObjectMapper.Mapper.Map<PatientModel, Patient>(patientModel, editPatient);

            await _patientRepository.UpdateAsync(editPatient);
            _logger.LogInformation($"Entity successfully updated - AspnetRunAppService");
        }

        public async Task Delete(PatientModel patientModel)
        {
            await ValidatePatientIfNotExist(patientModel);
            var deletedPatient = await _patientRepository.GetByIdAsync(patientModel.Id);
            if (deletedPatient == null)
                throw new ApplicationException($"Entity could not be loaded.");

            await _patientRepository.DeleteAsync(deletedPatient);
            _logger.LogInformation($"Entity successfully deleted - AspnetRunAppService");
        }

        private async Task ValidatePatientIfExist(PatientModel patientModel)
        {
            var existingEntity = await _patientRepository.GetByIdAsync(patientModel.Id);
            if (existingEntity != null)
                throw new ApplicationException($"{patientModel.ToString()} with this id already exists");
        }

        private async Task ValidatePatientIfNotExist(PatientModel patientModel)
        {
            var existingEntity = await _patientRepository.GetByIdAsync(patientModel.Id);
            if (existingEntity == null)
                throw new ApplicationException($"{patientModel.ToString()} with this id is not exists");
        }
    }
}
