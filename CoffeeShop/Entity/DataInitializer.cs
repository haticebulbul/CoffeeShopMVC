using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CoffeeShop.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori() { kategoriName="Filtre Kahve",Aciklama="Filtre kahve tutkunları için özel olarak seçilmiş en kaliteli kahveleri sunan web sitemize hoş geldiniz. Biz, kahve severlerin damak zevkine hitap eden özenle seçilmiş kahve çeşitleri ile sohbetlerin, çalışmaların veya sadece keyif anlarının vazgeçilmez lezzetini sunuyoruz.Siz de kahvenin eşsiz dünyasına bir adım atmak istiyorsanız, doğru yerdesiniz! Filtre kahve çeşitlerimiz, dünya çapında özenle yetiştirilen kahve çekirdekleri ile hazırlanmaktadır. Her bir fincan, özel kavurma teknikleri ve uzmanlıkla seçilmiş çekirdeklerle özel bir lezzet deneyimi sunmaktadır." },
                new Kategori() { kategoriName="Çekirdek Kahve",Aciklama="Kahve Tutkunlarına Özel Çekirdek Kahveler!\r\n\"Kahve Tutkunlarına Özel Çekirdek Kahveler!\r\n\r\nHayalinizdeki kahve deneyimine bir adım daha yaklaşın! Web sitemiz, en taze ve kaliteli çekirdek kahve çeşitleri ile kahve tutkunlarına özel lezzetleri sunmaktadır. Her bir çekirdek, özenle seçilmiş kahve plantasyonlarından tedarik edilir ve uzmanlarımız tarafından özel kavurma teknikleriyle işlenir.\r\n\r\nÇekirdek kahve tutkunları için hazırladığımız özel koleksiyonumuz, farklı aroma profilleri ve vücutlarıyla her damak zevkine hitap eder. Siz de kahve deneyiminizi kişiselleştirmek ve özel bir lezzet arayışına girmek istiyorsanız, web sitemizdeki çekirdek kahve seçeneklerimizi keşfedin. " },
                new Kategori() { kategoriName="Kapsül Kahve",Aciklama="Pratik ve Lezzetli: Kapsül Kahve Dünyasında Yeni Bir Deneyim!Kapsül kahve koleksiyonumuz, dünya çapında özenle yetiştirilen kahve çekirdekleri ile hazırlanır ve özel kavurma teknikleri ile işlenir. Her bir kapsül, taze kahve aromalarını koruyarak, tek bir tuşla mükemmel bir fincan kahve elde etmenizi sağlar."},
             
            };
            foreach (var kategori in kategoriler)
            {
                context.Kategoriler.Add(kategori);
            }
            context.SaveChanges();

            List<Urun> urunler = new List<Urun>()
            {
              

                new Urun() { urunName="Filtre Kahve",urunType="filtre kahve",urunFiyat=130,urunStok=4,urunAciklama="ince çekimi yumuşak içimiyle lezzetli",KategoriId=1,Resim="FiltreKahve.jpg"},
                 new Urun() { urunName="Karamel Aromalı Filtre Kahve",urunType="filtre kahve",urunFiyat=160,urunStok=4,urunAciklama="Karamelin ruhunuzu saracak etkileyici kokusu ve her yudumda sizi çıkaracağı eşsiz yolculuğun başlangıç noktası Kahve Dünyası karamel aromalı filtre kahve paketinde!",KategoriId=1,Resim="KaramelAromaliFiltreKahve.jpg"},
                new Urun() { urunName="Fındık Aromalı Filtre Kahve ",urunType="filtre kahve",urunFiyat=160,urunStok=4,urunAciklama="Fındığın bitmeyen enerjisi, kahvenin mükemmel tadı ve duyularınızı harekete geçirecek fındık kokusu Kahve Dünyası Fındık Aromalı Filtre Kahvesi ile bu pakette buluştu!",KategoriId=1,Resim="FindikAromaliFiltreKahve.jpg"},
                new Urun() { urunName="Guatemala Yöresel Filtre Kahve",urunType="filtre kahve",urunFiyat=196 ,urunStok=4,urunAciklama="Guatemala yöresel kahve; bol asitli, orta kıvamlı ve yumuşak içimli, kendine özgü isli bir kokuya ve baharatlı bir tada sahip kahvedir.üksek kıvamlı gövdeye sahip, sizi maya kültürünün esintilerini hissedebileceğiniz Orta Amerika’ya götürecek Guatemala kahve çekirdekleri sanal mağazamızda bir tık uzağınızda.",KategoriId=1,Resim="GuatemalaYoreselFiltreKahve.jpg"},
                 new Urun() { urunName="Kosta Rika Yöresel Filtre Kahve ",urunType="filtre kahve",urunFiyat=129,urunStok=4,urunAciklama="Kosta Rika kahve çekirdeklerini değerli kılan düşük asiditesi, mükemmel yapısı ve karmaşık lezzetidir. Orta derecede kıvamı, çiçeksi, baharatlı tadı ve fındığı andıran aroması ile Kosta Rika kahvemiz bir tık uzağınızda.",KategoriId=1,Resim="KostaRikaYoreselFiltreKahve.jpg"},
                 new Urun() { urunName="Kafeinsiz (Decaf) Filtre Kahve",urunType="filtre kahve",urunFiyat=160,urunStok=4,urunAciklama="Kahveden vazgeçemeyenlere özel, damağınızda bırakacağı yumuşacık kahve tadı ve kokusu, kafeinsiz tercihi ile her zaman yanınızda! Kahve Dünyası olarak özenle topladığımız kaliteli kahve çekirdeklerini çok özel işlemlerden geçirerek kafeinsiz hale getirip lezzet aromalarını koruruz.",KategoriId=1,Resim="KafeinsizDecafFiltreKahve.jpg"},
                 new Urun() { urunName="Etiyopya Yöresel Filtre Kahve",urunType="filtre kahve",urunFiyat=160,urunStok=4,urunAciklama="Etiyopya, Oromia bölgesinin mistik ve cazibeli yüksek rakımlı topraklarında yetişen, büyük cesur meyve notaları, şeker kamışı tatlılığı, çiçeksi aromaları barındıran, düşük asiditeye sahip, yüksek gövdeli, yüksek kıvamlı uzun bitişli nitelikli tür kahvedir.",KategoriId=1,Resim="EtiyopyaYoreselFiltreKahve.jpg"},


                
                new Urun() { urunName="Kenya Çekirdek ",urunType="Çekirdek kahve",urunFiyat=650,urunStok=4,urunAciklama="Bu değeri yüksek kahve, Kenya’yı saran bereketli kızıl volkanik topraklarda yetişir, keskin asidi ile bilinmektedir.Yoğun, kuru ve şarapsı bir tat bırakır. Dünyada tek %7 oranında asite sahip olan kahvedir.Yöresel kahvelerimizden, orta kıvamlı ve şarabımsı, böğürtlenimsi tatlara sahip olan Kenya kahve çekirdekleri, sanal mağazamızda bir tık uzağınızda.",KategoriId=2,Resim="KenyaKavrulmusCekirdek..jpg"},
             new Urun() { urunName="Kolombiya Çekirdek ",urunType="Çekirdek kahve",urunFiyat=850,urunStok=4,urunAciklama="Kolombiya kahvesi, en bilinen kahve türlerinden biridir.Yüksek dağlarda yetişen bu kahve zengin tatlar ve aromalar içerir. Ağır kıvamlı tadı ve yoğun miktarda ceviz aromasına sahip olan Kolombiya Yöresel Çekirdek Kahvemizi 1000 gr.’lık kilitli ambalajlarında beğeninize sunarız",KategoriId=2,Resim="KolombiyaKavrulmusCekirdek..jpg"},
              new Urun() { urunName="Çok Kavrulmuş Türk Kahvesi Çekirdek ",urunType="Çekirdek kahve",urunFiyat=320,urunStok=4,urunAciklama="Türk damak tadına en uygun çekirdek olan, Brezilya’nın Rio da Minas bölgesinin yüzde 100 Arabica çekirdeğini sizin için kavururuz.\r\n\r\nÇok özel kavurma işlemiyle çekirdeklerin yaşlanmasını engeller, tazeliğini ve aromasını koruruz.\r\n\r\nKahvenizi uzun süre taze tutmak isterseniz çekirdek kahve en doğru seçimdir.\r\n\r\nKahvelerin demleneceği zaman öğütülmesi hem tazelik, hem de lezzet olarak en iyi sonucu verecektir.\r\n\r\nEğer öğütme konusunda gerekli ekipman ve bilgiye sahipseniz siz de farklı kavurma derecelerine sahip Türk kahvesi çekirdeklerimizden dilediğinizi seçebilirsiniz.",KategoriId=2,Resim="CokKavrulmusTurkKahvesiCekirdek..jpg"},
               new Urun() { urunName="Orta Kavrulmuş Türk Kahvesi Çekirdek",urunType="Çekirdek kahve",urunFiyat=320,urunStok=4,urunAciklama="Türk damak tadına en uygun çekirdek olan, Brezilya’nın Rio Minas bölgesinin 100% Arabica çekirdeğini sizin için kavururuz. Orta kavrulmuş Türk kahvesi çekirdeklerini 1 kg.’lık özel ambalajlarında beğeninize sunarız.\r\n\r\nKahve çekirdeklerini orta derecede kavurup baharatımsı, odunumsu, meyvemsi ve tütünümsü lezzet aromalarını açığa çıkarırız. Ayrıca özel kavurma işlemiyle çekirdeklerin yaşlanmasını engeller, tazeliğini ve aromasını koruruz.\r\n\r\nKahvenizi uzun süre taze tutmak isterseniz, çekirdek kahve en doğru seçimdir. Kahvelerin demleneceği zaman öğütülmesi hem tazelik hem de lezzet olarak en iyi sonucu verecektir. Eğer öğütme konusunda gerekli ekipman ve bilgiye sahipseniz siz de farklı kavurma derecelerine sahip Kahve Dünyası Türk kahvesi çeşitleri arasından dilediğinizi seçip bol köpüklü Türk kahvesi hazırlayabilirsiniz.",KategoriId=2,Resim="OrtaKavrulmusTurkKahvesiCekirdek..jpg"},
                new Urun() { urunName="Kosta Rika Kavrulmuş Çekirdek",urunType="Çekirdek kahve",urunFiyat=590,urunStok=4,urunAciklama="Aroma, kıvam ve lezzetin mükemmel birleşimine sahip yumuşak içimli bu kahve size yağmur ormanlarının taze havasını hissettirecek.\r\n\r\nKosta Rika kahve çekirdeklerini değerli kılan düşük asiditesi, mükemmel yapısı ve karmaşık lezzetidir. Orta derecede kıvamı, çiçeksi, baharatlı tadı ve fındığı andıran aroması ile Kosta Rika kahvemiz bir tık uzağınızda.\r\n\r\nKosta Rika Yöresel Çekirdek Kahvemizi 1000 gr.’lık kilitli ambalajlarında beğeninize sunarız.",KategoriId=2,Resim="KostaRikaKavrulmusCekirdek..jpg"},
              new Urun() { urunName="Fındık Aromalı Filtre Kahve Çekirdek",urunType="Çekirdek kahve",urunFiyat=650,urunStok=4,urunAciklama=" fındığın bitmeyen enerjisini, duyularınızı harekete geçirecek fındık kokusunu, özenle topladığımız kaliteli kahve çekirdekleri ile bu pakette buluşturduk!\r\n\r\nEn iyi filtre kahveyi elde etmek için kahve çekirdeklerinin taze olması gerekir. Taze ve lezzetli kahve keyfi yaşamanız için Fındık Aromalı Filtre Kahve Çekirdeğini 1000 gr.’lık kilitli ambalajlarında beğeninize sunarız.\r\n\r\nÇekirdek filtre kahvenizi taze taze içmek için dilediğiniz gibi öğütebilir, farklı kahve demleme yöntemlerinden sizin için en uygun olanı seçerek keyifle içebilirsiniz.",KategoriId=2,Resim="FindikAromaliFiltreKahveCekirdek..jpg"},
              new Urun() { urunName="Espresso Çekirdek",urunType="Çekirdek kahve",urunFiyat=605,urunStok=4,urunAciklama="Espresso Çekirdek 1kg",KategoriId=2,Resim="EspressoCekirdek.jpg"},


                new Urun() { urunName=" Espresso Kapsül Kahve",urunType="kapsül kahve",urunFiyat=160,urunStok=4,urunAciklama="ince çekimi yumuşak içimiyle lezzetli",KategoriId=3,Resim="EspressoKapsulKahve.jpg"},
                new Urun() { urunName="Etiyopya Kapsül Kahve ",urunType="kapsül kahve",urunFiyat=160,urunStok=4,urunAciklama=" Kavrulmuş, Öğütülmüş %100 Arabica Etiyopya RA* Sertifikalı Kahve Çekirdeği\r\n\r\n  10''lu Kutu",KategoriId=3,Resim="EtiyopyaKapsulKahve.jpg"},
                new Urun() { urunName="Ristretto Kapsül Kahve",urunType="kapsül kahve",urunFiyat=160,urunStok=4,urunAciklama="Kavrulmuş, Öğütülmüş %100 Arabica Harman Kahve Çekirdekleri \r\n\r\n  10''lu Kutu",KategoriId=3,Resim="RistrettoKapsulKahve.jpg"},
                new Urun() { urunName="Vanilya Aromalı Kapsül Kahve",urunType="kapsül kahve",urunFiyat=170,urunStok=4,urunAciklama="Kavrulmuş Öğütülmüş Kahve, Vanilya Aroma Vericisi (%4,8)\r\n\r\n  10''lu Kutu",KategoriId=3,Resim="VanilyaAromaliKapsulKahve.jpg"},
                new Urun() { urunName="Kafeinsiz Kapsül Kahve",urunType="kapsül kahve",urunFiyat=170,urunStok=4,urunAciklama="Kavrulmuş, Öğütülmüş %100 Arabica Kafeinsiz Kahve Çekirdeği\r\n\r\n  10''lu Kutu",KategoriId=3,Resim="KafeinsizKapsulKahve.jpg"},
                new Urun() { urunName="Selection Kapsül Kahve",urunType="kapsül kahve",urunFiyat=170,urunStok=4,urunAciklama="Fındık Aromalı Kapsül Kahve (1 adet) : Kavrulmuş Öğütülmüş kahve, fındık aroma vericisi (%4)\r\n\r\nVanilya Aromalı Kapsül Kahve (1 adet) : Kavrulmuş Öğütülmüş kahve, vanilya aroma vericisi (%4,8)\r\n\r\nKaramel Aromalı Kapsül Kahve (1 adet) : Kavrulmuş Öğütülmüş kahve, karamel aroma vericisi (%3,9)\r\n\r\nKafeinsiz Kapsül Kahve (1 adet) : Kavrulmuş, Öğütülmüş %100 Arabica Kafeinsiz Kahve Çekirdeği\r\n\r\nEtiyopya Kapsül Kahve (1 adet) : Kavrulmuş, Öğütülmüş %100 Arabica Etiyopya Kahve Çekirdeği\r\n\r\nKolombiya Kapsül Kahve (1 adet) : Kavrulmuş, Öğütülmüş %100 Arabica Kolombiya Kahve Çekirdeği\r\n\r\nEspresso Kapsül Kahve (2 adet) : Kavrulmuş, Öğütülmüş Harman Kahve Çekirdekleri\r\n\r\nRistretto Kapsül Kahve (2 adet) : Kavrulmuş, Öğütülmüş %100 Arabica Harman Kahve Çekirdekleri",KategoriId=3,Resim="SelectionKapsulKahve.jpg"},
              //new Urun() { urunName="French Press ",urunType="Kahve Hazırlama Ürünü",urunFiyat=300,urunStok=4,urunAciklama="Kahve Dünyası french press 350 ml hacminde, kolay temizlenebilir paslanmaz çelik süzgeç, hijyenik cam gövdeye sahiptir.",KategoriId=3,Resim="FrenchPress.png"},
              // new Urun() { urunName="Termos 460 ml",urunType="Termos",urunFiyat=700,urunStok=4,urunAciklama="7 saate kadar sıcak 24 saate kadar soğuk tutma özelliğine sahiptir.",KategoriId=3,Resim="AlgoturTermos460ml..png"},
              //  new Urun() { urunName="2'li Espresso Fincan Seti",urunType="kupa ve fincan",urunFiyat=300,urunStok=4,urunAciklama="sıcak içecekler grubuna özel olarak tasarlanan fincanlar 80ml olmaktadır.",KategoriId=3,Resim="EspressoFincani.png"},
              //   new Urun() { urunName="Bez Kahve Filtresi",urunType="Kahve Hazırlama Ürünü",urunFiyat=43,urunStok=4,urunAciklama="Çevre dostu kahve filtremiz el yapımıdır ve tekrar kullanılabilir. Pamuk ve keten karışımıdır. Ham kumaştır, boya ve ağartıcı içermez.",KategoriId=3,Resim="BezKahveFiltresi.jpg"},






            };

            foreach (var urun in urunler)
            {
                context.Urun.Add(urun);
            }
            context.SaveChanges();





            List<AksesuarKategori> aksesuarkategoriler = new List<AksesuarKategori>()
            {
                new AksesuarKategori() { kategoriName="Kupa ve Fincanlar",Aciklama="Kişiye Özel Kahve Deneyimi: Kupa ve Fincan İçinde En Taze Lezzetler!Her bir kupa ve fincan, estetik tasarımlarıyla göz alıcı bir kahve deneyimi yaşamanızı sağlar. Sevdiklerinize veya kendinize özel hazırlanan kahve setlerimizle, sadece kahve içmekle kalmayacak, aynı zamanda estetik bir keyif de yaşayacaksınız." },
                new AksesuarKategori() { kategoriName="Termoslar",Aciklama="Sıcak Tutulan Lezzet: Kahve Keyfinizi Her Yere Taşıyın!Her bir termos kahvemiz, özenle seçilmiş kahve çekirdekleri ve özel kavurma teknikleri ile hazırlanır. Sıcak tutma özellikleriyle uzun süre boyunca taze ve aromatik bir kahve deneyimi sunar, böylece her yerde en sevdiğiniz içeceğin tadını çıkarabilirsiniz." },
                new AksesuarKategori() { kategoriName="Kahve Hazırlama Ürünleri",Aciklama="Evinizde Mükemmel Kahve Deneyimi İçin Her Şey Burada!Kahve hazırlamak sanatseverlerin işidir ve bu sanatı en üst seviyeye taşımak için ihtiyacınız olan her şeyi burada bulabilirsiniz! " },

            };
            foreach (var aksesuark in aksesuarkategoriler)
            {
                context.aksesuarKategoriler.Add(aksesuark);
            }
            context.SaveChanges();
            List<AksesuarUrun> AksesuarUrunler = new List<AksesuarUrun>()
            {
              new AksesuarUrun() { UrunName="French Press ",urunType="Kahve Hazırlama Ürünü",urunFiyat=300,urunStok=4,urunAciklama="Kahve Dünyası french press 350 ml hacminde, kolay temizlenebilir paslanmaz çelik süzgeç, hijyenik cam gövdeye sahiptir.",AksesuarKategoriId=3,Resim="FrenchPress.png"},
              new AksesuarUrun() { UrunName="Bez Kahve Filtresi",urunType="Kahve Hazırlama Ürünü",urunFiyat=43,urunStok=4,urunAciklama="Çevre dostu kahve filtremiz el yapımıdır ve tekrar kullanılabilir. Pamuk ve keten karışımıdır. Ham kumaştır, boya ve ağartıcı içermez.",AksesuarKategoriId=3,Resim="BezKahveFiltresi.jpg"},
             new AksesuarUrun() { UrunName="Elektrikli Kahve Değirmeni",urunType="Kahve Hazırlama Ürünü",urunFiyat=2.039,urunStok=4,urunAciklama="Elektrikli kahve değirmeni ile artık bu çeşidin tadını evinizde de çıkarabilirsiniz. Öğütücü 26 öğütme derecesi sunar ve fincan hassasiyetinde öğütme işlevi sayesinde kahve çekirdekleri israf edilmez. Toplama kabı yaklaşık 85 gr kahve tozu alır. Bu yaklaşık 12 fincan kahveye karşılık gelir",AksesuarKategoriId=3,Resim="elektrikli-kahve-degirmeni.jpeg"},
          new AksesuarUrun() { UrunName="Şarjlı Kahve Değirmeni ",urunType="Kahve Hazırlama Ürünü",urunFiyat=999,urunStok=4,urunAciklama="Bir kahvenin aroması en iyi taze öğütüldüğü zaman ortaya çıkar. Bu, şarjlı değirmen ile her zaman mümkün - ister evde ister dışarıda. Şarjlı değirmen kahve çekirdeklerini tek düğmeyle zahmetsiz ve elektriğe ihtiyaç duymadan öğütebilir. Entegre şarj göstergesi sayesinde değirmen, yanında bulunan USB kabloosu ile tekrar şarj edilebilir ve her zaman kullanıma hazırdır. ",AksesuarKategoriId=3,Resim="şarjlikahvedegirmeni.jpeg"},
           new AksesuarUrun() { UrunName="Pilli Süt Köpürtücü ",urunType="Kahve Hazırlama Ürünü",urunFiyat=399,urunStok=4,urunAciklama="Ergonoik tasarım sayesinde kolay kullanıma sahiptir.Küçük rotasyonlar sayesinde kremsi süt köpüğü sağlar.Paslanmaz çelik uzun süreli kullanım anlamına gelir. Bakımı kolaydır ve ısıya dayanıklıdır.",AksesuarKategoriId=3,Resim="pilli-sut-kopurtucu.jpeg"},


                new AksesuarUrun() { UrunName="Termos 460 ml",urunType="Termos",urunFiyat=700,urunStok=4,urunAciklama="7 saate kadar sıcak 24 saate kadar soğuk tutma özelliğine sahiptir.",AksesuarKategoriId=2,Resim="AlgoturTermos460ml..png"},
                new AksesuarUrun() { UrunName="İzolasyonlu Matara",urunType="Termos",urunFiyat=400,urunStok=4,urunAciklama="Kahve veya çayınızı yanınızda taşımanız için idealdir.İçecekleri daha uzun süre sıcak veya soğuk tutar.Gazlı içecekler için de uygundur.Kapasitesi yakl. 450 ml",AksesuarKategoriId=2,Resim="izolasyonlumatara.jpg"},
                new AksesuarUrun() { UrunName="2 Bardaklı Termos",urunType="Termos",urunFiyat=750,urunStok=4,urunAciklama="Entegre iki adet bardak - iki kişi için uygundur.İçecekleri daha uzun süre sıcak veya soğuk tutar.Çıkarılabilir, uzunluğu ayarlanabilir omuz askısı.Gazlı içecekler için de uygundur.Taşıma saplı.Vidalı kapak ile sızdırmaz.Kapasitesi yakl. 1.000 ml",AksesuarKategoriId=2,Resim="2bardaklitermos.jpg"},
                new AksesuarUrun() { UrunName="Su Şişesi Füme 0.47 L",urunType="Termos",urunFiyat=860,urunStok=4,urunAciklama="Paslanmaz çelikten üretilen şişe vakum yalıtımı üzerine yapılan seramik kaplamadan oluşmaktadır. Bu sayede optimum ölçüde dayanıklılık, temizlenebilirlik bakımından kolaylık gibi imkanlar sağlıyor. Kaplama sayesinde lekelere karşı dayanıklı olan dış yüzey, metalik tat ve koku vermeyen iç yüzey ile birleşerek mükemmel deneyim yaşaman, özetle hayatın için tasarlanmıştır. Kalite tesadüf değildir.",AksesuarKategoriId=2,Resim="stanley-go-quick-flip-su-sisesi-fume-0-47-l-termos-dunyasi-1.jpeg"},



                new AksesuarUrun() { UrunName="2'li Espresso Fincan Seti",urunType="kupa ve fincan",urunFiyat=300,urunStok=4,urunAciklama="sıcak içecekler grubuna özel olarak tasarlanan fincanlar 80ml olmaktadır.",AksesuarKategoriId=1,Resim="EspressoFincani.png"},
                new AksesuarUrun() { UrunName="2'li Latte Macchiato bardağı",urunType="kupa ve fincan",urunFiyat=499,urunStok=4,urunAciklama="Latte macchiato için ısı yalıtımlı kahve bardakları içecekleri daha uzun süre sıcak tutarken, dışı hoş bir şekilde serin kalır.",AksesuarKategoriId=1,Resim="2li-latte-macchiato-bardagi.jpg"},
                new AksesuarUrun() { UrunName="2`li Caffè Crema bardağı",urunType="kupa ve fincan",urunFiyat=399,urunStok=4,urunAciklama="Caffè crema ve cappuccino için ısı yalıtımlı kahve bardakları içecekleri daha uzun süre sıcak tutarken, dışarısı hoş bir şekilde serin kalır.",AksesuarKategoriId=1,Resim="2li-caffe-crema-bardagi.jpeg"},
                new AksesuarUrun() { UrunName="2 Adet Bardak",urunType="kupa ve fincan",urunFiyat=379,urunStok=4,urunAciklama="Kaliteli seramikten yapılmıştır.Her parça eşsizdir - sır kaplama her parçada farklılık gösterir.Sıcak ve soğuk içecekler için uygun bardaklar - sabah kahvesi veya öğleden sonra çay saati için.Her birinin kapasitesi yakl. 380 ml",AksesuarKategoriId=1,Resim="2adetbardak.jpeg"},






            };
            foreach (var aurun in AksesuarUrunler)
            {
                context.AksesuarUrunler.Add(aurun);
            }
            context.SaveChanges();








            List<Hakkimizda> hakkimizda = new List<Hakkimizda>()
            {
                new Hakkimizda() { link="https://www.kahvedunyasi.com/french-press-siyah-kulplu-p-65" },
                new Hakkimizda() { link="https://www.kahvedunyasi.com/2li-espresso-fincan-seti-p-759" },
                new Hakkimizda() { link="https://www.kahvedunyasi.com/bez-kahve-filtresi-p-2085" },
                new Hakkimizda() { link="https://www.kahvedunyasi.com/kahve-dunyasi-algotur-termos-460-ml-p-1863" },
                new Hakkimizda() { link="https://www.kahvedunyasi.com/karamel-aromali-filtre-kahve-250g-p-18" },
                new Hakkimizda() { link="https://www.kahvedunyasi.com/filtre-kahve-250g-p-17" },
                new Hakkimizda() { link="https://www.kahvedunyasi.com/kafeinsiz-decaf-filtre-kahve-250g-p-21" },
                new Hakkimizda() { link="https://www.kahvedunyasi.com/findik-aromali-filtre-kahve-250g-p-2021" },
                new Hakkimizda() { link="https://www.kahvedunyasi.com/guatemala-yoresel-filtre-kahve-200g-p-1782" },
                new Hakkimizda() { link="https://www.kahvedunyasi.com/kosta-rika-yoresel-filtre-kahve-200g-p-1784" },
                new Hakkimizda() { link="https://www.kahvedunyasi.com/kolombiya-yoresel-filtre-kahve-200g-p-1785" },
                new Hakkimizda (){ link="https://www.kahvedunyasi.com/espresso-cekirdek-1-kg-p-1892" },
                new Hakkimizda (){ link="https://www.kahvedunyasi.com/findik-aromali-filtre-kahve-cekirdek-1-kg-p-881" },
                new Hakkimizda (){ link="https://www.kahvedunyasi.com/kenya-kavrulmus-cekirdek-1-kg-p-876" },
                new Hakkimizda (){ link="https://www.kahvedunyasi.com/cok-kavrulmus-turk-kahvesi-cekirdek-1-kg-p-14" },
                new Hakkimizda (){ link="https://www.kahvedunyasi.com/kolombiya-kavrulmus-cekirdek-1-kg-p-874" },
                new Hakkimizda  (){ link="https://www.kahvedunyasi.com/orta-kavrulmus-turk-kahvesi-cekirdek-1-kg-p-13" },
                new Hakkimizda (){ link="https://www.kahvedunyasi.com/kosta-rika-kavrulmus-cekirdek-1-kg-p-875" },
                new Hakkimizda  (){ link="https://www.kahvedunyasi.com/vanilya-aromali-kapsul-kahve-10lu-kutu-p-2177" },
                new Hakkimizda  (){ link="https://www.kahvedunyasi.com/espresso-kapsul-kahve-10lu-kutu-p-2184" },
                new Hakkimizda  (){ link="https://www.kahvedunyasi.com/selection-kapsul-kahve-10lu-kutu-p-2185" },
                new Hakkimizda  (){ link="https://www.kahvedunyasi.com/kafeinsiz-kapsul-kahve-10lu-kutu-p-2183" },
                new Hakkimizda  (){ link="https://www.kahvedunyasi.com/ristretto-kapsul-kahve-10lu-kutu-p-2180" },
                new Hakkimizda  (){ link="https://www.kahvedunyasi.com/etiyopya-kapsul-kahve-10lu-kutu-p-2181" },
                new Hakkimizda  (){ link="https://tr.pinterest.com/pin/752523419009101468/" },
                new Hakkimizda  (){ link="https://tr.pinterest.com/pin/876372408718496399/ "},
                new Hakkimizda  (){ link="https://www.tchibo.com.tr/products/402052665/sarjli-kahve-degirmeni" },
                new Hakkimizda  (){ link="https://www.tchibo.com.tr/products/402101304/elektrikli-kahve-degirmeni" },
                new Hakkimizda(){link="https://www.tchibo.com.tr/products/400138040/pilli-sut-kopurtucu"},
                new Hakkimizda(){link="https://www.tchibo.com.tr/products/402100722/2-bardakli-termos"},
                new Hakkimizda(){link="https://www.tchibo.com.tr/products/400161287/izolasyonlu-matara"},
                new Hakkimizda(){link="https://www.termosdunyasi.com.tr/collections/yilbasi-hediyeleri/products/stanley-go-quick-flip-water-bottle-fume-16oz-0-47l"},
                new Hakkimizda(){link="https://www.tchibo.com.tr/products/402060527/2li-caffe-crema-bardagi"},
                new Hakkimizda(){link="https://www.tchibo.com.tr/products/402060526/2li-latte-macchiato-bardagi"},
                new Hakkimizda(){link="https://www.tchibo.com.tr/products/400168435/2-adet-bardak"},
            };

            foreach (var link in hakkimizda)
            {
                context.Hakkimizda.Add(link);
            }
            context.SaveChanges();

            base.Seed(context);
        }

    }
}