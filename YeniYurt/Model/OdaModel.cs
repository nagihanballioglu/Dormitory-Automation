using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YeniYurt.Entity;

namespace YeniYurt.Model
{
  public class OdaModel
    {
        public int OdaID { get; set; }
        public Nullable<int> OgrenciID { get; set; }
        public string OgrenciTC { get; set; }
        public Nullable<int> OdaNo { get; set; }
        public Nullable<int> OdaKatNo { get; set; }

        public Ogrenciler ogrenciler = new Ogrenciler();


        //public virtual Ogrenciler Ogrenciler { get; set; }
    }
}
