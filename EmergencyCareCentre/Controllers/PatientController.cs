using EmergencyCareCentre.Controllers.Interfaces;
using EmergencyCareCentre.Models;
using EmergencyCareCentre.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmergencyCareCentre.Controllers
{ 
    //[Authorize]
    [ApiController]
    [Route("[controller]/[action]")]
    public class PatientController : ControllerBase, IPatientController
    {
        IPatientService _patientsService;
        public PatientController(IPatientService patientService)
        {
            _patientsService = patientService;
        }

        [HttpDelete]
        public void DeletePatient(int patientId)
        {
            _patientsService.DeletePatient(patientId);
        }

        [HttpGet]
        public PatientModel GetPatientById(int patientId)
        {
            return _patientsService.GetPatientById(patientId);
        }

        [HttpGet]
        public IEnumerable<PatientModel> GetPatients()
        {
            return _patientsService.GetPatients();
        }

        [HttpPut]
        public void InsertPatient(PatientModel patient)
        {
            _patientsService.InsertPatient(patient);
        }

        [HttpPatch]
        public void UpdatePatient(PatientModel patient)
        {
            _patientsService.UpdatePatient(patient);
        }
    }
}
