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
        public ProgramGuideEntities db = new ProgramGuideEntities();
        public dynamic GetAllProgramCategory()
        {
            var programCategory = db.ProgramCategories.ToList();
            return programCategory;
        }
        public dynamic GetAllProgramDetailsByChannelId(int id)
        {
            //if (id != 0)
            //{
            //    var programs = from scheduleDetails in db.ScheduleDetails
            //                   join programDetails in db.ProgramDetails on scheduleDetails.ProgramId
            //                       equals programDetails.ProgramId
            //                   where scheduleDetails.ChannelId == id
            //                   select new
            //                   {
            //                       scheduleDetails.ProgramId,
            //                       scheduleDetails.StartTime,
            //                       scheduleDetails.EndTime,
            //                       scheduleDetails.meridiem,
            //                       scheduleDetails.programShowDate,
            //                       programDetails.ImagePath,
            //                       programDetails.ProgramName
            //                   };
            //    return programs;
            //}
            //else
            //{
            //    return null;
            //}


            var programs = db.Programs.ToList();
            return programs;
        }


    }
}