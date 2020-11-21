using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIRESEP.DAL;

namespace ProyectoAnalisis
{
    public partial class FrEliminarPerfiles : System.Web.UI.Page
    {

        PerfilPersona persona;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect(Page.Request.Url.ToString(), true);
            }

            cargar();
        }
        public void cargar()
        {
            var query = (from a in SIRESEP.BS.Clases.ManPerfilPersona._Instancia.Mostrar().AsEnumerable()
                         join b in SIRESEP.BS.Clases.ManInfoNacionalidad._Instancia.Mostrar().AsEnumerable()
                         on a.idNacionalidad equals b.idNacionalidad
                         join c in SIRESEP.BS.Clases.ManInfoGenero._Instancia.Mostrar()
                 
                         on a.idGenero equals c.idGenero
                         where a.idEstado == 1
                         select new { a.idPerfilProfesional, a.nombre, a.apellidos, a.telefono, a.fechaNacimiento, a.direccion, b.nacionalidad, c.genero }).ToList();

            gvMostrarPersonas.DataSource = query;
            gvMostrarPersonas.DataBind();
        }
        protected void gvMostrarPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = gvMostrarPersonas.SelectedRow;
            txtID.Value = gr.Cells[1].Text;
            txtNombre.Value = gr.Cells[2].Text;
            txtapellidos.Value = gr.Cells[3].Text;

        }

        protected void eliminar_Click(object sender, EventArgs e)
        {
            persona = new PerfilPersona();
            persona.idPerfilProfesional = Convert.ToInt32(txtID.Value);
            SIRESEP.BS.Clases.ManPerfilPersona._Instancia.Eliminar(persona);

            txtID.Value = null;
            txtNombre.Value = null;
            txtapellidos.Value = null;
            Response.Write("<script>window.location.href='FrEliminarPerfiles.aspx';</script>");
            //Server.Transfer("FrEliminarPerfiles.aspx");
        }

        protected void gvMostrarPersonas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            cargar();
            gvMostrarPersonas.PageIndex = e.NewPageIndex;
            gvMostrarPersonas.DataBind();
        }
    }
    }
