using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DAL.Interfaces;
namespace SIRESEP.DAL.Clases
{
    public class ManInfoInstitucion : IManInfoInstitucion
    {
        private static ManInfoInstitucion Instancia;

        public static ManInfoInstitucion _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManInfoInstitucion();
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
        public void Actualizar(InfoInstitucion institucion)
        {
            try
            {
                using (BD_SIRESEPEntities entities = new BD_SIRESEPEntities())
                {
                    entities.Entry(institucion).State = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(InfoInstitucion institucion)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                var result = entities.InfoInstitucion.Find(institucion.idInstitucion);
                entities.InfoInstitucion.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(InfoInstitucion institucion)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                entities.InfoInstitucion.Add(institucion);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<InfoInstitucion> Mostrar()
        {
            //Inicializamos
            List<InfoInstitucion> lista = new List<InfoInstitucion>();

            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                lista = entities.InfoInstitucion.ToList();
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
