using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sss.BasicHomePage.Models.ConfigModels;
using Sss.BasicHomePage.Models.Poco;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Models;
using Link = Sss.BasicHomePage.Models.Poco.Link;

namespace Sss.BasicHomePage.Models.PageModels
{
    public class BasePage : ContentModel
    {

        public decimal SearchEngineRelativePriority =>
            Content.GetProperty(Constants.DocumentTypes.BasePage.Fields.SearchEngineRelativePriority).Value<decimal>();

        public string SearchEngineChangeFrequency => Content.HasValue(Constants.DocumentTypes.BasePage.Fields.SearchEngineChangeFrequency) ? 
            Content.Value<string>(Constants.DocumentTypes.BasePage.Fields.SearchEngineChangeFrequency) : "yearly";

        public bool HideFromXmlSitemap => Content.Value<bool>(Constants.DocumentTypes.BasePage.Fields.HideFromXmlSitemap);

        public string MetaDescription => Content.Value<string>(Constants.DocumentTypes.BasePage.Fields.MetaDescription);
        public string MetaKeywords => Content.Value<string>(Constants.DocumentTypes.BasePage.Fields.MetaKeywords);

        public string Title => Content.Value<string>(Constants.DocumentTypes.BasePage.Fields.Title);
        public string Abstract => Content.Value<string>(Constants.DocumentTypes.BasePage.Fields.Abstract);
        public Image EmotionImage { get; set; }
        public bool NotClickable => Content.Value<bool>(Constants.DocumentTypes.BasePage.Fields.NotClickable);
        public bool HideFromNavi => Content.Value<bool>(Constants.DocumentTypes.BasePage.Fields.HideFromNavi);
        public Link RedirectLink { get; set; }

        public string MainContent => Content.Value<string>(Constants.DocumentTypes.BasePage.Fields.MainContent);



        public HeaderConfig HeaderConfig { get; set; }


        public BasePage(IPublishedContent content) : base(content)
        {
        }
    }
}
