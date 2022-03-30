using MedicalWebApi.Models;
using MedicalWebApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MedicalWebApi.Controllers
{
    [Route("api/patients")]
    public class PatientController : Controller
    {
        private IPatientRepository _repository;
        public PatientController(IPatientRepository repository) 
        {
            _repository = repository; 
        }
        [HttpGet("{id}")]
        public Patient GetPatient(int id)
        {
            return _repository.GetPatient(id);
        }
        public IEnumerable<Patient> Patients()
        {
            return _repository.GetPatients();
        }
        [HttpDelete("{id}")]
        public IActionResult DeletePatient(int id)
        {
            if (_repository.DeletePatient(id) == true)
            {
                return Ok("Success");
            }
            else
            {
                return Ok("Failed");
            }

        }
        [HttpPost]
        public int AddPatient([FromBody] Patient patient)
        {
            _repository.AddPatient(patient);
            return patient.Id;
        }
        [HttpPatch]
        public void UpdatePatient([FromBody] Patient patient)
        {
            _repository.UpdatePatient(patient);
        }
    }
}
