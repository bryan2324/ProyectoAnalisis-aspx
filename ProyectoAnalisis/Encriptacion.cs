using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace ProyectoAnalisis
{
    public class Encriptacion
    {
        public static string Llave = "jskruwiqhendmsud";


        public static string Decriptar(string contra, string llave)
        {
            byte[] keyArray = Encoding.UTF8.GetBytes(llave);
            byte[] descriptar = Convert.FromBase64String(contra);

            var tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultado = cTransform.TransformFinalBlock(descriptar, 0, descriptar.Length);
            tdes.Clear();
            return Encoding.UTF8.GetString(resultado);
        }

        public static string Encriptar(string contra, string llave)
        {
            byte[] keyArray = Encoding.UTF8.GetBytes(llave);
            byte[] encriptar = Encoding.UTF8.GetBytes(contra);

            var tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultado = cTransform.TransformFinalBlock(encriptar, 0, encriptar.Length);
            tdes.Clear();
            return Convert.ToBase64String(resultado, 0, resultado.Length);
        }
    }
}