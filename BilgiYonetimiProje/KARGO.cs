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
    
    public partial class KARGO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KARGO()
        {
            this.KITAPSEVKIYATI = new HashSet<KITAPSEVKIYATI>();
        }
    
        public int ID { get; set; }
        public string FirmaAdı { get; set; }
        public string FirmaTelefonNumarası { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KITAPSEVKIYATI> KITAPSEVKIYATI { get; set; }
    }
}