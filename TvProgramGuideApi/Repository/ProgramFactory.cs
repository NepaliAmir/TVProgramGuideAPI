using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TvProgramGuideApi.Models;
using TvProgramGuideApi.ServiceLayer;
using TvProgramGuideApi.Models.DTO;

namespace TvProgramGuideApi.Repository
{
    public class ProgramFactory
    {
        public ProgramService programService = new ProgramService();
        public List<ProgramCategory> GetAllProgramCategory()
        {
            List<ProgramCategory> lstProgramCategory = new List<ProgramCategory>();
            lstProgramCategory = programService.GetAllProgramCategory();
            return lstProgramCategory;
        }
        public List<ProgramsDetailsScheduleDTO> GetProgramSchedulesDetailByChannelId(int channelId)
        {
            List<ProgramsDetailsScheduleDTO> lstProgramScheduleDetails = new List<ProgramsDetailsScheduleDTO>();
            lstProgramScheduleDetails = programService.GetProgramSchedulesDetailByChannelId(channelId);
            return lstProgramScheduleDetails;
        }
    }
}