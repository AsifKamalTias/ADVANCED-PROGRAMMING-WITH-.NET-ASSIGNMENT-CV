using System.Web;
using System.Web.Mvc;

namespace ADVANCED__PROGRAMMING_WITH.NET_ASSIGNMENT_CV
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
