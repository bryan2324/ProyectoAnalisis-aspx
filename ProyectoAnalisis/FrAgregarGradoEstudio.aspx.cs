using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrAgregarGradoEstudio : System.Web.UI.Page
    {
        InfoGradoEstudio infogrado;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null && Session["usuario"] == null)
            {
                //se valida que haya un inicio de seccion valido, si no lo manda al Login
                Response.Redirect("FrLogin.aspx");
            }
        }

        protected void agregarGrado_Click(object sender, EventArgs e)
        {
            string pa = (Session["pagina"].ToString());
            infogrado = new InfoGradoEstudio();
            infogrado.descripcion = newGradoEstudio.Value;

            var r = new List<InfoGradoEstudio>();
            r = SIRESEP.BS.Clases.ManInfoGradoEstudio._Instancia.Mostrar();

            bool ok = true;
            int largo = Convert.ToInt32(r.Count.ToString());

            for (int i = 0; i < largo; i++)
            {
                String user = r[i].descripcion.ToString();
                String expass = newGradoEstudio.Value;
                if (expass.Equals(user))
                {
                    label1.Visible = true;
                    ok = false;
                }

            }
            if (ok == true)
            {

                if (pa.Equals("agregar"))
                {
                    SIRESEP.BS.Clases.ManInfoGradoEstudio._Instancia.Insertar(infogrado);
                    Response.Redirect("FrAgregarPerfil.aspx");
                }
                else if (pa.Equals("Editar"))
                {

                    SIRESEP.BS.Clases.ManInfoGradoEstudio._Instancia.Insertar(infogrado);
                    Response.Redirect("FrEditarMiPerfil.aspx");
                }
                else if
                    (pa.Equals("concurso"))
                {
                    SIRESEP.BS.Clases.ManInfoGradoEstudio._Instancia.Insertar(infogrado);
                    Response.Redirect("FrAgregarInfoRequisitos.aspx");
                }
                else if
                   (pa.Equals("concursoR"))
                {
                    SIRESEP.BS.Clases.ManInfoGradoEstudio._Instancia.Insertar(infogrado);
                    Response.Redirect("FrActualizarInfoRequisitos.aspx");
                }



            }
        }
    }
}