using Hospital_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital_WebAPI.DataAccess
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options) { }

        public DbSet<Patients> Patients { get; set; }
        
    }
}
