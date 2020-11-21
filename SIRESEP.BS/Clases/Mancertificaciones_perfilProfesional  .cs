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
    public class Mancertificaciones_perfilProfesional: IMancertificaciones_perfilProfesional
    {
        private static Mancertificaciones_perfilProfesional Instancia;

        public static Mancertificaciones_perfilProfesional _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new Mancertificaciones_perfilProfesional();
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

        public void Actualizar(certificaciones_perfilProfesional certificaciones_perfilProfesional)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.Mancertificaciones_perfilProfesional._Instancia.Actualizar(certificaciones_perfilProfesional);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(certificaciones_perfilProfesional certificaciones_perfilProfesional)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.Mancertificaciones_perfilProfesional._Instancia.Eliminar(certificaciones_perfilProfesional);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(certificaciones_perfilProfesional certificaciones_perfilProfesional)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.Mancertificaciones_perfilProfesional._Instancia.Insertar(certificaciones_perfilProfesional);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<certificaciones_perfilProfesional> Mostrar()
        {
            List<certificaciones_perfilProfesional> lista = new List<certificaciones_perfilProfesional>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Clases.Mancertificaciones_perfilProfesional._Instancia.Mostrar();
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
