using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sss.BasicHomePage.Models.Constants
{
    public static class DocumentTypes
    {
        public static class BasePage
        {
            public const string DocumentTypeAlias = "basePage";
            public static class Fields
            {
                public const string Title = "title";
                public const string Abstract = "abstract";
                public const string NotClickable = "notClickable";
                public const string HideFromNavi = "hideFromNavi";
                public const string MainContent = "mainContent";
                public const string SearchEngineRelativePriority = "searchEngineRelativePriority";
                public const string SearchEngineChangeFrequency = "searchEngineChangeFrequency";
                public const string HideFromXmlSitemap = "hideFromXmlSitemap";
                public const string MetaDescription = "metaDescription";
                public const string MetaKeywords = "metaKeywords";
                public const string EmotionImage = "emotionImage";
            }

        }


        public static class SeoConfig
        {
            public const string DocumentTypeAlias = "seoConfig";


            public static class Fields
            {

                public const string MetaDescription = "metaDescription";
                public const string MetaKeywords = "metaKeywords";
            }
        }

 

        public static class ArticlePage
        {
            public const string DocumentTypeAlias = "articlePage";
            public static class Fields
            {
                public const string Title = "title";
            }


        } 
    }
}
