using Ninject.Modules;
using Ninject.Web.Common;
using System.Data.Entity;
using Zen.Towes.Model;

namespace Zen.Towes.Repository.IoCConfig
{
    public class NinjectModuleConfig : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(DbContext)).To(typeof(TowesEntity)).InRequestScope();

            Bind<IProductRepository>().To<ProductRepository>();
            Bind<IExpiryDateRepository>().To<ExpiryDateRepository>();
            Bind<IProductExpiryDateRepository>().To<ProductExpiryDateRepository>();
        }
    }
}
