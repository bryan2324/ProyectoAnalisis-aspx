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
    
    public partial class InfoHabilidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InfoHabilidad()
        {
            this.habilidades_perfilProfesional = new HashSet<habilidades_perfilProfesional>();
            this.InfoRequisitos = new HashSet<InfoRequisitos>();
        }
    
        public int idHabilidad { get; set; }
        public string habilidad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<habilidades_perfilProfesional> habilidades_perfilProfesional { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoRequisitos> InfoRequisitos { get; set; }
    }
}
