using Hospital_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital_WebAPI.DataAccess.Repository
{
    public class HospitalRepository : IHospitalRepository
    {
        private readonly HospitalContext _context;

        public HospitalRepository(HospitalContext context)
        {
            _context = context;
        }

        public async Task<Patients> AddPatient(Patients patient)
        {
            if (patient != null)
            {
                _context.Patients.Add(patient);
                await _context.SaveChangesAsync();
                return patient;
            }
            return null;
        }

        public async Task UpdatePatient(Patients patient)
        {
            if (patient != null)
            {
                _context.Entry(patient).State = EntityState.Modified;
            }
        }

        public async Task<IEnumerable<Patients>> GetAllPatients()
        {
            return await _context.Patients.ToListAsync();
        }

        public async Task<Patients> GetPatientById(int id)
        {

            return await _context.Patients.FindAsync(id);

        }

        public async Task DeletePatients(int id)
        {
            Patients patient = _context.Patients.Find(id);
            _context.Patients.Remove(patient);
        }
    }
}
