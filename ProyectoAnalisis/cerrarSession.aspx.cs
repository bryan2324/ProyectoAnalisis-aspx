using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class cerrarSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //cuando se hace click en Logout se redirecciona a este aspx para que elimine la seccion establecida ya sea 
            // 'admin' o 'usuario' y redireccione al Login, si no se elimina la seccion, se puede navegar dentro  
            // de las paginas sin logearse
            Session.Abandon();
            Response.Redirect("FrLogin.aspx");
        }
    }
}