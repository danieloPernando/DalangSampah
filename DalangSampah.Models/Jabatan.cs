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
    
    public partial class Jabatan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Jabatan()
        {
            this.Karyawans = new HashSet<Karyawan>();
        }
    
        public int ID { get; set; }
        public string Jabatan1 { get; set; }
        public string Deskripsi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Karyawan> Karyawans { get; set; }
    }
}
