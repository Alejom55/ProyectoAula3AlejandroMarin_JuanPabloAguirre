using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;
using System.ComponentModel;
using System.Text;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static List<int> lstCodigos = new List<int>();
        static List<Integrantes> lstIntegrantes = new List<Integrantes>();
        static List<Negocios> lstNegocios = new List<Negocios>();

        private void limpiarCamposInt()
        {
            tbCodigoInt.Text = ""; 
            tbId.Text = "";
            tbNombreInt.Text = "";
            tbApellidosInt.Text = "";
            tbRolInt.Text = "";
            tbCorreoInt.Text = "";
            lblErrorInt.Visible = false;
            lblExitoso2.Visible = true;

        }

        private void limpiarCamposNeg()
        {
            lblExitoso.Visible = true;
            tbNombreNegocio.Text = "";
            lblError.Visible = false;
            tbImpacto.Text = "";
            tbIngresos.Text = "";
            tbValorInversion.Text = "";
            btnGenerarCodigo.Visible = true;
            lblGenerarCodigo.Visible = false;
            cblDepartamentos.ClearSelection();
            cblHerramientas.ClearSelection();
        }

        private int GenerarCodigo()
        {
            int codigo = new Random().Next(100, 10000);
            if (!lstCodigos.Contains(codigo))
            {
                
                lblGenerarCodigo.Text = Convert.ToString(codigo);
                lblGenerarCodigo.Visible = true;
                btnGenerarCodigo.Visible = false;
                
            }
            return codigo;
        }

        public List<ListItem> AgregarDepartamentos()
        {

            List<ListItem> lstDepartamentos = cblDepartamentos.Items.Cast<ListItem>()
                .Where(li => li.Selected)
                .ToList();
            return lstDepartamentos;
        }

        public List<ListItem> Agregar4RI()
        {
            List<ListItem> lst4RI = cblHerramientas.Items.Cast<ListItem>()
                .Where(li => li.Selected)
                .ToList();
            return lst4RI;
        }
        
        private Integrantes crearIntegrante(string codigo, string id, string nombre, string apellidos, string rol, string correo)
        {
            Integrantes integrante = new Integrantes(codigo, id, nombre, apellidos, rol, correo);
            lstIntegrantes.Add(integrante);
            limpiarCamposInt();
            return integrante;
            
            
        }

        private void crearNegocio(string codigo, string nombre, string impacto, List<ListItem> departamentos, int inversion, int ingresos, List<Integrantes> integrantes, List<ListItem> RI)
        {
            Negocios negocio = new Negocios(codigo, nombre, impacto, inversion, ingresos, integrantes, departamentos, RI);
            lstNegocios.Add(negocio);
            lstCodigos.Add(Convert.ToInt16(codigo));
            limpiarCamposNeg();
            
        }

        private void AnnadirIntegranteAlNegocio(Integrantes integrante)
        {
            foreach(Negocios n in lstNegocios)
            {
                if(integrante.Codigo == n.Codigo)
                {
                    n.Integrantes.Add(integrante);
                }
            }
        }

        private void EliminarIntegranteAlNegocio(Integrantes integrante)
        {
            foreach (Negocios n in lstNegocios)
            {
                if(integrante.Codigo == n.Codigo)
                {
                    
                    foreach(Integrantes i in n.Integrantes)
                    {
                        if (integrante.Id == i.Id)
                        {
                            n.Integrantes.Remove(integrante);
                        }
                    }
                    
                }
            }
        }
        private int ImpactoDepartamentos()
        {
            
            int numMaxDep = 0;
            int aux = 0;
            for(int i = 0; i < lstNegocios.Count(); i++)
            {
                if(numMaxDep < lstNegocios[i].Departamentos.Count())
                {
                    numMaxDep = lstNegocios[i].Departamentos.Count();
                    aux = i;
                }
                
            }
            return aux;
        }
        private List<Negocios> tresDepartamentos()
        {
            List<Negocios> depNegocios = new List<Negocios>();
            foreach(Negocios n in lstNegocios)
            {
                if(n.Departamentos.Count() >= 3)
                {
                    depNegocios.Add(n);
                }
            }
            return depNegocios;
        }

        private void Rentabilidad()
        {

        }

        private int TotalIngresos()
        {
            int total = 0;
            foreach(Negocios n in lstNegocios)
            {
                total = total + n.Ingresos;
            }
            return total;
        }

        private int TotalInvertir()
        {
            int total = 0;
            foreach (Negocios n in lstNegocios)
            {
                total = total + n.Inversion;
            }
            return total;
        }

        private int MayorIngresos()
        {
            int numMaxDep = 0;
            int aux = 0;
            for (int i = 0; i < lstNegocios.Count(); i++)
            {
                if (numMaxDep < lstNegocios[i].Ingresos)
                {
                    numMaxDep = lstNegocios[i].Ingresos;
                    aux = i;
                }
            }
            return aux;
        }

        private int cantIA()
        {

            int total = 0;
            foreach (Negocios n in lstNegocios)
            { 
                for (int i = 0; i < n.Ri.Count(); i++)
                {
                    if (Convert.ToString(n.Ri[i]) == "Inteligencia artificial")
                    {
                        total++;
                    }
                }
                
            }
            return total;


        }

        private int Comprobasion()
        {
            if (tbCodigoInt.Text == "")
            {
                lblErrorInt.Text = "Ingrese un codigo del emprendimiento valido";
                lblErrorInt.Visible = true;
                return 0;
            }
            else if (tbId.Text == "")
            {
                lblErrorInt.Text = "Ingrese la identificacion";
                lblErrorInt.Visible = true;
                return 0;
            }

            else if (!lstCodigos.Contains(Convert.ToInt16(tbCodigoInt.Text)))
            {
                lblErrorInt.Text = "No se ha encontrado el negocio";
                lblErrorInt.Visible = true;
                return 0;
            }
            else if (tbNombreInt.Text == "")
            {
                lblErrorInt.Text = "Ingrese el nombre";
                lblErrorInt.Visible = true;
                return 0;
            }
            else if (tbApellidosInt.Text == "")
            {
                lblErrorInt.Text = "Ingrese un apellido";
                lblErrorInt.Visible = true;
                return 0;
            }
            else if (tbRolInt.Text == "")
            {
                lblErrorInt.Text = "Ingrese un correo";
                lblErrorInt.Visible = true;
                return 0;
            }
            else if (tbCorreoInt.Text == "")
            {
                lblErrorInt.Text = "Ingrese un correo";
                lblErrorInt.Visible = true;
                return 0;
            }
            else
            {
                return 1;

            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerarCodigo_Click(object sender, EventArgs e)
        {
            GenerarCodigo();
        }

        protected void btnCrearNegocio_Click(object sender, EventArgs e)
        {
            if (lblGenerarCodigo.Visible is false)
            {
                lblError.Visible = true;
                lblError.Text = "Debes generar un codigo antes de poder guardar el negocio";
            }
            else if (tbNombreNegocio.Text == "")
            {
                lblError.Visible = true;
                lblError.Text = "Ingresa un nombre valido";
            } else if (tbImpacto.Text == "")
            {
                lblError.Visible = true;
                lblError.Text = "Ingresa un impacto valido";

            } else if (AgregarDepartamentos().Count() == 0)
            {
                lblError.Visible = true;
                lblError.Text = "Debes poner al menos un departamento";
            } else if (tbValorInversion.Text == "")
            {
                lblError.Visible = true;
                lblError.Text = "Ingresa un valor de iversion valido";
            } else if (tbIngresos.Text == "")
            {
                lblError.Visible = true;
                lblError.Text = "Ingresa un valor de ingresos a los 3 años valido"; 
            }
            else if (Agregar4RI().Count() == 0)
            {
                lblError.Visible = true;
                lblError.Text = "Debes seleccionar al menos una herramienta 4RI";
            }
            else
            {
                crearNegocio(lblGenerarCodigo.Text, tbNombreNegocio.Text, tbImpacto.Text, AgregarDepartamentos(), Convert.ToInt32(tbValorInversion.Text), Convert.ToInt32(tbIngresos.Text), lstIntegrantes, Agregar4RI());
            }
            
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if(Comprobasion() == 1)
            {
                AnnadirIntegranteAlNegocio(crearIntegrante(tbCodigoInt.Text, tbId.Text, tbNombreInt.Text, tbApellidosInt.Text, tbRolInt.Text, tbCorreoInt.Text));
            }
            
        }

        private void mostrarInfo()
        {
            if (lstNegocios.Count() > 0)
            {
                StringBuilder sbResultados = new StringBuilder();
                sbResultados.AppendLine("El Negocio con mas departamentos");
                sbResultados.AppendLine("Codigo: " + lstNegocios[ImpactoDepartamentos()].Codigo);
                sbResultados.AppendLine("Nombre: " + lstNegocios[ImpactoDepartamentos()].Nombre);
                sbResultados.AppendLine("Cantidad: " + lstNegocios[ImpactoDepartamentos()].Departamentos.Count());
                sbResultados.AppendLine("");
                sbResultados.AppendLine("El negocio con mas total de ingresos");
                sbResultados.AppendLine("Codigo: " + lstNegocios[MayorIngresos()].Codigo);
                sbResultados.AppendLine("Nombre: " + lstNegocios[MayorIngresos()].Nombre);
                sbResultados.AppendLine("Cantidad: " + lstNegocios[MayorIngresos()].Ingresos);
                sbResultados.AppendLine("");
                sbResultados.AppendLine("Los negocios que impactan mas de 3 departamentos");
                foreach (Negocios n in tresDepartamentos())
                {
                    sbResultados.AppendLine("Nombre:" + n.Nombre);

                }
                sbResultados.AppendLine("");
                sbResultados.AppendLine("Total ingresos y inverson de todas las ideas de negocio");
                sbResultados.AppendLine("Total ingresos: " + TotalIngresos());
                sbResultados.AppendLine("Total inversion: " + TotalInvertir());
                sbResultados.AppendLine("");
                sbResultados.AppendLine("Total de Negocios que utilizan IA");
                sbResultados.AppendLine("Total: " + cantIA());
                




                txtResultados.Text = sbResultados.ToString();
            }//foreach (Negocios n in ls)
            //{
            //    
            //        
            //    sbResultados.AppendLine("Cantidad dep" + ImpactoDepartamentos());
            //}

            
        }
        protected void Unnamed1_Click1(object sender, EventArgs e)
        {
            mostrarInfo();
        }

        protected void btnEliminarInt_Click(object sender, EventArgs e)
        {
            EliminarIntegranteAlNegocio(crearIntegrante(tbCodigoInt.Text, tbId.Text, tbNombreInt.Text, tbApellidosInt.Text, tbRolInt.Text, tbCorreoInt.Text));
        }
    }
}