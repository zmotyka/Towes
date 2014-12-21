using Ninject;
using Ninject.Web.Common;
using System.Web.Http;
using System.Web.Mvc;
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
        }

        protected override IKernel CreateKernel()
        {
            return KernelConfig.InitializeKernel();
        }
    }
}
