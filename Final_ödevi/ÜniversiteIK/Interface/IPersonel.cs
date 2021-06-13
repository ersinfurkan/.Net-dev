using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜniversiteIK
{
    public interface IPersonel /*Personel class'ı için miras alınacak Interfaces değişkenim*/
    {
        public int KimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime Dogum_Tarihi { get; set; }
        public Enumlar.Departmanlar Gorevi { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public void PersonelEkle();
        public void Personel_sil();
        public void Personel_Guncelle();


    }
}
