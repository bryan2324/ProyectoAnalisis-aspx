using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrAgregarCarrera : System.Web.UI.Page
    {
        Carrera carr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null && Session["usuario"] == null)
            {
                //se valida que haya un inicio de seccion valido, si no lo manda al Login
                Response.Redirect("FrLogin.aspx");
            }

        }

        protected void agregarCarrera_Click(object sender, EventArgs e)
        {
             string pa = (Session["pagina"].ToString());
            carr = new Carrera();
            carr.carrera = newCarrera.Value;
            var r = new List<Carrera>();
            r = SIRESEP.BS.Clases.ManCarrera._Instancia.Mostrar();

            bool ok = true;
            int largo = Convert.ToInt32(r.Count.ToString());
            for (int i = 0; i < largo; i++)
            {
                String user = r[i].carrera.ToString();

                String exPass = newCarrera.Value;


                if (exPass.Equals(user))
                {

                    label1.Visible = true;
                    ok = false;



                }
               
            
            }
            if (ok == true)
            {

                if (pa.Equals("agregar"))
                {
                    SIRESEP.BS.Clases.ManCarrera._Instancia.Insertar(carr);
                    Response.Redirect("FrAgregarPerfil.aspx");
                }
                else if (pa.Equals("Editar"))
                {

                    SIRESEP.BS.Clases.ManCarrera._Instancia.Insertar(carr);
                    Response.Redirect("FrEditarMiPerfil.aspx");
                }
                else if
                   (pa.Equals("concurso"))
                {

                    SIRESEP.BS.Clases.ManCarrera._Instancia.Insertar(carr);
                    Response.Redirect("FrAgregarInfoRequisitos.aspx");
                }
                else if
                  (pa.Equals("concursoR"))
                {

                    SIRESEP.BS.Clases.ManCarrera._Instancia.Insertar(carr);
                    Response.Redirect("FrActualizarInfoRequisitos.aspx");
                }
            }
        }
    }
}