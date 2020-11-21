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
    public class ManInfoLaboral: IManInfoLaboral
    {
        private static ManInfoLaboral Instancia;

        public static ManInfoLaboral _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManInfoLaboral();
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

        public void Actualizar(InfoLaboral InfoLaboral)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManInfoLaboral._Instancia.Actualizar(InfoLaboral);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(InfoLaboral InfoLaboral)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManInfoLaboral._Instancia.Eliminar(InfoLaboral);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(InfoLaboral InfoLaboral)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManInfoLaboral._Instancia.Insertar(InfoLaboral);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<InfoLaboral> Mostrar()
        {
            List<InfoLaboral> lista = new List<InfoLaboral>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Clases.ManInfoLaboral._Instancia.Mostrar();
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
