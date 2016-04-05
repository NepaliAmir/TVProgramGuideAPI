﻿using System;
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
    public class ChannelController : ApiController
    {
        #region get
        public ChannelFactory factory = new ChannelFactory();

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
            channelCategory = factory.GetAllChannelCategoty();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, channelCategory);
            return response;
        }
        [HttpGet]
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
            ChannelFactory factory = new ChannelFactory();

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
            ChannelFactory factory = new ChannelFactory();
            factory.SaveChannelLogoImagePath(ChannelId, imageName);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "message");
            return response;
        }
        #endregion

    }
}