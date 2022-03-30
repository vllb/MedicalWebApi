using MedicalWebApi.Models;

namespace MedicalWebApi.Repository
{
    public class PatientRepository : IPatientRepository
    {
        private MedicalDbContext _context;
        public PatientRepository(MedicalDbContext context)
        {
            _context = context;
        }
        public void AddPatient(Patient patient)
        {
            _context.Patients.Add(patient);
            _context.SaveChanges();
        }

        public bool DeletePatient(int id)
        {
            var patient = GetPatient(id);
            if(patient != null)
            {
                _context.Patients.Remove(patient);
                return true;
            }
            return false;
        }

        public Patient GetPatient(int id)
        {
            return _context.Patients.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Patient> GetPatients() => _context.Patients;

        public void UpdatePatient(Patient patient)
        {
            _context.Patients.Update(patient);
            _context.SaveChanges();
        }
    }
}
