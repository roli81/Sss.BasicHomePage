using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sss.BasicHomePage.Models.PageModels;
using Sss.BasicHomePage.Services;
using Umbraco.Web.Models;

namespace Sss.BasicHomePage.Controllers.PageController
{
    public class BlogPageController : BasePageController
    {


        public BlogPageController(IConfigService configurationService, IImageService imageService) : base(configurationService, imageService)
        {
        }


        public override ActionResult Index(ContentModel model)
        {
            return base.Index<BlogPage>(new BlogPage(model.Content));
        }
    }
}