using System.Web;
using System.Web.Mvc;

namespace BootStrap_V5UpdateTest
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
