using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TvProgramGuideApi.Models.ViewModel
{
    public class ChannelInfoViewModel
    {
        public string ChannelId { get; set; }
        public string CategoryDescription { get; set; }
        public string LogoPath { get; set; }
        public string ChannelName { get; set; }
    }
}