using MedicalWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MedicalWebApi
{
    public class MedicalDbContext : DbContext
    {
        public MedicalDbContext(DbContextOptions<MedicalDbContext> options) : base(options) {}

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Area> Areas { get; set; }
    }
}
