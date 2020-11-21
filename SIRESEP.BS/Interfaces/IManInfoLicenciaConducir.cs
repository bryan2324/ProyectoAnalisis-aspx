using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.BS.Interfaces
{
    public interface IManInfoLicenciaConducir
    {
        void Insertar(InfoLicenciaConducir InfoLicenciaConducir);
        List<InfoLicenciaConducir> Mostrar();
        void Actualizar(InfoLicenciaConducir InfoLicenciaConducir);
        void Eliminar(InfoLicenciaConducir InfoLicenciaConducir);
    }
}
