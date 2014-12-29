using System.Collections.Generic;
using System.Web.Http;
using Zen.Towes.Bll;
using Zen.Towes.Model;

namespace Zen.Towes.Api.Controllers
{
    public class ExpiryDateController : ApiController
    {
        private readonly IExpiryDateBll _expiryDateBll;

        public ExpiryDateController(
            IExpiryDateBll expiryDateBll
            )
        {
            _expiryDateBll = expiryDateBll;
        }

        //public IEnumerable<ExpiryDate> Get()
        //{
        //    return _expiryDateBll.Get();
        //}

        [HttpPost]
        public void Post(ExpiryDate expiryDate)
        {
            _expiryDateBll.Save(expiryDate);
        }
    }
}
