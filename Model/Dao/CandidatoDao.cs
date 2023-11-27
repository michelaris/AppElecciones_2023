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
    public class CandidatoDao
    {
        public DataTable listarCandidatos(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "spListarCandidatos";
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
        public DataTable listarCandidatosPorEleccion(int idEleccion)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "spListarCandidatosPorEleccion";
                MySqlCommand Comando = new MySqlCommand(sql_tarea, SqlCon);
                Comando.CommandTimeout = 60;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pIdEleccion", idEleccion);
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
        public DataTable listarCandidatosPorEleccionParaVotante(int idEleccion)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "spListarCandidatosPorEleccionParaVotante";
                MySqlCommand Comando = new MySqlCommand(sql_tarea, SqlCon);
                Comando.CommandTimeout = 60;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pIdEleccion", idEleccion);
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

        public string crearCandidato(Candidato oCa)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);

                Sqltarea = "spCrearCandidato";

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pNombres", oCa.Nombres);
                Comando.Parameters.AddWithValue("pApellidos", oCa.Apellidos);
                Comando.Parameters.AddWithValue("pMensaje", oCa.Mensaje);
                Comando.Parameters.AddWithValue("pFoto", oCa.Foto);
                Comando.Parameters.AddWithValue("pActivo", oCa.Activo);
                Comando.Parameters.AddWithValue("pFechaRegistro", oCa.FechaRegistro);
                Comando.Parameters.AddWithValue("pIdUsuario", oCa.IdUsuario);
                Comando.Parameters.AddWithValue("pIdEleccion", oCa.IdEleccion);

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
        public string editarCandidato(Candidato oCa)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);

                Sqltarea = "spActualizarCandidato";

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pIdCandidato", oCa.IdCandidato);
                Comando.Parameters.AddWithValue("pNombres", oCa.Nombres);
                Comando.Parameters.AddWithValue("pApellidos", oCa.Apellidos);
                Comando.Parameters.AddWithValue("pMensaje", oCa.Mensaje);
                Comando.Parameters.AddWithValue("pFoto", oCa.Foto);
                Comando.Parameters.AddWithValue("pActivo", oCa.Activo);
                Comando.Parameters.AddWithValue("pFechaRegistro", oCa.FechaRegistro);
                Comando.Parameters.AddWithValue("pIdUsuario", oCa.IdUsuario);
                Comando.Parameters.AddWithValue("pIdEleccion", oCa.IdEleccion);

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

        public string eliminarCandidato(int idCandidato)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {

                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Sqltarea = "spEliminarCandidato";

                Comando.Parameters.AddWithValue("pIdCandidato", idCandidato);
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
        public Candidato obtenerCandidato(int idCandidato)
        {
            Candidato ca = new Candidato();
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                string sql_tarea = "spObtenerCandidato";
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(sql_tarea, SqlCon);

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pIdCandidato", idCandidato);
                Comando.CommandTimeout = 60;

                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                if (Resultado.HasRows)
                {
                    while (Resultado.Read())
                    {
                        ca.IdCandidato = Resultado.GetInt32(0);
                        ca.Nombres = Resultado.GetString(1);
                        ca.Apellidos = Resultado.GetString(2);
                        ca.Mensaje = Resultado.GetString(3);
                        ca.Foto = (byte[])Resultado.GetValue(4);
                        ca.Activo = Resultado.GetBoolean(5);
                        ca.FechaRegistro = Resultado.GetDateTime(6);
                        ca.IdUsuario = Resultado.GetInt32(7);
                        ca.IdEleccion = Resultado.GetInt32(8);

                    }
                }

                Tabla.Load(Resultado);
                //return Tabla;
                return ca;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); }
        }
    }
}
