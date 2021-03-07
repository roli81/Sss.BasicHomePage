using System.Web.Mvc;
using Sss.BasicHomePage.Models.PageModels;
using Sss.BasicHomePage.Services;
using Umbraco.Web.Models;

namespace Sss.BasicHomePage.Controllers.PageController
{
    public class HomePageController : BasePageController
    {
        // GET

        public HomePageController(IConfigService configurationService, IImageService imageService) : base(configurationService, imageService)
        {
            
        }

        public override ActionResult Index(ContentModel model)
        {


            return base.Index<HomePage>(new HomePage(model.Content));
        }
    }
}