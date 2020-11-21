using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIRESEP.DAL;
namespace ProyectoAnalisis
{
    public partial class FrEliminarConcurso : System.Web.UI.Page
    {
        PerfilDelConcurso concurso;
        aplicaciones apppl;
        perfilProfesional_PerfilConcurso perfiles;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("FrLogin.aspx");
            }

            cargar();
        }
        public void cargar()
        {
            var query = (from a in SIRESEP.BS.Clases.ManPerfilDelConcurso._Instancia.Mostrar().AsEnumerable()
                         join b in SIRESEP.BS.Clases.ManInfoPuesto._Instancia.Mostrar().AsEnumerable()
                         on a.idPuesto equals b.idPuesto
                         where a.idEstado==1
                         select new { a.idConcurso, a.codConcurso, b.puesto, a.idInfoRequisitos, a.fechaInicio, a.fechaCierre, a.descripcionConcurso }).ToList();

            gvMostrarConcurso.DataSource = query;
            gvMostrarConcurso.DataBind();
        }
        protected void gvMostrarConcurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = gvMostrarConcurso.SelectedRow;
            txtID.Value = gr.Cells[1].Text;
            txtCodigo.Value = gr.Cells[2].Text;
           

        }

        protected void eliminar_Click(object sender, EventArgs e)
        {
            //apppl = new aplicaciones();
            //perfiles = new perfilProfesional_PerfilConcurso();
            concurso = new PerfilDelConcurso();
            concurso.idConcurso = Convert.ToInt32(txtID.Value);

            //apppl.idConcurso = Convert.ToInt32(txtID.Value);
            

            //var query = (from a in SIRESEP.BS.Clases.ManAplicaciones._Instancia.Mostrar().AsEnumerable()
                         
            //             where a.idConcurso == Convert.ToInt32(txtID.Value)
            //             select a.idAplicacion).FirstOrDefault();

            //var query2 = (from a in SIRESEP.BS.Clases.ManPerfilProfesional_PerfilConcurso._Instancia.Mostrar().AsEnumerable()

            //             where a.idConcurso == Convert.ToInt32(txtID.Value)
            //             select a.idMatch).FirstOrDefault();


            //apppl.idAplicacion = Convert.ToInt32(query);
            //perfiles.idMatch = Convert.ToInt32(query2);
          
            //    SIRESEP.BS.Clases.ManAplicaciones._Instancia.Eliminar(apppl);
            //    SIRESEP.BS.Clases.ManPerfilProfesional_PerfilConcurso._Instancia.Eliminar(perfiles);
                SIRESEP.BS.Clases.ManPerfilDelConcurso._Instancia.Eliminar(concurso);

                txtID.Value = null;
                txtCodigo = null;
                Response.Write("<script>window.location.href='FrEliminarConcurso.aspx';</script>");
            
       

           // Server.Transfer("FrEliminarConcurso.aspx");
        }

        protected void gvMostrarConcurso_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            cargar();
            gvMostrarConcurso.PageIndex = e.NewPageIndex;
            gvMostrarConcurso.DataBind();
        }
    }
}