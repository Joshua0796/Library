using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectLibrary.Models
{
        public abstract class ObjetoBibliotecaBase
        {
            public string Id { get; set; }
            public virtual string Nombre { get; set; }

            public ObjetoBibliotecaBase()
            {
                Id = Guid.NewGuid().ToString();
            }

            public override string ToString()
            {
                return $"{Nombre},{Id}";
            }
        }
}
