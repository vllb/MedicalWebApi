using MedicalWebApi.Models;

namespace MedicalWebApi.Repository
{
    public interface IDoctorRepository
    {
        IEnumerable<Doctor> GetDoctors();
        void AddDoctor(Doctor doctor);
        Doctor GetDoctor(int id);
        void UpdateDoctor(Doctor doctor);
        bool DeleteDoctor(int id);
    }
}
