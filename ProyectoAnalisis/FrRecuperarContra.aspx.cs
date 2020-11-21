using System;
using SIRESEP.DAL;
using SIRESEP.DO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SimpleCrypto;
using System.Net.Mail;
using System.Net;
using System.Configuration;

namespace ProyectoAnalisis
{
    public partial class FrRecuperarContra : System.Web.UI.Page
    {
        //public static Usuarios usuario;
        Usuario usuarioo;
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        //  <appSettings>
        //  <add key = "correoElectronico" value="siresep@gmail.com"/>
        //  <add key = "contraseniaCorreo" value="contra123"/>
        //</appSettings>

        protected void btnRecuperar_Click(object sender, EventArgs e)
        {
            int varCedula = Convert.ToInt32(cedula.Value.Trim());


            List<Usuarios> allUsers = new List<Usuarios>();
            allUsers = SIRESEP.BS.ManUsuario._Instancia.Mostrar();

            int largo = Convert.ToInt32(allUsers.Count.ToString());
            bool ok = false;
            for (int i = 0; i < largo; i++)
            {
                int cedulaForm = Convert.ToInt32(cedula.Value.Trim());
                int cedulaBD = Convert.ToInt32(allUsers[i]._cedula.ToString());


                if (cedulaForm == cedulaBD)
                {
                    //Se hace nueva contraseña random y se manda al correo
                    ICryptoService cryptoService = new PBKDF2();
                    string contraNueva = RandomPassword.Generate(10, PasswordGroup.Lowercase, PasswordGroup.Uppercase, PasswordGroup.Numeric);
                    string salt = cryptoService.GenerateSalt();
                    string contraEncriptada = cryptoService.Compute(contraNueva);
                    var query2 = (from a in SIRESEP.BS.ManUsuario._Instancia.Mostrar().AsEnumerable()
                                  where a._cedula == (cedula.Value)
                                  select a._correoElectronico);
                    string correeo;
                    correeo = query2.First().Trim();

                    //usuarioo = new Usuarios();
                    usuarioo = new Usuario();
                    usuarioo.correoElectronico = correeo;
                    usuarioo.cedula = cedula.Value.Trim();
                    usuarioo.contrasena = contraEncriptada;
                    usuarioo.salt = salt;
                    SIRESEP.BS.ManUsuario._Instancia.ActualizarContra(usuarioo);
                    EnviarEmail(usuarioo.correoElectronico, contraNueva);
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "AlertaUsuario", "window.onload = function(){ alert('Se ha enviado la nueva contrasenia al correo');};", true);

                }
                else
                {
                    //Response.Redirect("FrLogin.aspx");
                    Response.Write("<script>window.location.href='FrLogin.aspx';</script>");
                    // ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "AlertaUsuario", "window.onload = function(){ alert('El usuario no existe');};", true);
                }
                }

            }
        

        public void EnviarEmail(string EnviarA, string contraseniaRecuperar)
        {
            string correoAdministrador = ConfigurationManager.AppSettings["correoElectronico"].ToString();
            string contraseniaAdministrador = ConfigurationManager.AppSettings["contraseniaCorreo"].ToString();

            string asunto = "Recuperacion de contraseña en SIRESEP";
            string body = "Se solicito una nueva contraseña de ingreso a SIRESEP, su nueva contraseña es: " + contraseniaRecuperar + " ";

            var smpt = new SmtpClient();
            {
                smpt.Host = "smtp.gmail.com";
                smpt.Port = 587;
                smpt.EnableSsl = true;
                smpt.DeliveryMethod = SmtpDeliveryMethod.Network;
                smpt.Credentials = new NetworkCredential(correoAdministrador, contraseniaAdministrador);
                smpt.Timeout = 20000;
            }
            if (EnviarA != null && contraseniaRecuperar != null)
            {
                smpt.Send(correoAdministrador, EnviarA, asunto, body);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "AlertaFailMessage", "window.onload = function(){ alert('El correo no se pudo enviar');};", true);

            }
         
        }
    }
}