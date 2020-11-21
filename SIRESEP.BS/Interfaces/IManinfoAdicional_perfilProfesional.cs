using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.BS.Interfaces
{
    public interface IManinfoAdicional_perfilProfesional
    {
        void Insertar(infoAdicional_perfilProfesional infoAdicional_perfilProfesional);
        List<infoAdicional_perfilProfesional> Mostrar();
        void Actualizar(infoAdicional_perfilProfesional infoAdicional_perfilProfesional);
        void Eliminar(infoAdicional_perfilProfesional infoAdicional_perfilProfesional);
    }
}
