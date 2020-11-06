using Cari.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cari.Entities.Concrete
{
    public class Person: IEntity
    {
        [Key]
        public int PersonID { get; set; }
        public string Title { get; set; }  //ünvanı

        public List<Phones> Phones { get; set; }
        public List<Addresses>Addresses { get; set; }
    }
}
