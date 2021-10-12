using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Registro_De_Permisos.Entidades;

namespace Registro_De_Permisos.DAL
{
    class Contexto : DbContext
    {
        public DbSet<Permiso> Permiso { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<RolesDetalle> RolesDetalle { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = BD_Permiso.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Permiso>().HasData(
                
                new Permiso() { permisoId = 1, descripcion = "Descuenta" },
                new Permiso() { permisoId = 2, descripcion = "Vende" },
                new Permiso() { permisoId = 3, descripcion = "Cobra" }
           );

        }
    }
}
