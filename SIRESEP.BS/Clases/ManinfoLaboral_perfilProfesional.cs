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
    public class ManinfoLaboral_perfilProfesional: IManinfoLaboral_perfilProfesional
    {
        private static ManinfoLaboral_perfilProfesional Instancia;

        public static ManinfoLaboral_perfilProfesional _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManinfoLaboral_perfilProfesional();
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

        public void Actualizar(infoLaboral_perfilProfesional infoLaboral_perfilProfesional)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManinfoLaboral_perfilProfesional._Instancia.Actualizar(infoLaboral_perfilProfesional);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(infoLaboral_perfilProfesional infoLaboral_perfilProfesional)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManinfoLaboral_perfilProfesional._Instancia.Eliminar(infoLaboral_perfilProfesional);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(infoLaboral_perfilProfesional infoLaboral_perfilProfesional)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManinfoLaboral_perfilProfesional._Instancia.Insertar(infoLaboral_perfilProfesional);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<infoLaboral_perfilProfesional> Mostrar()
        {
            List<infoLaboral_perfilProfesional> lista = new List<infoLaboral_perfilProfesional>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Clases.ManinfoLaboral_perfilProfesional._Instancia.Mostrar();
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
