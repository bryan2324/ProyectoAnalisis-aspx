using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrAgregarInstitucion : System.Web.UI.Page
    {
        InfoInstitucion instu;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                //se valida que haya un inicio de seccion valido, si no lo manda al Login
                Response.Redirect("FrLogin.aspx");
            }
        }

        protected void agregarInstitucion_Click(object sender, EventArgs e)
        {
            string pa = (Session["pagina"].ToString());
            instu = new InfoInstitucion();
            instu.nombreInstitucion = newInstitucion.Value;
            instu.ano = Convert.ToDateTime(anoFront.Value);
            var r = new List<InfoInstitucion>();
            r = SIRESEP.BS.Clases.ManInfoInstitucion._Instancia.Mostrar();

            bool ok = true;
            int largo = Convert.ToInt32(r.Count.ToString());
            for (int i = 0; i < largo; i++)
            {
                String user = r[i].nombreInstitucion.ToString();

                String exPass = newInstitucion.Value;


                if (exPass.Equals(user))
                {

                    label1.Visible = true;
                    ok = false;



                }
           

            }
            if (ok == true)
            {
                if (pa.Equals("agregar"))
                {
                    SIRESEP.BS.Clases.ManInfoInstitucion._Instancia.Insertar(instu);
                    Response.Redirect("FrAgregarPerfil.aspx");
                }
                else if (pa.Equals("Editar"))
                {

                    SIRESEP.BS.Clases.ManInfoInstitucion._Instancia.Insertar(instu);
                    Response.Redirect("FrEditarMiPerfil.aspx");
                }
            }

        }
    }
}