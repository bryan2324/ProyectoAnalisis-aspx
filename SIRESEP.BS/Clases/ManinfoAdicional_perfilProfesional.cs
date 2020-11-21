using SIRESEP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SIRESEP.BS.Clases
{
    public class ManinfoAdicional_perfilProfesional
    {
        private static ManinfoAdicional_perfilProfesional Instancia;

        public static ManinfoAdicional_perfilProfesional _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManinfoAdicional_perfilProfesional();
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

        public void Actualizar(infoAdicional_perfilProfesional infoAdicional_perfilProfesional)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManinfoAdicional_perfilProfesional._Instancia.Actualizar(infoAdicional_perfilProfesional);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(infoAdicional_perfilProfesional infoAdicional_perfilProfesional)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManinfoAdicional_perfilProfesional._Instancia.Eliminar(infoAdicional_perfilProfesional);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(infoAdicional_perfilProfesional infoAdicional_perfilProfesional)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManinfoAdicional_perfilProfesional._Instancia.Insertar(infoAdicional_perfilProfesional);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<infoAdicional_perfilProfesional> Mostrar()
        {
            List<infoAdicional_perfilProfesional> lista = new List<infoAdicional_perfilProfesional>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Clases.ManinfoAdicional_perfilProfesional._Instancia.Mostrar();
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
