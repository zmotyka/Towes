using System;
using System.Collections.Generic;
using Zen.Towes.Model;
using Zen.Towes.Repository;
using System.Linq;
using System.IO;

namespace Zen.Towes.Bll
{
    public interface IProductBll
    {
        Product GetProduct(int id);
        IEnumerable<Product> GetProducts();
        void Save(Product product);
    }

    public class ProductBll : IProductBll
    {
        private const string DefaultImgSrcPrefix = "./img/products/";
        private readonly IProductRepository _productRepository;

        public ProductBll(
            IProductRepository productRepository
            )
        {
            _productRepository = productRepository;
        }

        public Product GetProduct(int id)
        {
            return _productRepository.GetProduct(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productRepository.GetProducts().OrderBy(p => p.Name);
        }

        public void Save(Product product)
        {
            product.CreatedOn = DateTime.UtcNow;
            product.CreatedBy = "Zenon Motyka";

            var imgFileName = string.Format("{0}.png", product.Name.Replace(' ', '_'));
            product.ImgSrc = Path.Combine(DefaultImgSrcPrefix, imgFileName);

            _productRepository.Save(product);
        }
    }
}
