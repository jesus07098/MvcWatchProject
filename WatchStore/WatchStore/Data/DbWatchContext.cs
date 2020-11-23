using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchStore.Models;

namespace WatchStore.Data
{
    public class DbWatchContext : DbContext
    {

        public DbWatchContext(DbContextOptions<DbWatchContext> options) : base(options)
        {
        }

        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Marca> Marcas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Provincia>().ToTable("Provincia");
            modelBuilder.Entity<Direccion>().ToTable("Direccion");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Marca>().ToTable("Marca");
        }

    }
}
