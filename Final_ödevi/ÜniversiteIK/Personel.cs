using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜniversiteIK
{
    public class Personel : IPersonel  /*IPersonel'den miras aldım*/
    {
        public int KimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime Dogum_Tarihi { get; set; }
        public Enumlar.Departmanlar Gorevi { get; set; }    /*Değişkenlerimi girdim*/
        public DateTime BaslamaTarihi { get; set; }

        public void PersonelEkle()    /*PersonelEkle methodumu ekledikten değişkenlerimi girerek hepsini arraylere atadım*/
        {
            IPersonel personel = new Personel();

            personel.KimlikNo = 1453;
            personel.Ad = "Furkan";
            personel.Soyad = "Ersin";
            personel.Dogum_Tarihi = new DateTime(2000, 12, 25);
            personel.Gorevi = Enumlar.Departmanlar.Hizmet;
            personel.BaslamaTarihi = new DateTime(2020, 12, 6);

            JArray array = new JArray();
            array.Add(personel.KimlikNo);
            array.Add(personel.Ad);
            array.Add(personel.Soyad);
            array.Add(personel.Dogum_Tarihi);
            array.Add(personel.Gorevi.ToString());
            array.Add(personel.BaslamaTarihi);


            JArray rss = new JArray(
                     new JObject(
                            new JProperty("Kimlik No", personel.KimlikNo),
                            new JProperty("Adi", personel.Ad),
                            new JProperty("Soyadi", personel.Soyad),
                            new JProperty("Dogumtarihi", personel.Dogum_Tarihi),
                            new JProperty("Bolumu", personel.Gorevi.ToString()),
                            new JProperty("Ise Giris", personel.BaslamaTarihi)));

            File.WriteAllText(@"C:\Users\FURKAN\Desktop\Personel.json", rss.ToString());
            using (StreamWriter file = File.CreateText(@"C:\Users\FURKAN\Desktop\Personel.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                rss.WriteTo(writer);
            }
        }
        public void Personel_sil()    
        {

            var json = File.ReadAllText(@"C:\Users\FURKAN\Desktop\Personel.json");
            JArray array = new JArray(json);
            JToken elem = array[0];
            array.Remove(elem);
            using (StreamWriter file = File.CreateText(@"C:\Users\FURKAN\Desktop\Personel.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                array.WriteTo(writer);
            }
        }

        public void Personel_Guncelle() /*Personel_Guncelle methodu'mu oluşturdum ve güncellenecek kişiyi oluşturduktan sonra onu array'e atadım*/
        {
            var json = File.ReadAllText(@"C:\Users\FURKAN\Desktop\Personel.json");  
            JArray array = new JArray(json);



            IPersonel personel2 = new Personel();

            personel2.KimlikNo = 45245;
            personel2.Ad = "Yılmaz";
            personel2.Soyad = "Carık";
            personel2.Dogum_Tarihi = new DateTime(2005, 6, 29);
            personel2.Gorevi = Enumlar.Departmanlar.Muhasebe;
            personel2.BaslamaTarihi = new DateTime(2015, 04, 18);



            JArray rss2 = new JArray(
                  new JObject(
                           new JProperty("OgrenciNo", personel2.KimlikNo),
                           new JProperty("Adi", personel2.Ad),
                           new JProperty("Soyadi", personel2.Soyad),
                           new JProperty("Dogumtarihi", personel2.Dogum_Tarihi),
                           new JProperty("Gorevi", personel2.Gorevi.ToString()),
                           new JProperty("Ise Baslama", personel2.BaslamaTarihi)));

            JToken elem = array[0];
            elem.Replace(rss2[0]);

            using (StreamWriter file = File.CreateText(@"C:\Users\FURKAN\Desktop\Personel.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                array.WriteTo(writer);
            }
        }

    }
}
