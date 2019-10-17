using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectLibrary.Models
{
    public class Biblioteca : ObjetoBibliotecaBase
    {
        public int AnoDeCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public List<Libro> Libros { get; set; }


        
        public Biblioteca(string nombre, int ano) => (Nombre, AnoDeCreacion) = (nombre, ano);

        public Biblioteca(string nombre, int año,
                       string pais = "", string ciudad = "") : base()
        {
            (Nombre, AnoDeCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }
        public Biblioteca()
        {
        }
        
        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Dirección: {Direccion}, Pais: {Pais}, Ciudad: {Ciudad}";
        }
    }
}
