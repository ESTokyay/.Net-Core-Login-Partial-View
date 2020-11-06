using Cari.Business.Abstract;
using Cari.Core.Business;
using Cari.DataAccess.Abstract;
using Cari.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Cari.Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserDal _userDal;

        public UserService(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public void Add(Users entity)
        {
            _userDal.Add(entity);
           
        }

        public void Delete(Users entity)
        {
            _userDal.Delete(entity);
        }

        public Users Get(Expression<Func<Users, bool>> filter = null)
        {
            return _userDal.Get(filter);
        }

        public List<Users> GetList(Expression<Func<Users, bool>> filter = null)
        {
            return _userDal.GetList(filter);
        }

        public void Update(Users entity)
        {
            _userDal.Update(entity);
        }
    }
}
