using SIRESEP.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Clases
{
    public class ManInfoLaboral:IManInfoLaboral
    {
        private static ManInfoLaboral Instancia;

        public static ManInfoLaboral _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManInfoLaboral();
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
        public void Actualizar(InfoLaboral InfoLaboral)
        {
            try
            {
                using (BD_SIRESEPEntities entities = new BD_SIRESEPEntities())
                {
                    entities.Entry(InfoLaboral).State = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(InfoLaboral InfoLaboral)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                var result = entities.InfoLaboral.Find(InfoLaboral.idInfoLaboral);
                entities.InfoLaboral.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(InfoLaboral InfoLaboral)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                entities.InfoLaboral.Add(InfoLaboral);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<InfoLaboral> Mostrar()
        {
            //Inicializamos
            List<InfoLaboral> lista = new List<InfoLaboral>();

            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                lista = entities.InfoLaboral.ToList();
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
