using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrDisableInfoInstitucion : System.Web.UI.Page
    {
        InfoInstitucion ins;
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
            var query = (from a in SIRESEP.BS.Clases.ManInfoInstitucion._Instancia.Mostrar().AsEnumerable()
                         select new { a.idInstitucion, a.nombreInstitucion, a.ano }).ToList();

            dgvInstitucion.DataSource = query;
            dgvInstitucion.DataBind();
        }
        protected void singlebutton_Click(object sender, EventArgs e)
        {
            ins= new InfoInstitucion();
            ins.idInstitucion = Convert.ToInt32(txtIdInsti.Value);
            ins.nombreInstitucion = "N/A";


            SIRESEP.BS.Clases.ManInfoInstitucion._Instancia.Actualizar(ins);

            Response.Write("<script>alert('Anulado Correctamente!')</script>");
            Response.Write("<script>window.location.href='FrDisableInfoInstitucion.aspx';</script>");
           // Server.Transfer("FrDisableInfoInstitucion.aspx");
        }
        protected void dgvInstitucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = dgvInstitucion.SelectedRow;
            txtIdInsti.Value = gr.Cells[1].Text;
            txtInstitucion.Value = gr.Cells[2].Text;

        }

        protected void dgvInstitucion_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            cargar();
            dgvInstitucion.PageIndex = e.NewPageIndex;
            dgvInstitucion.DataBind();
        }
    }
}