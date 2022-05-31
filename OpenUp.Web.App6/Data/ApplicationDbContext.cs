using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OpenUp.EFCore.Autores;
using OpenUp.EFCore.Editoras;
using OpenUp.EFCore.Livros;

namespace OpenUp.Web.App6.Data;

public class ApplicationDbContext : IdentityDbContext
{    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Livro>().ToTable("Livros");

        modelBuilder.Entity<Editora>().ToTable("Editoras");

        modelBuilder.Entity<Autor>().ToTable("Autores");

        modelBuilder.Entity<Autor>().Property(x => x.Email);

        modelBuilder.Entity<Autor>().Property(x => x.Apelido).HasMaxLength(10);

        modelBuilder.Entity<Autor>().Property(x => x.Idade);

        base.OnModelCreating(modelBuilder);

        
    }

}
