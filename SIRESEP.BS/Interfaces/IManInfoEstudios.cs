using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DAL;

namespace SIRESEP.BS.Interfaces
{
    public interface IManInfoEstudios
    {
        void Insertar(InfoEstudios estudios);
        List<InfoEstudios> Mostrar();
        void Actualizar(InfoEstudios estudios);
        void Eliminar(InfoEstudios estudios);
    }
}
