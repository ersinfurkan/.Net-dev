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
    public class IdariPersonel : IIdariPersonel /*IIdariPersonel Interfaces'den miras aldım*/
    {
        public int KimlikNo { get ; set ; }
        public string Ad { get ; set ; }
        public string Soyad { get ; set ; }
        public DateTime Dogum_Tarihi { get ; set ; }
        public Enumlar.IderiPersonelGorevleri Gorevi { get ; set ; }          /*Değişkenlerimi girdim*/

        public void IdariPersonelEkle()     /*IdariPersonelEkle methodumu ekledikten değişkenlerimi girerek hepsini arraylere atadım*/
        {
            IIdariPersonel ıdariPersonel = new IdariPersonel();   

            ıdariPersonel.KimlikNo = 1453;
            ıdariPersonel.Ad = "Furkan";
            ıdariPersonel.Soyad = "Ersin";
            ıdariPersonel.Dogum_Tarihi = new DateTime(2000, 12, 25);
            ıdariPersonel.Gorevi = Enumlar.IderiPersonelGorevleri.HarcamaRaporu;

            JArray array = new JArray();
            array.Add(ıdariPersonel.KimlikNo);
            array.Add(ıdariPersonel.Ad);
            array.Add(ıdariPersonel.Soyad);
            array.Add(ıdariPersonel.Dogum_Tarihi);
            array.Add(ıdariPersonel.Gorevi.ToString());

            JArray rss = new JArray(
                     new JObject(
                            new JProperty("Kimlik No", ıdariPersonel.KimlikNo),
                            new JProperty("Adi", ıdariPersonel.Ad),
                            new JProperty("Soyadi", ıdariPersonel.Soyad),
                            new JProperty("Dogumtarihi", ıdariPersonel.Dogum_Tarihi),
                            new JProperty("Bolumu", ıdariPersonel.Gorevi.ToString())));

            File.WriteAllText(@"C:\Users\FURKAN\Desktop\IdariPersonel.json", rss.ToString());
            using (StreamWriter file = File.CreateText(@"C:\Users\FURKAN\Desktop\IdariPersonel.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                rss.WriteTo(writer);
            }


        }

        public void IdariPersonelSil()
        {
            var json = File.ReadAllText(@"C:\Users\FURKAN\Desktop\IdariPersonel.json");
            JArray array = new JArray(json);
            JToken elem = array[0];
            array.Remove(elem);
            using (StreamWriter file = File.CreateText(@"C:\Users\FURKAN\Desktop\IdariPersonel.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                array.WriteTo(writer);
            }

        }

        public void IdariPersonelGuncelle()       /*IdariPersonelGuncelle methodu'mu oluşturdum ve güncellenecek kişiyi oluşturduktan sonra onu array'e atadım*/
        {
            var json = File.ReadAllText(@"C:\Users\FURKAN\Desktop\IdariPersonel.json");
            JArray array = new JArray(json);

            IIdariPersonel personel2 = new IdariPersonel();

            personel2.KimlikNo = 1256;
            personel2.Ad = "Servet";
            personel2.Soyad = "Cetin";
            personel2.Dogum_Tarihi = new DateTime(1968, 12, 01);
            personel2.Gorevi = Enumlar.IderiPersonelGorevleri.SırketKayıtları;

            JArray rss2 = new JArray(
                  new JObject(
                           new JProperty("OgrenciNo", personel2.KimlikNo),
                           new JProperty("Adi", personel2.Ad),
                           new JProperty("Soyadi", personel2.Soyad),
                           new JProperty("Dogumtarihi", personel2.Dogum_Tarihi),
                           new JProperty("Gorevi", personel2.Gorevi.ToString())));

            JToken elem = array[0];
            elem.Replace(rss2[0]);

            using (StreamWriter file = File.CreateText(@"C:\Users\FURKAN\Desktop\IdariPersonel.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                array.WriteTo(writer);
            }

        }
    }
}
