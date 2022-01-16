using EmergencyCareCentre.Models;
using EmergencyCareCentre.Repositories.Interfaces;
using EmergencyCareCentre.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmergencyCareCentre.Services
{
    public class BedService : IBedService
    {
        IBedRepository _bedRepo;
        public BedService(IBedRepository bedRepository)
        {
            _bedRepo = bedRepository;
        }

        public void DeleteBed(int bedId)
        {
            _bedRepo.DeleteBed(bedId);
        }

        public BedModel GetBedById(int bedId)
        {
            return _bedRepo.GetBedById(bedId);
        }

        public IEnumerable<BedModel> GetBeds()
        {
            return _bedRepo.GetBeds();
        }

        public void InsertBed(BedModel bed)
        {
            _bedRepo.InsertBed(bed);
        }

        public void Save()
        {
            _bedRepo.Save();
        }

        public void UpdateBed(BedModel bed)
        {
            _bedRepo.UpdateBed(bed);
        }

        public IEnumerable<BedModel> GetBedsWithStatus(int status)
        {
            return _bedRepo.GetBeds().Where(b => b.BedStatus.Id == status);
        }
    }
}
