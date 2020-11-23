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
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Rol_usuario> Roles_usuario { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Categoria_producto> Categorias_producto { get; set; }
        public DbSet<Imagenproducto> Imagenesproducto { get; set; }
        public DbSet<Itemcarrito> Itemscarrito { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Detallepedido> Detallespedido { get; set; }









        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Provincia>().ToTable("Provincia");
            modelBuilder.Entity<Direccion>().ToTable("Direccion");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Marca>().ToTable("Marca");
            modelBuilder.Entity<Rol>().ToTable("Rol");
            modelBuilder.Entity<Rol_usuario>().ToTable("Rol_usuario");
            modelBuilder.Entity<Producto>().ToTable("Producto");
            modelBuilder.Entity<Categoria>().ToTable("Categoria");
            modelBuilder.Entity<Categoria_producto>().ToTable("Categoria_producto");
            modelBuilder.Entity<Imagenproducto>().ToTable("Imagenproducto");
            modelBuilder.Entity<Itemcarrito>().ToTable("Itemcarrito");
            modelBuilder.Entity<Pedido>().ToTable("Pedido");
            modelBuilder.Entity<Detallepedido>().ToTable("Detallepedido");





            //Llaves compuestas
            modelBuilder.Entity<Rol_usuario>()
        .HasKey(ru => new { ru.rolID, ru.usuarioID });

         modelBuilder.Entity<Categoria_producto>()
        .HasKey(c => new { c.categoriaID, c.productoID });
            modelBuilder.Entity<Itemcarrito>()
.HasKey(cr => new { cr.usuarioID, cr.productoID });

            modelBuilder.Entity<Detallepedido>()
        .HasKey(d => new { d.pedidoID, d.productoID });


        }

    }
}
