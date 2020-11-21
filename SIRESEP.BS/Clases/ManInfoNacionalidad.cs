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
    public class ManInfoNacionalidad: IManInfoNacionalidad
    {
        private static ManInfoNacionalidad Instancia;

        public static ManInfoNacionalidad _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManInfoNacionalidad();
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

        public void Actualizar(InfoNacionalidad persona)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManInfoNacionalidad._Instancia.Actualizar(persona);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(InfoNacionalidad persona)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManInfoNacionalidad._Instancia.Eliminar(persona);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(InfoNacionalidad persona)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManInfoNacionalidad._Instancia.Insertar(persona);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<InfoNacionalidad> Mostrar()
        {
            List<InfoNacionalidad> lista = new List<InfoNacionalidad>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Clases.ManInfoNacionalidad._Instancia.Mostrar();
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
