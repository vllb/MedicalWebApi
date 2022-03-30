using MedicalWebApi.Models;

namespace MedicalWebApi.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        private MedicalDbContext _context;
        public DoctorRepository(MedicalDbContext context)
        {
            _context = context;
        }
        public void AddDoctor(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
        }

        public bool DeleteDoctor(int id)
        {
            var doctor = GetDoctor(id);
            if(doctor != null)
            {
                _context.Doctors.Remove(doctor);
                _context.SaveChanges();
                return true;
            }
            
            return false;
        }

        public Doctor GetDoctor(int id)
        {
            return _context.Doctors.FirstOrDefault(d => d.Id == id);
        }

        public IEnumerable<Doctor> GetDoctors() => _context.Doctors;

        public void UpdateDoctor(Doctor doctor)
        {
            _context.Doctors.Update(doctor);
            _context.SaveChanges();
        }
    }
}
