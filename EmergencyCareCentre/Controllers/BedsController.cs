using EmergencyCareCentre.Models;
using EmergencyCareCentre.Services;
using EmergencyCareCentre.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmergencyCareCentre.Controllers.Interfaces
{
    //[Authorize]
    [ApiController]
    [Route("[controller]/[action]")]
    public class BedsController : ControllerBase, IBedsController
    {
        IBedService _bedsService;
        public BedsController(IBedService bedService)
        {
            _bedsService = bedService;
        }

        [HttpDelete]
        public void DeleteBed(int bedId)
        {
            _bedsService.DeleteBed(bedId);
        }

        [HttpGet]
        public IEnumerable<BedModel> GetAll()
        {
            return _bedsService.GetBeds();
        }

        [HttpGet]
        public IEnumerable<BedModel> GetAvailableBeds()
        {
            return _bedsService.GetBedsWithStatus(BedStatuses.Free);
        }

        [HttpGet]
        public BedModel GetBed(int bedId)
        {
            return _bedsService.GetBedById(bedId);
        }

        [HttpGet]
        public IEnumerable<BedModel> GetInUseBeds()
        {
            return _bedsService.GetBedsWithStatus(BedStatuses.InUse);
        }

        [HttpPut]
        public void InsertBed(BedModel bed)
        {
            _bedsService.InsertBed(bed);
        }

        [HttpPatch]
        public void UpdateBed(BedModel bed)
        {
            _bedsService.UpdateBed(bed);
        }
    }
}
