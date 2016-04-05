using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvProgramGuideApi.Models;
using TvProgramGuideApi.DataLayer;
using TvProgramGuideApi.Models.DTO;

namespace TvProgramGuideApi.ServiceLayer
{
    interface IProgramService
    {
        List<ProgramsDetailsScheduleDTO> GetProgramSchedulesDetailByChannelId(int id);
        List<ProgramCategory> GetAllProgramCategory();
    }
}
