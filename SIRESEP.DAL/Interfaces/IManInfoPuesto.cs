using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Interfaces
{
   public  interface IManInfoPuesto
    {
        void Insertar(InfoPuesto puesto);
        List<InfoPuesto> Mostrar();
        void Actualizar(InfoPuesto puesto);
        void Eliminar(InfoPuesto puesto);
    }
}
