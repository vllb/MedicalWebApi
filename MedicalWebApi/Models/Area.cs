namespace MedicalWebApi.Models
{
    public class Area
    {
        public int Id { get; set; }
        public string City { get; set; }
        public IEnumerable<Doctor> Doctors { get; set; }
        public IEnumerable<Patient> Patients { get; set; }
    }
}
