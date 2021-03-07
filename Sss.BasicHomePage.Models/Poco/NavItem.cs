using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sss.BasicHomePage.Models.Poco
{
    public class NavItem
    {
        public bool HideFromNavigation { get; set; }
        public bool Clickable { get; set; }
        public Link Link { get; set; }
        public IEnumerable<NavItem> Children { get; set; }
    }
}
