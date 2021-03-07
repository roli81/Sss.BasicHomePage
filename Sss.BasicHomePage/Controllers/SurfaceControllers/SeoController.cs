﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sss.BasicHomePage.Services;
using Umbraco.Web.Mvc;

namespace Sss.BasicHomePage.Controllers.SurfaceControllers
{
    public class SeoController : SurfaceController
    {
        private readonly IConfigService _configService;

        public SeoController(IConfigService configService)
        {
            _configService = configService;
        }

        // GET: Seo

        public ActionResult Index()
        {
            return View("~/Views/Partials/Seo.cshtml", _configService.GetSeoConfig());
        }
    }
}