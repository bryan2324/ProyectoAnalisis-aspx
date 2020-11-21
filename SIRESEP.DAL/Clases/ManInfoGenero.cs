using SIRESEP.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Clases
{
    public class ManInfoGenero: IManInfoGenero
    {
        private static ManInfoGenero Instancia;

        public static ManInfoGenero _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManInfoGenero();
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

        public void Actualizar(InfoGenero persona)
        {
            try
            {
                using (BD_SIRESEPEntities entities = new BD_SIRESEPEntities())
                {
                    entities.Entry(persona).State = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(InfoGenero persona)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                var result = entities.InfoGenero.Find(persona.idGenero);
                entities.InfoGenero.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(InfoGenero persona)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                entities.InfoGenero.Add(persona);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<InfoGenero> Mostrar()
        {
            //Inicializamos
            List<InfoGenero> lista = new List<InfoGenero>();

            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                lista = entities.InfoGenero.ToList();
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
