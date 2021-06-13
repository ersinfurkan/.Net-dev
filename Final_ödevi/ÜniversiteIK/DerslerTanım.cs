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
    public class DerslerTanım : IDerslerTanımSınıfı                          /*IDerslerTanımSınıfı Interfaces'den miras aldım*/
    {
        public int DersNo { get ; set ; }
        public string Ad { get ; set ; }
        public string Acıklama { get ; set ; }               /*Değişkenlerimi girdim*/
        public Enumlar.OgretimGorevlisi1 Gorevi { get ; set ; }

        public void DerslerTanımEkle()                        /*DerslerTanımEkle methodumu ekledikten değişkenlerimi girerek hepsini arraylere atadım*/
        {
            IDerslerTanımSınıfı personel = new DerslerTanım();

            personel.DersNo = 1453;
            personel.Ad = "Furkan";
            personel.Acıklama = "Matematik";           
            personel.Gorevi = Enumlar.OgretimGorevlisi1.SosyalHizmetler;
            

            JArray array = new JArray();
            array.Add(personel.DersNo);
            array.Add(personel.Ad);
            array.Add(personel.Acıklama);           
            array.Add(personel.Gorevi.ToString());



            JArray rss = new JArray(
                     new JObject(
                            new JProperty("Kimlik No", personel.DersNo),
                            new JProperty("Adi", personel.Ad),
                            new JProperty("Soyadi", personel.Acıklama),
                            new JProperty("Bolumu", personel.Gorevi.ToString())));
                            

            File.WriteAllText(@"C:\Users\FURKAN\Desktop\DersTanım.json", rss.ToString());
            using (StreamWriter file = File.CreateText(@"C:\Users\FURKAN\Desktop\DersTanım.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                rss.WriteTo(writer);
            }
        }

        public void DerslerTanımSil()
        {

            var json = File.ReadAllText(@"C:\Users\FURKAN\Desktop\DersTanım.json");
            JArray array = new JArray(json);
            JToken elem = array[0];
            array.Remove(elem);
            using (StreamWriter file = File.CreateText(@"C:\Users\FURKAN\Desktop\DersTanım.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                array.WriteTo(writer);
            }
        }

        public void DerslerTanımGuncelle()         /*DerslerTanımGuncelle methodu'mu oluşturdum ve güncellenecek kişiyi oluşturduktan sonra onu array'e atadım*/
        {
            var json = File.ReadAllText(@"C:\Users\FURKAN\Desktop\DersTanım.json");
            JArray array = new JArray(json);



            IDerslerTanımSınıfı personel2 = new DerslerTanım();

            personel2.DersNo = 1256421;
            personel2.Ad = "Yılmaz";
            personel2.Acıklama = "Carık";            
            personel2.Gorevi = Enumlar.OgretimGorevlisi1.GuvenlikOnlemleri;




            JArray rss2 = new JArray(
                  new JObject(
                           new JProperty("OgrenciNo", personel2.DersNo),
                           new JProperty("Adi", personel2.Ad),
                           new JProperty("Soyadi", personel2.Acıklama),
                           new JProperty("Gorevi", personel2.Gorevi.ToString())));
                           

            JToken elem = array[0];
            elem.Replace(rss2[0]);

            using (StreamWriter file = File.CreateText(@"C:\Users\FURKAN\Desktop\DersTanım.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                array.WriteTo(writer);
            }
        }
    }
}
