using System.Web;
using System.Web.Mvc;
using WEBAPI_Execption.CustomFilterRepo;

namespace WEBAPI_Execption
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
             
            filters.Add(new HandleErrorAttribute());
        }
    }
}
