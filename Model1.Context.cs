﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DREAM_TEAM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PLANEDEntities : DbContext
    {
        public PLANEDEntities()
            : base("name=PLANEDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Actividad> Actividads { get; set; }
        public virtual DbSet<Escuela> Escuelas { get; set; }
        public virtual DbSet<Grado> Gradoes { get; set; }
        public virtual DbSet<Grupo> Grupoes { get; set; }
        public virtual DbSet<Materia> Materias { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Usuario_Escuela> Usuario_Escuela { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Genero> Generoes { get; set; }
        public virtual DbSet<Plantilla> Plantillas { get; set; }
    }
}
