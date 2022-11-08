using Hospital_WebAPI.Models;

namespace Hospital_WebAPI.DataAccess.Repository
{
    public interface IHospitalRepository 
    {
        Task<IEnumerable<Patients>> GetAllPatients();
         
        Task<Patients> GetPatientById(int id);

        Task<Patients> AddPatient(Patients patient);

        Task UpdatePatient(Patients patient);

        Task DeletePatients(int id);
    }
}
