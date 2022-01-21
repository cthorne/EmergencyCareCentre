using EmergencyCareCentre.Models;
using EmergencyCareCentre.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmergencyCareCentre.Services
{
    public class SummaryService : ControllerBase, ISummaryService
    {
        IBedService _bedService;
        IPatientService _patientService;
        public SummaryService(IBedService bedService, IPatientService patientService)
        {
            _bedService = bedService;
            _patientService = patientService;
        }
        public SummaryModel GetSummaryView()
        {
            var beds = _bedService.GetBeds();
            var patients = _patientService.GetCurrentPatients();
            return new SummaryModel { Beds = beds, Patients = patients };
        }
    }
}
