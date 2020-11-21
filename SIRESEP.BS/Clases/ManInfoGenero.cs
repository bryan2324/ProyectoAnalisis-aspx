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
   public class ManInfoGenero: IManInfoGenero
    {
        private static ManInfoGenero Instancia;

        public static ManInfoGenero _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManInfoGenero();
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

        public void Actualizar(InfoGenero persona)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    SIRESEP.DAL.Clases.ManInfoGenero._Instancia.Actualizar(persona);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(InfoGenero persona)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    SIRESEP.DAL.Clases.ManInfoGenero._Instancia.Eliminar(persona);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(InfoGenero persona)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    SIRESEP.DAL.Clases.ManInfoGenero._Instancia.Insertar(persona);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<InfoGenero> Mostrar()
        {
            List<InfoGenero> lista = new List<InfoGenero>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = SIRESEP.DAL.Clases.ManInfoGenero._Instancia.Mostrar();
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
