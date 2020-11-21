using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrDisableCarrera : System.Web.UI.Page
    {

        Carrera car;
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
            var query = (from a in SIRESEP.BS.Clases.ManCarrera._Instancia.Mostrar().AsEnumerable()
                         select new { a.idCarrera, a.carrera }).ToList();

            dgvCarrera.DataSource = query;
            dgvCarrera.DataBind();
        }
        protected void singlebutton_Click(object sender, EventArgs e)
        {
            car = new Carrera();
            car.idCarrera = Convert.ToInt32(txtIdcarrera.Value);
            car.carrera = "N/A";

            SIRESEP.BS.Clases.ManCarrera._Instancia.Actualizar(car);
            Response.Write("<script>alert('Anulado Correctamente!')</script>");
            Response.Write("<script>window.location.href='FrDisableCarrera.aspx';</script>");
           // Server.Transfer("FrDisableCarrera.aspx");

        }

        protected void dgvCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = dgvCarrera.SelectedRow;
            txtIdcarrera.Value = gr.Cells[1].Text;
            txtCarrera.Value = gr.Cells[2].Text;
        }

        protected void dgvCarrera_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            cargar();
            dgvCarrera.PageIndex = e.NewPageIndex;
            dgvCarrera.DataBind();
        }
    }
}