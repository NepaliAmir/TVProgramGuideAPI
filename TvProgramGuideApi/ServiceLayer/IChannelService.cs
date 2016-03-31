using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvProgramGuideApi.Models;

namespace TvProgramGuideApi.ServiceLayer
{
    public interface IChannelService
    {
        List<ChannelDetail> GetAllChannelDetail();
        void SaveChannelLogoImagePath(int ChannelId, string imageName);
        void SaveChannelDetail(string ChannelName);
        void UpdateChannelDetail(string ChannelName, int? channelId);
        List<ChannelCategory> GetAllChannelCategoty();
        List<Language> GetAllLanguageType();
        List<ProgramCategory> GetAllProgramCategory();

    }
}
