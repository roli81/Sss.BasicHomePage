using System.Collections.Generic;
using Sss.BasicHomePage.Models.Poco;

namespace Sss.BasicHomePage.Services
{
    public interface INavigationService
    {
        IEnumerable<NavItem> GetMainNavigation();
    }
}