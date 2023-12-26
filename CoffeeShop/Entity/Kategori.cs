using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop.Entity
{
    public class Kategori
    {
        public int Id { get; set; } 
        public string kategoriName { get; set; }
        public string Aciklama { get; set; }

        public List<Urun>Urunler { get; set; }


    }
}