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
    class HelperGider
    {
        public static Gıderler ConvertToGider(GiderModel gm)//Giderler tablosunu GiderModel sınıfına dönderir.
        {
            Gıderler yenigider = new Gıderler();
            yenigider.gıderID = gm.gıderID;
            yenigider.giderTuru = gm.giderTuru;
            yenigider.giderTutar = gm.giderTutar;

            return yenigider;
        }
        public static bool AddGider(GiderModel giderekle)
        {
            using (YurtDbEntities db = new YurtDbEntities())
            {
                Gıderler giderler = ConvertToGider(giderekle);
                db.Gıderler.Add(giderler);
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
        public static bool DeleteGider(int ID)
        {
            using (YurtDbEntities db = new YurtDbEntities())
            {
                var giderdelete = db.Gıderler.Find(ID);
                db.Gıderler.Remove(giderdelete);
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
        public static List<GiderModel> GiderListesiModel()// giderler tablosunu model cinsinden listeleyip datagride basar.
        {
            List<GiderModel> giderList = new List<GiderModel>();
            using (YurtDbEntities db = new YurtDbEntities())
            {
                var list = db.Gıderler.ToList();
                foreach (Gıderler item in list)
                {
                    GiderModel gm = new GiderModel();
                    gm.gıderID = item.gıderID;
                    gm.giderTuru = item.giderTuru;
                    gm.giderTutar = item.giderTutar;
                    giderList.Add(gm);
                }
            }
            return giderList;
        }
    }
}
