using AutoMapper;
using Hospital_WebAPI.DataAccess.Repository;
using Hospital_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

[assembly: AssemblyTitle("Hospital_UnitTest")]
namespace Hospital_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
       
        private readonly IMapper _mapper;
        private readonly IHospitalRepository _repository;

        public PatientsController(IMapper mapper, IHospitalRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        [HttpPost(Name = "POST/Patient")]
        public async Task<ActionResult<List<Patients>>> AddPatients(Patients patient)
        {
            if (ModelState.IsValid)
            {
                await _repository.AddPatient(patient);
                return Ok(patient);
            }
            return null;
        }

        [HttpGet(Name = "Get/Patients")]
        public async Task<ActionResult<IEnumerable<Patients>>> GetPatientDTO([FromQuery] PaginationParams @params)
        {
            
            var patients = await _repository.GetAllPatients();
            if (patients != null)
            {
                return  Ok(patients.OrderBy(patient => patient.Dob)
                                   .Select(patient => _mapper.Map<PatientsDto>(patient))
                                   .Skip((@params.Page - 1) * @params.ItemsPerPage)
                                   .Take(@params.ItemsPerPage));
            }
            return BadRequest(patients);
        }
    }
}
