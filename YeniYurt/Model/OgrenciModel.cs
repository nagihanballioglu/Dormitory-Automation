using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeniYurt.Model
{
    public class OgrenciModel
    {
        public int OgrenciID { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public string OgrenciTC { get; set; }
        public string OgrenciOkul { get; set; }
        public string OgrenciBolum { get; set; }
        public string OgrenciSınıf { get; set; }
        public Nullable<System.DateTime> OgrenciKayitTarihi { get; set; }
        public Nullable<int> KalacagiOda { get; set; }
        public string OgrenciTelefon { get; set; }
        public string VeliAdi { get; set; }
        public string VeliTelefon { get; set; }
        public string OgrenciAdresi { get; set; }
    }
}
