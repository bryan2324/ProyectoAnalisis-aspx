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
    public class ManPerfilPersona: IManPerfilPersona
    {
        private static ManPerfilPersona Instancia;

        public static ManPerfilPersona _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManPerfilPersona();
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

        public void Actualizar(PerfilPersona persona)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManPerfilPersona._Instancia.Actualizar(persona);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(PerfilPersona persona)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManPerfilPersona._Instancia.EliminarbyProcedure(persona);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(PerfilPersona persona)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManPerfilPersona._Instancia.Insertar(persona);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<PerfilPersona> Mostrar()
        {
            List<PerfilPersona> lista = new List<PerfilPersona>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Clases.ManPerfilPersona._Instancia.Mostrar();
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
