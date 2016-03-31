using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TvProgramGuideApi.Models;
using TvProgramGuideApi.ServiceLayer;
namespace TvProgramGuideApi.Repository
{
    public class Factory : IFactory
    {
        public ChannelService channelService = new ChannelService();
        public List<ChannelDetail> GetAllChannels()
        {
            ChannelService channelService = new ChannelService();
            List<ChannelDetail> channels = new List<ChannelDetail>();
            channels = channelService.GetAllChannelDetail();
            return channels;
        }
        public List<ChannelCategory> GetAllChannelCategoty()
        {
            List<ChannelCategory> lstchannelCategory = new List<ChannelCategory>();
            lstchannelCategory = channelService.GetAllChannelCategoty();
            return lstchannelCategory;
        }
        public List<Language> GetAllLanguageType()
        {
            List<Language> lstLangugae = new List<Language>();
            lstLangugae = channelService.GetAllLanguageType();
            return lstLangugae;
        }
        public List<ProgramCategory> GetAllProgramCategory()
        {
            List<ProgramCategory> lstProgramCategory = new List<ProgramCategory>();
            lstProgramCategory = channelService.GetAllProgramCategory();
            return lstProgramCategory;
        }
        public void SaveChannelLogoImagePath(int channelId, string imageName)
        {

            channelService.SaveChannelLogoImagePath(channelId, imageName);
        }
        public void SaveChannelDetail(string channelName)
        {
            channelService.SaveChannelDetail(channelName);
        }
        public void UpdateChannelDetail(string channelName, int? channelId)
        {
            channelService.UpdateChannelDetail(channelName, channelId);
        }

    }
}