using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.BS.Interfaces
{
    public interface IManPerfilProfesional_PerfilConcurso
    {
        void Insertar(perfilProfesional_PerfilConcurso concurso);
        List<perfilProfesional_PerfilConcurso> Mostrar();
        void Actualizar(perfilProfesional_PerfilConcurso concurso);
        void Eliminar(perfilProfesional_PerfilConcurso concurso);
    }
}
