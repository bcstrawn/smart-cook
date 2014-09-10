using System.Web;
using Abp.Localization.Sources.Xml;

namespace SmartCook.Web.Localization.SmartCook
{
    public class SmartCookLocalizationSource : XmlLocalizationSource
    {
        public SmartCookLocalizationSource()
            : base("SmartCook", HttpContext.Current.Server.MapPath("/Localization/SmartCook"))
        {
        }
    }
}