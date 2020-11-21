using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.BS.Interfaces
{
   public interface IManInfoNacionalidad
    {
        
        void Insertar(InfoNacionalidad nacionalidad);
        List<InfoNacionalidad> Mostrar();
        void Actualizar(InfoNacionalidad nacionalidad);
        void Eliminar(InfoNacionalidad nacionalidad);
    }
}
