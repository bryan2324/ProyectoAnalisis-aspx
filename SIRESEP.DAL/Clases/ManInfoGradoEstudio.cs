using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DAL.Interfaces;

namespace SIRESEP.DAL.Clases
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
                using (BD_SIRESEPEntities entities = new BD_SIRESEPEntities())
                {
                    entities.Entry(gradoestudio).State = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();
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
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                var result = entities.InfoGradoEstudio.Find(gradoestudio.idGradoEstudio);
                entities.InfoGradoEstudio.Remove(result);
                entities.SaveChanges();

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
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                entities.InfoGradoEstudio.Add(gradoestudio);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<InfoGradoEstudio> Mostrar()
        {
            //Inicializamos
            List<InfoGradoEstudio> lista = new List<InfoGradoEstudio>();

            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                lista = entities.InfoGradoEstudio.ToList();
                entities.SaveChanges();

                return lista;
            }
            catch (Exception ee)
            {

                throw;
            }
        }
    }
}
