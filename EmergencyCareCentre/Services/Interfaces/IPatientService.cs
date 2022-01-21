using EmergencyCareCentre.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmergencyCareCentre.Services.Interfaces
{
    public interface IPatientService
    {
        IEnumerable<PatientModel> GetPatients();
        IEnumerable<PatientModel> GetCurrentPatients();
        PatientModel GetPatientById(int patientId);
        void InsertPatient(PatientModel patient);
        void DeletePatient(int patientId);
        void UpdatePatient(PatientModel patient);
    }
}
