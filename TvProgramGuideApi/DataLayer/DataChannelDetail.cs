using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TvProgramGuideApi.Models;
using System.Data;
using System.Data.Entity;

namespace TvProgramGuideApi.DataLayer
{
    public class DataChannelDetail
    {

        public ProgramGuideEntities db = new ProgramGuideEntities();
        public dynamic GetAllChannelDetails()
        {
            var channelDetails = from channels in db.Channels
                                 join category in db.ChannelCategories on channels.ChannelCategoryId
                               equals category.ChannelCategoryId
                                 select new
                                {
                                    channels.ChannelId,
                                    category.Description,
                                    category.ChannelCategoryId,
                                    channels.Logopath,
                                    channels.Name
                                };
            return channelDetails;
        }

        public dynamic GetAllChannelCategoty()
        {
            var channelCategory = from category in db.ChannelCategories
                                  select new
                                  {
                                      category.ChannelCategoryId,
                                      category.Description
                                  };
            return channelCategory;
        }
        public dynamic GetAllLanguageType()
        {
            var languageType = db.Languages.ToList();
            return languageType;
        }

        public void SaveChannelDetail(string ChannelName, string channelCategoryId)
        {
            Channels channelDetail = new Channels();
            channelDetail.Name = ChannelName;
            channelDetail.ChannelCategoryId = channelCategoryId;
            db.Channels.Add(channelDetail);
            db.SaveChanges();
        }
        public void SaveChannelLogoImagePath(string ChannelId, string imageName)
        {
            string fullPath = "https://channelscheduleimage.blob.core.windows.net/pictures/" + imageName;
            var result = db.Channels.Find(ChannelId);
            if (result != null)
            {
                result.Logopath = fullPath;
                db.SaveChanges();
            }

        }
        public void UpdateChannelDetail(string ChannelName,string channelCategoryId, string channelId)
        {
            var chaQuery = db.Channels.SingleOrDefault(c => c.ChannelId == channelId);
            if (chaQuery != null)
            {
                chaQuery.Name = ChannelName;
                chaQuery.ChannelCategoryId = channelCategoryId;
                db.SaveChanges();
            }
        }


    }
}