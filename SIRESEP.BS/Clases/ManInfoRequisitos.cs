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
    public class ManInfoRequisitos : IManInfoRequisitos
    {
        private static ManInfoRequisitos Instancia;

        public static ManInfoRequisitos _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManInfoRequisitos();
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

        public void Actualizar(InfoRequisitos requisito)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManInfoRequisitos._Instancia.Actualizar(requisito);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }
    

        public void Eliminar(InfoRequisitos requisito)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManInfoRequisitos._Instancia.Eliminar(requisito);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
            
        }

        public void Insertar(InfoRequisitos requisito)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManInfoRequisitos._Instancia.Insertar(requisito);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<InfoRequisitos> Mostrar()
        {
            List<InfoRequisitos> lista = new List<InfoRequisitos>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Clases.ManInfoRequisitos._Instancia.Mostrar();
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