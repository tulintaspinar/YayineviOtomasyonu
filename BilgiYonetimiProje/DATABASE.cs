using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace BilgiYonetimiProje
{
    //Github bağlantısı
    class DATABASE
    {
        static BilgiYonetimiProjeEntities2 entity = new BilgiYonetimiProjeEntities2();
        public void KitapINSERT(int isbnNo,string kitapAdi,DateTime tarih,int sSayisi,string KitapTuru,string yazarID,string cevirmen,string dosyayolu)
        {
            KITAP kitap = new KITAP();
            int turID = 0,yID = 0;
            foreach (KITAPTURLERI pro in entity.KITAPTURLERI.ToList())
            {
                turID = pro.ID;
            }
            foreach (YAZARLAR pro in entity.YAZARLAR.ToList())
            {
                yID = pro.ID;
            }
            try
            {
                if (cevirmen != "")
                {
                    kitap.ISBN_NO = isbnNo;
                    kitap.KitapAdı = kitapAdi;
                    kitap.YayinTarihi = tarih;
                    kitap.SayfaSayisi = sSayisi;
                    kitap.KitapTuruID = turID;
                    kitap.YazarID = yID;
                    kitap.Çevirmen = cevirmen;
                    kitap.KİtapPDF = dosyayolu;
                }
                else
                {
                    kitap.ISBN_NO = isbnNo;
                    kitap.KitapAdı = kitapAdi;
                    kitap.YayinTarihi = tarih;
                    kitap.SayfaSayisi = sSayisi;
                    kitap.KitapTuruID = turID;
                    kitap.YazarID = yID;
                    kitap.Çevirmen = "-";
                    kitap.KİtapPDF = dosyayolu;
                }
                entity.KITAP.Add(kitap);
                entity.SaveChanges();
            }
            catch (Exception ex)
            {
               
            } 
        }
        public void KitapTuruINSERT(string kTur)
        {
            KITAPTURLERI turler = new KITAPTURLERI();
            turler.KitapTuru = kTur;
            entity.KITAPTURLERI.Add(turler);
            entity.SaveChanges();
        }
        public void YazarINSERT(string ad ,string soyad, string telNo)
        {
            YAZARLAR kayit = new YAZARLAR();
            kayit.YazarAdi = ad;
            kayit.YazarSoyadi = soyad;
            kayit.Telefon_No = telNo;
            entity.YAZARLAR.Add(kayit);
            entity.SaveChanges();
        }
        public void PersonelINSERT(string ad, string soyad,string tc,string email,DateTime dt,int subeID,string kullaniciAdi,string sifre)
        {
            PERSONEL kayit = new PERSONEL();
            kayit.PersonalAdi = ad;
            kayit.PersonelSoyadi = soyad;
            kayit.T_C_KimlikNumarası = tc;
            kayit.E_Mail = email;
            kayit.DogumTarihi = dt;
            kayit.SubeID = subeID;
            kayit.KullaniciAdi = kullaniciAdi;
            kayit.Sifre = sifre;
            entity.PERSONEL.Add(kayit);
            entity.SaveChanges();
        }
        public void KargoINSERT(string firmaAdı,string telefonNo)
        {
            KARGO kayit = new KARGO();
            kayit.FirmaAdı = firmaAdı;
            kayit.FirmaTelefonNumarası = telefonNo;
            entity.KARGO.Add(kayit);
            entity.SaveChanges();
        }
        public void KitapSevkiyatINSERT(int yayineviID,int kitapciID, int kitapID, int kargoID, int kitapAdedi)
        {
            Random rnd = new Random();
            KITAPSEVKIYATI kayit = new KITAPSEVKIYATI();
            kayit.GönderenYayınEvi = yayineviID;
            kayit.KitapciID = kitapciID;
            kayit.KitapID = kitapID;
            kayit.KargoID = kargoID;
            kayit.KargoTakipNumarası = rnd.Next();
            kayit.KitapAdedi = kitapAdedi;
            kayit.GonderimDurumu = "GÖNDERİLDİ";
            entity.KITAPSEVKIYATI.Add(kayit);
            entity.SaveChanges();
        }
        public void KitapSevkiyatUPDATE(double takipNo)
        {
            var list = entity.KITAPSEVKIYATI.Where(x => x.KargoTakipNumarası == takipNo).FirstOrDefault();
            list.GonderimDurumu = "TESLİM EDİLDİ";
            entity.SaveChanges();
        }
        public void KitapSevkiyatDELETE(int kargoNo)
        {
            var list = entity.KITAPSEVKIYATI.Where(x => x.KargoTakipNumarası == kargoNo).FirstOrDefault();
            entity.KITAPSEVKIYATI.Remove(list);
            entity.SaveChanges();
        }
        public void KitapciINSERT(KITAPCİLAR kitapci)
        {
            entity.KITAPCİLAR.Add(kitapci);
            entity.SaveChanges();
        }
    }
}
