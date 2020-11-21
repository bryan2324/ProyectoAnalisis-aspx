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
   public class ManPerfilProfesional_PerfilConcurso: IManPerfilProfesional_PerfilConcurso
    {
        private static ManPerfilProfesional_PerfilConcurso Instancia;

        public static ManPerfilProfesional_PerfilConcurso _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManPerfilProfesional_PerfilConcurso();
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

        public void Actualizar(perfilProfesional_PerfilConcurso perfilProfesional_PerfilConcurso)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManPerfilProfesional_PerfilConcurso._Instancia.Actualizar(perfilProfesional_PerfilConcurso);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(perfilProfesional_PerfilConcurso perfilProfesional_PerfilConcurso)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManPerfilProfesional_PerfilConcurso._Instancia.Eliminar(perfilProfesional_PerfilConcurso);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(perfilProfesional_PerfilConcurso perfilProfesional_PerfilConcurso)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManPerfilProfesional_PerfilConcurso._Instancia.Insertar(perfilProfesional_PerfilConcurso);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<perfilProfesional_PerfilConcurso> Mostrar()
        {
            List<perfilProfesional_PerfilConcurso> lista = new List<perfilProfesional_PerfilConcurso>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Clases.ManPerfilProfesional_PerfilConcurso._Instancia.Mostrar();
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
