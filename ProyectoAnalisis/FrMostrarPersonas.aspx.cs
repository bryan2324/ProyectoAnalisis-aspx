using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIRESEP.DAL;
using SIRESEP.BS.Clases;
using SIRESEP.BS.Interfaces;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.IO;

namespace ProyectoAnalisis
{
    public partial class FrMostrarPersonas : System.Web.UI.Page
    {
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

                         join rsw in SIRESEP.BS.Clases.ManInfoIdioma._Instancia.Mostrar().AsEnumerable()
                         on r3.idIdioma equals rsw.idIdioma

                         where a.idEstado==1
                         
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
                             r5.tiempoExperiencia,
                             rsw.idioma
                         }).ToList();


            #endregion


            gvMostrarPersonas.DataSource = query;
            gvMostrarPersonas.DataBind();

            
        }

    

        protected void gvMostrarPersonas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
         

        }

        protected void gvMostrarPersonas_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }

        protected void gvMostrarPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {

            GridViewRow gr = gvMostrarPersonas.SelectedRow;
        

            Document pdfDoc = new Document(PageSize.A4, 10, 10, 10, 10);

            try
            {
                PdfWriter.GetInstance(pdfDoc, System.Web.HttpContext.Current.Response.OutputStream);

                //Open PDF Document to write data 
                pdfDoc.Open();


                string cadenaFinal = "";

                cadenaFinal += "<br/><br/><h2>CURRICULUM<h2/><br/><br/><br/>";
                cadenaFinal += "<TABLE BORDER='1'><TR><TD>NOMBRE :</TD><TD>"+ gr.Cells[2].Text +"</TD></TR>" +
                                "<TR><TD>APELLIDOS:</TD><TD>"+ gr.Cells[3].Text + "</TD></TR>" +
                                "<TR><TD>TELEFONO:</TD><TD>" + gr.Cells[4].Text + "</TD></TR>" +
                                "<TR><TD>FECHA NACIMIENTO:</TD><TD>" + gr.Cells[5].Text + "</TD></TR>" +
                                "<TR><TD>DIRECCION:</TD><TD>" + gr.Cells[6].Text + "</TD></TR>" +
                                "<TR><TD>NACIONALIDAD:</TD><TD>" + gr.Cells[7].Text + "</TD></TR>" +
                                "<TR><TD>CORREO ELECTRONICO:</TD><TD>" + gr.Cells[8].Text + "</TD></TR>" +
                                "<TR><TD>HABILIDAD ESPECIAL:</TD><TD>" + gr.Cells[9].Text + "</TD></TR>" +
                                "<TR><TD>CERTIFICACION DESTACADA:</TD><TD>" + gr.Cells[10].Text + "</TD></TR>" +
                                "<TR><TD>FECHA CERTIFICACION DESTACADA:</TD><TD>" + gr.Cells[11].Text + "</TD></TR>" +
                                "<TR><TD>CARRERA:</TD><TD>" + gr.Cells[12].Text + "</TD></TR>" +
                                "<TR><TD>GRADO ACADEMICO:</TD><TD>" + gr.Cells[13].Text + "</TD></TR>" +
                                "<TR><TD>ULTIMA PROFESION:</TD><TD>" + gr.Cells[14].Text + "</TD></TR>" +
                                "<TR><TD>SEGUNDO IDIOMA :</TD><TD>"+ gr.Cells[16].Text + "</TD></TR></TABLE>";
                //Assign Html content in a string to write in PDF 
                string strContent = cadenaFinal;

                //Read string contents using stream reader and convert html to parsed conent 
                var parsedHtmlElements = HTMLWorker.ParseToList(new StringReader(strContent), null);

                //Get each array values from parsed elements and add to the PDF document 
                foreach (var htmlElement in parsedHtmlElements)
                    pdfDoc.Add(htmlElement as IElement);

                //Close your PDF 
                pdfDoc.Close();

                Response.ContentType = "application/pdf";

                //Set default file Name as current datetime 
                Response.AddHeader("content-disposition", "attachment; filename="+ gr.Cells[2].Text+ "_CV.pdf");
                System.Web.HttpContext.Current.Response.Write(pdfDoc);

                Response.Flush();
                Response.End();

            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        
    }
    }
}