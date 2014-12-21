using Ninject;
using Ninject.Modules;

namespace Zen.Towes.Api.IoCConfig
{
    public static class KernelConfig
    {
        public static IKernel InitializeKernel()
        {
            var modules = new NinjectModule[]
            {
                new Zen.Towes.Repository.IoCConfig.NinjectModuleConfig(),
                new Zen.Towes.Bll.IoCConfig.NinjectModuleConfig()
            };

            var kernel = new StandardKernel(modules);

            return kernel;
        }
    }
}