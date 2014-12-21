using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zen.Towes.Model;
using Zen.Towes.Repository;

namespace Zen.Towes.Bll
{
    public interface IProductBll
    {
        IEnumerable<Product> Get();
    }

    public class ProductBll : IProductBll
    {
        private readonly IProductRepository _productRepository;

        public ProductBll(
            IProductRepository productRepository
            )
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> Get()
        {
            return _productRepository.Get();
        }
    }
}
