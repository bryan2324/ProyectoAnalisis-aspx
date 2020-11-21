using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Interfaces
{
  public   interface IManInfoInstitucion
    {
        void Insertar(InfoInstitucion institucion);
        List<InfoInstitucion> Mostrar();
        void Actualizar(InfoInstitucion institucion);
        void Eliminar(InfoInstitucion institucion);
    }
}
