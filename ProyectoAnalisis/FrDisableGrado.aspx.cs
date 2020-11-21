using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrDisableGrado : System.Web.UI.Page
    {
        InfoGradoEstudio ge;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                //se valida que haya un inicio de seccion valido, si no lo manda al Login
                Response.Redirect("FrLogin.aspx");
            }
            cargar();
        }
        public void cargar()
        {
            var query = (from a in SIRESEP.BS.Clases.ManInfoGradoEstudio._Instancia.Mostrar().AsEnumerable()
                         select new { a.idGradoEstudio, a.descripcion }).ToList();

            dgvGrado.DataSource = query;
            dgvGrado.DataBind();
        }
        protected void singlebutton_Click(object sender, EventArgs e)
        {
            ge = new InfoGradoEstudio();
            ge.idGradoEstudio = Convert.ToInt32(txtidgrado.Value);
            ge.descripcion = "N/A";

            SIRESEP.BS.Clases.ManInfoGradoEstudio._Instancia.Actualizar(ge);
            Response.Write("<script>alert('Anulado Correctamente!')</script>");
            Response.Write("<script>window.location.href='FrDisableGrado.aspx';</script>");
            //Server.Transfer("FrDisableGrado.aspx");

        }
        protected void dgvGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = dgvGrado.SelectedRow;
            txtidgrado.Value = gr.Cells[1].Text;
            txtGrado.Value = gr.Cells[2].Text;

        }

        protected void dgvGrado_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            cargar();
            dgvGrado.PageIndex = e.NewPageIndex;
            dgvGrado.DataBind();
        }
    }
}