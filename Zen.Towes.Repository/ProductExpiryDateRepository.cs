using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Zen.Towes.Model;

namespace Zen.Towes.Repository
{
    public interface IProductExpiryDateRepository
    {
        IEnumerable<ProductExpiryDate> Get();
        IEnumerable<ProductExpiryDate> GetForProduct(int productId);
    }

    public class ProductExpiryDateRepository : RepositoryBase<ProductExpiryDate>, IProductExpiryDateRepository
    {
        public ProductExpiryDateRepository(DbContext dbContext)
            : base(dbContext)
        {
        }

        public IEnumerable<ProductExpiryDate> Get()
        {
            return base.GetAll().ToList();
        }

        public IEnumerable<ProductExpiryDate> GetForProduct(int productId)
        {
            return base.FindAll(p => p.ProductId == productId).ToList();
        }
    }
}
