using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.BS.Interfaces
{
    public interface IManInfoPuesto
    {
        void Insertar(InfoPuesto puesto);
        List<InfoPuesto> Mostrar();
        void Actualizar(InfoPuesto puesto);
        void Eliminar(InfoPuesto puesto);
    }
}
