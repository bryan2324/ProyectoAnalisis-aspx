using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Interfaces
{
    public interface IManAplicaciones
    {
        void Insertar(aplicaciones aplicaciones);
        List<aplicaciones> Mostrar();
        void Actualizar(aplicaciones aplicaciones);
        void Eliminar(aplicaciones aplicaciones);
    }
}
