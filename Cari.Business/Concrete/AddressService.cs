using Cari.Business.Abstract;
using Cari.DataAccess.Abstract;
using Cari.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Cari.Business.Concrete
{
    public class AddressService : IAddressService
    {
        public readonly IAddressDal _addressDal;
        public AddressService(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }
        public void Add(Addresses entity)
        {
            _addressDal.Add(entity);
            
        }

        public void Delete(Addresses entity)
        {
            _addressDal.Delete(entity);
        }

        public Addresses Get(Expression<Func<Addresses, bool>> filter = null)
        {
            return _addressDal.Get(filter);
        }

        public List<Addresses> GetList(Expression<Func<Addresses, bool>> filter = null)
        {
            return _addressDal.GetList(filter);
        }

        public void Update(Addresses entity)
        {
            _addressDal.Update(entity);
        }
    }
}
