using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models.PublishedContent;

namespace Sss.BasicHomePage.Models.PageModels
{
    public class ArticlePage : BasePage
    {
        public ArticlePage(IPublishedContent content) : base(content)
        {
        }
    }
}
