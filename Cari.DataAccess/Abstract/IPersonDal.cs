using Cari.Core.DataAccess;
using Cari.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cari.DataAccess.Abstract
{
    public interface IPersonDal: IEntityRepository<Person>
    {
    }
}
