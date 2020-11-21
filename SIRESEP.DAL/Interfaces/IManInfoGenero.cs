using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Interfaces
{
    public interface IManInfoGenero
    {
        void Insertar(InfoGenero infogenero);
        List<InfoGenero> Mostrar();
        void Actualizar(InfoGenero infogenero);
        void Eliminar(InfoGenero infogenero);
    }
}
