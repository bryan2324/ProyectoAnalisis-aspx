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
    public class ManPerfilDelConcurso : IManPerfilDelConcurso
    {
        private static ManPerfilDelConcurso Instancia;

        public static ManPerfilDelConcurso _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManPerfilDelConcurso();
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
        public void Actualizar(PerfilDelConcurso concurso)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManPerfilDelConcurso._Instancia.Actualizar(concurso);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(PerfilDelConcurso concurso)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManPerfilDelConcurso._Instancia.EliminarbyProcedure(concurso);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(PerfilDelConcurso concurso)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManPerfilDelConcurso._Instancia.Insertar(concurso);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<PerfilDelConcurso> Mostrar()
        {
            List<PerfilDelConcurso> lista = new List<PerfilDelConcurso>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Clases.ManPerfilDelConcurso._Instancia.Mostrar();
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
