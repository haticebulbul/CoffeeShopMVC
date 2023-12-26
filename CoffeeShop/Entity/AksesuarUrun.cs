using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoffeeShop.Entity
{
    public class AksesuarUrun
    {
        [Key]
        public int urunId { get; set; }
        public string UrunName { get; set; }
        public string urunType { get; set; }
        public string urunAciklama { get; set; }
        public double urunFiyat { get; set; }
        public int urunStok { get; set; }
        public string Resim { get; set; }
        public int AksesuarKategoriId { get; set; }
        public AksesuarKategori Aksesuarkategori { get; set; }
    }
}