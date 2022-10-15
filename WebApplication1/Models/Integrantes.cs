using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Integrantes
    {
        public Integrantes(string codigo, string id, string nombre, string apellidos, string rol, string correo)
        {
            Codigo = codigo;
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Rol = rol;
            Correo = correo;
        }

        public string Codigo { get; set; }
        public string Id { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Rol { get; set; }

        public string Correo { get; set; }

    }
}