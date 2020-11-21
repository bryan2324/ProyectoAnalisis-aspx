using SIRESEP.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Interfaces
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
