using System.Collections.Generic;
using Sss.BasicHomePage.Models.PageModels;
using Umbraco.Core.Models.PublishedContent;

namespace Sss.BasicHomePage.Services
{
    public interface IXmlSitemapService
    {
        IEnumerable<BasePage> GetSitemap(IPublishedContent model);
    }
}