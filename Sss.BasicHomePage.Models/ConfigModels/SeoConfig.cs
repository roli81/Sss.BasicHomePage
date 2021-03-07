using Sss.BasicHomePage.Models.Poco;

namespace Sss.BasicHomePage.Models.ConfigModels
{
    public class SeoConfig
    {
		public Image Logo { get; set; }

        public string MetaDescription
        {
            get;
            set;
        }

        public string MetaKeywords
        {
            get;
            set;
        }
	}
}