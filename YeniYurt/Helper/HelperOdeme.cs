using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YeniYurt.Entity;
using YeniYurt.Model;

namespace YeniYurt.Helper
{
    class HelperOdeme
    {
        public static Odemeler ConvertToOdemeler(OdemeModel odm)//Odemeler tablosunu OdemeModel sınıfına dönderir.
        {
            Odemeler yeniodeme = new Odemeler();
            yeniodeme.OdemeID = odm.OdemeID;
            yeniodeme.OgrenciID = odm.OgrenciID;
            yeniodeme.OgrenciTC = odm.OgrenciTC;
            yeniodeme.KalanTaksit = odm.KalanTaksit;
            yeniodeme.odenenTutar = Convert.ToInt32(odm.odenenTutar);
            yeniodeme.odemeTarihi = odm.odemeTarihi;
            return yeniodeme;
        }

        public static bool AddOdeme(OdemeModel odemeekle)
        {
            using (YurtDbEntities db = new YurtDbEntities())
            {
                Odemeler odemeler = ConvertToOdemeler(odemeekle);
                db.Odemeler.Add(odemeler);
                if (db.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool DeleteOdeme(int ID)
        {
            using (YurtDbEntities db = new YurtDbEntities())
            {
                var odemedelete = db.Odemeler.Find(ID);
                db.Odemeler.Remove(odemedelete);
                if (db.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public static List<OdemeModel> OdemelerListesiModel()
        {
            List<OdemeModel> odemelerlerList = new List<OdemeModel>();
            using (YurtDbEntities db = new YurtDbEntities())
            {
                var list = db.Odemeler.ToList();
                var ogrList = db.Ogrenciler.ToList();
                foreach (var item in list)
                {
                    OdemeModel odm = new OdemeModel();
                    odm.OdemeID = item.OdemeID;
                    odm.OgrenciID = item.OgrenciID;
                    odm.OgrenciTC = item.OgrenciTC;
                    odm.KalanTaksit = item.KalanTaksit;
                    odm.odenenTutar = item.odenenTutar;
                    odm.odemeTarihi = item.odemeTarihi;

                    foreach (var ogrenci in ogrList)
                    {
                        if (item.OgrenciTC == ogrenci.OgrenciTC)
                        {
                            //ım.om.OgrenciTC = ogrenci.OgrenciTC;
                            odm.om.OgrenciAdi = ogrenci.OgrenciAdi;
                            odm.om.OgrenciSoyadi = ogrenci.OgrenciSoyadi;

                        }
                    }
                    odemelerlerList.Add(odm);

                }
            }
            return odemelerlerList;
        }

        public static List<OdemeModel> OdemeModelDon(List<Odemeler> odemedön)
        {
            List<OdemeModel> studentModels = new List<OdemeModel>();
            using (YurtDbEntities db = new YurtDbEntities())
            {
                var ogTC = db.Ogrenciler.ToList();
                foreach (var item in odemedön)
                {
                    OdemeModel om = new OdemeModel();
                    {
                        om.OgrenciID = item.OgrenciID;
                        om.OgrenciTC = item.OgrenciTC;
                        om.KalanTaksit = item.KalanTaksit;
                        om.odenenTutar = item.odenenTutar;
                        foreach (var ogrenci in ogTC)
                        {
                            if (item.OgrenciTC == ogrenci.OgrenciTC)
                            {
                                om.om.OgrenciAdi = ogrenci.OgrenciAdi;
                                om.om.OgrenciSoyadi = ogrenci.OgrenciSoyadi;

                            }
                        }

                    }

                    studentModels.Add(om);
                }
            }
            return studentModels;
        } //textboxa yazdırmak için

        public static List<Odemeler> GetOdemeler(string gc)
        {
            using (YurtDbEntities db = new YurtDbEntities())
            {
                return db.Odemeler.Where(c => c.OgrenciTC.Contains(gc)).ToList();
            }
        }
    }
}
