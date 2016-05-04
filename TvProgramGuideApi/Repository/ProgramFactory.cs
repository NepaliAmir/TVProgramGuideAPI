using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TvProgramGuideApi.Models;
using TvProgramGuideApi.ServiceLayer;
using TvProgramGuideApi.Models.DTO;

namespace TvProgramGuideApi.Repository
{
    public class ProgramFactory : IProgramFactory
    {
        private readonly IProgramService _programService;
        public ProgramFactory(IProgramService programService)
        {
            _programService = programService;
        }
        public List<ProgramCategory> GetAllProgramCategory()
        {
            List<ProgramCategory> lstProgramCategory = new List<ProgramCategory>();
            lstProgramCategory = _programService.GetAllProgramCategory();
            return lstProgramCategory;
        }
        public List<ProgramsDetailsScheduleDTO> GetProgramSchedulesDetailByChannelId(int channelId)
        {
            List<ProgramsDetailsScheduleDTO> lstProgramScheduleDetails = new List<ProgramsDetailsScheduleDTO>();
            lstProgramScheduleDetails = _programService.GetProgramSchedulesDetailByChannelId(channelId);
            return lstProgramScheduleDetails;
        }
    }
}