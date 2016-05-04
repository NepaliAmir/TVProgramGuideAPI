using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TvProgramGuideApi.Models.DTO;
using TvProgramGuideApi.Models;
using TvProgramGuideApi.Repository;
using TvProgramGuideApi.Models.ViewModel;
using System.Web.Http.Cors;
using TvProgramGuideApi.App_Start;

namespace TvProgramGuideApi.Controllers
{
    // [EnableCors(origins: "http://tvprogramapi.azurewebsites.net", headers: "*", methods: "*")]
    // [EnableCors(origins: "http://localhost:7783/", headers: "*", methods: "post,get")]

    [AllowCORS]
    public class ChannelController : ApiController
    {

        private readonly IChannelFactory _channelFactory;

        public ChannelController(IChannelFactory channelFactory)
        {
            _channelFactory = channelFactory;
        }
        #region get
        [HttpGet]
        public HttpResponseMessage AllChannelName()
        {
            List<ChannelInfoViewModel> channels = new List<ChannelInfoViewModel>();
            channels = _channelFactory.GetAllChannels();
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
                ProgramDay = "Today"

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
        public HttpResponseMessage GetAllChannelCategory()
        {
            List<ChannelCategory> channelCategory = new List<ChannelCategory>();
            channelCategory = _channelFactory.GetAllChannelCategoty();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, channelCategory);
            return response;
        }
        [HttpGet]
        public HttpResponseMessage GetAllLanguageType()
        {
            List<Language> lstLanguage = new List<Language>();
            lstLanguage = _channelFactory.GetAllLanguageType();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, lstLanguage);
            return response;
        }
        #endregion


        #region post
        [HttpPost]
        public void SaveUpdateChannelDetail(Channels channelDetail)
        {
            if (channelDetail.ChannelId != null)
            {
                _channelFactory.UpdateChannelDetail(channelDetail.Name, channelDetail.ChannelCategoryId, channelDetail.ChannelId);
            }
            else
            {
                _channelFactory.SaveChannelDetail(channelDetail.Name, channelDetail.ChannelCategoryId);
            }
        }

        [HttpPost]
        public HttpResponseMessage ImagePath(PhotoViewModel photoDetail)
        {
            string ChannelId = photoDetail.ChannelId;
            string imageName = photoDetail.Name;
            _channelFactory.SaveChannelLogoImagePath(ChannelId, imageName);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "message");
            return response;
        }
        #endregion

    }
}
