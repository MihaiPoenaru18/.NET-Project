using Hospital_WebAPI;
using System.ComponentModel.DataAnnotations;

namespace Hospital_WebAPI.Models
{
    public class PatientsDto
    {
        public string Town { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public PatientSex PatientSex { get; set; }
    }
}
