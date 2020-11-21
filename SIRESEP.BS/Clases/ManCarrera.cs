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
    public class ManCarrera : IManCarrera
    {
        private static ManCarrera Instancia;

        public static ManCarrera _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManCarrera();
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

        public void Actualizar(Carrera carrera)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManCarrera._Instancia.Actualizar(carrera);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(Carrera carrera)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManCarrera._Instancia.Eliminar(carrera);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(Carrera carrera)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManCarrera._Instancia.Insertar(carrera);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Carrera> Mostrar()
        {
            List<Carrera> lista = new List<Carrera>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Clases.ManCarrera._Instancia.Mostrar();
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
