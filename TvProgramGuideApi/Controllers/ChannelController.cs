using TvProgramGuideApi.Models;
using TvProgramGuideApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TvProgramGuideApi.Models.DTO;

namespace TvProgramGuideApi.Controllers
{
    public class ChannelController : ApiController
    {
        #region get
        public Factory factory = new Factory();

        [HttpGet]
        public HttpResponseMessage AllChannelName()
        {
            List<ChannelDetail> channels = new List<ChannelDetail>();
            channels = factory.GetAllChannels();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, channels);
            return response;
        }

        [HttpGet]
        public HttpResponseMessage GetCurrentProgramList(DateTime currentTime)
        {
            //Program Name,ChannelName,ProgramType,Program language,ImageProgram,ImageChannel
            List<ProgramDetailDTO> lstProgramDetaiDTO = new List<ProgramDetailDTO>();
            ProgramDetailDTO programDetailDTO1 = new ProgramDetailDTO()
            {
                ProgramName = "Bhadragoal",
                ProgramLogoImagePath = "https://channelscheduleimage.blob.core.windows.net/pictures/2.jpg",
                ChannelLogoImagePath = "https://channelscheduleimage.blob.core.windows.net/pictures/3.jpeg",
                ProgramType = "Comedy Series",
                ProgramShowStartTime = 8.00,
                ProgramLanguage = "Nepali",
                TimeMeridiem = "PM",
                ProgramDay="Today"
                
            };
            lstProgramDetaiDTO.Add(programDetailDTO1);
            ProgramDetailDTO programDetailDTO2 = new ProgramDetailDTO()
            {
                ProgramName = "AakhiJhyal",
                ChannelName = "Kantipur",
                ProgramLogoImagePath = "https://channelscheduleimage.blob.core.windows.net/pictures/2.jpg",
                ChannelLogoImagePath = "https://channelscheduleimage.blob.core.windows.net/pictures/3.jpeg",
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

        [HttpGet]
        public HttpResponseMessage GetChannelNameByChannelCategoryId(int categoryID, DateTime dateTime)
        {
            //Program Name,ChannelName,ProgramType,Program language,ImageProgram,ImageChannel
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "message");
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
        [HttpGet]

        public HttpResponseMessage GetAllChannelCategory()
        {
            List<ChannelCategory> channelCategory = new List<ChannelCategory>();
            channelCategory = factory.GetAllChannelCategoty();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, channelCategory);
            return response;
        }
        [HttpGet]
        public HttpResponseMessage GetAllProgramCategory()
        {
            List<ProgramCategory> lstProgramCategory = new List<ProgramCategory>();
            lstProgramCategory = factory.GetAllProgramCategory();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, lstProgramCategory);
            return response;
        }
        public HttpResponseMessage GetAllLanguageType()
        {
            List<Language> lstLanguage = new List<Language>();
            lstLanguage = factory.GetAllLanguageType();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, lstLanguage);
            return response;
        }
        #endregion




        #region post
        [HttpPost]
        public void SaveUpdateChannelDetail(ChannelDetail channelDetail)
        {
            Factory factory = new Factory();

            if (channelDetail.ChannelId != null)
            {
                factory.UpdateChannelDetail(channelDetail.ChannelName, channelDetail.ChannelId);
            }
            else
            {
                factory.SaveChannelDetail(channelDetail.ChannelName);
            }
        }

        [HttpPost]
        public HttpResponseMessage ImagePath(PhotoViewModel photoDetail)
        {
            int ChannelId = photoDetail.ChannelId;
            string imageName = photoDetail.Name;
            Factory factory = new Factory();
            factory.SaveChannelLogoImagePath(ChannelId, imageName);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "message");
            return response;
        }
        #endregion

    }
}
