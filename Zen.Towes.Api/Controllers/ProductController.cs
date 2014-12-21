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

        public IEnumerable<Product> Get()
        {
            return _productBll.Get();
        }

        [HttpPost]
        public void Post(Product product)
        {
            _productBll.Save(product);
        }
    }
}
