using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TvProgramGuideApi.Models
{
    public class PhotoViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public long Size { get; set; }
        public string Url { get; set; }
        public string ChannelId { get; set; }
    }
}