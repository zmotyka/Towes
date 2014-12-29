using Ninject.Modules;

namespace Zen.Towes.Bll.IoCConfig
{
    public class NinjectModuleConfig : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductBll>().To<ProductBll>();
            Bind<IExpiryDateBll>().To<ExpiryDateBll>();
            Bind<IProductExpiryDateBll>().To<ProductExpiryDateBll>();
        }
    }
}
