using Abp.Web.Mvc.Controllers;

namespace SmartCook.Web.Controllers
{
    public abstract class SmartCookControllerBase : AbpController
    {
        protected SmartCookControllerBase()
        {
            LocalizationSourceName = "SmartCook";
        }
    }
}