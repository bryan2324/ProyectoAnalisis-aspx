using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.BS.Interfaces
{
    public interface IMancertificaciones_perfilProfesional
    {
        void Insertar(certificaciones_perfilProfesional certificaciones_perfilProfesional);
        List<certificaciones_perfilProfesional> Mostrar();
        void Actualizar(certificaciones_perfilProfesional certificaciones_perfilProfesional);
        void Eliminar(certificaciones_perfilProfesional certificaciones_perfilProfesional);
    }
}
