using SIRESEP.DO;
using SIRESEP.BS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using SimpleCrypto;
namespace ProyectoAnalisis
{
    public partial class Login : System.Web.UI.Page
    {


        public static Usuarios usuario;
        
        

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Usuarios> allUser = new List<Usuarios>();
            allUser = SIRESEP.BS.ManUsuario._Instancia.Mostrar();

            int largo = Convert.ToInt32(allUser.Count.ToString());

            if (largo == 0)
            {
                Session["help"] = 1;
                Response.Redirect("FrRegistro.aspx");

            }
            else
            {
                Session["help"] = 2;
            }
        }


        protected void Iniciar_Click(object sender, EventArgs e)
        {
            Session["help"] = 2;
            label1.Visible = false;
            List<Usuarios> allUser = new List<Usuarios>();
            allUser = SIRESEP.BS.ManUsuario._Instancia.Mostrar();

            int largo = Convert.ToInt32(allUser.Count.ToString());
            Session["help"] = 1;
            Session.Add("usuario", "valor");

            for (int i = 0; i < largo; i++)
            {
                String user = allUser[i]._cedula.ToString();
                String pass = allUser[i]._contrasena.ToString();
                String salt = allUser[i]._salt.ToString();
                String idRol = allUser[i]._idRol.ToString();
             

               

                String exUser = cedula.Value.Trim();
                String exPass = inputPassword.Value.Trim();
                //Encriptar la contraseña y comparar para verificar que la registrada sea la misma usando el mismo algoritmo que tiene en la base
                ICryptoService cryptoService = new PBKDF2();
                string contraEncrip = cryptoService.Compute(exPass, salt);


                if (exUser.Equals(user) && contraEncrip.Equals(pass))
                {
                    if (idRol.Equals("1"))
                    {
                        //se hacen 'secciones' para indicar el tipo de usuario, ademas sirve para evitar acceder a las paginas si no es el usuario correcto
                        // tambien sirve para cambiar el master page en las paginas compartidas como carrera, grado de estudio e idioma 
                        Session.Add("admin", "valor");
                        Response.Redirect("FrInicioAdmin.aspx");

                    }
                    if (idRol.Equals("2"))
                    {
                        string ced = exUser.Trim();
                        Session["ced"] = ced;
                        Session.Add("usuario", "valor");
                        Response.Redirect("FrInicioUser.aspx");
                        usuario._cedula = cedula.Value;

                    }
                    else
                    {
                        label1.Visible = true;
                    }


                    if (idRol.Equals("3"))
                    {


                    }

                }
            }


        
            }
               
        

      
    }
}