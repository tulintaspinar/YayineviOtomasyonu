//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BilgiYonetimiProje
{
    using System;
    using System.Collections.Generic;
    
    public partial class KITAPSEVKIYATI
    {
        public int ID { get; set; }
        public Nullable<int> GönderenYayınEvi { get; set; }
        public Nullable<int> KitapciID { get; set; }
        public Nullable<int> KitapID { get; set; }
        public Nullable<int> KargoID { get; set; }
        public Nullable<double> KitapAdedi { get; set; }
        public Nullable<double> KargoTakipNumarası { get; set; }
        public string GonderimDurumu { get; set; }
    
        public virtual KARGO KARGO { get; set; }
        public virtual KITAP KITAP { get; set; }
        public virtual KITAPCİLAR KITAPCİLAR { get; set; }
    }
}
