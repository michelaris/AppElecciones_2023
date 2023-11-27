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
    public class ResultadoDao
    {
        public DataTable listarResultados(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "spListarResultados";
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

        public string crearResultado(Resultado oRe)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);

                Sqltarea = "spCrearResultado";

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pIdCandidato", oRe.IdCandidato);
                Comando.Parameters.AddWithValue("pPorcentaje_votos", oRe.PorcentajeVotos);
                Comando.Parameters.AddWithValue("pIdEleccion", oRe.IdEleccion);
                Comando.Parameters.AddWithValue("pFechaRegistro", oRe.FechaRegistro);


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
        public string editarResultado(Resultado oRe)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);

                Sqltarea = "spEditarResultado";

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pIdResultado", oRe.IdResultado);
                Comando.Parameters.AddWithValue("pIdCandidato", oRe.IdCandidato);
                Comando.Parameters.AddWithValue("pPorcentaje_votos", oRe.PorcentajeVotos);
                Comando.Parameters.AddWithValue("pIdEleccion", oRe.IdEleccion);
                Comando.Parameters.AddWithValue("pFechaRegistro", oRe.FechaRegistro);

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

        public string eliminarResultado(int idResultado)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {

                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Sqltarea = "spEliminarResultado";

                Comando.Parameters.AddWithValue("pIdResultado", idResultado);
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
        public Resultado obtenerResultado(int idResultado)
        {
            Resultado oRe = new Resultado();
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                string sql_tarea = "spObtenerResultado";
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(sql_tarea, SqlCon);

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pIdResultado", idResultado);
                Comando.CommandTimeout = 60;

                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                if (Resultado.HasRows)
                {
                    while (Resultado.Read())
                    {
                        oRe.IdResultado = Resultado.GetInt32(0);
                        oRe.IdCandidato = Resultado.GetInt32(1);
                        oRe.PorcentajeVotos = Resultado.GetInt32(2);
                        oRe.IdEleccion = Resultado.GetInt32(3);
                        oRe.FechaRegistro = Resultado.GetDateTime(4);

                    }
                }

                Tabla.Load(Resultado);
                //return Tabla;
                return oRe;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); }
        }
    }
}
