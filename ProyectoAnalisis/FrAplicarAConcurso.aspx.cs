using SIRESEP.DAL;
using SIRESEP.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrAplicarAConcurso : System.Web.UI.Page
    {
        aplicaciones appl;
        perfilProfesional_PerfilConcurso app2;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                //se valida que haya un inicio de seccion valido, si no lo manda al Login
                Response.Redirect("FrLogin.aspx");
            }
            cargar();
           verificaUsuario();
        }
        public void cargar()
        {
            var query = (from a in SIRESEP.BS.Clases.ManPerfilDelConcurso._Instancia.Mostrar().AsEnumerable()
                         join b in SIRESEP.BS.Clases.ManInfoPuesto._Instancia.Mostrar().AsEnumerable()
                         on a.idPuesto equals b.idPuesto
                         select new { a.idConcurso, a.codConcurso, b.puesto, a.idInfoRequisitos, a.fechaInicio, a.fechaCierre, a.descripcionConcurso }).ToList();

            gvMostrarConcurso.DataSource = query;
            gvMostrarConcurso.DataBind();
        }

        public void verificaUsuario()
        {
            string UsuarioSes = (Session["ced"].ToString());

            var query = (from a in SIRESEP.BS.ManUsuario._Instancia.Mostrar().AsEnumerable()
                         where a._cedula.Contains(UsuarioSes)
                         select a._idUsuario);

            int idUsuario;
            idUsuario = Convert.ToInt32(query.First());
            app2 = new perfilProfesional_PerfilConcurso();

            ///////////////////////////////////////////////////////////////////////////////////////////////
         

            var query2 = (from a in SIRESEP.BS.Clases.ManPerfilPersona._Instancia.Mostrar().AsEnumerable()
                          where a.idUsuario == (idUsuario)
                          select a.idPerfilProfesional);


            int idperfil;
            idperfil = Convert.ToInt32(query2.FirstOrDefault());
            if (idperfil == 0)
            {
                lbApli.Visible = true;
                aplicar.Enabled = false;
            }

        }
        protected void aplicar_Click(object sender, EventArgs e)///agregar aplicaciones concursantes
        {
            string UsuarioSes = (Session["ced"].ToString());

            var query = (from a in SIRESEP.BS.ManUsuario._Instancia.Mostrar().AsEnumerable()
                         where a._cedula.Contains(UsuarioSes)
                         select a._idUsuario);

            int idUsuario;
            idUsuario = Convert.ToInt32(query.First());
            app2 = new perfilProfesional_PerfilConcurso();

            ///////////////////////////////////////////////////////////////////////////////////////////////
            if (idUsuario == 0)
            {
                Response.Write("<script>alert('No puede')</script>");
                Response.Write("<script>window.location.href='FrAgregarPerfil.aspx';</script>");
            }

            var query2 = (from a in SIRESEP.BS.Clases.ManPerfilPersona._Instancia.Mostrar().AsEnumerable()
                          where a.idUsuario == (idUsuario)
                          select a.idPerfilProfesional);
          

            int idperfil;
            idperfil = Convert.ToInt32(query2.FirstOrDefault());

            appl = new aplicaciones();
            appl.idPerfilProfesional = idperfil;
            appl.idConcurso = Convert.ToInt32(txtID.Value);



            ///////////////////
            #region Legend of Linqs
            var queryPerfil = (from a in SIRESEP.BS.Clases.ManPerfilPersona._Instancia.Mostrar().AsEnumerable()
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

                               join ri in SIRESEP.BS.Clases.ManInfoIdioma._Instancia.Mostrar().AsEnumerable()
                               on r3.idIdioma equals ri.idIdioma

                               join li in SIRESEP.BS.Clases.ManInfoLicenciaConducir._Instancia.Mostrar().AsEnumerable()
                              on r3.idLicenciaConducir equals li.idLicenciaConducir


                               join ec in SIRESEP.BS.Clases.ManinfoEstudios_perfilProfesional._Instancia.Mostrar().AsEnumerable()
                              on a.idPerfilProfesional equals ec.idPerfilProfesional
                               join r4 in SIRESEP.BS.Clases.ManInfoEstudios._Instancia.Mostrar().AsEnumerable()
                               on ec.idEstudios equals r4.idEstudios
                               join r44 in SIRESEP.BS.Clases.ManInfoGradoEstudio._Instancia.Mostrar().AsEnumerable()
                               on r4.idGradoEstudio equals r44.idGradoEstudio
                               join r444 in SIRESEP.BS.Clases.ManCarrera._Instancia.Mostrar().AsEnumerable()
                               on r4.idCarrera equals r444.idCarrera



                               join ed in SIRESEP.BS.Clases.ManinfoLaboral_perfilProfesional._Instancia.Mostrar().AsEnumerable()
                              on a.idPerfilProfesional equals ed.idPerfilProfesional
                               join r5 in SIRESEP.BS.Clases.ManInfoLaboral._Instancia.Mostrar().AsEnumerable()
                               on ed.idInfoLaboral equals r5.idInfoLaboral
                               where a.idPerfilProfesional == (idperfil)

                               select new
                               {

                                   b.nacionalidad,
                                   ri.idioma,
                                   r3.nivelIdioma,
                                   li.licencia,
                                   r2.habilidad,
                                   r1.nombre,
                                   r5.profesion,
                                   r5.tiempoExperiencia,
                                   r444.carrera,
                                   r44.descripcion

                               }).ToList();


            string habilidadPerfil = "";
            string carreraPerfil = "";
            string gradoPerfil = "";
            string idiomaPerfil = "";

            foreach (var item in queryPerfil)
            {
                habilidadPerfil = item.habilidad;
                carreraPerfil = item.carrera;
                gradoPerfil = item.descripcion;
                idiomaPerfil = item.idioma;
            }

            //// ok
            #endregion
            ///////////////////
            var queryConcurso = (from a in SIRESEP.BS.Clases.ManPerfilDelConcurso._Instancia.Mostrar().AsEnumerable()
                                 join lx in SIRESEP.BS.Clases.ManInfoRequisitos._Instancia.Mostrar().AsEnumerable()
                                on a.idInfoRequisitos equals lx.idInfoRequisitos


                                 join r1 in SIRESEP.BS.Clases.ManInfoIdioma._Instancia.Mostrar().AsEnumerable()
                                on lx.idIdioma equals r1.idIdioma

                                 join r2 in SIRESEP.BS.Clases.ManInfoHabilidad._Instancia.Mostrar().AsEnumerable()
                                on lx.idHabilidad equals r2.idHabilidad

                                 join r10 in SIRESEP.BS.Clases.ManInfoGradoEstudio._Instancia.Mostrar().AsEnumerable()
                      on lx.idGradoEstudio equals r10.idGradoEstudio


                                 join r5 in SIRESEP.BS.Clases.ManCarrera._Instancia.Mostrar().AsEnumerable()
                                        on lx.idCarrera equals r5.idCarrera


                                 where a.idConcurso == Convert.ToInt32(txtID.Value)

                                 select new
                                 {

                                     r2.habilidad,
                                     r1.idioma,
                                     r10.descripcion,
                                     r5.carrera


                                 }).ToList();


            string habilidadConcurso = "";
            string carreraConcurso = "";
            string gradoConcurso = "";
            string idiomaConcurso = "";



            foreach (var item in queryConcurso)
            {
                habilidadConcurso = item.habilidad;
                carreraConcurso = item.carrera;
                gradoConcurso = item.descripcion;
                idiomaConcurso = item.idioma;
            }

            app2.porcentajeMatch = (decimal)0;
            if (carreraConcurso.Equals(carreraPerfil))
            {
                app2.porcentajeMatch = 50;

                if (gradoConcurso.Equals(gradoPerfil))
                {
                    app2.porcentajeMatch = 75;


                    if (habilidadConcurso.Equals(habilidadPerfil) && idiomaConcurso.Equals(idiomaPerfil))
                    {
                        app2.porcentajeMatch = 100;
                    }
                    else if (habilidadConcurso.Equals(habilidadPerfil) || idiomaConcurso.Equals(idiomaPerfil))
                    {

                        app2.porcentajeMatch = 85;
                    }
                }
            }




            app2.idPerfilProfesional = idperfil;
            app2.idConcurso = Convert.ToInt32(txtID.Value);

            app2.usuarioCrea = Environment.UserName;
            app2.fechaCreacion = System.DateTime.Now;


            List<aplicaciones> allUser = new List<aplicaciones>();
            allUser = SIRESEP.BS.Clases.ManAplicaciones._Instancia.Mostrar();

            int largo = Convert.ToInt32(allUser.Count.ToString());
            bool r = false;
            for (int i = 0; i < largo; i++)
            {

                int idUsuarioBD = Convert.ToInt32(allUser[i].idPerfilProfesional.ToString());
                int idConcursoBD = Convert.ToInt32(allUser[i].idConcurso.ToString());
                int idConcursoSys = Convert.ToInt32(txtID.Value);

                if (idUsuarioBD == idperfil && idConcursoBD == idConcursoSys)
                {
                    Response.Write("<script>alert('Ya aplico en este concurso')</script>");
                    Response.Write("<script>window.location.href='FrAplicarAConcurso.aspx';</script>");
                    r = true;
                }

            }
            if (r == false)
            {
                
                SIRESEP.BS.Clases.ManAplicaciones._Instancia.Insertar(appl);
                SIRESEP.BS.Clases.ManPerfilProfesional_PerfilConcurso._Instancia.Insertar(app2);
                Response.Write("<script>alert('Felicidades se ha aplicado al concurso!')</script>");
                Response.Write("<script>window.location.href='FrAplicarAConcurso.aspx';</script>");
            }


        }

        protected void gvMostrarConcurso_SelectedIndexChanged1(object sender, EventArgs e)
        {
            GridViewRow gr = gvMostrarConcurso.SelectedRow;
            txtID.Value = gr.Cells[1].Text;
            txtCodigo.Value = gr.Cells[2].Text;
        }
        protected void gvMostrarConcurso_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            cargar();
            gvMostrarConcurso.PageIndex = e.NewPageIndex;
            gvMostrarConcurso.DataBind();
        }
    }
}