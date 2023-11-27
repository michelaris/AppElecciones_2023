using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class EleccionDao
    {
        public DataTable listarElecciones(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "spListarEleccionesOpcion";//"listarElecciones";
                MySqlCommand Comando = new MySqlCommand(sql_tarea, SqlCon);
                Comando.CommandTimeout = 60;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("cTexto", cTexto);
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); }
        }

        public string crearEleccion(Eleccion oEle)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);

                Sqltarea = "spCrearEleccion";

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pDescripcion", oEle.Descripcion);
                Comando.Parameters.AddWithValue("pCargo", oEle.Cargo);
                Comando.Parameters.AddWithValue("pActivo", oEle.Activo);
                Comando.Parameters.AddWithValue("pFechaRegistro", oEle.FechaRegistro);
                Comando.Parameters.AddWithValue("pFechaVotacion", oEle.FechaVotacion);
                Comando.Parameters.AddWithValue("pIdUsuario", oEle.IdUsuario);
                Comando.Parameters.AddWithValue("pFoto", oEle.Foto);

                Comando.CommandText = Sqltarea;

                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo ingresar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        public string editarEleccion(Eleccion oEle)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);

                Sqltarea = "spActualizarEleccion";

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pIdEleccion", oEle.IdEleccion);

                Comando.Parameters.AddWithValue("pDescripcion", oEle.Descripcion);
                Comando.Parameters.AddWithValue("pCargo", oEle.Cargo);
                Comando.Parameters.AddWithValue("pActivo", oEle.Activo);
                Comando.Parameters.AddWithValue("pFechaRegistro", oEle.FechaRegistro);
                Comando.Parameters.AddWithValue("pFechaVotacion", oEle.FechaVotacion);
                Comando.Parameters.AddWithValue("pIdUsuario", oEle.IdUsuario);
                Comando.Parameters.AddWithValue("pFoto", oEle.Foto);

                Comando.CommandText = Sqltarea;

                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo Actualizar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string eliminarEleccion(int idEleccion)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {

                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Sqltarea = "spEliminarEleccion";

                Comando.Parameters.AddWithValue("pIdEleccion", idEleccion);
                Comando.CommandText = Sqltarea;

                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        public Eleccion obtenerEleccion(int idEleccion)
        {
            Eleccion ele = new Eleccion();
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                string sql_tarea = "spObtenerEleccion";
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(sql_tarea, SqlCon);

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pIdEleccion", idEleccion);
                Comando.CommandTimeout = 60;

                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                if (Resultado.HasRows)
                {
                    while (Resultado.Read())
                    {
                        ele.IdEleccion = Resultado.GetInt32(0);
                        ele.Descripcion = Resultado.GetString(1);
                        ele.Cargo = Resultado.GetString(2);
                        ele.Activo = Resultado.GetBoolean(3);
                        ele.FechaRegistro = Resultado.GetDateTime(4);
                        ele.FechaVotacion = Resultado.GetDateTime(5);
                        ele.IdUsuario = Resultado.GetInt32(6);
                        ele.Foto = (byte[])Resultado.GetValue(7);
                    }
                }

                Tabla.Load(Resultado);
                //return Tabla;
                return ele;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); }
        }
    }
}
