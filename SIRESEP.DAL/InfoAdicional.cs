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
    
    public partial class InfoAdicional
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InfoAdicional()
        {
            this.infoAdicional_perfilProfesional = new HashSet<infoAdicional_perfilProfesional>();
        }
    
        public int idInfoAdicional { get; set; }
        public Nullable<int> idIdioma { get; set; }
        public string nivelIdioma { get; set; }
        public Nullable<int> idLicenciaConducir { get; set; }
    
        public virtual InfoIdioma InfoIdioma { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<infoAdicional_perfilProfesional> infoAdicional_perfilProfesional { get; set; }
        public virtual InfoLicenciaConducir InfoLicenciaConducir { get; set; }
    }
}