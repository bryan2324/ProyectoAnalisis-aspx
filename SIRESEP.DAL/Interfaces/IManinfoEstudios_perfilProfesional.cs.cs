using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Interfaces
{
    public interface IManinfoEstudios_perfilProfesional
    {
        void Insertar(infoEstudios_perfilProfesional infoEstudios_perfilProfesional);
        List<infoEstudios_perfilProfesional> Mostrar();
        void Actualizar(infoEstudios_perfilProfesional infoEstudios_perfilProfesional);
        void Eliminar(infoEstudios_perfilProfesional infoEstudios_perfilProfesional);
    }
}
