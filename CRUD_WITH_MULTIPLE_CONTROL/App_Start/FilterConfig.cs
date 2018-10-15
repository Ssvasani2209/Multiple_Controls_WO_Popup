using System.Web;
using System.Web.Mvc;

namespace CRUD_WITH_MULTIPLE_CONTROL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
