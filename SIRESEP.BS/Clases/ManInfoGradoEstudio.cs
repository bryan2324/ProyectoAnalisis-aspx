using SIRESEP.DAL;
using SIRESEP.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
namespace SIRESEP.BS.Clases
{
    public class ManInfoGradoEstudio : IManInfoGradoEstudio
    {
        private static ManInfoGradoEstudio Instancia;

        public static ManInfoGradoEstudio _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManInfoGradoEstudio();
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
        public void Actualizar(InfoGradoEstudio gradoestudio)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    SIRESEP.DAL.Clases.ManInfoGradoEstudio._Instancia.Actualizar(gradoestudio);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(InfoGradoEstudio gradoestudio)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    SIRESEP.DAL.Clases.ManInfoGradoEstudio._Instancia.Eliminar(gradoestudio);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(InfoGradoEstudio gradoestudio)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    SIRESEP.DAL.Clases.ManInfoGradoEstudio._Instancia.Insertar(gradoestudio);
                    scope.Complete();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<InfoGradoEstudio> Mostrar()
        {
            List<InfoGradoEstudio> lista = new List<InfoGradoEstudio>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    lista = SIRESEP.DAL.Clases.ManInfoGradoEstudio._Instancia.Mostrar();
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
