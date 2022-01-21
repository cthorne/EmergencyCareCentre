using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmergencyCareCentre.Models
{
    public class SummaryModel
    {
        public IEnumerable<PatientModel> Patients { get; set; }
        public IEnumerable<BedModel> Beds { get; set; }
    }
}
