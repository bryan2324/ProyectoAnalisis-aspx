﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BD_SIRESEPEntities : DbContext
    {
        public BD_SIRESEPEntities()
            : base("name=BD_SIRESEPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<aplicaciones> aplicaciones { get; set; }
        public virtual DbSet<Carrera> Carrera { get; set; }
        public virtual DbSet<Certificaciones> Certificaciones { get; set; }
        public virtual DbSet<certificaciones_perfilProfesional> certificaciones_perfilProfesional { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<habilidades_perfilProfesional> habilidades_perfilProfesional { get; set; }
        public virtual DbSet<InfoAdicional> InfoAdicional { get; set; }
        public virtual DbSet<infoAdicional_perfilProfesional> infoAdicional_perfilProfesional { get; set; }
        public virtual DbSet<InfoEstudios> InfoEstudios { get; set; }
        public virtual DbSet<infoEstudios_perfilProfesional> infoEstudios_perfilProfesional { get; set; }
        public virtual DbSet<InfoGenero> InfoGenero { get; set; }
        public virtual DbSet<InfoGradoEstudio> InfoGradoEstudio { get; set; }
        public virtual DbSet<InfoHabilidad> InfoHabilidad { get; set; }
        public virtual DbSet<InfoIdioma> InfoIdioma { get; set; }
        public virtual DbSet<InfoInstitucion> InfoInstitucion { get; set; }
        public virtual DbSet<InfoLaboral> InfoLaboral { get; set; }
        public virtual DbSet<infoLaboral_perfilProfesional> infoLaboral_perfilProfesional { get; set; }
        public virtual DbSet<InfoLicenciaConducir> InfoLicenciaConducir { get; set; }
        public virtual DbSet<InfoNacionalidad> InfoNacionalidad { get; set; }
        public virtual DbSet<InfoPuesto> InfoPuesto { get; set; }
        public virtual DbSet<InfoRequisitos> InfoRequisitos { get; set; }
        public virtual DbSet<PerfilDelConcurso> PerfilDelConcurso { get; set; }
        public virtual DbSet<PerfilPersona> PerfilPersona { get; set; }
        public virtual DbSet<perfilProfesional_PerfilConcurso> perfilProfesional_PerfilConcurso { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Rol_Usuario> Rol_Usuario { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}