namespace Hospital_WebAPI.Models
{
    public class Doctors
    {
        public  string FirstName { get; set; }

        public string LastName { get; set; }

        public WorkAreaForDoctor WorkArea { get; set; }

        public int Age { get; set; }

        public int YearOfExperiends { get; set; }
    }
}
