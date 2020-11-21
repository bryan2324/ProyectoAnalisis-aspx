using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrDisableCertificacion : System.Web.UI.Page
    {
        Certificaciones cert;
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
            var query = (from a in SIRESEP.BS.Clases.ManCertificaciones._Instancia.Mostrar().AsEnumerable()
                         select new { a.idCertificacion, a.nombre }).ToList();

            dgvCertificacion.DataSource = query;
            dgvCertificacion.DataBind();
        }
        protected void singlebutton_Click(object sender, EventArgs e)
        {
            cert = new Certificaciones();
            cert.idCertificacion = Convert.ToInt32(txtIdCertificacion.Value);
            cert.nombre = "N/A";
            


            SIRESEP.BS.Clases.ManCertificaciones._Instancia.Actualizar(cert);

            Response.Write("<script>alert('Anulado Correctamente!')</script>");
            Response.Write("<script>window.location.href='FrDisableCertificacion.aspx';</script>");
            //Server.Transfer("FrDisableCertificacion.aspx");
        }

        protected void dgvCertificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = dgvCertificacion.SelectedRow;
            txtIdCertificacion.Value = gr.Cells[1].Text;
            txtCertificacion.Value = gr.Cells[2].Text;

        }

        protected void dgvCertificacion_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            cargar();
            dgvCertificacion.PageIndex = e.NewPageIndex;
            dgvCertificacion.DataBind();
        }
    }
}