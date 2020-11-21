using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrActualizarInfoRequisitos : System.Web.UI.Page
    {
        InfoRequisitos requi;
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarComboBox1();
            cargarComboBox2();
            cargarComboBox3();
            cargarComboBox4();
        }
        #region Linqs para Obtener id

        private int getID1(string Idioma)
        {
            var query = (from a in SIRESEP.BS.Clases.ManInfoIdioma._Instancia.Mostrar().AsEnumerable()
                         where a.idioma.Equals(Idioma)
                         select a.idIdioma).FirstOrDefault();
            return Convert.ToInt32(query);
        }
        private int getID2(string carr)
        {
            var query = (from a in SIRESEP.BS.Clases.ManCarrera._Instancia.Mostrar().AsEnumerable()
                         where a.carrera.Equals(carr)
                         select a.idCarrera).FirstOrDefault();
            return Convert.ToInt32(query);
        }
        private int getID3(string gradoE)
        {
            var query = (from a in SIRESEP.BS.Clases.ManInfoGradoEstudio._Instancia.Mostrar().AsEnumerable()
                         where a.descripcion.Equals(gradoE)
                         select a.idGradoEstudio).FirstOrDefault();
            return Convert.ToInt32(query);
        }
        private int getID4(string habi)
        {
            var query = (from a in SIRESEP.BS.Clases.ManInfoHabilidad._Instancia.Mostrar().AsEnumerable()
                         where a.habilidad.Equals(habi)
                         select a.idHabilidad).FirstOrDefault();
            return Convert.ToInt32(query);
        }
        #endregion
        #region Listas y combo box

        private void cargarComboBox1()
        {

            var query = (from a in SIRESEP.BS.Clases.ManInfoIdioma._Instancia.Mostrar().AsEnumerable()
                         select a.idioma).ToList<String>();
            ListaIdiomas.DataSource = query;
            ListaIdiomas.DataBind();
        }
        private void cargarComboBox2()
        {

            var query = (from a in SIRESEP.BS.Clases.ManCarrera._Instancia.Mostrar().AsEnumerable()
                         select a.carrera).ToList<String>();
            listaCarreras.DataSource = query;
            listaCarreras.DataBind();
        }
        private void cargarComboBox3()
        {

            var query = (from a in SIRESEP.BS.Clases.ManInfoGradoEstudio._Instancia.Mostrar().AsEnumerable()
                         select a.descripcion).ToList<String>();
            listaGrado.DataSource = query;
            listaGrado.DataBind();
        }
        private void cargarComboBox4()
        {

            var query = (from a in SIRESEP.BS.Clases.ManInfoHabilidad._Instancia.Mostrar().AsEnumerable()
                         select a.habilidad).ToList<String>();
            listaHabilidad.DataSource = query;
            listaHabilidad.DataBind();
        }
        #endregion
        #region Botones

        protected void addIdioma_Click(object sender, EventArgs e)
        {
            string pagina = "concursoR".Trim();
            Session["pagina"] = pagina;
            Response.Redirect("FrAgregarIdioma.aspx");
        }

        protected void addCarrera_Click(object sender, EventArgs e)
        {

            string pagina = "concursoR".Trim();
            Session["pagina"] = pagina;
            Response.Redirect("FrAgregarCarrera.aspx");
        }

        protected void addGrado_Click(object sender, EventArgs e)
        {
            string pagina = "concursoR".Trim();
            Session["pagina"] = pagina;
            Response.Redirect("FrAgregarGradoEstudio.aspx");
        }
        #endregion

        protected void agregarRequisito_Click(object sender, EventArgs e)
        {
            #region InfoRequisitos
            requi = new InfoRequisitos();
            requi.idIdioma = getID1(ListaIdiomas.SelectedValue);
            requi.idGradoEstudio = getID3(listaGrado.SelectedValue);
            requi.idHabilidad = getID4(listaHabilidad.SelectedValue);
            requi.idCarrera = getID2(listaCarreras.SelectedValue);
            SIRESEP.BS.Clases.ManInfoRequisitos._Instancia.Insertar(requi);
            Response.Redirect("FrEditarConcurso.aspx");


            #endregion
        }
    }
}