using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Interfaces
{
   public interface IManCertificaciones
    {
        void Insertar(Certificaciones Certificaciones);
        List<Certificaciones> Mostrar();
        void Actualizar(Certificaciones Certificaciones);
        void Eliminar(Certificaciones Certificaciones);
    }
}
