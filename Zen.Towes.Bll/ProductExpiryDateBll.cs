using System;
using System.Collections.Generic;
using Zen.Towes.Model;
using Zen.Towes.Repository;
using System.Linq;
using System.IO;

namespace Zen.Towes.Bll
{
    public interface IProductExpiryDateBll
    {
        IEnumerable<ProductExpiryDate> Get();
        IEnumerable<ProductExpiryDate> GetForProduct(int productId);
    }

    public class ProductExpiryDateBll : IProductExpiryDateBll
    {
        private readonly IProductExpiryDateRepository _productExpiryDateRepository;

        public ProductExpiryDateBll(
            IProductExpiryDateRepository productExpiryDateRepository
            )
        {
            _productExpiryDateRepository = productExpiryDateRepository;
        }

        public IEnumerable<ProductExpiryDate> Get()
        {
            return _productExpiryDateRepository.Get().OrderBy(p => p.DueDate);
        }

        public IEnumerable<ProductExpiryDate> GetForProduct(int productId)
        {
            return _productExpiryDateRepository.GetForProduct(productId).OrderBy(p => p.DueDate);
        }
    }
}
