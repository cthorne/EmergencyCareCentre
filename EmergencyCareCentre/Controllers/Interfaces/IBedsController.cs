using EmergencyCareCentre.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmergencyCareCentre.Controllers.Interfaces
{
    public interface IBedsController
    {
        IEnumerable<BedModel> GetAll();
        IEnumerable<BedModel> GetAvailableBeds();
        IEnumerable<BedModel> GetInUseBeds();
        BedModel GetBed(int bedId);
        void UpdateBed(BedModel bed);
        void DeleteBed(int bedId); 
        void InsertBed(BedModel bed);
    }
}
