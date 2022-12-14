using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hospital_WebAPI.Models
{
    public class Patients
    {
        [Key]
        public int Patient_Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyyMMdd}", ApplyFormatInEditMode = true)]
        public DateTime Dob { get; set; }

        public PatientSex PatientSex { get; set; }

        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public string Town { get; set; } = string.Empty;

        [PasswordPropertyText]
        public string Password { get; set; }

        public Doctors DoctorData { get; set; }
    }
}
