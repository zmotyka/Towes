using System.Collections.Generic;
using System.Data.Entity;
using Zen.Towes.Model;
using System.Linq;

namespace Zen.Towes.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> Get();
        void Save(Product product);
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(DbContext dbContext)
            : base(dbContext)
        {
        }

        public IEnumerable<Product> Get()
        {
            return base.GetAll().ToList();
        }

        public void Save(Product product)
        {
            base.Add(product);
        }
    }
}
