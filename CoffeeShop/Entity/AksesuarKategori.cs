using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoffeeShop.Entity
{
    public class AksesuarKategori
    {
        [Key]
        public int AksesuarKategorId { get; set; }
        public string kategoriName { get; set; }
        public string Aciklama { get; set; }

        public List<AksesuarUrun> AksesuarUrunler { get; set; }
    }
}