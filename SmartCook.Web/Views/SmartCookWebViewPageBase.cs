using Abp.Web.Mvc.Views;

namespace SmartCook.Web.Views
{
    public abstract class SmartCookWebViewPageBase : SmartCookWebViewPageBase<dynamic>
    {

    }

    public abstract class SmartCookWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SmartCookWebViewPageBase()
        {
            LocalizationSourceName = "SmartCook";
        }
    }
}