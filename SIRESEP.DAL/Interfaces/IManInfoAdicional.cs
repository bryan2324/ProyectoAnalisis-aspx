using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Interfaces
{
    public interface IManInfoAdicional
    {
        void Insertar(InfoAdicional InfoAdicional);
        List<InfoAdicional> Mostrar();
        void Actualizar(InfoAdicional InfoAdicional);
        void Eliminar(InfoAdicional InfoAdicional);
    }
}
