using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrMiPerfilProfesional : System.Web.UI.Page
    {

        PerfilPersona perfilpersona;
        InfoEstudios estu;
        InfoLaboral laboral;
        Certificaciones certi;
        InfoHabilidad habi;
        InfoAdicional adic;

        protected void Page_Load(object sender, EventArgs e)
        {
            #region LISTAS

            var perfiles = new List<PerfilPersona>();
            var estudios = new List<infoEstudios_perfilProfesional>();
            var trabajos = new List<infoLaboral_perfilProfesional>();
            var certifi = new List<certificaciones_perfilProfesional>();
            var skill = new List<habilidades_perfilProfesional>();
            var other = new List<infoAdicional_perfilProfesional>();

            perfiles = SIRESEP.BS.Clases.ManPerfilPersona._Instancia.Mostrar();
            estudios = SIRESEP.BS.Clases.ManinfoEstudios_perfilProfesional._Instancia.Mostrar();
            trabajos = SIRESEP.BS.Clases.ManinfoLaboral_perfilProfesional._Instancia.Mostrar();
            certifi = SIRESEP.BS.Clases.Mancertificaciones_perfilProfesional._Instancia.Mostrar();
            skill = SIRESEP.BS.Clases.Manhabilidades_perfilProfesional._Instancia.Mostrar();
            other = SIRESEP.BS.Clases.ManinfoAdicional_perfilProfesional._Instancia.Mostrar();
            #endregion


            #region cargarInfo
            int largo = Convert.ToInt32(perfiles.Count.ToString());

            string UsuarioSes = (Session["ced"].ToString());

            var query = (from a in SIRESEP.BS.ManUsuario._Instancia.Mostrar().AsEnumerable()
                         where a._cedula.Contains(UsuarioSes)
                         select a._idUsuario);

            int idUsuario;
            idUsuario = Convert.ToInt32(query.First());


            for (int i = 0; i < largo; i++)
            {
                int user = Convert.ToInt32(perfiles[i].idUsuario.ToString());

                if (idUsuario==(user)) {

                    nombreFront.Value = perfiles[i].nombre.ToString();
                    apellidosFront.Value= perfiles[i].apellidos.ToString();
                    fechaFront.Text = (perfiles[i].fechaNacimiento.ToString());
                    telefonoFront.Value = perfiles[i].telefono.ToString();
                    DireccionFront.Value = perfiles[i].direccion.ToString();


                    int idNac = Convert.ToInt32(perfiles[i].idNacionalidad.ToString());
                    var queryNacionalidad = from a in SIRESEP.BS.Clases.ManInfoNacionalidad._Instancia.Mostrar().AsEnumerable()
                                            where a.idNacionalidad.Equals(idNac)
                                            select a.nacionalidad;
                    lista1.DataSource = queryNacionalidad;
                    lista1.DataBind();



                    int idGenero = Convert.ToInt32(perfiles[i].idGenero.ToString());
                    var queryGenero = from a in SIRESEP.BS.Clases.ManInfoGenero._Instancia.Mostrar().AsEnumerable()
                                            where a.idGenero.Equals(idGenero)
                                            select a.genero;
                    lista2.DataSource = queryGenero;
                    lista2.DataBind();


                    int idPerfilProf = Convert.ToInt32(perfiles[i].idPerfilProfesional.ToString());
                    var queryInstitucion = (from a in SIRESEP.BS.Clases.ManinfoEstudios_perfilProfesional._Instancia.Mostrar().AsEnumerable()
                                            join b in SIRESEP.BS.Clases.ManInfoEstudios._Instancia.Mostrar().AsEnumerable()
                                            on a.idEstudios equals b.idEstudios
                                            join c in SIRESEP.BS.Clases.ManInfoInstitucion._Instancia.Mostrar().AsEnumerable()
                                            on b.idInstitucion equals c.idInstitucion
                                            where a.idPerfilProfesional == idPerfilProf
                                            select c.nombreInstitucion);

                    lista3.DataSource = queryInstitucion;
                    lista3.DataBind();


                    var queryCarrera = (from a in SIRESEP.BS.Clases.ManinfoEstudios_perfilProfesional._Instancia.Mostrar().AsEnumerable()
                                            join b in SIRESEP.BS.Clases.ManInfoEstudios._Instancia.Mostrar().AsEnumerable()
                                            on a.idEstudios equals b.idEstudios
                                            join c in SIRESEP.BS.Clases.ManCarrera._Instancia.Mostrar().AsEnumerable()
                                            on b.idCarrera equals c.idCarrera
                                            where a.idPerfilProfesional == idPerfilProf
                                            select c.carrera);

                    lista4.DataSource = queryCarrera;
                    lista4.DataBind();


                    var queryGrado = (from a in SIRESEP.BS.Clases.ManinfoEstudios_perfilProfesional._Instancia.Mostrar().AsEnumerable()
                                        join b in SIRESEP.BS.Clases.ManInfoEstudios._Instancia.Mostrar().AsEnumerable()
                                        on a.idEstudios equals b.idEstudios
                                        join c in SIRESEP.BS.Clases.ManInfoGradoEstudio._Instancia.Mostrar().AsEnumerable()
                                        on b.idGradoEstudio equals c.idGradoEstudio
                                        where a.idPerfilProfesional == idPerfilProf
                                        select c.descripcion);

                    lista5.DataSource = queryGrado;
                    lista5.DataBind();


                    var queryInfoLaboral = (from a in SIRESEP.BS.Clases.ManinfoLaboral_perfilProfesional._Instancia.Mostrar().AsEnumerable()
                                        join b in SIRESEP.BS.Clases.ManInfoLaboral._Instancia.Mostrar().AsEnumerable()
                                        on a.idInfoLaboral equals b.idInfoLaboral
                                        where a.idPerfilProfesional == idPerfilProf
                                        select b.profesion);

                    string profesion;
                    profesion = queryInfoLaboral.First();
                    txtProfesion.Value = profesion;


                    var queryExp = (from a in SIRESEP.BS.Clases.ManinfoLaboral_perfilProfesional._Instancia.Mostrar().AsEnumerable()
                                            join b in SIRESEP.BS.Clases.ManInfoLaboral._Instancia.Mostrar().AsEnumerable()
                                            on a.idInfoLaboral equals b.idInfoLaboral
                                            where a.idPerfilProfesional == idPerfilProf
                                            select b.tiempoExperiencia);

                    int exp;
                    exp = Convert.ToInt32(queryExp.First());
                    txtExperiencia.Value = Convert.ToString(exp);





                    var queryCer = (from a in SIRESEP.BS.Clases.Mancertificaciones_perfilProfesional._Instancia.Mostrar().AsEnumerable()
                                    join b in SIRESEP.BS.Clases.ManCertificaciones._Instancia.Mostrar().AsEnumerable()
                                    on a.idCertificacion equals b.idCertificacion
                                    where a.idPerfilProfesional == idPerfilProf
                                    select b.nombre);

                    string Cer;
                   Cer=queryCer.First();
                    txtCertificacion.Value = Cer;


                    var queryCert = (from a in SIRESEP.BS.Clases.Mancertificaciones_perfilProfesional._Instancia.Mostrar().AsEnumerable()
                                    join b in SIRESEP.BS.Clases.ManCertificaciones._Instancia.Mostrar().AsEnumerable()
                                    on a.idCertificacion equals b.idCertificacion
                                    where a.idPerfilProfesional == idPerfilProf
                                    select b.ano );

                    string Cert;
                    Cert = Convert.ToString(queryCert.First());
                    fechaCerti.Text = Cert;


                    var queryskills = (from a in SIRESEP.BS.Clases.Manhabilidades_perfilProfesional._Instancia.Mostrar().AsEnumerable()
                                    join b in SIRESEP.BS.Clases.ManInfoHabilidad._Instancia.Mostrar().AsEnumerable()
                                    on a.idHabilidad equals b.idHabilidad
                                    where a.idPerfilProfesional == idPerfilProf
                                    select b.habilidad);

                    string ski;
                    ski = queryskills.First();
                    txtHabilidades.Value = ski;



                    var queryIdio = (from a in SIRESEP.BS.Clases.ManinfoAdicional_perfilProfesional._Instancia.Mostrar().AsEnumerable()
                                     join b in SIRESEP.BS.Clases.ManInfoAdicional._Instancia.Mostrar().AsEnumerable()
                                      on a.idInfoAdicional equals b.idInfoAdicional
                                     join c in SIRESEP.BS.Clases.ManInfoIdioma._Instancia.Mostrar().AsEnumerable()
                             on b.idIdioma equals c.idIdioma
                                    where a.idPerfilProfesional == idPerfilProf
                                    select c.idioma);

                    ListaIdiomas.DataSource = queryIdio;
                    ListaIdiomas.DataBind();

                    var queryLevel = (from a in SIRESEP.BS.Clases.ManinfoAdicional_perfilProfesional._Instancia.Mostrar().AsEnumerable()
                                     join b in SIRESEP.BS.Clases.ManInfoAdicional._Instancia.Mostrar().AsEnumerable()
                                      on a.idInfoAdicional equals b.idInfoAdicional
                                    
                                     where a.idPerfilProfesional == idPerfilProf
                                     select b.nivelIdioma);

                    string lvl;
                    lvl = queryLevel.First();
                    TxtIdioma.Value = lvl;



                    var querylic = (from a in SIRESEP.BS.Clases.ManinfoAdicional_perfilProfesional._Instancia.Mostrar().AsEnumerable()
                                     join b in SIRESEP.BS.Clases.ManInfoAdicional._Instancia.Mostrar().AsEnumerable()
                                      on a.idInfoAdicional equals b.idInfoAdicional
                                     join c in SIRESEP.BS.Clases.ManInfoLicenciaConducir._Instancia.Mostrar().AsEnumerable()
                             on b.idLicenciaConducir equals c.idLicenciaConducir
                                     where a.idPerfilProfesional == idPerfilProf
                                     select c.licencia);

                    ListaLicencias.DataSource = querylic;
                    ListaLicencias.DataBind();
                }



            }

          

            #endregion
        }

        protected void EditarPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrEditarMiPerfil.aspx");

        }
    }
}