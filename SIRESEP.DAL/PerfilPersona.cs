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
    
    public partial class PerfilPersona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PerfilPersona()
        {
            this.aplicaciones = new HashSet<aplicaciones>();
            this.certificaciones_perfilProfesional = new HashSet<certificaciones_perfilProfesional>();
            this.habilidades_perfilProfesional = new HashSet<habilidades_perfilProfesional>();
            this.infoAdicional_perfilProfesional = new HashSet<infoAdicional_perfilProfesional>();
            this.infoEstudios_perfilProfesional = new HashSet<infoEstudios_perfilProfesional>();
            this.infoLaboral_perfilProfesional = new HashSet<infoLaboral_perfilProfesional>();
            this.perfilProfesional_PerfilConcurso = new HashSet<perfilProfesional_PerfilConcurso>();
        }
    
        public int idPerfilProfesional { get; set; }
        public Nullable<int> idUsuario { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
        public Nullable<int> telefono { get; set; }
        public string direccion { get; set; }
        public Nullable<int> idNacionalidad { get; set; }
        public Nullable<int> idGenero { get; set; }
        public Nullable<int> idEstado { get; set; }
        public string usuarioCrea { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public string usuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<aplicaciones> aplicaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<certificaciones_perfilProfesional> certificaciones_perfilProfesional { get; set; }
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<habilidades_perfilProfesional> habilidades_perfilProfesional { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<infoAdicional_perfilProfesional> infoAdicional_perfilProfesional { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<infoEstudios_perfilProfesional> infoEstudios_perfilProfesional { get; set; }
        public virtual InfoGenero InfoGenero { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<infoLaboral_perfilProfesional> infoLaboral_perfilProfesional { get; set; }
        public virtual InfoNacionalidad InfoNacionalidad { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<perfilProfesional_PerfilConcurso> perfilProfesional_PerfilConcurso { get; set; }
    }
}