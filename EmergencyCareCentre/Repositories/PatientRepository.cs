using EmergencyCareCentre.Data;
using EmergencyCareCentre.Models;
using EmergencyCareCentre.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmergencyCareCentre.Repositories
{
    public class PatientRepository : IPatientRepository, IDisposable
    {
        private bool disposedValue = false;
        private ApplicationDbContext _dbContext;

        public PatientRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void DeletePatient(int patientId)
        {
            PatientModel patient = _dbContext.Patients.Find(patientId);
            _dbContext.Patients.Remove(patient);
        }

        public PatientModel GetPatientById(int patientId)
        {
            return _dbContext.Patients.Find(patientId);
        }

        public IEnumerable<PatientModel> GetPatients()
        {
            return _dbContext.Patients.ToList();
        }

        public void InsertPatient(PatientModel patient)
        {
            _dbContext.Patients.Add(patient);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdatePatient(PatientModel patient)
        {
            _dbContext.Entry(patient).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
