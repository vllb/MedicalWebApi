using MedicalWebApi.Models;
using MedicalWebApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MedicalWebApi.Controllers
{
    [ApiController]
    [Route("api/doctors")]
    public class DoctorController : Controller
    {
        private IDoctorRepository _repository;

        public DoctorController(IDoctorRepository repository)
        {
            _repository = repository;
        }


        [HttpGet("{id}")]
        public Doctor GetDoctor(int id)
        {
            return _repository.GetDoctor(id);
        }
        public IEnumerable<Doctor> Doctors()
        {
            return _repository.GetDoctors();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDoctor(int id)
        {
            if (_repository.DeleteDoctor(id) == true)
            {
                return Ok("Success");
            }
            else
            {
                return Ok("Failed");
            }
            
        }
        [HttpPost]
        public int AddDoctor([FromBody] Doctor doctor)
        {
            _repository.AddDoctor(doctor);
            return doctor.Id;
        }
        [HttpPatch]
        public void UpdateDoctor([FromBody] Doctor doctor)
        {
            _repository.UpdateDoctor(doctor);
        }
    }
}
