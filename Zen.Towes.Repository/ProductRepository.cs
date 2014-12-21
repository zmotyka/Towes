using System.Collections.Generic;
using System.Data.Entity;
using Zen.Towes.Model;

namespace Zen.Towes.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> Get();
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(DbContext dbContext)
            : base(dbContext)
        {
        }

        public IEnumerable<Product> Get()
        {
            return new[] 
            { 
                new Product { Id = 1, Name = "First Street chicken boneless breast with rib meat", ImgSrc = "./img/products/2.jpg" },
                new Product { Id = 2, Name = "Szynka drobiowa Duda 200g", ImgSrc = "./img/products/1.jpg" },
                new Product { Id = 3, Name = "Szynka drobiowa Duda 200g", ImgSrc = "./img/products/1.jpg" },
            };
        }
    }
}
