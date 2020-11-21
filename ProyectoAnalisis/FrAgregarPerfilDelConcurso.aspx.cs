using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrAgregarPerfilDelConcurso : System.Web.UI.Page
    {
        PerfilDelConcurso perfilconcurso;
        InfoPuesto puest;


        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["admin"] == null)
            {
                //se valida que haya un inicio de seccion valido, si no lo manda al Login
                Response.Redirect("FrLogin.aspx");
            }
            cargar();
            if (!IsPostBack)
            {
                CargarComboBox();
            }
        }
         #region cargarGrid
        public void cargar()
        {

           
            var query = (from a in SIRESEP.BS.Clases.ManInfoRequisitos._Instancia.Mostrar().AsEnumerable()
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

            dgvrequisitos.DataSource = query;
            dgvrequisitos.DataBind();
            
        }
        #endregion
        #region Linqs para Obtener id
        private int getID(string puesto)
        {
            var query = (from a in SIRESEP.BS.Clases.ManInfoPuesto._Instancia.Mostrar().AsEnumerable()
                         where a.puesto.Equals(puesto)
                         select a.idPuesto).FirstOrDefault();
            return Convert.ToInt32(query);
        }
        private int getID2(int requi)
        {
            var query = (from a in SIRESEP.BS.Clases.ManInfoRequisitos._Instancia.Mostrar().AsEnumerable()
                         where a.idInfoRequisitos.Equals(requi)
                         select a.idInfoRequisitos).FirstOrDefault();
            return Convert.ToInt32(query);
        }
        //private int getID2(string Idioma)
        //{
        //    var query = (from a in SIRESEP.BS.Clases.ManInfoIdioma._Instancia.Mostrar().AsEnumerable()
        //                 where a.idioma.Equals(Idioma)
        //                 select a.idIdioma).FirstOrDefault();
        //    return Convert.ToInt32(query);
        //}
        //private int getID3(string carr)
        //{
        //    var query = (from a in SIRESEP.BS.Clases.ManCarrera._Instancia.Mostrar().AsEnumerable()
        //                 where a.carrera.Equals(carr)
        //                 select a.idCarrera).FirstOrDefault();
        //    return Convert.ToInt32(query);
        //}
        //private int getID4(string gradoE)
        //{
        //    var query = (from a in SIRESEP.BS.Clases.ManInfoGradoEstudio._Instancia.Mostrar().AsEnumerable()
        //                 where a.descripcion.Equals(gradoE)
        //                 select a.idGradoEstudio).FirstOrDefault();
        //    return Convert.ToInt32(query);
        //}
        //private int getID5(string habi)
        //{
        //    var query = (from a in SIRESEP.BS.Clases.ManInfoHabilidad._Instancia.Mostrar().AsEnumerable()
        //                 where a.habilidad.Equals(habi)
        //                 select a.idHabilidad).FirstOrDefault();
        //    return Convert.ToInt32(query);
        //}

        #endregion
        #region Listas y combo box
        private void CargarComboBox()
        {
            listaPuestos.Items.Clear();
            var query = (from a in SIRESEP.BS.Clases.ManInfoPuesto._Instancia.Mostrar().AsEnumerable()
                         select a.puesto).ToList<String>();
            listaPuestos.DataSource = query;
            listaPuestos.DataBind();
        }

 

        //private void cargarComboBox2()
        //{

        //    var query = (from a in SIRESEP.BS.Clases.ManInfoIdioma._Instancia.Mostrar().AsEnumerable()
        //                 select a.idioma).ToList<String>();
        //    ListaIdiomas.DataSource = query;
        //    ListaIdiomas.DataBind();
        //}
        //private void cargarComboBox3()
        //{

        //    var query = (from a in SIRESEP.BS.Clases.ManCarrera._Instancia.Mostrar().AsEnumerable()
        //                 select a.carrera).ToList<String>();
        //    listaCarreras.DataSource = query;
        //    listaCarreras.DataBind();
        //}
        //private void cargarComboBox4()
        //{

        //    var query = (from a in SIRESEP.BS.Clases.ManInfoGradoEstudio._Instancia.Mostrar().AsEnumerable()
        //                 select a.descripcion).ToList<String>();
        //    listaGrado.DataSource = query;
        //    listaGrado.DataBind();
        //}
        //private void cargarComboBox5()
        //{

        //    var query = (from a in SIRESEP.BS.Clases.ManInfoHabilidad._Instancia.Mostrar().AsEnumerable()
        //                 select a.habilidad).ToList<String>();
        //    listaHabilidad.DataSource = query;
        //    listaHabilidad.DataBind();
        //}
        #endregion
        #region Botones
        protected void addPuesto_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrAgregarPuesto.aspx");
        }


      
        protected void addRequi_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrAgregarInfoRequisitos.aspx");
        }

        protected void AgregarPerfilDelConcurso_Click(object sender, EventArgs e)
        {
            perfilconcurso = new PerfilDelConcurso();
            perfilconcurso.idPuesto = getID(listaPuestos.SelectedItem.Value);
            perfilconcurso.idInfoRequisitos = getID2(Convert.ToInt32(txtReq.Value));
            perfilconcurso.idEstado = 1;
            perfilconcurso.codConcurso = codConcursoFront.Value;
            perfilconcurso.fechaInicio = Convert.ToDateTime(fechaIniFront.Text);
            perfilconcurso.fechaCierre = Convert.ToDateTime(fechaCieFront.Text);
            perfilconcurso.descripcionConcurso = descripcionFront.Value;
            perfilconcurso.usuarioCrea = Environment.UserName;
            perfilconcurso.fechaCreacion = Convert.ToDateTime(DateTime.Now);
            perfilconcurso.usuarioModifica = "n/a";
            perfilconcurso.fechaModifica = Convert.ToDateTime(DateTime.Now);


            SIRESEP.BS.Clases.ManPerfilDelConcurso._Instancia.Insertar(perfilconcurso);
            Response.Write("<script>alert('Insertado correctamente!')</script>");
            Formulario1.Visible = false;

            labelMensaje.Visible = true;

        }

        #endregion

        protected void dgvIdiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = dgvrequisitos.SelectedRow;
            txtReq.Value = gr.Cells[1].Text;
            
        }

        protected void dgvrequisitos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            cargar();
            dgvrequisitos.PageIndex = e.NewPageIndex;
            dgvrequisitos.DataBind();
        }

        protected void btnAceptarP_Click(object sender, EventArgs e)
        {
            if (txtPuesto.Text != "")
            {
                puest = new InfoPuesto();
                puest.puesto = txtPuesto.Text;
                var r = new List<InfoPuesto>();
                r = SIRESEP.BS.Clases.ManInfoPuesto._Instancia.Mostrar();

                bool ok = true;
                int largo = Convert.ToInt32(r.Count.ToString());
                for (int i = 0; i < largo; i++)
                {
                    String user = r[i].puesto.ToString();

                    String exPass = txtPuesto.Text;


                    if (exPass.Equals(user))
                    {
                        mpePuesto.Show();
                        labelVerificarPuesto.Visible = true;
                        ok = false;



                    }
                }
                if (ok == true)
                {
                    SIRESEP.BS.Clases.ManInfoPuesto._Instancia.Insertar(puest);
                    labelVerificarPuesto.Visible = false;
                    txtPuesto.Text = "";
                    UpdatePanel1.Update();
                    CargarComboBox();
                }
            }
            else
            {
                mpePuesto.Show();
                labelVerificarPuesto.Text = "*No puede quedar vacio el campo";
                labelVerificarPuesto.Visible = true;
            }
        }

        protected void btnCancelarP_Click(object sender, EventArgs e)
        {
            labelVerificarPuesto.Text = "*El puesto ya existe";
            labelVerificarPuesto.Visible = false;
            txtPuesto.Text = "";
        }

        //protected void listaPuestos_DataBinding(object sender, EventArgs e)
        //{
        //    listaPuestos.Items.Clear();
        //}
    }
}