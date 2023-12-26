using CoffeeShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop.Models
{
    public class Cart
    {
        private List<CartLine> _cardLines = new List<CartLine>();
        public List<CartLine> CartLines
        {
            get { return _cardLines; }
        }

        public void AddUrun(Urun urun, int quantity)
        {
            var line = _cardLines
                .Where(i => i.Urun != null && i.Urun.urunId == urun.urunId)
                .FirstOrDefault();

            if (line == null)
            {
                _cardLines.Add(new CartLine { Urun = urun, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void AddAksesuarUrun(AksesuarUrun aksesuarurun, int quantity)
        {
            var line = _cardLines
                .Where(i => i.AksesuarUrun != null && i.AksesuarUrun.urunId == aksesuarurun.urunId)
                .FirstOrDefault();

            if (line == null)
            {
                _cardLines.Add(new CartLine { AksesuarUrun = aksesuarurun, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void AddUrunAndAksesuarUrun(Urun urun, AksesuarUrun aksesuarurun, int quantityUrun, int quantityAksesuarUrun)
        {
            var line = _cardLines
                .Where(i => i.Urun != null && i.Urun.urunId == urun.urunId && i.AksesuarUrun != null && i.AksesuarUrun.urunId == aksesuarurun.urunId)
                .FirstOrDefault();

            if (line == null)
            {
                _cardLines.Add(new CartLine { Urun = urun, Quantity = quantityUrun, AksesuarUrun = aksesuarurun, QuantityAksesuarUrun = quantityAksesuarUrun });
            }
            else
            {
                line.Quantity += quantityUrun;
                line.QuantityAksesuarUrun += quantityAksesuarUrun;
            }
        }

        public void DeleteUrun(Urun urun)
        {
            _cardLines.RemoveAll(i => i.Urun != null && i.Urun.urunId == urun.urunId);
        }

        public void DeleteAksesuarUrun(AksesuarUrun aksesuarurun)
        {
            _cardLines.RemoveAll(i => i.AksesuarUrun != null && i.AksesuarUrun.urunId == aksesuarurun.urunId);
        }

        public void DeleteUrunAndAksesuarUrun(Urun urun, AksesuarUrun aksesuarurun)
        {
            _cardLines.RemoveAll(i => i.Urun != null && i.Urun.urunId == urun.urunId && i.AksesuarUrun != null && i.AksesuarUrun.urunId == aksesuarurun.urunId);
        }

        public decimal Total()
        {
            return _cardLines.Sum(i => i.Urun != null ? (decimal)(i.Urun.urunFiyat * i.Quantity) : 0)
                 + _cardLines.Sum(i => i.AksesuarUrun != null ? (decimal)(i.AksesuarUrun.urunFiyat * i.Quantity) : 0);
        }

        public void Clear()
        {
            _cardLines.Clear();
        }
    }

    public class CartLine
    {
        public Urun Urun { get; set; }
        public AksesuarUrun AksesuarUrun { get; set; }
        public int Quantity { get; set; }
        public int QuantityAksesuarUrun { get; set; }
    }
}






//namespace CoffeeShop.Models
//{
//    public class Cart
//    {
//        private List<CartLine> _cardLines = new List<CartLine>();
//        public List<CartLine> CartLines
//        {
//            get { return _cardLines; }
//        }
//        //public void AddUrun(Urun urun, int quantity)
//        //{
//        //    var line = _cardLines.Where(i => i.Urun.urunId == urun.urunId).FirstOrDefault();

//        //    if (line == null)
//        //    {
//        //        _cardLines.Add(new CartLine { Urun = urun, Quantity = quantity });
//        //    }
//        //    else
//        //    {
//        //        line.Quantity += quantity;
//        //    }
//        //}
//        public void AddAksesuarUrun(AksesuarUrun aksesuarurun, int quantity)
//        {
//            var line = _cardLines.Where(i => i.AksesuarUrun.urunId == aksesuarurun.urunId).FirstOrDefault();

//            if (line == null)
//            {
//                _cardLines.Add(new CartLine { AksesuarUrun = aksesuarurun, Quantity = quantity });
//            }
//            else
//            {
//                line.Quantity += quantity;
//            }
//        }


//        //{
//        //    var line = _cardLines.Where(i => i.Urun.urunId == urun.urunId && i.AksesuarUrun.urunId == aksesuarurun.urunId).FirstOrDefault();

//        //    if (line == null)
//        //    {
//        //        _cardLines.Add(new CartLine { Urun = urun, Quantity = quantity, AksesuarUrun = aksesuarurun, AksQuantity = aksquantity });
//        //    }
//        //    else
//        //    {
//        //        line.Quantity += quantity;
//        //        line.AksQuantity += aksquantity;
//        //    }


//        //public void DeleteUrun(Urun urun)
//        //{
//        //    _cardLines.RemoveAll(i => i.Urun.urunId == urun.urunId);
//        //}
//        public void DeleteAksesuarUrun(AksesuarUrun aksesuarurun)
//        {
//            _cardLines.RemoveAll(i => i.AksesuarUrun.urunId == aksesuarurun.urunId);
//        }
//        //{
//        //    _cardLines.RemoveAll(i => i.Urun.urunId == urun.urunId && i.AksesuarUrun.urunId == aksesuarurun.urunId);
//        //}

//        //public decimal Total()
//        //{
//        //    return _cardLines.Sum(i => (decimal)(i.Urun.urunFiyat * i.Quantity));

//        //}
//        public decimal Total2()
//        {
//            return _cardLines.Sum(i => (decimal)(i.AksesuarUrun.urunFiyat * i.Quantity));

//        }


//        public void Clear()
//        {
//            _cardLines.Clear();
//        }
//    }

//    public class CartLine
//    {
//        public Urun Urun { get; set; }
//        public AksesuarUrun AksesuarUrun { get; set; }
//        public int Quantity { get; set; }
//        public int AksQuantity { get; set; }
//    }
//}



//namespace CoffeeShop.Models
//{
//    public class Cart
//    {
//        private List<CartLine> _cardLines = new List<CartLine>();
//        public List<CartLine> CartLines
//        {
//            get { return _cardLines; }
//        }

//        public void AddUrun(Urun urun, int quantity)
//        {
//            var line = _cardLines
//                .Where(i => i.Urun != null && i.Urun.urunId == urun.urunId)
//                .FirstOrDefault();

//            if (line == null)
//            {
//                _cardLines.Add(new CartLine { Urun = urun, Quantity = quantity });
//            }
//            else
//            {
//                line.Quantity += quantity;
//            }
//        }

//        public void AddAksesuarUrun(AksesuarUrun aksesuarurun, int quantity)
//        {
//            var line = _cardLines
//                .Where(i => i.AksesuarUrun != null && i.AksesuarUrun.urunId == aksesuarurun.urunId)
//                .FirstOrDefault();

//            if (line == null)
//            {
//                _cardLines.Add(new CartLine { AksesuarUrun = aksesuarurun, Quantity = quantity });
//            }
//            else
//            {
//                line.Quantity += quantity;
//            }
//        }

//        public void AddUrunAndAksesuarUrun(Urun urun, AksesuarUrun aksesuarurun, int quantityUrun, int quantityAksesuarUrun)
//        {
//            var line = _cardLines
//                .Where(i => i.Urun != null && i.Urun.urunId == urun.urunId && i.AksesuarUrun != null && i.AksesuarUrun.urunId == aksesuarurun.urunId)
//                .FirstOrDefault();

//            if (line == null)
//            {
//                _cardLines.Add(new CartLine { Urun = urun, Quantity = quantityUrun, AksesuarUrun = aksesuarurun, QuantityAksesuarUrun = quantityAksesuarUrun });
//            }
//            else
//            {
//                line.Quantity += quantityUrun;
//                line.QuantityAksesuarUrun += quantityAksesuarUrun;
//            }
//        }

//        public void DeleteUrun(Urun urun)
//        {
//            _cardLines.RemoveAll(i => i.Urun != null && i.Urun.urunId == urun.urunId);
//        }

//        public void DeleteAksesuarUrun(AksesuarUrun aksesuarurun)
//        {
//            _cardLines.RemoveAll(i => i.AksesuarUrun != null && i.AksesuarUrun.urunId == aksesuarurun.urunId);
//        }

//        public void DeleteUrunAndAksesuarUrun(Urun urun, AksesuarUrun aksesuarurun)
//        {
//            _cardLines.RemoveAll(i => i.Urun != null && i.Urun.urunId == urun.urunId && i.AksesuarUrun != null && i.AksesuarUrun.urunId == aksesuarurun.urunId);
//        }

//        public decimal Total()
//        {
//            return _cardLines.Sum(i => i.Urun != null ? (decimal)(i.Urun.urunFiyat * i.Quantity) : 0)
//                 + _cardLines.Sum(i => i.AksesuarUrun != null ? (decimal)(i.AksesuarUrun.urunFiyat * i.Quantity) : 0);
//        }

//        public void Clear()
//        {
//            _cardLines.Clear();
//        }
//    }

//    public class CartLine
//    {
//        public Urun Urun { get; set; }
//        public AksesuarUrun AksesuarUrun { get; set; }
//        public int Quantity { get; set; }
//        public int QuantityAksesuarUrun { get; set; }
//    }
//}

