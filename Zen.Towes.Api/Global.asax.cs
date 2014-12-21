using Ninject;
using Ninject.Web.Common;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Zen.Towes.Api.IoCConfig;

namespace Zen.Towes.Api
{
    public class WebApiApplication : NinjectHttpApplication
    {
        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();

            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected override IKernel CreateKernel()
        {
            return KernelConfig.InitializeKernel();
        }
    }
}
