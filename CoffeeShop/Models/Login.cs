using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CoffeeShop.Models
{
    public class Login
    {
        [Required]
        [DisplayName("Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }
        [Required]
        [DisplayName("Eposta")]
        [EmailAddress(ErrorMessage = "Eposta adresinizi doğru girdiğinize mein olunuz.")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Şifre")]
        public string Sifre { get; set; }

        [DisplayName("Beni Hatırla")]
        public bool RememberMe { get; set; }

    }
}