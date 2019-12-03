using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeniYurt.Model
{
    public class GiderModel
    {
        public int gıderID { get; set; }
        public string giderTuru { get; set; }
        public Nullable<int> giderTutar { get; set; }
    }
}
