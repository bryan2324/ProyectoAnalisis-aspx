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
    public partial class FrRegistro : System.Web.UI.Page
    {
        Usuarios usuario;
        int Helping;
        bool validacion = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            int help = Convert.ToInt32((Session["help"].ToString()));
            

            if (help == 1)
            {
                
              
                Helping = 1;
            }
            else
            {
              
         
                Helping = 2;
            }
        }

        private void getValues(bool update)
        {
            label1.Visible = false;
            string varCedula = cedula.Value.Trim();
            string varcorreo = inputEmail.Value.Trim();
            string contra = inputPassword.Value.Trim();
            string contraConfirm = confirmPassword.Value.Trim();
            //var contraescriptada = confirmPassword.Value = Encriptacion.Encriptar(confirmPassword.Value.Trim(), Encriptacion.Llave);

            ICryptoService cryptoService = new PBKDF2();
            //el salt es el algoritmo de encriptacion
            string saltt = cryptoService.GenerateSalt();
            string contraseniaEncriptada = cryptoService.Compute(contra);
            string contrr = contraseniaEncriptada;
            int rolInsert;
           

            if (Helping == 1)
            {
                rolInsert = 1;
            }
            else {
                rolInsert = 2;
            }

            if (contra == contraConfirm)
            {
                usuario = new Usuarios();
                if (update)
                {
                    usuario._cedula = varCedula;
                }
                usuario._cedula = varCedula;
                usuario._correoElectronico = varcorreo;
                usuario._contrasena = contrr;
                usuario._idRol = rolInsert;
                usuario._salt = saltt;
                validacion = true;
            }
            else {
                label1.Visible = true;
                validacion = false;
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            

            if (Helping == 1)   
            {
                getValues(true);
                SIRESEP.BS.ManUsuario._Instancia.Insertar(usuario);
                Response.Redirect("FrInicioUser.aspx");
            } 


                labelFalse.Visible = false;
            getValues(true);
            if (validacion == true)
            {
                List<Usuarios> allUsers = new List<Usuarios>();
                allUsers = SIRESEP.BS.ManUsuario._Instancia.Mostrar();

                int largo = Convert.ToInt32(allUsers.Count.ToString());
                bool ok = false;
                for (int i = 0; i < largo; i++)
                {
                   int cedulaForm = Convert.ToInt32(cedula.Value);
                    int cedulaBD = Convert.ToInt32(allUsers[i]._cedula.ToString());

                    string correoForm = Convert.ToString(inputEmail.Value);
                    string correoBD = Convert.ToString(allUsers[i]._correoElectronico.ToString());


                    if (cedulaForm==cedulaBD || correoForm==correoBD)
                    {
                        ok = false;
                        i = largo + 1;
                    }
                    else
                    {
                        ok = true;
                    }
                }

                if (ok == true)
                {
                    SIRESEP.BS.ManUsuario._Instancia.Insertar(usuario);
                    Response.Redirect("FrInicioUser.aspx");
                }
                else
                {
                    labelFalse.Visible = true;
                }

            }
        }    
            }      
    }