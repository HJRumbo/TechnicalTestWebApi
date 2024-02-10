using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using Entity.Entities;

namespace BusinessLogic.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;
        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public async Task<List<Patient>> GetPatients()
        {
            return await _patientRepository.GetPatients();
        }

        public async Task<List<Patient>> GetPatientsByDocumentNumber(string? documentNumber)
        {
            return await _patientRepository.GetPatientsByDocumentNumber(documentNumber);
        }

        public async Task<int> SavePatient(Patient patient)
        {
            return await _patientRepository.SavePatient(patient);
        }
    }
}
