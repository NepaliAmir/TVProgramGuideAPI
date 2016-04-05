using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TvProgramGuideApi.Models;
using System.Data;
using System.Data.Entity;

namespace TvProgramGuideApi.DataLayer
{
    public class DataProgramDetail
    {
        public NepalChannelScheduleEntities db = new NepalChannelScheduleEntities();
        public dynamic GetAllProgramCategory()
        {
            var programCategory = db.ProgramCategories.ToList();
            return programCategory;
        }
        public dynamic GetAllProgramDetailsByChannelId(int id)
        {
            if (id != 0)
            {
                var programs = from scheduleDetails in db.ScheduleDetails
                               join programDetails in db.ProgramDetails on scheduleDetails.ProgramId
                                   equals programDetails.ProgramId
                               where scheduleDetails.ChannelId == id
                               select new { ScheduleDetail = scheduleDetails, ProgramDetail = programDetails };
                return programs;
            }
            else
            {
                return null;
            }
        }


    }
}