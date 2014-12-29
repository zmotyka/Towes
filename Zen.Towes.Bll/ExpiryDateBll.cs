using System;
using System.Collections.Generic;
using Zen.Towes.Model;
using Zen.Towes.Repository;
using System.Linq;
using System.IO;

namespace Zen.Towes.Bll
{
    public interface IExpiryDateBll
    {
        //IEnumerable<ExpiryDate> Get();
        void Save(ExpiryDate expiryDate);
    }

    public class ExpiryDateBll : IExpiryDateBll
    {
        private readonly IExpiryDateRepository _expiryDateRepository;

        public ExpiryDateBll(
            IExpiryDateRepository expiryDateRepository
            )
        {
            _expiryDateRepository = expiryDateRepository;
        }

        //public IEnumerable<ExpiryDate> Get()
        //{
        //    return _expiryDateRepository.Get().OrderBy(p => p.DueDate);
        //}

        public void Save(ExpiryDate expiryDate)
        {
            expiryDate.CreatedOn = DateTime.UtcNow;
            expiryDate.CreatedBy = "Zenon Motyka";

            _expiryDateRepository.Save(expiryDate);
        }
    }
}
