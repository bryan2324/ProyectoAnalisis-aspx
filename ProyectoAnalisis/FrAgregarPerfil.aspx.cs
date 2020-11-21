using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrAgregarPerfil : System.Web.UI.Page
    {
        PerfilPersona perfilpersona;
        InfoEstudios estu;
        InfoLaboral laboral;
        Certificaciones certi;
        InfoHabilidad habi;
        InfoAdicional adic;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                //se valida que haya un inicio de seccion valido, si no lo manda al Login
                Response.Redirect("FrLogin.aspx");
            }
            cargarPerfil();
            cvFecha.ValueToCompare = DateTime.Now.Date.AddYears(-18).ToString("d");

          

            CargarComboBox();
            cargarComboBox2();
            cargarComboBox3();
            cargarComboBox4();
            cargarComboBox5();
            cargarComboBox6();
            cargarComboBox7();
        
           

        }



        #region LINQs para ObtenerId´s

        private int getID(string nac)
        {
            var query = (from a in SIRESEP.BS.Clases.ManInfoNacionalidad._Instancia.Mostrar().AsEnumerable()
                         where a.nacionalidad.Equals(nac)
                         select a.idNacionalidad).FirstOrDefault();
            return Convert.ToInt32(query);
        }
        private int getID2(string genero)
        {
            var query = (from a in SIRESEP.BS.Clases.ManInfoGenero._Instancia.Mostrar().AsEnumerable()
                         where a.genero.Equals(genero)
                         select a.idGenero).FirstOrDefault();
            return Convert.ToInt32(query);
        }
        private int getID3(string nombreInsti)
        {
            var query = (from a in SIRESEP.BS.Clases.ManInfoInstitucion._Instancia.Mostrar().AsEnumerable()
                         where a.nombreInstitucion.Equals(nombreInsti)
                         select a.idInstitucion).FirstOrDefault();
            return Convert.ToInt32(query);
        }
        private int getID4(string carr)
        {
            var query = (from a in SIRESEP.BS.Clases.ManCarrera._Instancia.Mostrar().AsEnumerable()
                         where a.carrera.Equals(carr)
                         select a.idCarrera).FirstOrDefault();
            return Convert.ToInt32(query);
        }
        private int getID5(string gradoE)
        {
            var query = (from a in SIRESEP.BS.Clases.ManInfoGradoEstudio._Instancia.Mostrar().AsEnumerable()
                         where a.descripcion.Equals(gradoE)
                         select a.idGradoEstudio).FirstOrDefault();
            return Convert.ToInt32(query);
        }
        private int getID6(string Idioma)
        {
            var query = (from a in SIRESEP.BS.Clases.ManInfoIdioma._Instancia.Mostrar().AsEnumerable()
                         where a.idioma.Equals(Idioma)
                         select a.idIdioma).FirstOrDefault();
            return Convert.ToInt32(query);
        }
        private int getID7(string lic)
        {
            var query = (from a in SIRESEP.BS.Clases.ManInfoLicenciaConducir._Instancia.Mostrar().AsEnumerable()
                         where a.licencia.Equals(lic)
                         select a.idLicenciaConducir).FirstOrDefault();
            return Convert.ToInt32(query);
        }



        #endregion


        #region listas y combo box

        private void CargarComboBox()
        {
            var query = (from a in SIRESEP.BS.Clases.ManInfoNacionalidad._Instancia.Mostrar().AsEnumerable()
                         select a.nacionalidad).ToList<String>();
            lista1.DataSource = query;
            lista1.DataBind();
        }
        private void cargarComboBox2() {

            var query = (from a in SIRESEP.BS.Clases.ManInfoGenero._Instancia.Mostrar().AsEnumerable()
                         select a.genero).ToList<String>();
            lista2.DataSource = query;
            lista2.DataBind();
        }
        private void cargarComboBox3()
        {
            var query = (from a in SIRESEP.BS.Clases.ManInfoInstitucion._Instancia.Mostrar().AsEnumerable()
                         select a.nombreInstitucion).ToList<String>();
            lista3.DataSource = query;
            lista3.DataBind();
        }
        private void cargarComboBox4()
        {

            var query = (from a in SIRESEP.BS.Clases.ManCarrera._Instancia.Mostrar().AsEnumerable()
                         select a.carrera).ToList<String>();
            lista4.DataSource = query;
            lista4.DataBind();
        }
        private void cargarComboBox5()
        {

            var query = (from a in SIRESEP.BS.Clases.ManInfoGradoEstudio._Instancia.Mostrar().AsEnumerable()
                         select a.descripcion).ToList<String>();
            lista5.DataSource = query;
            lista5.DataBind();
        }
        private void cargarComboBox6()
        {

            var query = (from a in SIRESEP.BS.Clases.ManInfoIdioma._Instancia.Mostrar().AsEnumerable()
                         select a.idioma).ToList<String>();
            ListaIdiomas.DataSource = query;
            ListaIdiomas.DataBind();
        }
        private void cargarComboBox7()
        {

            var query = (from a in SIRESEP.BS.Clases.ManInfoLicenciaConducir._Instancia.Mostrar().AsEnumerable()
                         select a.licencia).ToList<String>();
            ListaLicencias.DataSource = query;
            ListaLicencias.DataBind();
        }

        #endregion

        #region Botones

        protected void addIdioma_Click(object sender, EventArgs e)
        {
           
            string pagina = "agregar".Trim();
            Session["pagina"] = pagina;
            Response.Redirect("FrAgregarNacionalidad.aspx");
        }

        protected void AddGenero_Click(object sender, EventArgs e)
        {
            
            string pagina = "agregar".Trim();
            Session["pagina"] = pagina;
            Response.Redirect("FrAgregarGenero.aspx");
        }
        

        protected void addInstitucion_Click(object sender, EventArgs e)
        {
          
            string pagina = "agregar".Trim();
            Session["pagina"] = pagina;
            Response.Redirect("FrAgregarInstitucion.aspx");
        }

        protected void addCarrera_Click(object sender, EventArgs e)
        {
            
            string pagina = "agregar".Trim();
            Session["pagina"] = pagina;
            Response.Redirect("FrAgregarCarrera.aspx");
        }

        protected void addGrado_Click(object sender, EventArgs e)
        {
        
            string pagina = "agregar".Trim();
            Session["pagina"] = pagina;
            Response.Redirect("FrAgregarGradoEstudio.aspx");
        }
        #endregion


        #region agregarPerfil

        protected void AgregarPerfil_Click(object sender, EventArgs e)
        {



            #region Info Adicional

            adic = new InfoAdicional();
            adic.nivelIdioma = TxtIdioma.Value;
            adic.idIdioma = getID6(ListaIdiomas.SelectedValue);
            adic.idLicenciaConducir = getID7(ListaLicencias.SelectedValue);
            SIRESEP.BS.Clases.ManInfoAdicional._Instancia.Insertar(adic);
            #endregion

            #region Info Habilidades

            habi = new InfoHabilidad();
            habi.habilidad = txtHabilidades.Value;
            SIRESEP.BS.Clases.ManInfoHabilidad._Instancia.Insertar(habi);
            #endregion

            #region Certificaciones

            certi = new Certificaciones();
            certi.nombre = txtCertificacion.Value;
            certi.ano = Convert.ToDateTime(fechaCerti.Text);
            SIRESEP.BS.Clases.ManCertificaciones._Instancia.Insertar(certi);
            #endregion

            #region Info Laboral

            laboral = new InfoLaboral();
            laboral.profesion = txtProfesion.Value;
            laboral.tiempoExperiencia = Convert.ToInt32(txtExperiencia.Value);
            SIRESEP.BS.Clases.ManInfoLaboral._Instancia.Insertar(laboral);
            #endregion

            #region Info de estudios
            estu = new InfoEstudios();
            estu.idInstitucion = getID3(lista3.SelectedValue);
            estu.idCarrera = getID4(lista4.SelectedValue);
            estu.idGradoEstudio = getID5(lista5.SelectedValue);
            SIRESEP.BS.Clases.ManInfoEstudios._Instancia.Insertar(estu);
            
            

            Insertado.Visible = true;
            #endregion

            #region Datos personales
            perfilpersona = new PerfilPersona();

            string UsuarioSes = (Session["ced"].ToString());

            var query = (from a in SIRESEP.BS.ManUsuario._Instancia.Mostrar().AsEnumerable()
                         where a._cedula.Contains(UsuarioSes) select a._idUsuario);

            int idUsuario;
            idUsuario = Convert.ToInt32(query.First());

            perfilpersona.nombre = nombreFront.Value;
            perfilpersona.apellidos = apellidosFront.Value;
            perfilpersona.fechaNacimiento = Convert.ToDateTime(fechaFront.Text);
            perfilpersona.telefono = Convert.ToInt32(telefonoFront.Value);
            perfilpersona.direccion = DireccionFront.Value;
            perfilpersona.idNacionalidad = getID(lista1.SelectedItem.Value);
            perfilpersona.idGenero = getID2(lista2.SelectedItem.ToString());
            perfilpersona.idEstado = 1;
            perfilpersona.usuarioCrea = Environment.UserName;
            perfilpersona.fechaCreacion = Convert.ToDateTime(DateTime.Now);
            perfilpersona.usuarioModifica = "n/a";
            perfilpersona.FechaModifica = Convert.ToDateTime(DateTime.Now);
            perfilpersona.idUsuario = idUsuario;
            

            SIRESEP.BS.Clases.ManPerfilPersona._Instancia.Insertar(perfilpersona);
            Response.Write("<script>alert('Insertado correctamente!')</script>");
            Formulario1.Visible = false;

            Label1.Visible = true;
            #endregion

        }



        #endregion

        protected void addIdioma2_Click(object sender, EventArgs e)
        {
           
            string pagina = "agregar".Trim();
            Session["pagina"] = pagina;
            Response.Redirect("FrAgregarIdioma.aspx");
        }

        protected void addLicencia_Click(object sender, EventArgs e)
        {
            
            string pagina = "agregar".Trim();
            Session["pagina"] = pagina;
            Response.Redirect("FrAgregarLicenciaConducir.aspx");
        }

        public void cargarPerfil() {

            string UsuarioSes = (Session["ced"].ToString());

            var query = (from a in SIRESEP.BS.ManUsuario._Instancia.Mostrar().AsEnumerable()
                         where a._cedula.Contains(UsuarioSes)
                         select a._idUsuario);

            int idUsuarior;
            idUsuarior = Convert.ToInt32(query.First());

            List<PerfilPersona> allUser = new List<PerfilPersona>();
            allUser = SIRESEP.BS.Clases.ManPerfilPersona._Instancia.Mostrar();

            int largo = Convert.ToInt32(allUser.Count.ToString());

            for (int i = 0; i < largo; i++)
            {

                int idUsuarioBD = Convert.ToInt32(allUser[i].idUsuario.ToString());
                if (idUsuarioBD == idUsuarior)
                {

                    Formulario1.Visible = false;
                    Label2.Visible = true;
                    linkbtn.Visible = true;
                }
            }
             



              
         
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrMiPerfilProfesional.aspx");
        }
    }
}