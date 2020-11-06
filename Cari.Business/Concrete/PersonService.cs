using Cari.Business.Abstract;
using Cari.DataAccess.Abstract;
using Cari.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Cari.Business.Concrete
{
    public class PersonService : IPersonService
    {
        public readonly IPersonDal _personDal;
        public PersonService(IPersonDal personDal) 
        {
            _personDal = personDal;
        }
        public void Add(Person entity)
        {
            _personDal.Add(entity);
        }

        public void Delete(Person entity)
        {
            _personDal.Delete(entity);
        }

        public Person Get(Expression<Func<Person, bool>> filter = null)
        {
            return _personDal.Get(filter);
        }

        public List<Person> GetList(Expression<Func<Person, bool>> filter = null)
        {
            return _personDal.GetList(filter);
        }

        public void Update(Person entity)
        {
            _personDal.Update(entity);
        }
    }
}
