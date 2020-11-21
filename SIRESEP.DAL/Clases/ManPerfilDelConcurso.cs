using SIRESEP.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL.Clases
{
    public class ManPerfilDelConcurso : IManPerfilDelConcurso
    {
            
        private static ManPerfilDelConcurso Instancia;

        public static ManPerfilDelConcurso _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManPerfilDelConcurso();
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

        public void Actualizar(PerfilDelConcurso concurso)
        {
            try
            {
                using (BD_SIRESEPEntities entities = new BD_SIRESEPEntities())
                {
                    entities.Entry(concurso).State = System.Data.Entity.EntityState.Modified;
                    entities.SaveChanges();
                }
            }
            catch (Exception ee)
            {

                throw;
            }
        }
    

        public void Eliminar(PerfilDelConcurso concurso)
        {
        try
        {
            BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
            var result = entities.PerfilDelConcurso.Find(concurso.idConcurso);
            entities.PerfilDelConcurso.Remove(result);
            entities.SaveChanges();

        }
        catch (Exception ee)
        {

            throw;
        }
    }

        public void Insertar(PerfilDelConcurso concurso)
        {
            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                entities.PerfilDelConcurso.Add(concurso);
                entities.SaveChanges();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        public List<PerfilDelConcurso> Mostrar()
        {
            //Inicializamos
            List<PerfilDelConcurso> lista = new List<PerfilDelConcurso>();

            try
            {
                BD_SIRESEPEntities entities = new BD_SIRESEPEntities();
                lista = entities.PerfilDelConcurso.ToList();
                entities.SaveChanges();

                return lista;
            }
            catch (Exception ee)
            {

                throw;
            }
        }
        public void EliminarbyProcedure(PerfilDelConcurso concurso)
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
                    param0.Value = concurso.idConcurso;

                    //Abrir Conx
                    comm.Connection = conn;
                    conn.Open();

                    //Ejecutar SP y pasar parametros 
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "EliminarPerfilDelConcurso";
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

