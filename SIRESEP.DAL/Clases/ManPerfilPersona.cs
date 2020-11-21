using SIRESEP.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Clases
{
    public class ManPerfilPersona: IManPerfilPersona
    {
        private static ManPerfilPersona Instancia;

        public static ManPerfilPersona _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManPerfilPersona();
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

        public void Actualizar(PerfilPersona persona)
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

        public void Eliminar(PerfilPersona persona)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                var result = entities.PerfilPersona.Find(persona.idPerfilProfesional);
                entities.PerfilPersona.Remove(result);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void Insertar(PerfilPersona persona)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                entities.PerfilPersona.Add(persona);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<PerfilPersona> Mostrar()
        {
            //Inicializamos
            List<PerfilPersona> lista = new List<PerfilPersona>();

            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                lista = entities.PerfilPersona.ToList();
                entities.SaveChanges();

                return lista;
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public void EliminarbyProcedure(PerfilPersona persona)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(Settings.Default.proveedor);
            DbConnection conn = null;
            DbCommand comm = null;

            try
            {
                conn = factory.CreateConnection();
                conn.ConnectionString = Settings.Default.connection;
                comm = factory.CreateCommand();

                DbParameter param0 = factory.CreateParameter();

                param0.ParameterName = "@id";
                param0.DbType = DbType.Int32;
                param0.Value = persona.idPerfilProfesional;

                //Abrir Conx
                comm.Connection = conn;
                conn.Open();

                //Ejecutar SP y pasar parametros 
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "EliminarPerfil";
                comm.Parameters.Add(param0);
                comm.ExecuteNonQuery();

            }
            catch (Exception ee)
            {

                throw;
            }
            finally
            {
                comm.Dispose();
                conn.Dispose();
            }
        }

    }
}
