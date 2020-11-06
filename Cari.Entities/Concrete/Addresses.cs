using Cari.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cari.Entities.Concrete
{
    public class Addresses: IEntity
    {
        [Key]
        public int AddressID { get; set; }
        public string Address { get; set; }

        [ForeignKey("PersonAdress")]
        public int PersonID { get; set; }
        public Person PersonAdress { get; set; }
    }
}
