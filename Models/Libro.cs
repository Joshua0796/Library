using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectLibrary.Models
{
    public class Libro
    {
        public int LibroId { get; set; }
        public string Nombre { get; set; }
        public string Description { get; set; }
        public DateTime Fecha { get; set; }

    }
}
