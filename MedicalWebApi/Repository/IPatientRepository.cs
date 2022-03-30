using MedicalWebApi.Models;

namespace MedicalWebApi.Repository
{
    public interface IPatientRepository
    {
        IEnumerable<Patient> GetPatients();
        void AddPatient(Patient patient);
        Patient GetPatient(int id);
        void UpdatePatient(Patient patient);
        bool DeletePatient(int id);
    }
}
