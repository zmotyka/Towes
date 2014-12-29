using System.Collections.Generic;
using System.Web.Http;
using Zen.Towes.Bll;
using Zen.Towes.Model;

namespace Zen.Towes.Api.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IProductBll _productBll;

        public ProductController(
            IProductBll productBll
            )
        {
            _productBll = productBll;
        }

        [ActionName("GetAll")]
        public IEnumerable<Product> GetProducts()
        {
            return _productBll.GetProducts();
        }

        [ActionName("Get")]
        public Product GetProduct(int id)
        {
            return _productBll.GetProduct(id);
        }

        [HttpPost]
        public void Post(Product product)
        {
            _productBll.Save(product);
        }
    }
}
