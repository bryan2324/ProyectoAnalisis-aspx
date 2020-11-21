using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Interfaces
{
   public  interface IManInfoGradoEstudio
    {
        void Insertar(InfoGradoEstudio gradoestudio);
        List<InfoGradoEstudio> Mostrar();
        void Actualizar(InfoGradoEstudio gradoestudio);
        void Eliminar(InfoGradoEstudio gradoestudio);
    }
}
