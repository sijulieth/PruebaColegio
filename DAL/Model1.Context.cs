﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class colegiobdEntities : DbContext
    {
        public colegiobdEntities()
            : base("name=colegiobdEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tblcursos> tblcursos { get; set; }
        public DbSet<tblestudiantes> tblestudiantes { get; set; }
        public DbSet<tblmatriculas> tblmatriculas { get; set; }
    }
}
