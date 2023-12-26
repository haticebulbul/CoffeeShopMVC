using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Data.Entity;
using CoffeeShop.Identity;

namespace CoffeeShop.Entity
{
    public class DataContext:DbContext
    {
        public DataContext() :base("dataConnection") 
        {

            Database.SetInitializer(new DataInitializer());
            Database.SetInitializer<IdentityDataContex>(new IdentityInitializer());
        }
        public DbSet<Urun> Urun { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<AksesuarKategori> aksesuarKategoriler { get; set; }
        public DbSet<AksesuarUrun> AksesuarUrunler { get;set; }
        public DbSet<Hakkimizda> Hakkimizda { get; set; }

    }
}