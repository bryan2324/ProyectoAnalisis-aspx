using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.BS.Interfaces
{
    public interface IManinfoEstudios_perfilProfesional
    {
        void Insertar(infoEstudios_perfilProfesional infoEstudios_perfilProfesional);
        List<infoEstudios_perfilProfesional> Mostrar();
        void Actualizar(infoEstudios_perfilProfesional infoEstudios_perfilProfesional);
        void Eliminar(infoEstudios_perfilProfesional infoEstudios_perfilProfesional);
    }
}
