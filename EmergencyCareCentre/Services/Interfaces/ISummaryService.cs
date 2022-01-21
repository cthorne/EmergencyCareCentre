using EmergencyCareCentre.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmergencyCareCentre.Services.Interfaces
{
    public interface ISummaryService
    {
        SummaryModel GetSummaryView();
    }
}
