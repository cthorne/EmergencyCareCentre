using EmergencyCareCentre.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmergencyCareCentre.Repositories.Interfaces
{
    interface IPatientRepository
    {
        IEnumerable<PatientModel> GetPatients();
        PatientModel GetPatientById(int patientId);
        void InsertPatient(PatientModel patient);
        void DeletePatient(int patientId);
        void UpdatePatient(PatientModel patient);
        void Save();
    }
}
