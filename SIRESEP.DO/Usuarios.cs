using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DO
{
    public class Usuarios
    {
        private int idUsuario;

        public int _idUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        private string correoElectronico;

        public string _correoElectronico
        {
            get { return correoElectronico; }
            set { correoElectronico = value; }
        }


        private string salt;
        public string _salt
        {
            get { return salt; }
            set { salt = value; }
        }


        private string cedula;

        public string _cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        private string contrasena;

        public string _contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

    

        private DateTime fechaRegistro;

        public DateTime _fechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }

        private int idRol;

        public int _idRol
        {
            get { return idRol; }
            set { idRol = value; }
        }


    }
}
