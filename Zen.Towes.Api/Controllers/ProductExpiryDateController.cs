using System.Collections.Generic;
using System.Web.Http;
using Zen.Towes.Bll;
using Zen.Towes.Model;

namespace Zen.Towes.Api.Controllers
{
    public class ProductExpiryDateController : ApiController
    {
        private readonly IProductExpiryDateBll _productExpiryDateBll;

        public ProductExpiryDateController(
            IProductExpiryDateBll productExpiryDateBll
            )
        {
            _productExpiryDateBll = productExpiryDateBll;
        }

        [ActionName("Get")]
        public IEnumerable<ProductExpiryDate> Get()
        {
            return _productExpiryDateBll.Get();
        }

        [ActionName("Get")]
        public IEnumerable<ProductExpiryDate> GetForProduct(int id)
        {
            return _productExpiryDateBll.GetForProduct(id);
        }
    }
}
