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
    public class ManInfoIdioma: IManInfoIdioma
    {
        private static ManInfoIdioma Instancia;

        public static ManInfoIdioma _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManInfoIdioma();
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

        public void Actualizar(InfoIdioma InfoIdioma)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManInfoIdioma._Instancia.Actualizar(InfoIdioma);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(InfoIdioma InfoIdioma)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManInfoIdioma._Instancia.Eliminar(InfoIdioma);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(InfoIdioma InfoIdioma)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManInfoIdioma._Instancia.Insertar(InfoIdioma);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<InfoIdioma> Mostrar()
        {
            List<InfoIdioma> lista = new List<InfoIdioma>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Clases.ManInfoIdioma._Instancia.Mostrar();
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
