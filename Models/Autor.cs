using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectLibrary.Models
{
    public class Autor : ObjetoBibliotecaBase
    {
        public int AutorId { get; set; }
        public override string Nombre { get; set; }
        //public List<Libro> Libros { get; set; }

        
    }
}
