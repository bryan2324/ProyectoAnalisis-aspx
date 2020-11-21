using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.BS.Interfaces
{
    public interface IManhabilidades_perfilProfesional
    {
        void Insertar(habilidades_perfilProfesional habilidades_perfilProfesional);
        List<habilidades_perfilProfesional> Mostrar();
        void Actualizar(habilidades_perfilProfesional habilidades_perfilProfesional);
        void Eliminar(habilidades_perfilProfesional habilidades_perfilProfesional);
    }
}
