using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DAL;
namespace SIRESEP.BS.Interfaces
{
    public interface IManInfoRequisitos
    {
        void Insertar(InfoRequisitos requisito);
        List<InfoRequisitos> Mostrar();
        void Actualizar(InfoRequisitos requisito);
        void Eliminar(InfoRequisitos requisito);
    }
}
