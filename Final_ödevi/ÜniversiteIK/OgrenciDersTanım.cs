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
    public class OgrenciDersTanım : IOgrenciDersSınıfı
    {
        public int Dersno { get ; set ; }
        public int OgrenciNo { get ; set ; }

        public void OgrenciDersEkle()
        {
            IOgrenciDersSınıfı personel = new OgrenciDersTanım();

            personel.Dersno = 1453;
            personel.OgrenciNo = 86541;

            JArray array = new JArray();
            array.Add(personel.Dersno);
            array.Add(personel.OgrenciNo);
                       
            JArray rss = new JArray(
                     new JObject(
                            new JProperty("Kimlik No", personel.Dersno),                                                        
                            new JProperty("Bolumu", personel.OgrenciNo)));


            File.WriteAllText(@"C:\Users\FURKAN\Desktop\OgrenciDersTanım.json", rss.ToString());
            using (StreamWriter file = File.CreateText(@"C:\Users\FURKAN\Desktop\OgrenciDersTanım.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                rss.WriteTo(writer);
            }
        }

        public void OgrenciDersSil()
        {

            var json = File.ReadAllText(@"C:\Users\FURKAN\Desktop\OgrenciDersTanım.json");
            JArray array = new JArray(json);
            JToken elem = array[0];
            array.Remove(elem);
            using (StreamWriter file = File.CreateText(@"C:\Users\FURKAN\Desktop\OgrenciDersTanım.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                array.WriteTo(writer);
            }
        }
    }
}
