using EmergencyCareCentre.Data;
using EmergencyCareCentre.Models;
using EmergencyCareCentre.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmergencyCareCentre.Repositories
{
    public class BedRepository : IBedRepository, IDisposable
    {
        private bool disposedValue = false;
        private ApplicationDbContext _dbContext;

        public BedRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void DeleteBed(int bedId)
        {
            BedModel bed = _dbContext.Beds.Find(bedId);
            _dbContext.Beds.Remove(bed);
        }

        public BedModel GetBedById(int bedId)
        {
            return _dbContext.Beds.Find(bedId);
        }

        public IEnumerable<BedModel> GetBeds()
        {
            return _dbContext.Beds.Include(u => u.BedStatus).ToList();
        }

        public void InsertBed(BedModel bed)
        {
            _dbContext.Beds.Add(bed);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateBed(BedModel bed)
        {
            _dbContext.Entry(bed).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
