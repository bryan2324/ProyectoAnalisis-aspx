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
    public class ManInfoAdicional: IManInfoAdicional
    {
        private static ManInfoAdicional Instancia;

        public static ManInfoAdicional _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManInfoAdicional();
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

        public void Actualizar(InfoAdicional InfoAdicional)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManInfoAdicional._Instancia.Actualizar(InfoAdicional);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(InfoAdicional InfoAdicional)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManInfoAdicional._Instancia.Eliminar(InfoAdicional);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(InfoAdicional InfoAdicional)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManInfoAdicional._Instancia.Insertar(InfoAdicional);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<InfoAdicional> Mostrar()
        {
            List<InfoAdicional> lista = new List<InfoAdicional>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Clases.ManInfoAdicional._Instancia.Mostrar();
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
