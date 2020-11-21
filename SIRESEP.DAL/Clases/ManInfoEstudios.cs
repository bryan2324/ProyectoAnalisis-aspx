using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIRESEP.DAL.Interfaces;
namespace SIRESEP.DAL.Clases
{
    public class ManInfoEstudios : IManInfoEstudios
    {
        private static ManInfoEstudios Instancia;

        public static ManInfoEstudios _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManInfoEstudios();
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
        public void Actualizar(InfoEstudios estudios)
        {
            try
            {
                using (BD_SIRESEPEntities entities = new BD_SIRESEPEntities())
                {
                    entities.Entry(estudios).State = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(InfoEstudios estudios)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                var result = entities.InfoEstudios.Find(estudios.idEstudios);
                entities.InfoEstudios.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(InfoEstudios estudios)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                entities.InfoEstudios.Add(estudios);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<InfoEstudios> Mostrar()
        {
            //Inicializamos
            List<InfoEstudios> lista = new List<InfoEstudios>();

            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                lista = entities.InfoEstudios.ToList();
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
