using System;
using System.Collections.Generic;
using Zen.Towes.Model;
using Zen.Towes.Repository;
using System.Linq;

namespace Zen.Towes.Bll
{
    public interface IProductBll
    {
        IEnumerable<Product> Get();
        void Save(Product product);
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
            return _productRepository.Get().OrderBy(p => p.Name);
        }

        public void Save(Product product)
        {
            product.CreatedOn = DateTime.UtcNow;
            product.CreatedBy = "Zenon Motyka";

            _productRepository.Save(product);
        }
    }
}
