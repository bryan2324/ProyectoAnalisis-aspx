using SIRESEP.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Clases
{
   public class ManAplicaciones: IManAplicaciones
    {
        private static ManAplicaciones Instancia;

        public static ManAplicaciones _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManAplicaciones();
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
        public void Actualizar(aplicaciones aplicaciones)
        {
            try
            {
                using (BD_SIRESEPEntities entities = new BD_SIRESEPEntities())
                {
                    entities.Entry(aplicaciones).State = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }


        public void Eliminar(aplicaciones aplicaciones)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                var result = entities.aplicaciones.Find(aplicaciones.idAplicacion);
                entities.aplicaciones.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(aplicaciones aplicaciones)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                entities.aplicaciones.Add(aplicaciones);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<aplicaciones> Mostrar()
        {
            //Inicializamos
            List<aplicaciones> lista = new List<aplicaciones>();

            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                lista = entities.aplicaciones.ToList();
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
