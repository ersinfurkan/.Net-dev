using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜniversiteIK
{
    public interface IIdariPersonel /*IdariPersonel class'ı için miras alınacak Interfaces değişkenim*/
    {
        public int KimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime Dogum_Tarihi { get; set; }
        public Enumlar.IderiPersonelGorevleri Gorevi { get; set; }
        public void IdariPersonelEkle();
        public void IdariPersonelSil();
        public void IdariPersonelGuncelle();

    }
}
