using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Interfaces
{
    public interface IManInfoHabilidad
    {
        void Insertar(InfoHabilidad InfoHabilidad);
        List<InfoHabilidad> Mostrar();
        void Actualizar(InfoHabilidad InfoHabilidad);
        void Eliminar(InfoHabilidad InfoHabilidad);
    }
}
