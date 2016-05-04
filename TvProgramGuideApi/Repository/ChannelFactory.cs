using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TvProgramGuideApi.Models;
using TvProgramGuideApi.ServiceLayer;
using TvProgramGuideApi.Models.ViewModel;
namespace TvProgramGuideApi.Repository
{
    public class ChannelFactory : IChannelFactory
    {
        private readonly IChannelService _channelService ;
        public ChannelFactory(IChannelService channelService)
        {
            _channelService = channelService;
        }

        public List<ChannelInfoViewModel> GetAllChannels()
        {
            ChannelService channelService = new ChannelService();
            List<ChannelInfoViewModel> channels = new List<ChannelInfoViewModel>();
            channels = channelService.GetAllChannelDetail();
            return channels;
        }
        public List<ChannelCategory> GetAllChannelCategoty()
        {
            List<ChannelCategory> lstchannelCategory = new List<ChannelCategory>();
            lstchannelCategory = _channelService.GetAllChannelCategoty();
            return lstchannelCategory;
        }
        public List<Language> GetAllLanguageType()
        {
            List<Language> lstLangugae = new List<Language>();
            lstLangugae = _channelService.GetAllLanguageType();
            return lstLangugae;
        }
       
        public void SaveChannelLogoImagePath(string  channelId, string imageName)
        {

            _channelService.SaveChannelLogoImagePath(channelId, imageName);
        }
        public void SaveChannelDetail(string channelName,string channelCategory)
        {
            _channelService.SaveChannelDetail(channelName, channelCategory);
        }
        public void UpdateChannelDetail(string channelName, string channelCategory,string channelId)
        {
            _channelService.UpdateChannelDetail(channelName,  channelCategory,channelId);
        }

    }
}