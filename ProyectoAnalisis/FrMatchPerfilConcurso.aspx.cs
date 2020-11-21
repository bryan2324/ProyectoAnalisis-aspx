using SIRESEP.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrMatchPerfilConcurso : System.Web.UI.Page
    {
        static string id;
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


            var query = (from zx in SIRESEP.BS.Clases.ManPerfilDelConcurso._Instancia.Mostrar().AsEnumerable()
                       join a in SIRESEP.BS.Clases.ManInfoRequisitos._Instancia.Mostrar().AsEnumerable()
                       on zx.idInfoRequisitos equals a.idInfoRequisitos
                         join b in SIRESEP.BS.Clases.ManInfoIdioma._Instancia.Mostrar().AsEnumerable()
                         on a.idIdioma equals b.idIdioma
                         join c in SIRESEP.BS.Clases.ManInfoGradoEstudio._Instancia.Mostrar().AsEnumerable()
                         on a.idGradoEstudio equals c.idGradoEstudio
                         join d in SIRESEP.BS.Clases.ManInfoHabilidad._Instancia.Mostrar().AsEnumerable()
                         on a.idHabilidad equals d.idHabilidad
                         join f in SIRESEP.BS.Clases.ManCarrera._Instancia.Mostrar().AsEnumerable()
                         on a.idCarrera equals f.idCarrera
                         where zx.idEstado==1
                         select new
                         {ID_Del_Concurso=zx.idConcurso, Codigo_Del_Concurso = zx.codConcurso,Puesto=zx.InfoPuesto,Descripcion_del_Concurso=zx.descripcionConcurso, Idioma= b.idioma,Habilidades=d.habilidad, Grado_Academico = c.descripcion,Carrera = f.carrera }).ToList();

            dgvrequisitos.DataSource = query;
            dgvrequisitos.DataBind();

        }

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

        protected void addRequi_Click(object sender, EventArgs e)
            ////codigo modificado para probar
        {
            hhhhr.Visible = false;
            data1.Visible = false;
            dgvrequisitos.Visible = false;
            dgv2.Visible = true;
            hh.Visible = true;
            btndi.Visible = true;
            var query = (from a in SIRESEP.BS.Clases.ManPerfilProfesional_PerfilConcurso._Instancia.Mostrar().AsEnumerable()
                         join b in SIRESEP.BS.Clases.ManPerfilPersona._Instancia.Mostrar().AsEnumerable()
                         on a.idPerfilProfesional equals b.idPerfilProfesional
                         where a.idConcurso == Convert.ToInt32(txtReq.Value) && b.idEstado==1
                         select new { b.nombre, b.apellidos, a.porcentajeMatch, b.telefono, b.idUsuario }).ToList();

            List<Match> r = new List<Match>();
            
            foreach (var item in query)
            {
                id = Convert.ToString(item.idUsuario);
                string nombre = item.nombre;
                string apellido = item.apellidos;
                string por = Convert.ToString(item.porcentajeMatch+"%");
                string tele = Convert.ToString(item.telefono);
                
                r.Add(new Match {Nombre=nombre,Apellidos=apellido,Porcentaje_Del_Match=por,Telefono=tele,idUser=id});
            }

           


            dgv2.DataSource = r;
            dgv2.DataBind();

           

            

        }


        public void cargarPerfil(int r) {

            #region Legend of Linqs
            var query = (from a in SIRESEP.BS.Clases.ManPerfilPersona._Instancia.Mostrar().AsEnumerable()
                         join b in SIRESEP.BS.Clases.ManInfoNacionalidad._Instancia.Mostrar().AsEnumerable()
                         on a.idNacionalidad equals b.idNacionalidad
                         join c in SIRESEP.BS.Clases.ManInfoGenero._Instancia.Mostrar()
                         on a.idGenero equals c.idGenero

                         join d in SIRESEP.BS.Clases.Mancertificaciones_perfilProfesional._Instancia.Mostrar().AsEnumerable()
                         on a.idPerfilProfesional equals d.idPerfilProfesional
                         join r1 in SIRESEP.BS.Clases.ManCertificaciones._Instancia.Mostrar().AsEnumerable()
                          on d.idCertificacion equals r1.idCertificacion


                         join ea in SIRESEP.BS.Clases.Manhabilidades_perfilProfesional._Instancia.Mostrar().AsEnumerable()
                         on a.idPerfilProfesional equals ea.idPerfilProfesional
                         join r2 in SIRESEP.BS.Clases.ManInfoHabilidad._Instancia.Mostrar().AsEnumerable()
                        on ea.idHabilidad equals r2.idHabilidad


                         join eb in SIRESEP.BS.Clases.ManinfoAdicional_perfilProfesional._Instancia.Mostrar().AsEnumerable()
                        on a.idPerfilProfesional equals eb.idPerfilProfesional
                         join r3 in SIRESEP.BS.Clases.ManInfoAdicional._Instancia.Mostrar().AsEnumerable()
                         on eb.idInfoAdicional equals r3.idInfoAdicional


                         join ec in SIRESEP.BS.Clases.ManinfoEstudios_perfilProfesional._Instancia.Mostrar().AsEnumerable()
                        on a.idPerfilProfesional equals ec.idPerfilProfesional
                         join r4 in SIRESEP.BS.Clases.ManInfoEstudios._Instancia.Mostrar().AsEnumerable()
                         on ec.idEstudios equals r4.idEstudios


                         join ed in SIRESEP.BS.Clases.ManinfoLaboral_perfilProfesional._Instancia.Mostrar().AsEnumerable()
                        on a.idPerfilProfesional equals ed.idPerfilProfesional

                         join r5 in SIRESEP.BS.Clases.ManInfoLaboral._Instancia.Mostrar().AsEnumerable()
                         on ed.idInfoLaboral equals r5.idInfoLaboral

                         join ww in SIRESEP.BS.ManUsuario._Instancia.Mostrar().AsEnumerable()
                         on a.idUsuario equals ww._idUsuario

                         join sss in SIRESEP.BS.Clases.ManCarrera._Instancia.Mostrar().AsEnumerable()
                         on r4.idCarrera equals sss.idCarrera

                         join ttt in SIRESEP.BS.Clases.ManInfoGradoEstudio._Instancia.Mostrar().AsEnumerable()
                         on r4.idGradoEstudio equals ttt.idGradoEstudio


                         where (ww._idUsuario==r)
                         select new
                         {
                             a.idPerfilProfesional,
                             a.nombre,
                             a.apellidos,
                             a.telefono,
                             a.fechaNacimiento,
                             a.direccion,
                             b.nacionalidad,
                             ww._correoElectronico,
                             Habilidad = r2.habilidad,
                             Certificacion = r1.nombre,
                             Fecha_Certificacion = r1.ano,
                             sss.carrera,
                             ttt.descripcion,
                             r5.profesion,
                             r5.tiempoExperiencia
                         }).ToList();

            #endregion

            dgv3.DataSource = query;
           
            dgv3.DataBind();
        }

        protected void addRequi2_Click(object sender, EventArgs e)
        {
            hhhhr.Visible = true;
            data1.Visible = true;
            dgvrequisitos.Visible = true;
            dgvrequisitos.Visible = true;
            dgv2.Visible = false;
            txtReq.Value = "";
            hh.Visible =false;
            btndi.Visible = false;
        }

        protected void dgv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv2.Visible = false;
            hh.Visible = false;
            btndi.Visible = false;
            
            GridViewRow gr = dgv2.SelectedRow;
            Div1.Visible = true;
            int r = Convert.ToInt32(gr.Cells[5].Text);
            cargarPerfil(Convert.ToInt32(r));
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dgv2.Visible = true;
            hh.Visible = true;
            btndi.Visible = true;
            Div1.Visible = false;
        }
    }
}