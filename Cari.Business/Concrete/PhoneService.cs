using Cari.Business.Abstract;
using Cari.DataAccess.Abstract;
using Cari.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Cari.Business.Concrete
{
    public class PhoneService : IPhoneService
    {
        public readonly IPhoneDal _phoneDal;
        public PhoneService(IPhoneDal phoneDal)
        {
            _phoneDal = phoneDal;
        }
        public void Add(Phones entity)
        {
            _phoneDal.Add(entity);
        }

        public void Delete(Phones entity)
        {
            _phoneDal.Delete(entity);
        }

        public Phones Get(Expression<Func<Phones, bool>> filter = null)
        {
            return _phoneDal.Get(filter);
        }

        public List<Phones> GetList(Expression<Func<Phones, bool>> filter = null)
        {
            return _phoneDal.GetList(filter);
        }

        public void Update(Phones entity)
        {
            _phoneDal.Update(entity);
        }
    }
}
