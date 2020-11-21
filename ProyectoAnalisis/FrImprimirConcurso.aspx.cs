using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.IO;

namespace ProyectoAnalisis
{
    public partial class FrImprimirConcurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["admin"] == null)
            {
                //se valida que haya un inicio de seccion valido, si no lo manda al Login
                Response.Redirect("FrLogin.aspx");
            }


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
                         where a.idEstado == 1
                         select new { a.idConcurso, a.codConcurso, b.puesto, a.idInfoRequisitos, a.fechaInicio, a.fechaCierre, a.descripcionConcurso, bx.idioma, Grado_Requerido = cx.descripcion, dx.habilidad, fx.carrera }).ToList();

            gvMostrarConcurso.DataSource = query;
            gvMostrarConcurso.DataBind();
        }


        protected void gvMostrarConcurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = gvMostrarConcurso.SelectedRow;


            Document pdfDoc = new Document(PageSize.A4, 10, 10, 10, 10);

            try
            {
                PdfWriter.GetInstance(pdfDoc, System.Web.HttpContext.Current.Response.OutputStream);

                //Open PDF Document to write data 
                pdfDoc.Open();


                string cadenaFinal = "";

                cadenaFinal += "<br/><br/><h2>INFORMACION DE CONCURSO<h2/><br/><br/><br/>";
                cadenaFinal += "<TABLE BORDER='1'><TR><TD>CODIGO CONCURSO :</TD><TD>" + gr.Cells[2].Text + "</TD></TR>" +
                                 "<TR><TD>PUESTO VACANTE:</TD><TD>" + gr.Cells[3].Text + "</TD></TR>" +
                                "<TR><TD>FECHA INICIO:</TD><TD>" + gr.Cells[5].Text + "</TD></TR>" +
                                "<TR><TD>FECHA CIERRE:</TD><TD>" + gr.Cells[6].Text + "</TD></TR>" +
                                   "<TR><TD>DESCRIPCION:</TD><TD>" + gr.Cells[7].Text + "</TD></TR>" +
                                   "<TR><TD>IDIOMA REQUERIDO:</TD><TD>" + gr.Cells[8].Text + "</TD></TR>" +
                                      "<TR><TD>GRADO ACADEMICO REQUERIDO:</TD><TD>" + gr.Cells[9].Text + "</TD></TR>" +
                                       "<TR><TD>HABILIDAD ESPECIAL REQUERIDA:</TD><TD>" + gr.Cells[10].Text + "</TD></TR>" +
                                   "<TR><TD>CARRERA REQUERIDA:</TD><TD>" + gr.Cells[11].Text + "</TD></TR></TABLE>";
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
                Response.AddHeader("content-disposition", "attachment; filename=" + gr.Cells[2].Text + "_CONCURSO.pdf");
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