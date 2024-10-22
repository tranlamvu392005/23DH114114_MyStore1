using System.Web;
using System.Web.Mvc;

namespace _23DH114114_MyStore1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
