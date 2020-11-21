using SIRESEP.BS.Interfaces;
using SIRESEP.DAL;
using SIRESEP.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SIRESEP.BS
{
    public class ManUsuario: IManUsuario
    {
        private static ManUsuario Instancia;

        public static ManUsuario _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManUsuario();
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

        public void Actualizar(Usuarios Usuario)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.ManUsuario._Instancia.Actualizar(Usuario);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        //public void ActualizarContra(Usuarios Usuario)
        //{
           
        //}

        public void Eliminar(Usuarios Usuario)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.ManUsuario._Instancia.Eliminar(Usuario);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(Usuarios Usuario)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.ManUsuario._Instancia.Insertar(Usuario);
                    scope.Complete();

                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void ActualizarContra(Usuario usuarioo)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.ManUsuario._Instancia.ActualizarContra(usuarioo);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<Usuarios> Mostrar()
        {
            List<Usuarios> lista = new List<Usuarios>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = DAL.ManUsuario._Instancia.Mostrar();
                    scope.Complete();
                }
                return lista;
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void ActualizarRol(Usuarios usuarioo)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    DAL.ManUsuario._Instancia.ActualizarRol(usuarioo);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

    }
}
