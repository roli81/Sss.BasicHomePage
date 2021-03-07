using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sss.BasicHomePage.Services;
using Umbraco.Web.Mvc;

namespace Sss.BasicHomePage.Controllers.SurfaceControllers
{
    public class NavigationController : SurfaceController
    {
        private readonly INavigationService _navigationService;


        public NavigationController(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }


        // GET: Navigation
        public ActionResult Index()
        {
            return View("~/Views/Partials/Structure/Navigation.cshtml", _navigationService.GetMainNavigation());
        }
    }
}