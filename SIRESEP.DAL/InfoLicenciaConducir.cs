//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIRESEP.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class InfoLicenciaConducir
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InfoLicenciaConducir()
        {
            this.InfoAdicional = new HashSet<InfoAdicional>();
        }
    
        public int idLicenciaConducir { get; set; }
        public string licencia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoAdicional> InfoAdicional { get; set; }
    }
}
