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
    public partial class FrCambiarRolUsuarios : System.Web.UI.Page
    {

        Usuarios usuario;

        protected void Page_Load(object sender, EventArgs e)
        {
            var query = (from a in SIRESEP.BS.ManUsuario._Instancia.Mostrar().AsEnumerable()
             
                         select new { a._idUsuario, a._cedula, a._idRol, a._correoElectronico}).ToList();

            gvMostrarUsuarios.DataSource = query;
            gvMostrarUsuarios.DataBind();
        }

        protected void gvMostrarUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = gvMostrarUsuarios.SelectedRow;
            txtCedula.Value = gr.Cells[1].Text;
            txtRol.Value = gr.Cells[3].Text;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            usuario = new Usuarios();
            usuario._idUsuario = Convert.ToInt32(txtCedula.Value);
            usuario._idRol = Convert.ToInt32(txtRol.Value);

            SIRESEP.BS.ManUsuario._Instancia.ActualizarRol(usuario);

            Response.Redirect(Request.RawUrl);
        }
    }
}