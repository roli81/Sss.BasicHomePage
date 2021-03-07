using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Sss.BasicHomePage.Models.Poco;
using Sss.BasicHomePage.Services;
using Umbraco.Web;

namespace Sss.BasicHomePage.ServicesImpl
{
    public class NavigationService : BaseService, INavigationService
    {
        public IEnumerable<NavItem> GetMainNavigation()
        {
            var startPage = CurrentHelper.ContentAtRoot().FirstOrDefault(c => c.ContentType.Alias == "homePage");


            if (startPage == null || !startPage.Children.Any())
            {
                return new List<NavItem>();
            }

            return startPage?.Children.Where(c => c.ContentType.CompositionAliases.Contains("basePage"))
                .Select(c => new NavItem()
                {
                    HideFromNavigation = c.Value<bool>("hideFromNavi"),
                    Link = new Link()
                    {
                        Text = c.Name,
                        Href = c.Url(),

                    },
                    Children = c.Children.Where(cld => cld.ContentType.CompositionAliases.Contains("basePage"))
                        .Select(cld => new NavItem()
                        {
                            HideFromNavigation = cld.Value<bool>("hideFromNavi"),
                            Link = new Link()
                            {
                                Text = cld.Name,
                                Href = cld.Url(),

                            }

                        }).Where(ni => !ni.HideFromNavigation)
                }).Where(ni => !ni.HideFromNavigation);
        }
    }
}
