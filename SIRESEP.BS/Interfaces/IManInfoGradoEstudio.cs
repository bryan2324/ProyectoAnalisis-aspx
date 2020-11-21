using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DAL;

namespace SIRESEP.BS.Interfaces
{
   public interface IManInfoGradoEstudio
    {
        void Insertar(InfoGradoEstudio gradoestudio);
        List<InfoGradoEstudio> Mostrar();
        void Actualizar(InfoGradoEstudio gradoestudio);
        void Eliminar(InfoGradoEstudio gradoestudio);
    }
}
