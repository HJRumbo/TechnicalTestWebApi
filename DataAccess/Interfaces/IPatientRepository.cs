using Entity.Entities;

namespace DataAccess.Interfaces
{
    public interface IPatientRepository
    {
        Task<int> SavePatient(Patient patient);
        Task<List<Patient>> GetPatients();
        Task<List<Patient>> GetPatientsByDocumentNumber(string documentNumber);
    }
}
