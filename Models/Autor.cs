using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectLibrary.Models
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string Nombre { get; set; }
        public List<Libro> Libros { get; set; }

        
    }
}
