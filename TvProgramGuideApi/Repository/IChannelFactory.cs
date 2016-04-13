using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvProgramGuideApi.Models;
using TvProgramGuideApi.Models.ViewModel;


namespace TvProgramGuideApi.Repository
{
    public interface IChannelFactory
    {
        List<ChannelInfoViewModel> GetAllChannels();
        void SaveChannelLogoImagePath(string channelId, string imageName);
        void SaveChannelDetail(string channelName,string channelCategoryId);
        void UpdateChannelDetail(string channelName,string channelCategoryId, string channelId);
        List<ChannelCategory> GetAllChannelCategoty();
        List<Language> GetAllLanguageType();
       

    }
}
