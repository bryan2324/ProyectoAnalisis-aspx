using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.BS.Interfaces
{
    public interface IManinfoLaboral_perfilProfesional
    {
        void Insertar(infoLaboral_perfilProfesional infoLaboral_perfilProfesional);
        List<infoLaboral_perfilProfesional> Mostrar();
        void Actualizar(infoLaboral_perfilProfesional infoLaboral_perfilProfesional);
        void Eliminar(infoLaboral_perfilProfesional infoLaboral_perfilProfesional);
    }
}
