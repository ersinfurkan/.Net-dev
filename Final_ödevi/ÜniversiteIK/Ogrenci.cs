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
    public class Ogrenci : IOgrenci                     /*IOgrenci Interfaces'den miras aldım*/
    {
        public int OgrenciNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public Enumlar.Bolumler Bolum { get; set; }           /*Değişkenlerimi girdim*/
        public int Sınıfı { get; set; }
        public float NotOrtalama { get; set; }

        public void OgrenciEkle()        /*OgrenciEkle methodumu ekledikten değişkenlerimi girerek hepsini arraylere atadım*/
        {
            IOgrenci ogrenci = new Ogrenci();

            ogrenci.OgrenciNo = 1453;                     
            ogrenci.Ad = "Furkan";
            ogrenci.Soyad = "Ersin";
            ogrenci.DogumTarihi = new DateTime(2000, 12, 25);
            ogrenci.Bolum = Enumlar.Bolumler.BilgisayarMuhendisligi;
            ogrenci.Sınıfı = 2;
            ogrenci.NotOrtalama = 5.12f;

            

            JArray rss = new JArray(
                     new JObject(
                            new JProperty("OgrenciNo", ogrenci.OgrenciNo),
                            new JProperty("Adi", ogrenci.Ad),
                            new JProperty("Soyadi", ogrenci.Soyad),
                            new JProperty("Dogumtarihi", ogrenci.DogumTarihi),
                            new JProperty("Bolumu", ogrenci.Bolum.ToString()),
                            new JProperty("Sinifi", ogrenci.Sınıfı),
                            new JProperty("Not Ortalama", ogrenci.NotOrtalama)));

            File.WriteAllText(@"C:\Users\FURKAN\Desktop\Ogrenci.json", rss.ToString());
            using (StreamWriter file = File.CreateText(@"C:\Users\FURKAN\Desktop\Ogrenci.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                rss.WriteTo(writer);
            }
        
           
        }
        public void OgrenciSil()
        {

            var json = File.ReadAllText(@"C:\Users\FURKAN\Desktop\Ogrenci.json");
            JArray array = new JArray(json);
            JToken elem = array[0];
            array.Remove(elem);
            using (StreamWriter file = File.CreateText(@"C:\Users\FURKAN\Desktop\Ogrenci.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                array.WriteTo(writer);
            }
        }

        public void OgrenciGuncelle()            /*OgrenciGuncelle methodu'mu oluşturdum ve güncellenecek kişiyi oluşturduktan sonra onu array'e atadım*/
        {
            var json = File.ReadAllText(@"C:\Users\FURKAN\Desktop\Ogrenci.json");
            JArray array = new JArray(json);



            IOgrenci ogrenci2 = new Ogrenci();

            ogrenci2.OgrenciNo = 5621;
            ogrenci2.Ad = "Mehmet";
            ogrenci2.Soyad = "Ersoy";
            ogrenci2.DogumTarihi = new DateTime(2005, 6, 29);
            ogrenci2.Bolum = Enumlar.Bolumler.Tıp;
            ogrenci2.Sınıfı = 4;
            ogrenci2.NotOrtalama = 4.00f;


            JArray rss2 = new JArray(
                  new JObject(
                           new JProperty("OgrenciNo", ogrenci2.OgrenciNo),
                           new JProperty("Adi", ogrenci2.Ad),
                           new JProperty("Soyadi", ogrenci2.Soyad),
                           new JProperty("Dogumtarihi", ogrenci2.DogumTarihi),
                           new JProperty("Bolumu", ogrenci2.Bolum.ToString()),
                           new JProperty("Sinifi", ogrenci2.Sınıfı),
                           new JProperty("Not Ortalama", ogrenci2.NotOrtalama)));

            JToken elem = array[0];
            elem.Replace(rss2[0]);

            using (StreamWriter file = File.CreateText(@"C:\Users\FURKAN\Desktop\Ogrenci.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                array.WriteTo(writer);
            }
        }




    }
}
