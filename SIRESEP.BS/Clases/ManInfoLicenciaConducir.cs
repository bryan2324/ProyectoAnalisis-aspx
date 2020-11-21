using SIRESEP.BS.Interfaces;
using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SIRESEP.BS.Clases
{
    public class ManInfoLicenciaConducir: IManInfoLicenciaConducir
    {
        private static ManInfoLicenciaConducir Instancia;

        public static ManInfoLicenciaConducir _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManInfoLicenciaConducir();
                }
                return Instancia;
            }
            set
            {
                if (Instancia == null)
                {
                    Instancia = value;
                }
            }
        }

        public void Actualizar(InfoLicenciaConducir InfoLicenciaConducir)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManInfoLicenciaConducir._Instancia.Actualizar(InfoLicenciaConducir);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(InfoLicenciaConducir InfoLicenciaConducir)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManInfoLicenciaConducir._Instancia.Eliminar(InfoLicenciaConducir);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(InfoLicenciaConducir InfoLicenciaConducir)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManInfoLicenciaConducir._Instancia.Insertar(InfoLicenciaConducir);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<InfoLicenciaConducir> Mostrar()
        {
            List<InfoLicenciaConducir> lista = new List<InfoLicenciaConducir>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Clases.ManInfoLicenciaConducir._Instancia.Mostrar();
                    scope.Complete();
                }
                return lista;
            }
            catch (Exception ee)
            {

                throw;
            }
        }
    }
}
