using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YeniYurt.Entity;
using YeniYurt.Model;

namespace YeniYurt.Helper
{
    class HelperOgrenci
    {
        public static int BulOgrenciID(string tc)
        {
            int id = 0;
            using (YurtDbEntities yde = new YurtDbEntities())
            {
                var list = yde.Ogrenciler.ToList();
                foreach (var item in list)
                {
                    if (item.OgrenciTC==tc)
                    {
                        id = item.OgrenciID;
                    }
                }
            }
            return id;
        }
        public static Ogrenciler ConvertToOgrenci(OgrenciModel om)//Ogrenciler tablosunu ogrencimodel sınıfına dönderir.
        {
            Ogrenciler yeniogrenci = new Ogrenciler();
            yeniogrenci.OgrenciID = om.OgrenciID;
            yeniogrenci.OgrenciAdi = om.OgrenciAdi;
            yeniogrenci.OgrenciSoyadi = om.OgrenciSoyadi;
            yeniogrenci.OgrenciTC = om.OgrenciTC;
            yeniogrenci.OgrenciOkul = om.OgrenciOkul;
            yeniogrenci.OgrenciBolum = om.OgrenciBolum;
            yeniogrenci.OgrenciSınıf = om.OgrenciSınıf;
            yeniogrenci.OgrenciKayitTarihi = om.OgrenciKayitTarihi;
            yeniogrenci.KalacagiOda = om.KalacagiOda;
            yeniogrenci.OgrenciTelefon = om.OgrenciTelefon;
            yeniogrenci.VeliAdi = om.VeliAdi;
            yeniogrenci.VeliTelefon = om.VeliTelefon;
            yeniogrenci.OgrenciAdresi = om.OgrenciAdresi;

            return yeniogrenci;
        }

        public static bool AddOgrenci(OgrenciModel ogrekle)
        {
            using (YurtDbEntities db = new YurtDbEntities())
            {
                Ogrenciler ogrenciler = ConvertToOgrenci(ogrekle);
                db.Ogrenciler.Add(ogrenciler);
                if (db.SaveChanges()>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool UpdateOgrenci(OgrenciModel ogrguncelle)
        {
            var yeniogrenci = ConvertToOgrenci(ogrguncelle);
            using (YurtDbEntities db = new YurtDbEntities())
            {

                db.Entry(yeniogrenci).State = EntityState.Modified;

                if (db.SaveChanges() > 0)
                {
                    return true;
                }
                else
                    return false;


            }
        }

        public static bool DeleteOgrenci(int ID)
        {
            using (YurtDbEntities db = new YurtDbEntities())
            {
                var studentdelete = db.Ogrenciler.Find(ID);
                db.Ogrenciler.Remove(studentdelete);
                if (db.SaveChanges()>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }

        public static List<Ogrenciler> GetOgrenciler(string gc)
        {
            using (YurtDbEntities db = new YurtDbEntities())
            {
                return db.Ogrenciler.Where(c => c.OgrenciAdi.Contains(gc)).ToList();
            }
        }

        public static List<OgrenciModel> OgrenciListesiModel()// öğrenciler tablosunu model cinsinden listeleyip datagride basar.
        {
            List<OgrenciModel> ogrenciList = new List<OgrenciModel>();
            using (YurtDbEntities ch = new YurtDbEntities())
            {
                var list = ch.Ogrenciler.ToList();
                foreach (Ogrenciler item in list)
                {
                    OgrenciModel om = new OgrenciModel();
                    
                    om.OgrenciID = item.OgrenciID;
                    om.OgrenciAdi = item.OgrenciAdi;
                    om.OgrenciSoyadi = item.OgrenciSoyadi;
                    om.OgrenciTC = item.OgrenciTC;
                    om.OgrenciOkul = item.OgrenciOkul;
                    om.OgrenciBolum = item.OgrenciBolum;
                    om.OgrenciSınıf = item.OgrenciSınıf;
                    om.OgrenciKayitTarihi = item.OgrenciKayitTarihi;
                    om.KalacagiOda = item.KalacagiOda;
                    om.OgrenciTelefon = item.OgrenciTelefon;
                    om.VeliAdi = item.VeliAdi;
                    om.VeliTelefon = item.VeliTelefon;
                    om.OgrenciAdresi = item.OgrenciAdresi;
                    ogrenciList.Add(om);

                }
            }
            return ogrenciList;
        }

        public static List<OgrenciModel> StudentModelDon(List<Ogrenciler> ogrencidön)
        {
            List<OgrenciModel> studentModels = new List<OgrenciModel>();

            foreach (var item in ogrencidön)
            {
                OgrenciModel om = new OgrenciModel();
                {
                    om.OgrenciID = item.OgrenciID;
                    om.OgrenciAdi = item.OgrenciAdi;
                    om.OgrenciSoyadi = item.OgrenciSoyadi;
                    om.OgrenciTC = item.OgrenciTC;
                    om.OgrenciOkul = item.OgrenciOkul;
                    om.OgrenciBolum = item.OgrenciBolum;
                    om.OgrenciSınıf = item.OgrenciSınıf;
                    om.OgrenciKayitTarihi = item.OgrenciKayitTarihi;
                    om.KalacagiOda = item.KalacagiOda;
                    om.OgrenciTelefon = item.OgrenciTelefon;
                    om.VeliAdi = item.VeliAdi;
                    om.VeliTelefon = item.VeliTelefon;
                    om.OgrenciAdresi = item.OgrenciAdresi;

                }

                studentModels.Add(om);
            }

            return studentModels;
        } //textboxa yazdırmak için

        //public static int FindOgrenci(OgrenciModel m)// silme butonunda  kullanıldı.
        //{
        //    int ogrID = 0;
        //    using (YurtDbEntities db = new YurtDbEntities())
        //    {
        //        var list = db.Ogrenciler.ToList();
        //        foreach (var item in list)
        //        {
        //            if (m.OgrenciID.Equals(item.OgrenciID) && m.OgrenciAdi.Equals(item.OgrenciAdi) &&
        //                m.OgrenciSoyadi.Equals(item.OgrenciSoyadi) && m.OgrenciTC.Equals(item.OgrenciTC) &&
        //                m.OgrenciOkul.Equals(item.OgrenciOkul) && m.OgrenciBolum.Equals(item.OgrenciBolum) &&
        //                m.OgrenciSınıf.Equals(item.OgrenciSınıf) && m.OgrenciKayitTarihi.Equals(item.OgrenciKayitTarihi) &&
        //                m.KalacagiOda.Equals(item.KalacagiOda) && m.OgrenciTelefon.Equals(item.OgrenciTelefon) &&
        //                m.VeliAdi.Equals(item.VeliAdi) && m.VeliTelefon.Equals(item.VeliTelefon) && m.OgrenciAdresi.Equals(item.OgrenciAdresi))
        //            {
        //                ogrID = item.OgrenciID;
        //            }
        //        }
        //    }

        //    return ogrID;
        //}
    }
}
