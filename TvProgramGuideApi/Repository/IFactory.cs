using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvProgramGuideApi.Models;


namespace TvProgramGuideApi.Repository
{
    public interface IFactory
    {
        List<ChannelDetail> GetAllChannels();
        void SaveChannelLogoImagePath(int channelId, string imageName);
        void SaveChannelDetail(string channelName);
        void UpdateChannelDetail(string channelName, int? channelId);
        List<ChannelCategory> GetAllChannelCategoty();
        List<Language> GetAllLanguageType();
        List<ProgramCategory> GetAllProgramCategory();

    }
}
