using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Zen.Towes.Model;

namespace Zen.Towes.Repository
{
    public interface IProductRepository
    {
        Product GetProduct(int id);
        IEnumerable<Product> GetProducts();
        void Save(Product product);
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(DbContext dbContext)
            : base(dbContext)
        {
        }

        public Product GetProduct(int id)
        {
            return base.Get(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return base.GetAll().ToList();
        }

        public void Save(Product product)
        {
            base.Add(product);
        }
    }
}
