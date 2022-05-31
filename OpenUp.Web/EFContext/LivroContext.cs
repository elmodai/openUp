using Microsoft.EntityFrameworkCore;
using OpenUp.EFCore.Autores;
using OpenUp.EFCore.Editoras;
using OpenUp.EFCore.Livros;

namespace OpenUp.Web.EFContext
{
    public class LivroContext : DbContext
    {
        public DbSet<Livro> Livros { get; set; }

        public DbSet<Autor> Autors { get; set; }

        public DbSet<Editora> Editoras { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlite("Data Source=LibrarySys.db;");

            // optionsBuilder
            //     .UseNpgsql("Server=127.0.0.1;Database=LibrSys1;Username=postgres;Password="); 

            // optionsBuilder
            //     .UseSqlServer("Server=127.0.0.1;Database=LibrarySystem;User Id=sa;Password=<YourStrong@Passw0rd>");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>().ToTable("Livros");

            modelBuilder.Entity<Editora>().ToTable("Editoras");

            modelBuilder.Entity<Autor>().ToTable("Autores");

            modelBuilder.Entity<Autor>().Property(x => x.Email);

            modelBuilder.Entity<Autor>().Property(x => x.Apelido).HasMaxLength(10);

            modelBuilder.Entity<Autor>().Property(x => x.Idade);
            
        }
    }
}