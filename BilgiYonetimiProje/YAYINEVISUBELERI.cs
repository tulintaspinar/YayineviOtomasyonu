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
    
    public partial class YAYINEVISUBELERI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public YAYINEVISUBELERI()
        {
            this.PERSONEL = new HashSet<PERSONEL>();
        }
    
        public int ID { get; set; }
        public string SubeAdi { get; set; }
        public string il { get; set; }
        public string Ilçe { get; set; }
        public string Adres { get; set; }
        public string TelefonNumarasi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONEL> PERSONEL { get; set; }
    }
}
