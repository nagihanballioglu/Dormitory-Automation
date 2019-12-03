using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YeniYurt.Entity;

namespace YeniYurt.Model
{
    public class OdemeModel
    {
        public int OdemeID { get; set; }
        public Nullable<int> OgrenciID { get; set; }
        public string OgrenciTC { get; set; }
        public Nullable<int> KalanTaksit { get; set; }
        public Nullable<int> odenenTutar { get; set; }
        public Nullable<System.DateTime> odemeTarihi { get; set; }


        public Ogrenciler ogrenciler = new Ogrenciler();

        public OgrenciModel om = new OgrenciModel();
        // public virtual Ogrenciler Ogrenciler { get; set; }
    }
}
