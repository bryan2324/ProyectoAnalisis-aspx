using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrDisableIdioma : System.Web.UI.Page
    {
        InfoIdioma r;

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
            var query = (from a in SIRESEP.BS.Clases.ManInfoIdioma._Instancia.Mostrar().AsEnumerable()
                         select new { a.idIdioma, a.idioma }).ToList();

            dgvIdiomas.DataSource = query;
            dgvIdiomas.DataBind();

        }

        protected void singlebutton_Click(object sender, EventArgs e)
        {
            r = new InfoIdioma();
            r.idIdioma = Convert.ToInt32(txtididioma.Value);
            r.idioma = "N/A";


            SIRESEP.BS.Clases.ManInfoIdioma._Instancia.Actualizar(r);

            Response.Write("<script>alert('Anulado Correctamente!')</script>");
            Response.Write("<script>window.location.href='FrDisableIdioma.aspx';</script>");
           // Server.Transfer("FrDisableIdioma.aspx");
        }

        protected void dgvIdiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = dgvIdiomas.SelectedRow;
            txtididioma.Value = gr.Cells[1].Text;
            txtIdioma.Value = gr.Cells[2].Text;
            
        }

        protected void dgvIdiomas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            cargar();
            dgvIdiomas.PageIndex = e.NewPageIndex;
            dgvIdiomas.DataBind();
        }
    }
}