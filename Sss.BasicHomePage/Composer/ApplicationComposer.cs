using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sss.BasicHomePage.Services;
using Sss.BasicHomePage.ServicesImpl;
using Umbraco.Core.Composing;

namespace Sss.BasicHomePage.Composer
{
    public class ApplicationComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register(typeof(IConfigService), typeof(ConfigService), Lifetime.Scope);
            composition.Register(typeof(IImageService), typeof(ImageService), Lifetime.Scope);
            composition.Register(typeof(INavigationService), typeof(NavigationService), Lifetime.Scope);
            composition.Register(typeof(IXmlSitemapService), typeof(XmlSitemapService), Lifetime.Scope);
        }
    }
}