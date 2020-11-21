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
    public class ManCertificaciones: IManCertificaciones
    {
        private static ManCertificaciones Instancia;

        public static ManCertificaciones _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManCertificaciones();
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

        public void Actualizar(Certificaciones Certificaciones)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManCertificaciones._Instancia.Actualizar(Certificaciones);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(Certificaciones Certificaciones)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManCertificaciones._Instancia.Eliminar(Certificaciones);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(Certificaciones Certificaciones)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.Clases.ManCertificaciones._Instancia.Insertar(Certificaciones);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Certificaciones> Mostrar()
        {
            List<Certificaciones> lista = new List<Certificaciones>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.Clases.ManCertificaciones._Instancia.Mostrar();
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
