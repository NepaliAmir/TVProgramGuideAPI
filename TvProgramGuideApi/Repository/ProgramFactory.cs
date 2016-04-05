using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TvProgramGuideApi.Models;
using TvProgramGuideApi.ServiceLayer;

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
    }
}