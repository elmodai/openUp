﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpenUp.EFCore.EFContext;

#nullable disable

namespace OpenUp.EFCore.Migrations
{
    [DbContext(typeof(LivroContext))]
    partial class LivroContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("OpenUp.EFCore.Autores.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WebUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Autores", (string)null);
                });

            modelBuilder.Entity("OpenUp.EFCore.Livros.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AutorID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataPublicacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AutorID");

                    b.ToTable("Livros", (string)null);
                });

            modelBuilder.Entity("OpenUp.EFCore.Livros.Livro", b =>
                {
                    b.HasOne("OpenUp.EFCore.Autores.Autor", "Autor")
                        .WithMany()
                        .HasForeignKey("AutorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");
                });
#pragma warning restore 612, 618
        }
    }
}