using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Db tabloları ile proje class larını ilişkilendirmek
    public class MyDatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //Proje hangi veri tabanı ile ilişkili onu belirtiyor
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=MyDatabase; Trusted_Connection = true");
        }
            public DbSet<Car> Cars { get; set; }
            public DbSet<Color> Colors { get; set; }
            public DbSet<Brand> Brands { get; set; }

        
    } 
    
}
