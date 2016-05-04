using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvProgramGuideApi.Models;
using TvProgramGuideApi.Models.DTO;

namespace TvProgramGuideApi.Repository
{
    public interface IProgramFactory
    {
        List<ProgramCategory> GetAllProgramCategory();
        List<ProgramsDetailsScheduleDTO> GetProgramSchedulesDetailByChannelId(int channelId);
    }
}
