using SIRESEP.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Clases
{
    public class ManInfoLicenciaConducir: IManInfoLicenciaConducir
    {
        private static ManInfoLicenciaConducir Instancia;

        public static ManInfoLicenciaConducir _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManInfoLicenciaConducir();
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
        public void Actualizar(InfoLicenciaConducir InfoLicenciaConducir)
        {
            try
            {
                using (BD_SIRESEPEntities entities = new BD_SIRESEPEntities())
                {
                    entities.Entry(InfoLicenciaConducir).State = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Eliminar(InfoLicenciaConducir InfoLicenciaConducir)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                var result = entities.InfoLicenciaConducir.Find(InfoLicenciaConducir.idLicenciaConducir);
                entities.InfoLicenciaConducir.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(InfoLicenciaConducir InfoLicenciaConducir)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                entities.InfoLicenciaConducir.Add(InfoLicenciaConducir);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<InfoLicenciaConducir> Mostrar()
        {
            //Inicializamos
            List<InfoLicenciaConducir> lista = new List<InfoLicenciaConducir>();

            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                lista = entities.InfoLicenciaConducir.ToList();
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
