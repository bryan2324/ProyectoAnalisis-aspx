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
    public class ManinfoEstudios_perfilProfesional: IManinfoEstudios_perfilProfesional
    {
        private static ManinfoEstudios_perfilProfesional Instancia;

        public static ManinfoEstudios_perfilProfesional _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManinfoEstudios_perfilProfesional();
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

        public void Actualizar(infoEstudios_perfilProfesional infoEstudios_perfilProfesional)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManinfoEstudios_perfilProfesional._Instancia.Actualizar(infoEstudios_perfilProfesional);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(infoEstudios_perfilProfesional infoEstudios_perfilProfesional)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManinfoEstudios_perfilProfesional._Instancia.Eliminar(infoEstudios_perfilProfesional);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(infoEstudios_perfilProfesional infoEstudios_perfilProfesional)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManinfoEstudios_perfilProfesional._Instancia.Insertar(infoEstudios_perfilProfesional);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<infoEstudios_perfilProfesional> Mostrar()
        {
            List<infoEstudios_perfilProfesional> lista = new List<infoEstudios_perfilProfesional>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Clases.ManinfoEstudios_perfilProfesional._Instancia.Mostrar();
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
