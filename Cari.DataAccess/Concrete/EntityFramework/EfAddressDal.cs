using Cari.Core.DataAccess.EntityFramework;
using Cari.DataAccess.Abstract;
using Cari.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cari.DataAccess.Concrete.EntityFramework
{
    public class EfAddressDal: EfEntityRepositoryBase<Addresses,CariContext>, IAddressDal
    {
    }
}
