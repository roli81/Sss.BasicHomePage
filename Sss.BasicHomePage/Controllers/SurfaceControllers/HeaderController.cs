using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace Sss.BasicHomePage.Controllers.SurfaceControllers
{
    public class HeaderController : SurfaceController
    {
        // GET: Header
        public ActionResult Index()
        {
            return View("~/Views/Partials/Structure/Header.cshtml");
        }
    }
}