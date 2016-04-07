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

        public Entities db = new Entities();
        public dynamic GetAllChannelDetails()
        {
            //db.database_firewall_rules();
            var channelDetails = from channel in db.ChannelDetails
                                 select channel;
            // var amir = from channel in db.ChannelDetails where db.ChannelDetails.id
            //            select channel;
            return channelDetails;
        }

        public dynamic GetAllChannelCategoty()
        {
            var channelCategory = db.ChannelCategories.ToList();
            return channelCategory;
        }
        public dynamic GetAllLanguageType()
        {
            var languageType = db.Languages.ToList();
            return languageType;
        }
       
        public void SaveChannelDetail(string ChannelName)
        {
            ChannelDetail channelDetail = new ChannelDetail();
            channelDetail.ChannelName = ChannelName;
            db.ChannelDetails.Add(channelDetail);
            db.SaveChanges();
        }
        public void SaveChannelLogoImagePath(int ChannelId, string imageName)
        {
            string fullPath = "https://channelscheduleimage.blob.core.windows.net/pictures/" + imageName;
            var result = db.ChannelDetails.Find(ChannelId);
            if (result != null)
            {
                result.ImagePath = fullPath;
                db.SaveChanges();
            }

        }
        public void UpdateChannelDetail(string ChannelName, int? channelId)
        {
            var chaQuery = db.ChannelDetails.SingleOrDefault(c => c.ChannelId == channelId);
            if (chaQuery != null)
            {
                chaQuery.ChannelName = ChannelName;
                db.SaveChanges();
            }
        }


    }
}