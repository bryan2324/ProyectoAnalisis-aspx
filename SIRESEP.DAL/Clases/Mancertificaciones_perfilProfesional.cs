using SIRESEP.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Clases
{
    public class Mancertificaciones_perfilProfesional: IMancertificaciones_perfilProfesional
    {
        private static Mancertificaciones_perfilProfesional Instancia;

        public static Mancertificaciones_perfilProfesional _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new Mancertificaciones_perfilProfesional();
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
        public void Actualizar(certificaciones_perfilProfesional certificaciones_perfilProfesional)
        {
            try
            {
                using (BD_SIRESEPEntities entities = new BD_SIRESEPEntities())
                {
                    entities.Entry(certificaciones_perfilProfesional).State = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(certificaciones_perfilProfesional certificaciones_perfilProfesional)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                var result = entities.certificaciones_perfilProfesional.Find(certificaciones_perfilProfesional.idCertificacionProfesional);
                entities.certificaciones_perfilProfesional.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(certificaciones_perfilProfesional certificaciones_perfilProfesional)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                entities.certificaciones_perfilProfesional.Add(certificaciones_perfilProfesional);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<certificaciones_perfilProfesional> Mostrar()
        {
            //Inicializamos
            List<certificaciones_perfilProfesional> lista = new List<certificaciones_perfilProfesional>();

            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                lista = entities.certificaciones_perfilProfesional.ToList();
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
