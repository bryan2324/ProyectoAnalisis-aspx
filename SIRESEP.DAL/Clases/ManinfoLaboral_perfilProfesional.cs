using SIRESEP.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Clases
{
   public class ManinfoLaboral_perfilProfesional: IManinfoLaboral_perfilProfesional
    {
        private static ManinfoLaboral_perfilProfesional Instancia;

        public static ManinfoLaboral_perfilProfesional _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManinfoLaboral_perfilProfesional();
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
        public void Actualizar(infoLaboral_perfilProfesional infoLaboral_perfilProfesional)
        {
            try
            {
                using (BD_SIRESEPEntities entities = new BD_SIRESEPEntities())
                {
                    entities.Entry(infoLaboral_perfilProfesional).State = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(infoLaboral_perfilProfesional infoLaboral_perfilProfesional)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                var result = entities.infoLaboral_perfilProfesional.Find(infoLaboral_perfilProfesional.idInfoLaboralProfesional);
                entities.infoLaboral_perfilProfesional.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(infoLaboral_perfilProfesional infoLaboral_perfilProfesional)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                entities.infoLaboral_perfilProfesional.Add(infoLaboral_perfilProfesional);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<infoLaboral_perfilProfesional> Mostrar()
        {
            //Inicializamos
            List<infoLaboral_perfilProfesional> lista = new List<infoLaboral_perfilProfesional>();

            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                lista = entities.infoLaboral_perfilProfesional.ToList();
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
