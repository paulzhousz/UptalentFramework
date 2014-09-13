using System.Collections;

namespace UptalentFramework
{
    public static class Constants
    {
        public static string RouteName
        {
            get { return "Localization"; }
        }

        public static string RouteParamnameLang
        {
            get { return "lang"; }
        }

        public static string CookieName
        {
            get { return "Uptalent.CurrentLanguage"; }
        }

        public static string ConnstringDefaultName
        {
            get { return "UptalentApp"; }
        }

        public static Hashtable SupportLangsList
        {
            get { 
                return new Hashtable{
                {"en-US","English"}, 
                {"zh-CN","简体中文"}, 
                {"zh-TW","繁體中文"}};
            }
        }

        public static string DefaultLang
        {
            get { return "en-US"; }
        }



        public static string LocalStringTableName
        {
            get { return "Resource"; }
        }

        public static string aa = "Resource"; 

        public static string LocalStringTablePrimarykey
        {
            get { return "Key"; }
        }

        public static bool LocalStringTablePKautoIncrement
        {
            get { return false; }
        }
    }
}