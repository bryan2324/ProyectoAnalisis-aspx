using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrDisableInfoPuesto : System.Web.UI.Page
    {
        InfoPuesto puest;
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
            var query = (from a in SIRESEP.BS.Clases.ManInfoPuesto._Instancia.Mostrar().AsEnumerable()
                         select new { a.idPuesto, a.puesto }).ToList();

            dgvPuesto.DataSource = query;
            dgvPuesto.DataBind();
        }
        protected void singlebutton_Click(object sender, EventArgs e)
        {
           puest = new InfoPuesto();
            puest.idPuesto = Convert.ToInt32(txtIdPuesto.Value);
            puest.puesto = "N/A";


            SIRESEP.BS.Clases.ManInfoPuesto._Instancia.Actualizar(puest);

            Response.Write("<script>alert('Anulado Correctamente!')</script>");
            Response.Write("<script>window.location.href='FrDisableInfoPuesto.aspx';</script>");
           // Server.Transfer("FrDisableInfoPuesto.aspx");
        }
        protected void dgvPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = dgvPuesto.SelectedRow;
            txtIdPuesto.Value = gr.Cells[1].Text;
            txtPuesto.Value = gr.Cells[2].Text;

        }

        protected void dgvPuesto_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            cargar();
            dgvPuesto.PageIndex = e.NewPageIndex;
            dgvPuesto.DataBind();
        }
    }
}