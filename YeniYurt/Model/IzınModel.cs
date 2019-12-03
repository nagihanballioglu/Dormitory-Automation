using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YeniYurt.Entity;

namespace YeniYurt.Model
{
   public class IzınModel
    {
        public int IzınID { get; set; }
        public Nullable<int> OgrenciID { get; set; }
        public string OgrenciTC { get; set; }
        public Nullable<System.DateTime> gidisTarihi { get; set; }
        public Nullable<System.DateTime> donusTarihi { get; set; }
        public string gidecegiKisiTel { get; set; }
        public string gşdecegiAdres { get; set; }

        public Ogrenciler ogrenciler = new Ogrenciler();

        public OgrenciModel om = new OgrenciModel();

        // public virtual Ogrenciler Ogrenciler { get; set; }
    }
}
