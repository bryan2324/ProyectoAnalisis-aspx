using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Interfaces
{
    public interface IManCarrera
    {
        void Insertar(Carrera carrera);
        List<Carrera> Mostrar();
        void Actualizar(Carrera carrera);
        void Eliminar(Carrera carrera);
    }
}
