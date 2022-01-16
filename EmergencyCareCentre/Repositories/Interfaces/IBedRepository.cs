using EmergencyCareCentre.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmergencyCareCentre.Repositories.Interfaces
{
    public interface IBedRepository : IDisposable
    {
        IEnumerable<BedModel> GetBeds();
        BedModel GetBedById(int bedId);
        void InsertBed(BedModel bed);
        void DeleteBed(int bedId);
        void UpdateBed(BedModel bed);
        void Save();
    }
}
