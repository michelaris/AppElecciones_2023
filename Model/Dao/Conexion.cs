using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Model.Dao
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Puerto;
        private string Usuario;
        private string Clave;
        private static Conexion Con = null;

        private Conexion()
        {
            this.Base = "DB_Elecciones";
            this.Servidor = "localhost";
            this.Puerto = "3306";
            this.Usuario = "root";
            this.Clave = "Admin2023";
            // this.Clave = "Admin$root_2022";
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection Cadena = new MySqlConnection();
            try
            {
                Cadena.ConnectionString = "datasource=" + this.Servidor +
                                        "; port=" + this.Puerto +
                                        ";username=" + this.Usuario +
                                        ";password=" + this.Clave +
                                        ";Database=" + this.Base;
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
