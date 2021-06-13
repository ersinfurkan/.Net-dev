using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜniversiteIK
{
    public interface IOgrenciIsleri               /*OgrenciIsleri class'ı için miras alınacak Interfaces değişkenim*/
    {
        public int KimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime Dogum_Tarihi { get; set; }
        public Enumlar.OgrenciIsleri Gorevi { get; set; }
        public void OgrenciIsleriEkle();
        public void OgrenciIsleriSil();
        public void OgrenciIsleriGuncelle();


    }
}
