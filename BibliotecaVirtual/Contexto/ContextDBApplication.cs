using BibliotecaVirtu.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaVirtual.Contexto
{
    public class ContextDBApplication : DbContext
    {
        public ContextDBApplication(DbContextOptions<ContextDBApplication> options) : base(options)
        {
        }
        public DbSet<LivroDTO> Livros { get; set; }
    }
}
