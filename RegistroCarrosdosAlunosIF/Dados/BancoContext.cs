using Microsoft.EntityFrameworkCore;
using RegistroCarrosdosAlunosIF.Models;

namespace RegistroCarrosdosAlunosIF.Dados
{
    public class CadastroDbContext : DbContext
    {
        public CadastroDbContext(DbContextOptions options) : base(options) 
        { 
        }
        public DbSet<Cadastros> Cadastros { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Cadastros>(entity => {
                entity.HasIndex(e => e.Email).IsUnique();
                entity.HasIndex(c => c.CNH).IsUnique();
                entity.HasIndex(t => t.Telefone).IsUnique();
                entity.HasIndex(p => p.Placa).IsUnique();
            });
        }
    }

}
