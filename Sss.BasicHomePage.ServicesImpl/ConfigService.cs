using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientDependency.Core;
using Sss.BasicHomePage.Models.ConfigModels;
using Sss.BasicHomePage.Models.Constants;
using Sss.BasicHomePage.Services;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace Sss.BasicHomePage.ServicesImpl
{
    public class ConfigService : BaseService, IConfigService
    {
        private readonly IImageService _imageService;


        public ConfigService(IImageService imageService)
        {
            _imageService = imageService;
        }



        public HeaderConfig GetHeaderConfig()
        {
            var configId = GetIntAppSetting("page.headerConfigId");

            var config = CurrentHelper.Content(configId);

            if (config == null)
                throw new Exception();

            return new HeaderConfig(config)
            {
                HeaderCarousel = _imageService.GetImages(config.Value<IEnumerable<IPublishedContent>>("headerCarousel"), width: 2000, height: 300)
            };

       
        }

        public string GetAppSetting(string key)
        {
            throw new NotImplementedException();
        }

        public int GetIntAppSetting(string key)
        {
            if (int.TryParse(ConfigurationManager.AppSettings[key], out var parsed))
                return parsed;

            throw new Exception();
        }

        public bool GetBoolAppSetting(string key)
        {
            throw new NotImplementedException();
        }

        public SeoConfig GetSeoConfig()
        {

            IPublishedContent config = CurrentHelper.Content(GetIntAppSetting("page.SEOConfigId"));
            IPublishedContent currentPage = Umbraco.Web.Composing.Current.UmbracoHelper.AssignedContentItem;
            if (config == null)
            {
                throw new Exception("Config not found!");
            }
            return new SeoConfig
            {
                MetaDescription = config.Value<string>(DocumentTypes.SeoConfig.Fields.MetaDescription) + " " + currentPage.Value<string>(DocumentTypes.BasePage.Fields.MetaDescription),
                MetaKeywords = config.Value<string>(DocumentTypes.SeoConfig.Fields.MetaKeywords) + ", " + currentPage.Value<string>(DocumentTypes.BasePage.Fields.MetaKeywords),
                Logo = GetHeaderConfig().Logo
            };
        }
    }
}
