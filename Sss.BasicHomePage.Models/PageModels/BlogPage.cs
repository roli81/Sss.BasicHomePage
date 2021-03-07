using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models.PublishedContent;

namespace Sss.BasicHomePage.Models.PageModels
{
    public class BlogPage : BasePage
    {
        public BlogPage(IPublishedContent content) : base(content)
        {
        }
    }
}
