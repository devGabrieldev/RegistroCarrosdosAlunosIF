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
    }

}
