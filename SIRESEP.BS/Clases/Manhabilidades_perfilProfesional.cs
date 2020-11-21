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
    public class Manhabilidades_perfilProfesional: IManhabilidades_perfilProfesional
    {
        private static Manhabilidades_perfilProfesional Instancia;

        public static Manhabilidades_perfilProfesional _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new Manhabilidades_perfilProfesional();
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

        public void Actualizar(habilidades_perfilProfesional habilidades_perfilProfesional)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.Manhabilidades_perfilProfesional._Instancia.Actualizar(habilidades_perfilProfesional);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(habilidades_perfilProfesional habilidades_perfilProfesional)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.Manhabilidades_perfilProfesional._Instancia.Eliminar(habilidades_perfilProfesional);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(habilidades_perfilProfesional habilidades_perfilProfesional)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.Manhabilidades_perfilProfesional._Instancia.Insertar(habilidades_perfilProfesional);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<habilidades_perfilProfesional> Mostrar()
        {
            List<habilidades_perfilProfesional> lista = new List<habilidades_perfilProfesional>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Clases.Manhabilidades_perfilProfesional._Instancia.Mostrar();
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
