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
    public class VotacionDao
    {
        public DataTable listarVotaciones(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "spListarVotaciones";
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

        public string crearVotacion(Votacion oVo)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);

                Sqltarea = "spCrearVotacion";

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pFechaRegistro", oVo.FechaRegistro);
                Comando.Parameters.AddWithValue("pIdEleccion", oVo.IdEleccion);
                Comando.Parameters.AddWithValue("pIdVotante", oVo.IdVotante);
                Comando.Parameters.AddWithValue("pIdCandidato", oVo.IdCandidato);


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
        public string editarVotacion(Votacion oVo)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);

                Sqltarea = "spActualizarVotacion";

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pIdVotacion", oVo.IdVotacion);
                Comando.Parameters.AddWithValue("pFechaRegistro", oVo.FechaRegistro);
                Comando.Parameters.AddWithValue("pIdEleccion", oVo.IdEleccion);
                Comando.Parameters.AddWithValue("pIdVotante", oVo.IdVotante);
                Comando.Parameters.AddWithValue("pIdCandidato", oVo.IdCandidato);

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

        public string eliminarVotacion(int idVotacion)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {

                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Sqltarea = "spEliminarVotacion";

                Comando.Parameters.AddWithValue("pIdVotacion", idVotacion);
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
        public Votacion obtenerVotacion(int idVotacion)
        {
            Votacion oVo = new Votacion();
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                string sql_tarea = "spObtenerVotacion";
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(sql_tarea, SqlCon);

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pIdVotacion", idVotacion);
                Comando.CommandTimeout = 60;

                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                if (Resultado.HasRows)
                {
                    while (Resultado.Read())
                    {
                        oVo.IdVotacion = Resultado.GetInt32(0);
                        oVo.FechaRegistro = Resultado.GetDateTime(1);
                        oVo.IdEleccion = Resultado.GetInt32(2);
                        oVo.IdVotacion = Resultado.GetInt32(3);
                        oVo.IdCandidato = Resultado.GetInt32(4);                      
                    }
                }

                Tabla.Load(Resultado);
                //return Tabla;
                return oVo;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); }
        }
    }
}
