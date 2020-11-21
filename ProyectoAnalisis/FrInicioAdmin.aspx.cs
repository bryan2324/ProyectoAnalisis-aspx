using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrInicioAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //si la seccion no es de admin e intenta ingresar a la pagina lo manda al LOGIN
            if (Session["admin"] == null)
            {
                Response.Redirect("FrLogin.aspx");
            }

        }
    }
}