using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Interfaces
{
   public interface IManInfoLaboral
    {
        void Insertar(InfoLaboral InfoLaboral);
        List<InfoLaboral> Mostrar();
        void Actualizar(InfoLaboral InfoLaboral);
        void Eliminar(InfoLaboral InfoLaboral);
    }
}
