using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ÜniversiteIK;

namespace ÜniversiteIK
{
    public class OgretimGorevlisi : IOgretimGorevlisi            /*IOgretimGorevlisi Interfaces'den miras aldım*/
    {
        public int KimlikNo { get ; set ; } 
        public string Ad { get ; set ; } 
        public string Soyad { get ; set ; }                             /*Değişkenlerimi girdim*/
        public DateTime Dogum_Tarihi { get ; set ; }
        public Enumlar.OgretimGorevlisi Gorevi { get ; set ; }

        public void OgrentimGorevlisiEkle()       /*OgrentimGorevlisiEkle methodumu ekledikten değişkenlerimi girerek hepsini arraylere atadım*/
        {
            IOgretimGorevlisi ogrenci = new OgretimGorevlisi();
            ogrenci.KimlikNo = 1453;
            ogrenci.Ad = "Furkan";
            ogrenci.Soyad = "Ersin";
            ogrenci.Dogum_Tarihi = new DateTime(2000, 12, 25);
            ogrenci.Gorevi = Enumlar.OgretimGorevlisi.BilimselArastırma;

            JArray array = new JArray();
            array.Add(ogrenci.KimlikNo);
            array.Add(ogrenci.Ad);
            array.Add(ogrenci.Soyad);
            array.Add(ogrenci.Dogum_Tarihi);
            array.Add(ogrenci.Gorevi.ToString());

            JArray rss = new JArray(
                     new JObject(
                            new JProperty("Kimlik No", ogrenci.KimlikNo),
                            new JProperty("Adi", ogrenci.Ad),
                            new JProperty("Soyadi", ogrenci.Soyad),
                            new JProperty("Dogumtarihi", ogrenci.Dogum_Tarihi),
                            new JProperty("Bolumu", ogrenci.Gorevi.ToString())));

            File.WriteAllText(@"C:\Users\FURKAN\Desktop\OgretimGorevlisi.json", rss.ToString());
            using (StreamWriter file = File.CreateText(@"C:\Users\FURKAN\Desktop\OgretimGorevlisi.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                rss.WriteTo(writer);
            }
        }


        public void OgretimGorevlisiSil()
        {
            var json = File.ReadAllText(@"C:\Users\FURKAN\Desktop\OgretimGorevlisi.json");
            JArray array = new JArray(json);
            JToken elem = array[0];
            array.Remove(elem);
            using (StreamWriter file = File.CreateText(@"C:\Users\FURKAN\Desktop\OgretimGorevlisi.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                array.WriteTo(writer);
            }
        }

        public void OgretimGorevlisiGuncelle()        /*OgretimGorevlisiGuncelle methodu'mu oluşturdum ve güncellenecek kişiyi oluşturduktan sonra onu array'e atadım*/
        {
            var json = File.ReadAllText(@"C:\Users\FURKAN\Desktop\OgretimGorevlisi.json");
            JArray array = new JArray(json);

            IOgretimGorevlisi personel2 = new OgretimGorevlisi();
            personel2.KimlikNo = 1834759645;
            personel2.Ad = "Yıldıray";
            personel2.Soyad = "Serbest";
            personel2.Dogum_Tarihi = new DateTime(1992, 05, 22);
            personel2.Gorevi = Enumlar.OgretimGorevlisi.YayınEtkinlikleri;

            JArray rss2 = new JArray(
                  new JObject(
                           new JProperty("OgrenciNo", personel2.KimlikNo),
                           new JProperty("Adi", personel2.Ad),
                           new JProperty("Soyadi", personel2.Soyad),
                           new JProperty("Dogumtarihi", personel2.Dogum_Tarihi),
                           new JProperty("Gorevi", personel2.Gorevi.ToString())));

            JToken elem = array[0];
            elem.Replace(rss2[0]);

            using (StreamWriter file = File.CreateText(@"C:\Users\FURKAN\Desktop\OgretimGorevlisi.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                array.WriteTo(writer);
            }

        }
    }
}
