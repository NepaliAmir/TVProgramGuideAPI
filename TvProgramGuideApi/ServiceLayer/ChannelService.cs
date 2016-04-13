using System;
using System.Collections.Generic;
using TvProgramGuideApi.Models;
using TvProgramGuideApi.Models.ViewModel;
using TvProgramGuideApi.DataLayer;
using System.Data;


namespace TvProgramGuideApi.ServiceLayer
{
    public class ChannelService : IChannelService
    {
        DataChannelDetail datachannelDetail = new DataChannelDetail();
        public List<ChannelInfoViewModel> GetAllChannelDetail()
        {
            var channelDetails = datachannelDetail.GetAllChannelDetails();
            List<ChannelInfoViewModel> lstchannelDetail = new List<ChannelInfoViewModel>();
            if (channelDetails != null)
            {
                try
                {
                    foreach (var item in channelDetails) // Loop over the rows.
                    {
                        ChannelInfoViewModel channeldetail = new ChannelInfoViewModel()
                        {
                            CategoryDescription = item.Description,
                            ChannelId = Convert.ToString(item.ChannelId),
                            CategoryId=item.ChannelCategoryId,
                            ChannelName = Convert.ToString(item.Name),
                            LogoPath = Convert.ToString("https://channelscheduleimage.blob.core.windows.net/pictures/" + item.Logopath) 
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
                        languageId = Convert.ToInt16(item.LanguageId),
                        Name = item.LanguageName
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
                            ChannelCategoryId = item.ChannelCategoryId,
                            Description = item.Description
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
        public void SaveChannelLogoImagePath(string channelId, string imageName)
        {
            datachannelDetail.SaveChannelLogoImagePath(channelId, imageName);
        }
        public void SaveChannelDetail(string channelName, string channelCategoryId)
        {
            datachannelDetail.SaveChannelDetail(channelName, channelCategoryId);
        }
        public void UpdateChannelDetail(string channelName, string channelCategoryId, string channelId)
        {
            datachannelDetail.UpdateChannelDetail(channelName, channelCategoryId, channelId);
        }

    }
}