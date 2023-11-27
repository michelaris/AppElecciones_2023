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
   public class UsuarioDao
    {
        public bool login(string user, string pass)
        {
            MySqlDataReader Resultado;
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                string sql_tarea = "sp_Login";
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(sql_tarea, SqlCon);

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pLoginName", user);
                Comando.Parameters.AddWithValue("pPassword", pass);
                Comando.CommandTimeout = 60;

                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                if (Resultado.HasRows)
                {
                    while (Resultado.Read())
                    {
                        UsuarioCache.IdUSuario = Resultado.GetInt32(0);
                        UsuarioCache.DocumentoIdentidad = Resultado.GetString(1);
                        UsuarioCache.Nombres = Resultado.GetString(2);
                        UsuarioCache.Apellidos = Resultado.GetString(3);
                        UsuarioCache.Correo = Resultado.GetString(4);
                        UsuarioCache.LoginName = Resultado.GetString(5);
                        UsuarioCache.Password = Resultado.GetString(6);
                        UsuarioCache.Activo = Resultado.GetBoolean(7);
                        UsuarioCache.Rol = Resultado.GetString(8);
                        UsuarioCache.Foto = (byte[])Resultado.GetValue(9);
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
        public DataTable listarUsuarios(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string sql_tarea = "spListarUsuarios";
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

        public string crearUsuario(Usuario oUs)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);

                Sqltarea = "spCrearUsuario";

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pDocumentoIdentidad", oUs.DocumentoIdentidad);
                Comando.Parameters.AddWithValue("pNombres", oUs.Nombres);
                Comando.Parameters.AddWithValue("pApellidos", oUs.Apellidos);
                Comando.Parameters.AddWithValue("pCorreo", oUs.Correo);
                Comando.Parameters.AddWithValue("pLoginName", oUs.LoginName);
                Comando.Parameters.AddWithValue("pPassword", oUs.Password);
                Comando.Parameters.AddWithValue("pActivo", oUs.Activo);
                Comando.Parameters.AddWithValue("pRol", oUs.Rol);
                Comando.Parameters.AddWithValue("pFoto", oUs.Foto);

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
        public string editarUsuario(Usuario oUs)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);

                Sqltarea = "spActualizarUsuario";

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pIdUsuario", oUs.IdUsuario);
                Comando.Parameters.AddWithValue("pDocumentoIdentidad", oUs.DocumentoIdentidad);
                Comando.Parameters.AddWithValue("pNombres", oUs.Nombres);
                Comando.Parameters.AddWithValue("pApellidos", oUs.Apellidos);
                Comando.Parameters.AddWithValue("pCorreo", oUs.Correo);
                Comando.Parameters.AddWithValue("pLoginName", oUs.LoginName);
                Comando.Parameters.AddWithValue("pPassword", oUs.Password);
                Comando.Parameters.AddWithValue("pActivo", oUs.Activo);
                Comando.Parameters.AddWithValue("pRol", oUs.Rol);
                Comando.Parameters.AddWithValue("pFoto", oUs.Foto);

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

        public string eliminarUsuario(int idUsuario)
        {
            string Rpta = "";
            string Sqltarea = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {

                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(Sqltarea, SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Sqltarea = "spEliminarUsuario";

                Comando.Parameters.AddWithValue("pIdUsuario", idUsuario);
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
        public Usuario obtenerUsuario(int idUsuario)
        {
            Usuario us = new Usuario();
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                string sql_tarea = "spObtenerUsuario";
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand(sql_tarea, SqlCon);

                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("pIdUsuario", idUsuario);
                Comando.CommandTimeout = 60;

                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                if (Resultado.HasRows)
                {
                    while (Resultado.Read())
                    {
                        us.IdUsuario = Resultado.GetInt32(0);
                        us.DocumentoIdentidad = Resultado.GetString(1);
                        us.Nombres = Resultado.GetString(2);
                        us.Apellidos = Resultado.GetString(3);
                        us.Correo = Resultado.GetString(4);
                        us.LoginName = Resultado.GetString(5);
                        us.Password = Resultado.GetString(6);
                        us.Activo = Resultado.GetBoolean(7);//Resultado.GetInt32(6)==1?true:false;
                        //
                        us.Rol = Resultado.GetString(8);
                        us.Foto = (byte[])Resultado.GetValue(9);
                    }
                }

                Tabla.Load(Resultado);
                //return Tabla;
                return us;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); }
        }
    }
}
