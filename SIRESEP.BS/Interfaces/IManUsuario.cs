using SIRESEP.DO;
using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.BS.Interfaces
{
   public interface IManUsuario
    {
        void Insertar(Usuarios Usuario);
        List<Usuarios> Mostrar();
        void Actualizar(Usuarios Usuario);
        void ActualizarContra(Usuario Usuario);
        void Eliminar(Usuarios Usuario);
    }
}
