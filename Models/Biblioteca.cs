﻿using System;
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


        
<<<<<<< HEAD
        //public Biblioteca(string nombre, int ano) => (Nombre, AnoDeCreacion) = (nombre, ano);

        //public Biblioteca(string nombre, int año,
        //               string pais = "", string ciudad = "") : base()
        //{
        //    (Nombre, AnoDeCreacion) = (nombre, año);
        //    Pais = pais;
        //    Ciudad = ciudad;
        //}
        //public Biblioteca()
        //{
        //}
        
        //public override string ToString()
        //{
        //    return $"Nombre: \"{Nombre}\", Dirección: {Direccion}, Pais: {Pais}, Ciudad: {Ciudad}";
        //}
=======
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
>>>>>>> 31f668b5007f7c19b6f0a1f177609f3d9a4af9d8
    }
}
