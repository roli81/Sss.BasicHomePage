using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Web.Composing;
using Umbraco.Web;

namespace Sss.BasicHomePage.ServicesImpl
{
    public class BaseService
    {
        protected UmbracoHelper CurrentHelper => Current.UmbracoHelper;
        protected UmbracoContext CurrentContext => Current.UmbracoContext;
    }
}
