﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop.Entity
{
    public class Urun
    {
        public int urunId { get; set; }
        public string urunName { get; set; }
        public string urunType { get; set;}
        public string urunAciklama { get; set; }
        public double urunFiyat { get; set; }
        public int urunStok { get; set; }
        public string Resim { get; set; }
        public int KategoriId { get; set; }
        public Kategori kategori { get; set;}



    }
}