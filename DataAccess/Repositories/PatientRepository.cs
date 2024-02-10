using DataAccess.Interfaces;
using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace DataAccess.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly ApplicationDbContext _context;

        public PatientRepository(ApplicationDbContext context) {
            _context = context;
        }

        public async Task<List<Patient>> GetPatients()
        {
            return await _context.Patients.ToListAsync();
        }

        public async Task<List<Patient>> GetPatientsByDocumentNumber(string documentNumber)
        {
            if (documentNumber.IsNullOrEmpty())
            {
                return await _context.Patients.ToListAsync();
            }

            return await _context.Patients.Where(p => p.DocumentNumber.Contains(documentNumber)).ToListAsync();
        }

        public async Task<int> SavePatient(Patient patient)
        {
            try
            {
                _context.Patients.Add(patient);

                await _context.SaveChangesAsync();

                return patient.Id;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
