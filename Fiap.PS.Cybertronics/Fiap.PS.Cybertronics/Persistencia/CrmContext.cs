using Fiap.PS.Cybertronics.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.PS.Cybertronics.Persistencia
{
    public class CrmContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Empresa> Empresas { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public int MyProperty { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProdutoUsuarios>().HasKey(e => new { e.ProdutoId, e.UsuarioId });

            modelBuilder.Entity<ProdutoUsuarios>().HasOne(e => e.Produto).WithMany(e => e.ProdutoUsuarios).HasForeignKey(e => e.ProdutoId);

            modelBuilder.Entity<ProdutoUsuarios>().HasOne(e => e.Usuario).WithMany(e => e.ProdutoUsuarios).HasForeignKey(e => e.UsuarioId);

            base.OnModelCreating(modelBuilder);
        }

        public CrmContext(DbContextOptions options) : base(options)
        {

        }

    }
}
