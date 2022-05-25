using Microsoft.EntityFrameworkCore;
using OpenUp.EFCore.Autores;
using OpenUp.EFCore.Livros;

namespace OpenUp.EFCore.EFContext
{
    public class LivroContext : DbContext
    {
        public DbSet<Livro> Livros { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=CustomerDB.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>().ToTable("Livros");
            modelBuilder.Entity<Autor>().ToTable("Autores");
        }
    }
}