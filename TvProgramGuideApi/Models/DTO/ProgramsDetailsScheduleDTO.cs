using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TvProgramGuideApi.Models.DTO
{
    public class ProgramsDetailsScheduleDTO
    {
        public double ProgramId { get; set; }
        public string ProgramName { get; set; }
        public string ProgramLogoImagePath { get; set; }
        public double ProgramShowStartTime { get; set; }
        public double ProgramShowEndTime { get; set; }
        public string TimeMeridiem { get; set; }
        public DateTime datetime { get; set; }
    }
}