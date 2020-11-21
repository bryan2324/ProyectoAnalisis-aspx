using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DAL;
namespace SIRESEP.BS.Interfaces
{
    public interface IManPerfilDelConcurso
    {
        void Insertar(PerfilDelConcurso concurso);
        List<PerfilDelConcurso> Mostrar();
        void Actualizar(PerfilDelConcurso concurso);
        void Eliminar(PerfilDelConcurso concurso);
    }
}
