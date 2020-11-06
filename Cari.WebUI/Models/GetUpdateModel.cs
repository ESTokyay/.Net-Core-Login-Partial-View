using Cari.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cari.WebUI.Models
{
    public class GetUpdateModel
    {
        public string Unvan { get; set; }
        public List<double> Phones { get; set; }
    }
}
