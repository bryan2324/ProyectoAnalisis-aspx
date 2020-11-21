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
    public class ManInfoEstudios : IManInfoEstudios
    {
        private static ManInfoEstudios Instancia;

        public static ManInfoEstudios _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManInfoEstudios();
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
        public void Actualizar(InfoEstudios estudios)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    SIRESEP.DAL.Clases.ManInfoEstudios._Instancia.Actualizar(estudios);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(InfoEstudios estudios)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    SIRESEP.DAL.Clases.ManInfoEstudios._Instancia.Eliminar(estudios);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(InfoEstudios estudios)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    SIRESEP.DAL.Clases.ManInfoEstudios._Instancia.Insertar(estudios);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<InfoEstudios> Mostrar()
        {
            List<InfoEstudios> lista = new List<InfoEstudios>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = SIRESEP.DAL.Clases.ManInfoEstudios._Instancia.Mostrar();
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
