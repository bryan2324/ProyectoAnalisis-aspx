using SIRESEP.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Clases
{
    public class Manhabilidades_perfilProfesional: IManhabilidades_perfilProfesional
    {
        private static Manhabilidades_perfilProfesional Instancia;

        public static Manhabilidades_perfilProfesional _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new Manhabilidades_perfilProfesional();
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
        public void Actualizar(habilidades_perfilProfesional habilidades_perfilProfesional)
        {
            try
            {
                using (BD_SIRESEPEntities entities = new BD_SIRESEPEntities())
                {
                    entities.Entry(habilidades_perfilProfesional).State = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(habilidades_perfilProfesional habilidades_perfilProfesional)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                var result = entities.habilidades_perfilProfesional.Find(habilidades_perfilProfesional.idHabilidadProfesional);
                entities.habilidades_perfilProfesional.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(habilidades_perfilProfesional habilidades_perfilProfesional)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                entities.habilidades_perfilProfesional.Add(habilidades_perfilProfesional);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<habilidades_perfilProfesional> Mostrar()
        {
            //Inicializamos
            List<habilidades_perfilProfesional> lista = new List<habilidades_perfilProfesional>();

            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                lista = entities.habilidades_perfilProfesional.ToList();
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
