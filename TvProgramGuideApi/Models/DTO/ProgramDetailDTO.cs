using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TvProgramGuideApi.Models.DTO
{
    public class ProgramDetailDTO
    {
        public string ProgramName { get; set; }
        public string ChannelName { get; set; }
        public string ProgramLogoImagePath { get; set; }
        public string ChannelLogoImagePath { get; set; }
        public string ProgramType { get; set; }
        public double ProgramShowStartTime { get; set; }
        public double ProgramShowEndTime { get; set; }
        public string ProgramLanguage { get; set; }
        public string TimeMeridiem { get; set; }
        public string ProgramDay { get; set; }

    }
}