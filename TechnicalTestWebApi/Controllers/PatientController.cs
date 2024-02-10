using AutoMapper;
using BusinessLogic.Interfaces;
using Entity.Entities;
using Microsoft.AspNetCore.Mvc;
using TechnicalTestWebApi.Dtos;
using TechnicalTestWebApi.Dtos.PatientDtos;

namespace TechnicalTestWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPatientService _patientService;

        public PatientController(IMapper mapper, IPatientService patientService)
        {
            _mapper = mapper;
            _patientService = patientService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var patients = await _patientService.GetPatients();

            return Ok(_mapper.Map<List<PatientDto>>(patients));
        }

        [HttpGet("GetPatientsByDocumentNumber")]
        public async Task<ActionResult> GetPatientsByDocumentNumber(string? documentNumber)
        {
            var patients = await _patientService.GetPatientsByDocumentNumber(documentNumber);

            return Ok(_mapper.Map<List<PatientDto>>(patients));
        }

        [HttpPost]
        public async Task<ActionResult> Post(SavePatientDto patient)
        {
            var patientId = await _patientService.SavePatient(_mapper.Map<Patient>(patient));

            var response = new Response<int>(patientId, "Paciente registrado correctamente.");

            return Ok(response);
        }
    }
}
