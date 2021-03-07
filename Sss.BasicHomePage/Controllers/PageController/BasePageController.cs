using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sss.BasicHomePage.Models.Constants;
using Sss.BasicHomePage.Models.PageModels;
using Sss.BasicHomePage.Services;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace Sss.BasicHomePage.Controllers.PageController
{
    public class BasePageController : RenderMvcController
    {
        private readonly IConfigService _configurationService;
        private readonly IImageService _imageService;
        public BasePageController(IConfigService configurationService, IImageService imageService)
        {
            _imageService = imageService;
            _configurationService = configurationService;
        }




        // GET: BasePage
        public ActionResult Index<T>(BasePage basePage) where T : BasePage
        {
            basePage.HeaderConfig = _configurationService.GetHeaderConfig();
            basePage.EmotionImage = basePage.Content.HasValue(DocumentTypes.BasePage.Fields.EmotionImage)
                ? _imageService.GetImage(
                    basePage.Content.Value<IPublishedContent>(DocumentTypes.BasePage.Fields.EmotionImage), width: 500, height:400)
                : null;
            return base.Index(basePage as T);
        }
    }
}