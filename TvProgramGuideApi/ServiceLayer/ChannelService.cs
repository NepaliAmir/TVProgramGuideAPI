using System;
using System.Collections.Generic;
using TvProgramGuideApi.Models;
using TvProgramGuideApi.DataLayer;
using System.Data;


namespace TvProgramGuideApi.ServiceLayer
{
    public class ChannelService : IChannelService
    {
        DataChannelDetail datachannelDetail = new DataChannelDetail();
        public List<ChannelDetail> GetAllChannelDetail()
        {
            var channelDetails = datachannelDetail.GetAllChannelDetails();
            List<ChannelDetail> lstchannelDetail = new List<ChannelDetail>();
            if (channelDetails != null)
            {
                try
                {
                    foreach (var item in channelDetails) // Loop over the rows.
                    {
                        ChannelDetail channeldetail = new ChannelDetail()
                        {
                            Id = Convert.ToInt16(item.Id),
                            ChannelId = Convert.ToInt16(item.ChannelId),
                            ChannelName = Convert.ToString(item.ChannelName),
                            ImagePath = Convert.ToString(item.ImagePath)
                        };
                        lstchannelDetail.Add(channeldetail);
                    }
                }
                catch (Exception e)
                {
                    Exception exception = e;
                    return null;
                }
            }
            return lstchannelDetail;
        }
        public List<Language> GetAllLanguageType()
        {
            List<Language> lstLangugae = new List<Language>();
            var items = datachannelDetail.GetAllLanguageType();
            if (items != null)
            {
                foreach (var item in items)
                {
                    Language languageType = new Language()
                    {
                        LanguageId = Convert.ToInt16(item.LanguageId),
                        LanguageName = item.LanguageName
                    };
                    lstLangugae.Add(languageType);
                }

            }
            return lstLangugae;
        }
        public List<ChannelCategory> GetAllChannelCategoty()
        {
            List<ChannelCategory> lstchannelCategory = new List<ChannelCategory>();
            var items = datachannelDetail.GetAllChannelCategoty();
            if (items != null)
            {
                try
                {
                    foreach (var item in items)
                    {
                        ChannelCategory channelcategory = new ChannelCategory()
                        {
                            Id = Convert.ToInt16(item.Id),
                            CategoryId = Convert.ToInt16(item.CategoryId),
                            CategoryName = item.CategoryName
                        };
                        lstchannelCategory.Add(channelcategory);
                    }
                }
                catch (Exception e)
                {
                    Exception ex = e;
                    return null;
                }

            }
            return lstchannelCategory;
        }
        public void SaveChannelLogoImagePath(int channelId, string imageName)
        {
            datachannelDetail.SaveChannelLogoImagePath(channelId, imageName);
        }
        public void SaveChannelDetail(string channelName)
        {
            datachannelDetail.SaveChannelDetail(channelName);
        }
        public void UpdateChannelDetail(string channelName, int? channelId)
        {
            datachannelDetail.UpdateChannelDetail(channelName, channelId);
        }

    }
}