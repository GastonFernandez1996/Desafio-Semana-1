using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Desafio_Semana_1.Contexts
{
    public class UsuarioContext : DbContext
    {

        private const string Schema = "Usuario";
        public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options)
        {
        }

        protected override OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
            modelBuilder.HasDefaultSchema(Schema);
        }

        public DbSet<Usuario> Usuarios { get; set; } = null!;
        public DbSet<Posts> Post { get; set; } = null!;
        public DbSet<Comments> Coment { get; set; } = null!;


    }
}
