//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace D1_KEVIND_RADHITYA_WICAKSONO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Paket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Paket()
        {
            this.Transaksis = new HashSet<Transaksi>();
        }
    
        public int ID { get; set; }
        public string Nama { get; set; }
        public Nullable<int> IDJenis { get; set; }
        public double HargaPerJam { get; set; }
    
        public virtual Jeni Jeni { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaksi> Transaksis { get; set; }
    }
}
