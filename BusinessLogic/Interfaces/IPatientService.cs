using Entity.Entities;

namespace BusinessLogic.Interfaces
{
    public interface IPatientService
    {
        Task<int> SavePatient(Patient patient);
        Task<List<Patient>> GetPatients();
        Task<List<Patient>> GetPatientsByDocumentNumber(string? documentNumber);
    }
}
