using System;
using ÜniversiteIK;

namespace Final_ödevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yapmak istediğiniz işlemleri tek tek yazınız:");     

            string Ogrenci;
            Ogrenci = Console.ReadLine();
            if (Ogrenci == "Ögrenci ekle")
            {
                Ogrenci ogrenciekle = new();
                ogrenciekle.OgrenciEkle();
                
            }           
            else if (Ogrenci == "Ögrenci sil")            /*ÜniversiteIk projemi çalıştırabilmek için ayrı açtığım new project*/
            {
                Ogrenci ogrencisil = new();
                ogrencisil.OgrenciSil();
            }
            else if (Ogrenci == "Ögrenci guncelle")
            {
                Ogrenci ogrenciguncelle = new();
                ogrenciguncelle.OgrenciGuncelle();
            }
            


            string Personel;
            Personel = Console.ReadLine();
            if (Personel == "Personel ekle")
            {
                Personel PersonelEkle = new();
                PersonelEkle.PersonelEkle();
            }
            else if (Personel == "Personel sil")
            {
                Personel Personel_sil = new();
                Personel_sil.Personel_sil();
            }
            else if (Personel == "Personel guncelle")
            {
                Personel Personel_Guncelle = new();
                Personel_Guncelle.Personel_Guncelle();
            }

            string IdariPersonel;
            IdariPersonel = Console.ReadLine();

            if(IdariPersonel == "Idaripersonel ekle")
            {
                IdariPersonel IdariPersonelEkle = new();
                IdariPersonelEkle.IdariPersonelEkle();
            }
            else if (IdariPersonel == "Idaripersonel sil")
            {
                IdariPersonel IdariPersonelSil = new();
                IdariPersonelSil.IdariPersonelSil();
            }
            else if (IdariPersonel == "Idaripersonel guncelle")
            {
                IdariPersonel IdariPersonelGuncelle = new();
                IdariPersonelGuncelle.IdariPersonelGuncelle();
            }


            string OgrenciIsleri;
            OgrenciIsleri = Console.ReadLine();
            if (OgrenciIsleri =="Ogrenciisleri ekle")
            {
                OgrenciIsleri OgrenciIsleriEkle = new();
                OgrenciIsleriEkle.OgrenciIsleriEkle();
            }
            else if (OgrenciIsleri == "Ogrenciisleri sil")
            {
                OgrenciIsleri OgrenciIsleriSil = new();
                OgrenciIsleriSil.OgrenciIsleriSil();
            }
            else if (OgrenciIsleri == "Ogrenciisleri guncelle")
            {
                OgrenciIsleri OgrenciIsleriGuncelle = new();
                OgrenciIsleriGuncelle.OgrenciIsleriGuncelle();
            }


            string OgretimGorevlisi;

            OgretimGorevlisi = Console.ReadLine();
            if (OgretimGorevlisi =="Ogretimgorevlisi ekle")
            {
                OgretimGorevlisi OgrentimGorevlisiEkle = new();
                OgrentimGorevlisiEkle.OgrentimGorevlisiEkle();
            }
            else if  (OgretimGorevlisi == "Ogretimgorevlisi sil")
            {
                OgretimGorevlisi OgretimGorevlisiSil = new();
                OgretimGorevlisiSil.OgretimGorevlisiSil();
            }
            else if (OgretimGorevlisi == "Ogretimgorevlisi guncelle")
            {
                OgretimGorevlisi OgretimGorevlisiGuncelle = new();
                OgretimGorevlisiGuncelle.OgretimGorevlisiGuncelle();
            }

            string DerslerTanım;
            DerslerTanım = Console.ReadLine();
            if (DerslerTanım =="Derstanım ekle")
            {
                DerslerTanım DerslerTanımEkle = new();
                DerslerTanımEkle.DerslerTanımEkle();            
            }
            else if (DerslerTanım == "Derstanım sil")
            {
                DerslerTanım DerslerTanımSil = new();
                DerslerTanımSil.DerslerTanımSil();
            }
            else if (DerslerTanım == "Derstanım guncelle")
            {
                DerslerTanım DerslerTanımGuncelle = new();
                DerslerTanımGuncelle.DerslerTanımGuncelle();
            }
            string OgrenciDersTanım;
            OgrenciDersTanım = Console.ReadLine();
            if (OgrenciDersTanım =="Ogrenciderstanım ekle")
            {
                OgrenciDersTanım OgrenciDersEkle = new();
                OgrenciDersEkle.OgrenciDersEkle();
            }
            else if (OgrenciDersTanım == "Ogrenciderstanım sil")
            {
                OgrenciDersTanım OgrenciDersSil = new();
                OgrenciDersSil.OgrenciDersSil();
            }

            





        }
        
    }
}
