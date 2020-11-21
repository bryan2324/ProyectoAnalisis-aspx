using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.BS.Interfaces
{
    public interface IManinfoGenero
    {
        void Insertar(InfoGenero infogenero);
        List<InfoGenero> Mostrar();
        void Actualizar(InfoGenero infogenero);
        void Eliminar(InfoGenero infogenero);
    }
}
