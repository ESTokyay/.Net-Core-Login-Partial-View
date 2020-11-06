using Cari.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cari.Entities.Concrete
{
    public class Phones: IEntity
    {
        [Key]
        public int PhoneID { get; set; }
        public double Number { get; set; }

        [ForeignKey("PersonNumber")]
        public int PersonID { get; set; }
        public Person PersonNumber { get; set; }
    }
}
