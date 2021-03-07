using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sss.BasicHomePage.Services;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace Sss.BasicHomePage.Controllers
{
    public class XmlSitemapController : RenderMvcController
    {
        private readonly IXmlSitemapService _xmlSitemapService;

        public XmlSitemapController(IXmlSitemapService xmlSitemapService)
        {
            _xmlSitemapService = xmlSitemapService;
        }


        // GET: XmlSitemap
        public ActionResult Index(ContentModel model)
        {
            return View("~/Views/XmlSiteMap.cshtml", _xmlSitemapService.GetSitemap(model.Content));
        }
    }
}