using AutenticacaoEfCookie.Models;
using Microsoft.EntityFrameworkCore;

namespace AutenticacaoEfCookie.Dados
{
    public class AutenticacaoContexto : DbContext
    {
        //Classe Contexto (Banco de dados) 

        public AutenticacaoContexto(DbContextOptions<AutenticacaoContexto> options) : base(options)
        {}

        public DbSet<Usuario> UsuariosNoBanco {get; set;}

        public DbSet<Permissao> PermissoesNoBanco {get; set;}

        public DbSet<UsuarioPermissao> UsuariosPermissoesNoBanco {get; set;}

        //Criando Tabelas no Banco
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");
            modelBuilder.Entity<Permissao>().ToTable("Permissoes");
            modelBuilder.Entity<UsuarioPermissao>().ToTable("UsuariosPermissoes");

            base.OnModelCreating(modelBuilder);
        }

    }
}