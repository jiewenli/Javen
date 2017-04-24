using Abp.Web.Mvc.Views;

namespace Javen.Web.Views
{
    public abstract class JavenWebViewPageBase : JavenWebViewPageBase<dynamic>
    {

    }

    public abstract class JavenWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected JavenWebViewPageBase()
        {
            LocalizationSourceName = JavenConsts.LocalizationSourceName;
        }
    }
}