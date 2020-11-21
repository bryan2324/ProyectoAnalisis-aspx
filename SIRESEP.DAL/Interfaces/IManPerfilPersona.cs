using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Interfaces
{
   public interface IManPerfilPersona
    {
        void Insertar(PerfilPersona nacionalidad);
        List<PerfilPersona> Mostrar();
        void Actualizar(PerfilPersona nacionalidad);
        void Eliminar(PerfilPersona nacionalidad);
    }
}
