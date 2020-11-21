using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrDisableLicencia : System.Web.UI.Page
    {
        InfoLicenciaConducir lic;
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
            var query = (from a in SIRESEP.BS.Clases.ManInfoLicenciaConducir._Instancia.Mostrar().AsEnumerable()
                         select new { a.idLicenciaConducir, a.licencia }).ToList();

            dgvLicencia.DataSource = query;
            dgvLicencia.DataBind();
        }
        protected void singlebutton_Click(object sender, EventArgs e)
        {
            lic = new InfoLicenciaConducir();
            lic.idLicenciaConducir = Convert.ToInt32(txtidLicencia.Value);
            lic.licencia = "N/A";


            SIRESEP.BS.Clases.ManInfoLicenciaConducir._Instancia.Actualizar(lic);

            Response.Write("<script>alert('Anulado Correctamente!')</script>");
            Response.Write("<script>window.location.href='FrDisableLicencia.aspx';</script>");
            //Server.Transfer("FrDisableLicencia.aspx");
        }
        protected void dgvLicencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = dgvLicencia.SelectedRow;
            txtidLicencia.Value = gr.Cells[1].Text;
            txtLicencia.Value = gr.Cells[2].Text;

        }

        protected void dgvLicencia_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            cargar();
            dgvLicencia.PageIndex = e.NewPageIndex;
            dgvLicencia.DataBind();
        }
    }
}