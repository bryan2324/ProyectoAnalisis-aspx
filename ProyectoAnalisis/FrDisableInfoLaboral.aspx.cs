using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrDisableInfoLaboral : System.Web.UI.Page
    {
        InfoLaboral lab;
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
            var query = (from a in SIRESEP.BS.Clases.ManInfoLaboral._Instancia.Mostrar().AsEnumerable()
                         select new { a.idInfoLaboral, a.profesion, a.tiempoExperiencia }).ToList();

            dgvLaboral.DataSource = query;
            dgvLaboral.DataBind();
        }
        protected void singlebutton_Click(object sender, EventArgs e)
        {
            lab = new InfoLaboral();
            lab.idInfoLaboral = Convert.ToInt32(txtIdInfo.Value);
            lab.profesion = "N/A";
            lab.tiempoExperiencia = 0;


            SIRESEP.BS.Clases.ManInfoLaboral._Instancia.Actualizar(lab);

            Response.Write("<script>alert('Anulado Correctamente!')</script>");
            Response.Write("<script>window.location.href='FrDisableInfoLaboral.aspx';</script>");
            //Server.Transfer("FrDisableInfoLaboral.aspx");
        }

        protected void dgvLaboral_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = dgvLaboral.SelectedRow;
            txtIdInfo.Value = gr.Cells[1].Text;
            txtProfesion.Value = gr.Cells[2].Text;

        }

        protected void dgvLaboral_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            cargar();
            dgvLaboral.PageIndex = e.NewPageIndex;
            dgvLaboral.DataBind();
        }
    }
}