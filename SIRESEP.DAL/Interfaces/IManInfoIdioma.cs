using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Interfaces
{
    public interface IManInfoIdioma
    {
        void Insertar(InfoIdioma InfoIdioma);
        List<InfoIdioma> Mostrar();
        void Actualizar(InfoIdioma InfoIdioma);
        void Eliminar(InfoIdioma InfoIdioma);
    }
}
