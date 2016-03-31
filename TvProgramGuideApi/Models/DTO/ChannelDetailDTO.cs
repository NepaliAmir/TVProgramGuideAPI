using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TvProgramGuideApi.Models.DTO
{
    public class ChannelDetailDTO
    {
        public string ProgramName { get; set; }
        public string ChannelName { get; set; }
        public string ChannelLogoImagePath { get; set; }
        public double ProgramShowStartTime { get; set; }
        public double ProgramShowEndTime { get; set; }

    }
}