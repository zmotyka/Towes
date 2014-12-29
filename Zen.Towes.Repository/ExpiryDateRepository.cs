using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Zen.Towes.Model;

namespace Zen.Towes.Repository
{
    public interface IExpiryDateRepository
    {
        //IEnumerable<ExpiryDate> Get();
        void Save(ExpiryDate expiryDate);
    }

    public class ExpiryDateRepository : RepositoryBase<ExpiryDate>, IExpiryDateRepository
    {
        public ExpiryDateRepository(DbContext dbContext)
            : base(dbContext)
        {
        }

        //public IEnumerable<ExpiryDate> Get()
        //{
        //    return base.GetAll().ToList();
        //}

        public void Save(ExpiryDate expiryDate)
        {
            base.Add(expiryDate);
        }
    }
}
