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
    
    public partial class PERSONEL
    {
        public int ID { get; set; }
        public string PersonalAdi { get; set; }
        public string PersonelSoyadi { get; set; }
        public string T_C_KimlikNumaras─▒ { get; set; }
        public System.DateTime DogumTarihi { get; set; }
        public Nullable<int> SubeID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string E_Mail { get; set; }
    
        public virtual YAYINEVISUBELERI YAYINEVISUBELERI { get; set; }
    }
}
