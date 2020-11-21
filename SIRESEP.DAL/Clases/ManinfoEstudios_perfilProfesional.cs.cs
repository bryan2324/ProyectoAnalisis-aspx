using SIRESEP.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Clases
{
    public class ManinfoEstudios_perfilProfesional:IManinfoEstudios_perfilProfesional
    {
        private static ManinfoEstudios_perfilProfesional Instancia;

        public static ManinfoEstudios_perfilProfesional _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManinfoEstudios_perfilProfesional();
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
        public void Actualizar(infoEstudios_perfilProfesional infoEstudios_perfilProfesional)
        {
            try
            {
                using (BD_SIRESEPEntities entities = new BD_SIRESEPEntities())
                {
                    entities.Entry(infoEstudios_perfilProfesional).State = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(infoEstudios_perfilProfesional infoEstudios_perfilProfesional)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                var result = entities.infoEstudios_perfilProfesional.Find(infoEstudios_perfilProfesional.idEstudiosProfesional);
                entities.infoEstudios_perfilProfesional.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(infoEstudios_perfilProfesional infoEstudios_perfilProfesional)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                entities.infoEstudios_perfilProfesional.Add(infoEstudios_perfilProfesional);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<infoEstudios_perfilProfesional> Mostrar()
        {
            //Inicializamos
            List<infoEstudios_perfilProfesional> lista = new List<infoEstudios_perfilProfesional>();

            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                lista = entities.infoEstudios_perfilProfesional.ToList();
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
