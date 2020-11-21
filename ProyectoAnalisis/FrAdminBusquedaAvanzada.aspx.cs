using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrAdminBusquedaAvanzada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                //se valida que haya un inicio de seccion correcto, si no, lo manda al Login
                Response.Redirect("FrLogin.aspx");

            }

        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = listaPuestos.SelectedValue;
                string valor = textinput.Value;

                if (criterio.Equals("Cedula"))
                {
                    buscarByCedula(valor);
                    gvMostrarPersonas.Visible = true;
                    salvador.Visible = true;
                }
                else if (criterio.Equals("Nombre"))
                {
                    buscarByNombre(valor);
                    gvMostrarPersonas.Visible = true;
                    salvador.Visible = true;
                }
                else if (criterio.Equals("Carrera"))
                {
                    buscarByCarrera(valor);
                    gvMostrarPersonas.Visible = true;
                    salvador.Visible = true;

                }
                else if (criterio.Equals("Apellidos"))
                {
                    buscarByApellido(valor);
                    gvMostrarPersonas.Visible = true;
                    salvador.Visible = true;

                }
                else
                {


                }

            }
            catch (Exception) {

            }
        }
            



        public void buscarByApellido(string ape) {
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


                         where (a.apellidos == ape && a.idEstado==1)
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

            gvMostrarPersonas.DataSource = query;

            gvMostrarPersonas.DataBind();
        }

        public void buscarByNombre(string nom) {

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


                         where (a.nombre.ToLower() == nom.ToLower() && a.idEstado == 1)
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

            gvMostrarPersonas.DataSource = query;

            gvMostrarPersonas.DataBind();
        }


        public void buscarByCarrera(string Carrera) {
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


                         where (sss.carrera == Carrera && a.idEstado == 1)
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

            gvMostrarPersonas.DataSource = query;

            gvMostrarPersonas.DataBind();
        }


        public void buscarByCedula(string cedula) {
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


                         where (Convert.ToInt32(ww._cedula) == Convert.ToInt32(cedula) && a.idEstado == 1)
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

            gvMostrarPersonas.DataSource = query;

            gvMostrarPersonas.DataBind();

        }
    }
}