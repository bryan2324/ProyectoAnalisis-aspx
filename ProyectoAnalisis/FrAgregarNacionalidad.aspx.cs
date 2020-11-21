using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrAgregarNacionalidad : System.Web.UI.Page
    {
        InfoNacionalidad infonacionalidad;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                //se valida que haya un inicio de seccion valido, si no lo manda al Login
                Response.Redirect("FrLogin.aspx");
            }
        }

        protected void agregarIdioma_Click(object sender, EventArgs e)
        {
            string pa = (Session["pagina"].ToString());
            infonacionalidad = new InfoNacionalidad();
            infonacionalidad.nacionalidad = newNacionalidad.Value;

            var r = new List<InfoNacionalidad>();
            r = SIRESEP.BS.Clases.ManInfoNacionalidad._Instancia.Mostrar();

            bool ok = true;
            int largo = Convert.ToInt32(r.Count.ToString());

            for (int i = 0; i < largo; i++)
            {
                String user = r[i].nacionalidad.ToString();

                String exPass = newNacionalidad.Value;


                if (exPass.Equals(user))
                {

                    label1.Visible = true;
                    ok = false;


                    
                }
             

            }
            if (ok == true) {
                if (pa.Equals("agregar"))
                {
                    SIRESEP.BS.Clases.ManInfoNacionalidad._Instancia.Insertar(infonacionalidad);
                    Response.Redirect("FrAgregarPerfil.aspx");
                }
                else if (pa.Equals("Editar"))
                {

                    SIRESEP.BS.Clases.ManInfoNacionalidad._Instancia.Insertar(infonacionalidad);
                    Response.Redirect("FrEditarMiPerfil.aspx");
                }
            }

        }

    }
}