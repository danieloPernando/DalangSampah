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
    
    public partial class TipeIdentita
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipeIdentita()
        {
            this.Nasabahs = new HashSet<Nasabah>();
        }
    
        public int ID { get; set; }
        public string TipeIdentitas { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nasabah> Nasabahs { get; set; }
    }
}