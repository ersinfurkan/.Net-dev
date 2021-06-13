using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜniversiteIK
{
    public interface IOgretimGorevlisi           /*OgrenciIsleri class'ı için miras alınacak Interfaces değişkenim*/
    {
        public int KimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime Dogum_Tarihi { get; set; }
        public Enumlar.OgretimGorevlisi Gorevi { get; set; }
        public void OgrentimGorevlisiEkle();
        public void OgretimGorevlisiSil();
        public void OgretimGorevlisiGuncelle();

    }

    

}
