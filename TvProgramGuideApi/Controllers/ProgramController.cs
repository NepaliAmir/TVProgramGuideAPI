using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TvProgramGuideApi.Models.DTO;
using TvProgramGuideApi.Models;
using TvProgramGuideApi.Repository;


namespace TvProgramGuideApi.Controllers
{
    public class ProgramController : ApiController
    {
        public ProgramFactory programFactory = new ProgramFactory();

        [HttpGet]
        public HttpResponseMessage GetAllProgramCategory()
        {
            List<ProgramCategory> lstProgramCategory = new List<ProgramCategory>();
            lstProgramCategory = programFactory.GetAllProgramCategory();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, lstProgramCategory);
            return response;
        }
        [HttpGet]
        public HttpResponseMessage GetAllProgramNameByChannelId()
        {
            int channelId = 1;
            //Program Name,ProgramType,Program language,ImageProgram
            List<ProgramsDetailsScheduleDTO> lstprogramInfoDTO = new List<ProgramsDetailsScheduleDTO>();
            lstprogramInfoDTO = programFactory.GetProgramSchedulesDetailByChannelId(channelId);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, lstprogramInfoDTO);
            return response;
        }


    }
}
