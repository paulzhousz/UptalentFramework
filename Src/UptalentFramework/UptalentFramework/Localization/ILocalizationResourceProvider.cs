using System.Web;

namespace UptalentFramework.Localization
{
    public interface ILocalizationResourceProvider
    {
        string GetString(string cultureName, string key);

        string GetString(string key);

        IHtmlString GetHtmlString(string cultureName, string key);

        IHtmlString GetHtmlString(string key); 
    }
}