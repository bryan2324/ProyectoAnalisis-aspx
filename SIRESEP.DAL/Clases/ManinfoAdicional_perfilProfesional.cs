using SIRESEP.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Clases
{
    public class ManinfoAdicional_perfilProfesional: IManinfoAdicional_perfilProfesional
    {
        private static ManinfoAdicional_perfilProfesional Instancia;

        public static ManinfoAdicional_perfilProfesional _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManinfoAdicional_perfilProfesional();
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
        public void Actualizar(infoAdicional_perfilProfesional infoAdicional_perfilProfesional)
        {
            try
            {
                using (BD_SIRESEPEntities entities = new BD_SIRESEPEntities())
                {
                    entities.Entry(infoAdicional_perfilProfesional).State = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(infoAdicional_perfilProfesional infoAdicional_perfilProfesional)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                var result = entities.infoAdicional_perfilProfesional.Find(infoAdicional_perfilProfesional.idInfoAdicionalProfesional);
                entities.infoAdicional_perfilProfesional.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(infoAdicional_perfilProfesional infoAdicional_perfilProfesional)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                entities.infoAdicional_perfilProfesional.Add(infoAdicional_perfilProfesional);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<infoAdicional_perfilProfesional> Mostrar()
        {
            //Inicializamos
            List<infoAdicional_perfilProfesional> lista = new List<infoAdicional_perfilProfesional>();

            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                lista = entities.infoAdicional_perfilProfesional.ToList();
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
