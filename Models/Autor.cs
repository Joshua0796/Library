using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======
>>>>>>> 31f668b5007f7c19b6f0a1f177609f3d9a4af9d8
using System.Linq;
using System.Threading.Tasks;

namespace ProyectLibrary.Models
{
<<<<<<< HEAD
    public class Autor : ObjetoBibliotecaBase
    {
        public int AutorId { get; set; }
        public override string Nombre { get; set; }
        //public List<Libro> Libros { get; set; }
=======
    public class Autor
    {
        public int AutorId { get; set; }
        public string Nombre { get; set; }
        public List<Libro> Libros { get; set; }
>>>>>>> 31f668b5007f7c19b6f0a1f177609f3d9a4af9d8

        
    }
}
