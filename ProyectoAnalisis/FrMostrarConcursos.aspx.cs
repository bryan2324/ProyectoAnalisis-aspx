using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrMostrarConcursos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null && Session["usuario"] == null)
            {
                //se valida que haya un inicio de seccion valido, si no lo manda al Login
                Response.Redirect("FrLogin.aspx");
                
            }

            #region cargaRequisitos
            var query = (
                
                        from a in SIRESEP.BS.Clases.ManInfoRequisitos._Instancia.Mostrar().AsEnumerable()
                         join b in SIRESEP.BS.Clases.ManInfoIdioma._Instancia.Mostrar().AsEnumerable()
                         on a.idIdioma equals b.idIdioma
                         join c in SIRESEP.BS.Clases.ManInfoGradoEstudio._Instancia.Mostrar().AsEnumerable()
                         on a.idGradoEstudio equals c.idGradoEstudio
                         join d in SIRESEP.BS.Clases.ManInfoHabilidad._Instancia.Mostrar().AsEnumerable()
                         on a.idHabilidad equals d.idHabilidad
                         join f in SIRESEP.BS.Clases.ManCarrera._Instancia.Mostrar().AsEnumerable()
                         on a.idCarrera equals f.idCarrera
                         select new
                         { a.idInfoRequisitos, b.idioma, c.descripcion, d.habilidad, f.carrera }).ToList();

            

            #endregion

            cargar();
        }
        public void cargar()
        {
            var query = (from a in SIRESEP.BS.Clases.ManPerfilDelConcurso._Instancia.Mostrar().AsEnumerable()
                         join b in SIRESEP.BS.Clases.ManInfoPuesto._Instancia.Mostrar().AsEnumerable()
                         on a.idPuesto equals b.idPuesto
                         join c in SIRESEP.BS.Clases.ManInfoRequisitos._Instancia.Mostrar().AsEnumerable()
                          on a.idInfoRequisitos equals c.idInfoRequisitos
                         join bx in SIRESEP.BS.Clases.ManInfoIdioma._Instancia.Mostrar().AsEnumerable()
                          on c.idIdioma equals bx.idIdioma            
                         join cx in SIRESEP.BS.Clases.ManInfoGradoEstudio._Instancia.Mostrar().AsEnumerable()
                         on c.idGradoEstudio equals cx.idGradoEstudio
                         join dx in SIRESEP.BS.Clases.ManInfoHabilidad._Instancia.Mostrar().AsEnumerable()
                         on c.idHabilidad equals dx.idHabilidad
                         join fx in SIRESEP.BS.Clases.ManCarrera._Instancia.Mostrar().AsEnumerable()
                         on c.idCarrera equals fx.idCarrera
                         where a.idEstado==1
                         select new { a.idConcurso, a.codConcurso, b.puesto, a.idInfoRequisitos, a.fechaInicio, a.fechaCierre, a.descripcionConcurso,bx.idioma,Grado_Requerido=cx.descripcion,dx.habilidad,fx.carrera }).ToList();

            gvMostrarConcursos.DataSource = query;
            gvMostrarConcursos.DataBind();
        }

        protected void gvMostrarConcursos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            cargar();
            gvMostrarConcursos.PageIndex = e.NewPageIndex;
            gvMostrarConcursos.DataBind();
        }

        protected void gvMostrarConcursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = gvMostrarConcursos.SelectedRow;
            txtID.Value = gr.Cells[1].Text;
         
        }

        protected void actualizar_Click(object sender, EventArgs e)
        {
            if (txtID.Value != "")
            {
                string idConcursosky = txtID.Value.Trim();
                Session["idConcursosky"] = idConcursosky;
                Response.Redirect("FrEditarConcurso.aspx");
            }
            else 
            {
                lbVerifica.Visible = true; 
            }

        }

        

            
        
        
    }
}