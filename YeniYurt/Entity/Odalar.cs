//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YeniYurt.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Odalar
    {
        public int OdaID { get; set; }
        public Nullable<int> OgrenciID { get; set; }
        public string OgrenciTC { get; set; }
        public Nullable<int> OdaNo { get; set; }
        public Nullable<int> OdaKatNo { get; set; }
    
        public virtual Ogrenciler Ogrenciler { get; set; }
    }
}
