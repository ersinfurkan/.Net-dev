using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜniversiteIK
{
    public class Enumlar  /*Bütün Interfaces'lerim için ortak aldığım enum class'ım*/
    {
        public enum Bolumler
        {
            Tiyatro = 0,
            BilgisayasarProgramcılıgı = 1,
            GıdaMuhendıslıgı = 2,
            Makine = 3,           
            Muhendis = 4,
            BilgisayarMuhendisligi = 5,
            InsaatMuhendıslıgı = 6,
            Tıp = 7,
       }

        public enum Departmanlar
        {
            Hizmet = 10,
            Muhasebe = 11,
            Pazarlama = 12,
            Uretim = 13,
            Tasıma = 14,

        }

        public enum IderiPersonelGorevleri
        {
            StokYonetimi = 0,
            IdariDestek = 1,
            HarcamaRaporu = 2,
            SırketKayıtları =3,

        }

        public enum OgrenciIsleri
        {
            DersKaydı = 0,
            Tecil = 1,
            OgrenciBelgesi =2,
            KayıtDondurma =3,
            Muafiyet =4,
            Burs =5,
        }


        public enum OgretimGorevlisi
        {
            SosyalHizmetler = 0,
            YayınEtkinlikleri = 1,
            GuvenlikOnlemleri = 2,
            BilimselArastırma = 3,

        }

        public enum OgretimGorevlisi1
        {
            SosyalHizmetler = 0,
            YayınEtkinlikleri = 1,
            GuvenlikOnlemleri = 2,
            BilimselArastırma = 3,
        }


      




    }
}