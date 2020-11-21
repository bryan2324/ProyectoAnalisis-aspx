using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Interfaces
{
    public interface IManInfoLicenciaConducir
    {
        void Insertar(InfoLicenciaConducir InfoLicenciaConducir);
        List<InfoLicenciaConducir> Mostrar();
        void Actualizar(InfoLicenciaConducir InfoLicenciaConducir);
        void Eliminar(InfoLicenciaConducir InfoLicenciaConducir);
    }
}
