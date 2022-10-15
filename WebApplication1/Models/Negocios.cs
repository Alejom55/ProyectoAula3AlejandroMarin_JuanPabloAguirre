using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WebApplication1.Models
{
    public class Negocios
    {
        public Negocios(string codigo, string nombre, string impacto, int inversion, int ingresos, List<Integrantes> integrantes, List<ListItem> departamentos, List<ListItem> ri)
        {
            Codigo = codigo;
            Nombre = nombre;
            Impacto = impacto;
            Inversion = inversion;
            Ingresos = ingresos;
            Integrantes = integrantes;
            Departamentos = departamentos;
            Ri = ri;
        }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Impacto { get; set; }

        public int Inversion { get; set; }

        public int Ingresos { get; set; }

        public List<Integrantes> Integrantes { get; set; }

        public List<ListItem> Departamentos { get; set; }

        public List<ListItem> Ri { get; set; }



    }

    

   
}