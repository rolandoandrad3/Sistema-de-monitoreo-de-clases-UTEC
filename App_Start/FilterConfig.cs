using System.Web;
using System.Web.Mvc;

namespace Sistema_de_monitoreo_de_clases_UTEC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
