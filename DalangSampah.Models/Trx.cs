//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DalangSampah.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trx
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trx()
        {
            this.TrxDetails = new HashSet<TrxDetail>();
        }
    
        public int ID { get; set; }
        public int TypeID { get; set; }
        public int NasabahID { get; set; }
        public int KaryawanID { get; set; }
        public System.DateTime TglTrx { get; set; }
        public decimal LastBalance { get; set; }
    
        public virtual Karyawan Karyawan { get; set; }
        public virtual Nasabah Nasabah { get; set; }
        public virtual TrxType TrxType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrxDetail> TrxDetails { get; set; }
    }
}
