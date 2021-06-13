using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜniversiteIK
{
    public interface IDerslerTanımSınıfı  /*DerslerTanım class'ı için miras alınacak Interfaces değişkenim*/
    {
        public int DersNo { get; set; }
        public string Ad { get; set; }
        public string Acıklama { get; set; }
        public Enumlar.OgretimGorevlisi1 Gorevi { get; set; }
        public void DerslerTanımEkle();
        public void DerslerTanımSil();
        public void DerslerTanımGuncelle();

    }
}
