using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrAgregarLicenciaConducir : System.Web.UI.Page
    {
         InfoLicenciaConducir lic;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                //se valida que haya un inicio de seccion valido, si no lo manda al Login
                Response.Redirect("FrLogin.aspx");
            }
        }

        protected void agregarLicencia_Click(object sender, EventArgs e)
        {
            string pa = (Session["pagina"].ToString());
            lic = new InfoLicenciaConducir();
            lic.licencia = txtLicencia.Value;

            var r = new List<InfoLicenciaConducir>();
            r = SIRESEP.BS.Clases.ManInfoLicenciaConducir._Instancia.Mostrar();

            bool ok = true;
            int largo = Convert.ToInt32(r.Count.ToString());

            for (int i = 0; i < largo; i++)
            {
                String user = r[i].licencia.ToString();
                String expass = txtLicencia.Value;
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
                    SIRESEP.BS.Clases.ManInfoLicenciaConducir._Instancia.Insertar(lic);
                    Response.Redirect("FrAgregarPerfil.aspx");
                }
                else if (pa.Equals("Editar"))
                {

                    SIRESEP.BS.Clases.ManInfoLicenciaConducir._Instancia.Insertar(lic);
                    Response.Redirect("FrEditarMiPerfil.aspx");
                }
            }
            
        }
    }
}