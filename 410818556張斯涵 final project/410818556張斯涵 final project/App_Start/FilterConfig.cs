using System.Web;
using System.Web.Mvc;

namespace _410818556張斯涵_final_project
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
