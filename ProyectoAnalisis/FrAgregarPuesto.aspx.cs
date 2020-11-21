using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoAnalisis
{
    public partial class FrAgregarPuesto : System.Web.UI.Page
    {
        InfoPuesto puest;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                //se valida que haya un inicio de seccion valido, si no lo manda al Login
                Response.Redirect("FrLogin.aspx");
            }
        }

        protected void agregarPuesto_Click(object sender, EventArgs e)
        {
            puest = new InfoPuesto();
            puest.puesto = newPuesto.Value;
            var r = new List<InfoPuesto>();
            r = SIRESEP.BS.Clases.ManInfoPuesto._Instancia.Mostrar();

            bool ok = true;
            int largo = Convert.ToInt32(r.Count.ToString());
            for (int i = 0; i < largo; i++)
            {
                String user = r[i].puesto.ToString();

                String exPass = newPuesto.Value;


                if (exPass.Equals(user))
                {

                    label1.Visible = true;
                    ok = false;



                }
            }
            if (ok == true)
            {
                SIRESEP.BS.Clases.ManInfoPuesto._Instancia.Insertar(puest);
                Response.Redirect("FrAgregarPerfilDelConcurso.aspx");
            }
        }
    }
}