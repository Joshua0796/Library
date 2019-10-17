using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectLibrary.Models
{
    public class BibliotecaContext : DbContext
    {
        public DbSet<Biblioteca> Bibliotecas { get; set; }
        public DbSet<Autor> Autors { get; set; }
        public DbSet<Libro> Libros { get; set; }

        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var biblioteca = new Biblioteca();
            biblioteca.AnoDeCreacion = 2019;
            biblioteca.Id = Guid.NewGuid().ToString();
            biblioteca.Nombre = "JRBiblioteca";
            biblioteca.Pais = "Republica Dominicana";
            biblioteca.Ciudad = "Santo Domingo";
            biblioteca.Direccion = "Alma Rosa I";
            modelBuilder.Entity<Biblioteca>().HasData(biblioteca);

        }
    }
}

