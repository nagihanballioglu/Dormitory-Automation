using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YeniYurt.Entity;
using YeniYurt.Model;

namespace YeniYurt.Helper
{
    class Helperİzin
    {
        public static Izınler ConvertToIzınler(IzınModel ım)//Izınler tablosunu IzınModel sınıfına dönderir.
        {
            Izınler yeniIzın = new Izınler();
            yeniIzın.IzınID = ım.IzınID;
            yeniIzın.OgrenciID = ım.OgrenciID;
            yeniIzın.OgrenciTC = ım.OgrenciTC;
            yeniIzın.gidisTarihi = ım.gidisTarihi;
            yeniIzın.donusTarihi = ım.donusTarihi;
            yeniIzın.gidecegiKisiTel = ım.gidecegiKisiTel;
            yeniIzın.gşdecegiAdres = ım.gşdecegiAdres;

            return yeniIzın;
        }
        public static bool AddIzın(IzınModel ızınekle)
        {
            using (YurtDbEntities db = new YurtDbEntities())
            {
                Izınler ızınler = ConvertToIzınler(ızınekle);
                db.Izınler.Add(ızınler);
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

        public static bool DeleteIzın(int ID)
        {
            using (YurtDbEntities db = new YurtDbEntities())
            {
                var izindelete = db.Izınler.Find(ID);
                db.Izınler.Remove(izindelete);
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

        public static List<IzınModel> IzınlerListesiModel()
        {
            List<IzınModel> izinlerList = new List<IzınModel>();
            using (YurtDbEntities db = new YurtDbEntities())
            {
                var list = db.Izınler.ToList();
                var ogrenciList = db.Ogrenciler.ToList();
                foreach (var item in list)
                {
                    IzınModel ım = new IzınModel();
                    ım.IzınID = item.IzınID;
                    ım.OgrenciID = item.OgrenciID;
                    ım.OgrenciTC = item.OgrenciTC;
                    ım.gidisTarihi = item.gidisTarihi;
                    ım.donusTarihi = item.donusTarihi;
                    ım.gidecegiKisiTel = item.gidecegiKisiTel;
                    ım.gşdecegiAdres = item.gşdecegiAdres;

                    foreach (var ogrenci in ogrenciList)
                    {
                        if (item.OgrenciTC==ogrenci.OgrenciTC)
                        {
                            ım.om.OgrenciAdi = ogrenci.OgrenciAdi;
                            ım.om.OgrenciSoyadi = ogrenci.OgrenciSoyadi;
                        }
                    }
                    izinlerList.Add(ım);
                }
            }
            return izinlerList;
        }


        public static List<Izınler> GetIzınler(string gi)// textboxa isim gelsin diye
        {
            using (YurtDbEntities db = new YurtDbEntities())
            {
                return db.Izınler.Where(c => c.Ogrenciler.OgrenciAdi.Contains(gi)).ToList();
            }
        }


    }
}
