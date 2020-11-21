
using SIRESEP.DAL;
using SIRESEP.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
namespace SIRESEP.BS.Clases
{
    public class ManInfoInstitucion : IManInfoInstitucion
    {
        private static ManInfoInstitucion Instancia;

        public static ManInfoInstitucion _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManInfoInstitucion();
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
        public void Actualizar(InfoInstitucion institucion)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    SIRESEP.DAL.Clases.ManInfoInstitucion._Instancia.Actualizar(institucion);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(InfoInstitucion institucion)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    SIRESEP.DAL.Clases.ManInfoInstitucion._Instancia.Eliminar(institucion);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(InfoInstitucion institucion)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    SIRESEP.DAL.Clases.ManInfoInstitucion._Instancia.Insertar(institucion);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<InfoInstitucion> Mostrar()
        {
            List<InfoInstitucion> lista = new List<InfoInstitucion>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = SIRESEP.DAL.Clases.ManInfoInstitucion._Instancia.Mostrar();
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
