using EmergencyCareCentre.Models;
using EmergencyCareCentre.Repositories.Interfaces;
using EmergencyCareCentre.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmergencyCareCentre.Services
{
    public class PatientService : IPatientService
    {
        IPatientRepository _patientRepo;
        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepo = patientRepository;
        }

        public void DeletePatient(int patientId)
        {
            _patientRepo.DeletePatient(patientId);
        }

        public PatientModel GetPatientById(int patientId)
        {
            return _patientRepo.GetPatientById(patientId);
        }

        public IEnumerable<PatientModel> GetPatients()
        {
            return _patientRepo.GetPatients();
        }

        public void InsertPatient(PatientModel patient)
        {
            _patientRepo.InsertPatient(patient);
        }

        public void Save()
        {
            _patientRepo.Save();
        }

        public void UpdatePatient(PatientModel patient)
        {
            _patientRepo.UpdatePatient(patient);
        }
    }
}
