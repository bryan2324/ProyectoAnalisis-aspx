using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrDisableHabilidad : System.Web.UI.Page
    {
        InfoHabilidad hab;
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
            var query = (from a in SIRESEP.BS.Clases.ManInfoHabilidad._Instancia.Mostrar().AsEnumerable()
                         select new { a.idHabilidad, a.habilidad }).ToList();

            dgvHabilidad.DataSource = query;
            dgvHabilidad.DataBind();
        }
        protected void singlebutton_Click(object sender, EventArgs e)
        {
            hab = new InfoHabilidad();
            hab.idHabilidad = Convert.ToInt32(txtIdHabilidad.Value);
            hab.habilidad = "N/A";


            SIRESEP.BS.Clases.ManInfoHabilidad._Instancia.Actualizar(hab);

            Response.Write("<script>alert('Anulado Correctamente!')</script>");
            Response.Write("<script>window.location.href='FrDisableHabilidad.aspx';</script>");
           // Server.Transfer("FrDisableHabilidad.aspx");
        }

        protected void dgvHabilidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = dgvHabilidad.SelectedRow;
            txtIdHabilidad.Value = gr.Cells[1].Text;
            txtHabilidad.Value = gr.Cells[2].Text;

        }

        protected void dgvHabilidad_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            cargar();
            dgvHabilidad.PageIndex = e.NewPageIndex;
            dgvHabilidad.DataBind();
        }
    }
}