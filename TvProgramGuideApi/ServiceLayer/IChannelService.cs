using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvProgramGuideApi.Models;
using TvProgramGuideApi.Models.ViewModel;

namespace TvProgramGuideApi.ServiceLayer
{
    public interface IChannelService
    {
        List<ChannelInfoViewModel> GetAllChannelDetail();
        void SaveChannelLogoImagePath(string ChannelId, string imageName);
        void SaveChannelDetail(string ChannelName);
        void UpdateChannelDetail(string ChannelName, string channelId);
        List<ChannelCategory> GetAllChannelCategoty();
        List<Language> GetAllLanguageType();
      

    }
}
