using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrAgregarGenero : System.Web.UI.Page
    {
        InfoGenero infogenero;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("FrLogin.aspx");
            }
        }

        protected void agregarGenero_Click(object sender, EventArgs e)
        {

            string pa = (Session["pagina"].ToString());

            infogenero = new InfoGenero();
            infogenero.genero = newGenero.Value;

            var r = new List<InfoGenero>();
            r = SIRESEP.BS.Clases.ManInfoGenero._Instancia.Mostrar();

            bool ok = true;
            int largo = Convert.ToInt32(r.Count.ToString());

            for (int i = 0; i < largo; i++)
            {
                String user = r[i].genero.ToString();

                String exPass = newGenero.Value;


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
                    SIRESEP.BS.Clases.ManInfoGenero._Instancia.Insertar(infogenero);
                    Response.Redirect("FrAgregarPerfil.aspx");
                }
                else if (pa.Equals("Editar"))
                {

                    SIRESEP.BS.Clases.ManInfoGenero._Instancia.Insertar(infogenero);
                    Response.Redirect("FrEditarMiPerfil.aspx");
                }
            }

        }

    }
}
