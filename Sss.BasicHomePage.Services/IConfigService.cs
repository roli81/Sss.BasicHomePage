using Sss.BasicHomePage.Models.ConfigModels;
using Umbraco.Core.Models.PublishedContent;

namespace Sss.BasicHomePage.Services
{
    public interface IConfigService
    {
        HeaderConfig GetHeaderConfig();
        string GetAppSetting(string key);
        int GetIntAppSetting(string key);
        bool GetBoolAppSetting(string key);

        SeoConfig GetSeoConfig();

    }
}