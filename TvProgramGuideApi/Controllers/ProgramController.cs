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

        public HttpResponseMessage GetAllProgramCategory()
        {
            List<ProgramCategory> lstProgramCategory = new List<ProgramCategory>();
            lstProgramCategory = programFactory.GetAllProgramCategory();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, lstProgramCategory);
            return response;
        }
        [HttpGet]
        public HttpResponseMessage GetAllProgramNameByChannelId(int channelId)
        {
            //Program Name,ProgramType,Program language,ImageProgram
            List<ProgramInfoDTO> lstprogramInfoDTO = new List<ProgramInfoDTO>();
            ProgramInfoDTO programInfoDTO1 = new ProgramInfoDTO()
            {
                ProgramName = "Big Bang Theory",
                ProgramLogoImagePath = "https://channelimagelogos.blob.core.windows.net/pictures/5.jpg",
                ProgramType = "Commedy",
                ProgramShowStartTime = 9.00,
                ProgramShowEndTime = 10.00,
                ProgramLanguage = "English",
                TimeMeridiem = "AM",
                ProgramShowDay = "TodAY"
            };
            lstprogramInfoDTO.Add(programInfoDTO1);
            ProgramInfoDTO programInfoDTO2 = new ProgramInfoDTO()
            {
                ProgramName = "Games Of throne",
                ProgramLogoImagePath = "https://channelimagelogos.blob.core.windows.net/pictures/4.jpg",
                ProgramType = "Series",
                ProgramShowStartTime = 11.00,
                ProgramShowEndTime = 12.00,
                ProgramLanguage = "English",
                TimeMeridiem = "PM",
                ProgramShowDay = "TodAY"
            };
            lstprogramInfoDTO.Add(programInfoDTO2);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, lstprogramInfoDTO);
            return response;
        }

        [HttpGet]
        public HttpResponseMessage GetAllProgramNameByProgramCategoryId(int categoryID, DateTime dateTime)
        {
            List<ProgramDetailDTO> lstProgramDetaiDTO = new List<ProgramDetailDTO>();
            ProgramDetailDTO programDetailDTO1 = new ProgramDetailDTO()
            {
                ProgramName = "Bhadragoal",
                ChannelName = "NTV",
                ProgramLogoImagePath = "",
                ChannelLogoImagePath = "",
                ProgramType = "",
                ProgramShowStartTime = 8.00,
                ProgramShowEndTime = 9.00,
                ProgramLanguage = "Nepali",
                TimeMeridiem = "PM"
            };
            lstProgramDetaiDTO.Add(programDetailDTO1);
            ProgramDetailDTO programDetailDTO2 = new ProgramDetailDTO()
            {
                ProgramName = "Bhadragoal",
                ChannelName = "NTV",
                ProgramLogoImagePath = "",
                ChannelLogoImagePath = "",
                ProgramType = "",
                ProgramShowStartTime = 8.00,
                ProgramShowEndTime = 9.00,
                ProgramLanguage = "Nepali",
                TimeMeridiem = "PM"
            };
            lstProgramDetaiDTO.Add(programDetailDTO2);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, lstProgramDetaiDTO);
            return response;
        }


    }
}
