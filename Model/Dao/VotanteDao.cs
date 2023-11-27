using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace Model.Dao
{
    public class VotanteDao
    {

        public bool loginVotante(string dni)
        {
            MySqlDataReader Resultado;
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                string sql_tarea = "sp_LoginVotante";
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(sql_tarea, SqlCon);

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pDocumentoIdentidad", dni);
                Comando.CommandTimeout = 60;

                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                if (Resultado.HasRows)
                {
                    while (Resultado.Read())
                    {
                        VotanteCache.IdVotante = Resultado.GetInt32(0);
                        VotanteCache.DocumentoIdentidad = Resultado.GetString(1);
                        VotanteCache.Nombres = Resultado.GetString(2);
                        VotanteCache.Apellidos = Resultado.GetString(3);
                        VotanteCache.Activo = Resultado.GetBoolean(4);
                        VotanteCache.FechaRegistro = Resultado.GetDateTime(5);
                        VotanteCache.EmitioVotacion = Resultado.GetBoolean(6);
                        VotanteCache.IdEleccion = Resultado.GetInt32(7);                        
                        VotanteCache.IdUsuario = Resultado.GetInt32(8);
                        
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); }
        }

        public DataTable listarVotantes(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "spListarVotantes";
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

        public DataTable listarVotantesPorEleccion(int idEleccion)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "spListarVotantesPorEleccion";
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


        public string crearVotante(Votante oVo)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);

                Sqltarea = "spCrearVotante";

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pDocumentoIdentidad", oVo.DocumentoIdentidad);
                Comando.Parameters.AddWithValue("pNombres", oVo.Nombres);
                Comando.Parameters.AddWithValue("pApellidos", oVo.Apellidos);
                Comando.Parameters.AddWithValue("pActivo", oVo.Activo);
                Comando.Parameters.AddWithValue("pFechaRegistro", oVo.FechaRegistro);
                Comando.Parameters.AddWithValue("pEmitioVotacion", oVo.EmitioVotacion);
                Comando.Parameters.AddWithValue("pIdEleccion", oVo.IdEleccion);
                Comando.Parameters.AddWithValue("pIdUsuario", oVo.IdUsuario);
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

        public string cargarListaDeVotantes(string path)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);
                SqlCon.Open();
                Sqltarea = "spCrearVotanteDesdeLista";
                Comando.CommandText = Sqltarea;

                Comando.CommandType = CommandType.StoredProcedure;


                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
                Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Excel.Range range = xlWorksheet.UsedRange;
                int rows = range.Rows.Count;
                int cols = range.Columns.Count;
                for (int i = 2; i < rows; i++)
                {
                    /*  comm.Parameters.Clear();
                      comm.Parameters.AddWithValue("pDni", range.Cells[i,1].Value2.ToString());
                      comm.Parameters.AddWithValue("pNombres", range.Cells[i, 2].Value2.ToString());
                      comm.Parameters.AddWithValue("pApellidos", range.Cells[i, 3].Value2.ToString());*/
                    Comando.Parameters.Clear();
                    Comando.Parameters.AddWithValue("pDocumentoIdentidad", range.Cells[i, 1].Value2.ToString());
                    Comando.Parameters.AddWithValue("pNombres", range.Cells[i, 2].Value2.ToString());
                    Comando.Parameters.AddWithValue("pApellidos", range.Cells[i, 3].Value2.ToString());
                    Comando.Parameters.AddWithValue("pActivo", double.Parse(range.Cells[i, 4].Value2.ToString()));
                    Comando.Parameters.AddWithValue("pFechaRegistro", DateTime.FromOADate(range.Cells[i, 5].Value2));
                    Comando.Parameters.AddWithValue("pEmitioVotacion", double.Parse(range.Cells[i, 6].Value2.ToString()));
                    Comando.Parameters.AddWithValue("pIdEleccion", range.Cells[i, 7].Value2);
                    Comando.Parameters.AddWithValue("pIdUsuario", range.Cells[i, 8].Value2);

                    Comando.ExecuteNonQuery();
                    
                    //Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo ingresar el registro";
                }
                Marshal.ReleaseComObject(range);
                Marshal.ReleaseComObject(xlWorksheet);
                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);

                Rpta = "OK";//"La integracin se ha realizado satifactoriamente";//Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo ingresar el registro";
                // SqlCon.Open();
                // Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo ingresar el registro";
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

        public string editarVotante(Votante oVo)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);

                Sqltarea = "spActualizarVotante";

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pIdVotante", oVo.IdVotante);
                Comando.Parameters.AddWithValue("pDocumentoIdentidad", oVo.DocumentoIdentidad);
                Comando.Parameters.AddWithValue("pNombres", oVo.Nombres);
                Comando.Parameters.AddWithValue("pApellidos", oVo.Apellidos);
                Comando.Parameters.AddWithValue("pActivo", oVo.Activo);
                Comando.Parameters.AddWithValue("pFechaRegistro", oVo.FechaRegistro);
                Comando.Parameters.AddWithValue("pEmitioVotacion", oVo.EmitioVotacion);
                Comando.Parameters.AddWithValue("pIdEleccion", oVo.IdEleccion);
                Comando.Parameters.AddWithValue("pIdUsuario", oVo.IdUsuario);

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
        public string editarVotante_EmitioVotacion(int idVotante, bool emitioVotacion)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);

                Sqltarea = "spActualizarVotanteEmitioVotacion";

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pIdVotante", idVotante);
                Comando.Parameters.AddWithValue("pEmitioVotacion", emitioVotacion);

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

        public string eliminarVotante(int idVotante)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {

                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Sqltarea = "spEliminarVotante";

                Comando.Parameters.AddWithValue("pIdVotante", idVotante);
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
        public Votante obtenerVotante(int idVotante)
        {
            Votante oVo = new Votante();
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                string sql_tarea = "spObtenerVotante";
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(sql_tarea, SqlCon);

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pIdVotante", idVotante);
                Comando.CommandTimeout = 60;

                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                if (Resultado.HasRows)
                {
                    while (Resultado.Read())
                    {
                        oVo.IdVotante = Resultado.GetInt32(0);
                        oVo.DocumentoIdentidad = Resultado.GetString(1);
                        oVo.Nombres = Resultado.GetString(2);
                        oVo.Apellidos = Resultado.GetString(3);
                        oVo.Activo = Resultado.GetBoolean(4);
                        oVo.FechaRegistro = Resultado.GetDateTime(5);
                        oVo.EmitioVotacion = Resultado.GetBoolean(6); 
                        oVo.IdEleccion = Resultado.GetInt32(7);
                        oVo.IdUsuario = Resultado.GetInt32(8);

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
