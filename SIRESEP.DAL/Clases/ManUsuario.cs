using SIRESEP.DAL.Interfaces;
using SIRESEP.DO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DAL
{
    public class ManUsuario: IManUsuario
    {
        private static ManUsuario Instancia;

        public static ManUsuario _Instancia
        {
            get
            {
                if (Instancia == null)
                {
                    return new ManUsuario();
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

        public void Actualizar(Usuarios Usuarios)
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
                DbParameter param1 = factory.CreateParameter();
                DbParameter param2 = factory.CreateParameter();
                DbParameter param3 = factory.CreateParameter();



                param0.ParameterName = "@correoElectronico";
                param0.DbType = DbType.String;
                param0.Value = Usuarios._correoElectronico;


                param1.ParameterName = "@cedula";
                param1.DbType = DbType.String;
                param1.Value = Usuarios._cedula;

                param2.ParameterName = "@contrasena";
                param2.DbType = DbType.String;
                param2.Value = Usuarios._contrasena;

                param2.ParameterName = "@idRol";
                param2.DbType = DbType.Int32;
                param2.Value = Usuarios._idRol;







                //Abrir Conx
                comm.Connection = conn;
                conn.Open();

                //Ejecutar SP y pasar parametros 
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "ActualizarUsuarios";
                comm.Parameters.Add(param0);
                comm.Parameters.Add(param1);
                comm.Parameters.Add(param2);
                comm.Parameters.Add(param3);




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

        public void Eliminar(Usuarios Usuarios)
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

                param0.ParameterName = "@idUsuario";
                param0.DbType = DbType.Int32;
                param0.Value = Usuarios._idUsuario;

                //Abrir Conx
                comm.Connection = conn;
                conn.Open();

                //Ejecutar SP y pasar parametros 
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "disableUsuario";
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

        public void Insertar(Usuarios Usuarios)
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(Settings.Default.proveedor);
            DbConnection conn = null;
            DbCommand comm = null;

            try
            {
                conn = factory.CreateConnection();
                conn.ConnectionString = Settings.Default.connection;
                comm = factory.CreateCommand();

                DbParameter param1 = factory.CreateParameter();
                DbParameter param2 = factory.CreateParameter();
                DbParameter param3 = factory.CreateParameter();
                DbParameter param4 = factory.CreateParameter();
                DbParameter param5 = factory.CreateParameter();

                param1.ParameterName = "@correoElectronico";
                param1.DbType = DbType.String;
                param1.Value = Usuarios._correoElectronico;


                param2.ParameterName = "@cedula";
                param2.DbType = DbType.String;
                param2.Value = Usuarios._cedula;

                param3.ParameterName = "@contrasena";
                param3.DbType = DbType.String;
                param3.Value = Usuarios._contrasena;

                param4.ParameterName = "@salt";
                param4.DbType = DbType.String;
                param4.Value = Usuarios._salt;

                param5.ParameterName = "@idRol";
                param5.DbType = DbType.Int32;
                param5.Value = Usuarios._idRol;





                //Abrir Conx
                comm.Connection = conn;
                conn.Open();

                //Ejecutar SP y pasar parametros 
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "insertarUsuarios";
                comm.Parameters.Add(param1);
                comm.Parameters.Add(param2);
                comm.Parameters.Add(param3);
                comm.Parameters.Add(param4);
                comm.Parameters.Add(param5);



                comm.ExecuteNonQuery();

            }
            catch (Exception ex)
            {



                throw;
            }
            finally
            {

            }
        }

        public List<Usuarios> Mostrar()
        {
            //Inicializamos
            List<Usuarios> lista = new List<Usuarios>();

            DbConnection conn = null;
            DbCommand comm = null;

            try
            {

                DbProviderFactory factory = DbProviderFactories.GetFactory(Settings.Default.proveedor);

                conn = factory.CreateConnection();
                conn.ConnectionString = Settings.Default.connection;
                comm = factory.CreateCommand();

                comm.Connection = conn;
                conn.Open();

                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "MostrarUsuario";

                using (IDataReader dataReader = comm.ExecuteReader())
                {
                    Usuarios Usuarios;
                    while (dataReader.Read())
                    {
                        Usuarios = new Usuarios
                        {
                            _idUsuario = Convert.ToInt32(dataReader["IdUsuario"].ToString()),
                            _correoElectronico = dataReader["correoElectronico"].ToString(),
                            _cedula = dataReader["cedula"].ToString(),
                            _contrasena = dataReader["contrasena"].ToString(),
                            _fechaRegistro = Convert.ToDateTime(dataReader["fechaRegistro"].ToString()),
                            _salt = dataReader["salt"].ToString(),
                            _idRol = Convert.ToInt32(dataReader["idRol"].ToString()),
                            
                        };
                        lista.Add(Usuarios);
                    }
                }
                return lista;
            }
            catch (Exception ee)
            {

                throw;
            }



        }

      

        public void ActualizarContra(Usuario Usuarios)
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
                DbParameter param1 = factory.CreateParameter();
                DbParameter param2 = factory.CreateParameter();

                param0.ParameterName = "@cedula";
                param0.DbType = DbType.String;
                param0.Value = Usuarios.cedula;

                param1.ParameterName = "@contrasena";
                param1.DbType = DbType.String;
                param1.Value = Usuarios.contrasena;

                param2.ParameterName = "@salt";
                param2.DbType = DbType.String;
                param2.Value = Usuarios.salt;



                //Abrir Conx
                comm.Connection = conn;
                conn.Open();

                //Ejecutar SP y pasar parametros 
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "ActualizarContra";
                comm.Parameters.Add(param0);
                comm.Parameters.Add(param1);
                comm.Parameters.Add(param2);

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



        public void ActualizarRol(Usuarios Usuarios)
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
                DbParameter param1 = factory.CreateParameter();


                param0.ParameterName = "@idUsuario";
                param0.DbType = DbType.Int32;
                param0.Value = Usuarios._idUsuario;

                param1.ParameterName = "@idRol";
                param1.DbType = DbType.Int32;
                param1.Value = Usuarios._idRol;

     



                //Abrir Conx
                comm.Connection = conn;
                conn.Open();

                //Ejecutar SP y pasar parametros 
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "ActualizarRol";
                comm.Parameters.Add(param0);
                comm.Parameters.Add(param1);
   

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
