using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TvProgramGuideApi.Models;
using TvProgramGuideApi.DataLayer;
using TvProgramGuideApi.Models.DTO;

namespace TvProgramGuideApi.ServiceLayer
{
    public class ProgramService : IProgramService
    {
        public DataProgramDetail dataProgramDetail = new DataProgramDetail();

        public List<ProgramsDetailsScheduleDTO> GetProgramSchedulesDetailByChannelId(int channelId)
        {
            var scheduleDetailsobject = dataProgramDetail.GetAllProgramDetailsByChannelId(channelId);
            List<ProgramsDetailsScheduleDTO> lstProgramScheduleDetails = new List<ProgramsDetailsScheduleDTO>();
            
            if (scheduleDetailsobject != null)
            {
                foreach (var item in scheduleDetailsobject)
                {
                    ProgramsDetailsScheduleDTO ProgramScheduleDetails = new ProgramsDetailsScheduleDTO()
                    {
                        ProgramId = Convert.ToInt32(item.ProgramId),
                        ProgramName = item.ProgramName,
                        ProgramLogoImagePath = item.ImagePath,
                        ProgramShowStartTime = item.StartTime,
                        ProgramShowEndTime = item.EndTime,
                        TimeMeridiem = item.meridiem,
                        datetime = item.programShowDate
                    };
                    lstProgramScheduleDetails.Add(ProgramScheduleDetails);
                }
            }


            return lstProgramScheduleDetails;
        }
        public List<ProgramCategory> GetAllProgramCategory()
        {
            List<ProgramCategory> lstProgramCategory = new List<ProgramCategory>();
            var items = dataProgramDetail.GetAllProgramCategory();
            if (items != null)
            {
                foreach (var item in items)
                {
                    ProgramCategory programCategory = new ProgramCategory()
                    {
                        ProgramCategoryId = Convert.ToInt16(item.ProgramCategoryId),
                        Description = item.ProgramCategoryName
                    };
                    lstProgramCategory.Add(programCategory);
                }

            }
            return lstProgramCategory;
        }
    }
}