using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Cari.Entities.Concrete;

namespace Cari.DataAccess.Concrete.EntityFramework
{
    public class CariContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Cari;Integrated Security=True");
        }

       
        public DbSet<Users> Users { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Phones> Phones { get; set; }
        public DbSet<Addresses> Addresses { get; set; }
    }
}
