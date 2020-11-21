using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrDisableNacionalidad : System.Web.UI.Page
    {
        InfoNacionalidad r;

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
            var query = (from a in SIRESEP.BS.Clases.ManInfoNacionalidad._Instancia.Mostrar().AsEnumerable()
                         select new { a.idNacionalidad, a.nacionalidad }).ToList();

            dgvNacionalidad.DataSource = query;
            dgvNacionalidad.DataBind();
        }

        protected void singlebutton_Click(object sender, EventArgs e)
        {
            r = new InfoNacionalidad();
            r.idNacionalidad = Convert.ToInt32(txtidNacionalidad.Value);
            r.nacionalidad = "N/A";


            SIRESEP.BS.Clases.ManInfoNacionalidad._Instancia.Actualizar(r);

            Response.Write("<script>alert('Anulado Correctamente!')</script>");
            Response.Write("<script>window.location.href='FrDisableNacionalidad.aspx';</script>");
            //Server.Transfer("FrDisableNacionalidad.aspx");
        }

        protected void dgvNacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = dgvNacionalidad.SelectedRow;
            txtidNacionalidad.Value = gr.Cells[1].Text;
            txtNacionalidad.Value = gr.Cells[2].Text;
        }

        protected void dgvIdiomas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            cargar();
            dgvNacionalidad.PageIndex = e.NewPageIndex;
            dgvNacionalidad.DataBind();
        }
    }
}