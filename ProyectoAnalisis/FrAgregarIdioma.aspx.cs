using SIRESEP.DAL;
using SIRESEP.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrAgregarIdioma : System.Web.UI.Page
    {
        InfoIdioma idioma;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null && Session["usuario"] == null)
            {
                //se valida que haya un inicio de seccion valido, si no lo manda al Login
                Response.Redirect("FrLogin.aspx");
            }
        }

        

        protected void agregarIdioma_Click(object sender, EventArgs e)
        {
            string pa = (Session["pagina"].ToString());
            //string paAnte = Session["paginaAnterior"].ToString();
           
            idioma = new InfoIdioma();
            idioma.idioma = txtIdioma.Value;

            var r = new List<InfoIdioma>();
            r = SIRESEP.BS.Clases.ManInfoIdioma._Instancia.Mostrar();

            bool ok = true;
            int largo = Convert.ToInt32(r.Count.ToString());

            for (int i = 0; i < largo; i++)
            {
                String user = r[i].idioma.ToString();
                String expass = txtIdioma.Value;
                if (expass.Equals(user))
                {
                    label1.Visible = true;
                    ok = false;
                }
                
            }
            if (ok == true)
                {
                if (pa.Equals("agregar"))
                {
                    SIRESEP.BS.Clases.ManInfoIdioma._Instancia.Insertar(idioma);
                    Response.Redirect("FrAgregarPerfil.aspx");
                }
                else if (pa.Equals("Editar"))
                {

                    SIRESEP.BS.Clases.ManInfoIdioma._Instancia.Insertar(idioma);
                    Response.Redirect("FrEditarMiPerfil.aspx");
                }
                else if
                   (pa.Equals("concurso"))
                {
                    SIRESEP.BS.Clases.ManInfoIdioma._Instancia.Insertar(idioma);
                    Response.Redirect("FrAgregarInfoRequisitos.aspx");
                }
                else if
                 (pa.Equals("concursoR"))
                {
                    SIRESEP.BS.Clases.ManInfoIdioma._Instancia.Insertar(idioma);
                    Response.Redirect("FrActualizarInfoRequisitos.aspx");
                }
            }
            
        }
    }
}