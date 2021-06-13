using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜniversiteIK
{
    public interface IOgrenci                /*Ogrenci class'ı için miras alınacak Interfaces değişkenim*/
    {
        public int OgrenciNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public Enumlar.Bolumler Bolum { get; set; }              
        public int Sınıfı { get; set; }
        public float NotOrtalama { get; set; }
        public void OgrenciEkle();
        public void OgrenciSil();
        public void OgrenciGuncelle();
    }
}
