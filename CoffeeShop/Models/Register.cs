using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoffeeShop.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Adınız")]
        public string Isim { get; set; }
        [Required]
        [DisplayName("Soyadınız")]
        public string Soyisim { get; set; }
        [Required]
        [DisplayName("Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }
        [Required]
        [DisplayName("Eposta")]
        [EmailAddress(ErrorMessage ="Eposta adresinizi doğru girdiğinize mein olunuz.")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Şifre")]
        public string Sifre { get; set; }
        [Required]
        [DisplayName("Şifre Tekrar")]
        [Compare("Sifre",ErrorMessage ="Şifreleriniz uyuşmuyor.")]
        public string SifreTekrar { get; set; }

    }
}