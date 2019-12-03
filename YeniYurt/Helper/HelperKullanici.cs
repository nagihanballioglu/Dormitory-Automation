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
    class HelperKullanici
    {
        public static Yonetici GetKullanici(string kullanici, string sifre)
        {
            using (YurtDbEntities db = new YurtDbEntities())
            {
                return db.Yonetici.Where(x => x.YoneticiAdi == kullanici && x.YoneticiSifre == sifre).FirstOrDefault();
            }
        }
        public static Yonetici GetKullanici(int ID)
        {
            using (YurtDbEntities db = new YurtDbEntities())
            {
                return db.Yonetici.Where(x => x.YoneticiID == ID).FirstOrDefault();
            }
        }
        public static Yonetici UpdateKullanici(Yonetici k)
        {
            using (YurtDbEntities db = new YurtDbEntities())
            {
                db.Entry(k).State = EntityState.Modified;
                db.Yonetici.Add(k);
                db.SaveChanges();
                return k;
            }
        }


        //public static int BulSifre(string sifre)
        //{
        //    int id = 0;
        //    using(YurtDbEntities db=new YurtDbEntities())
        //    {
        //        var list = db.Yonetici.ToList();
        //        foreach (var item in list)
        //        {
        //            if (item.YoneticiSifre==sifre)
        //            {
        //                id = item.YoneticiID;
        //            }
        //        }
        //    }
        //    return id;
        //}

        //public static Yonetici ConvertToYonetici(YoneticiModel odm)//Yonetici tablosunu yoneticiModel sınıfına dönderir.
        //{
        //    Yonetici y = new Yonetici();
        //    y.YoneticiID = odm.YoneticiID;
        //    y.YoneticiAdi = odm.YoneticiAdi;
        //    y.YoneticiSifre = odm.YoneticiSifre;
        //    return y;

        //}
        //public static bool AddKullanici(YoneticiModel yoneticiekle)
        //{
        //    using (YurtDbEntities db = new YurtDbEntities())
        //    {
        //        Yonetici odemeler = ConvertToYonetici(yoneticiekle);
        //        db.Yonetici.Add(odemeler);
        //        if (db.SaveChanges() > 0)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}
    }
}
