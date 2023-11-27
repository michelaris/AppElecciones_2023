using Entities;
using Model.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class UsuarioController
    {
        UsuarioDao usuarioDao = new UsuarioDao();

        public bool Login(string user, string pass)
        {
            return usuarioDao.login(user, pass);
        }
        public DataTable ListarUsuarios(string cTexto)
        {
            return usuarioDao.listarUsuarios(cTexto);
        }

        public string CrearUsuario(Usuario oUs)
        {
            string Rpta = usuarioDao.crearUsuario(oUs);
            return Rpta;
        }
        public string EditarUsuario(Usuario oUs)
        {
            string Rpta = usuarioDao.editarUsuario(oUs);
            return Rpta;
        }

        public string EliminarUsuario(int idUsuario)
        {
            string Rpta = usuarioDao.eliminarUsuario(idUsuario);
            return Rpta;
        }
        public Usuario ObtenerUsuario(int idUsuario)
        {
            Usuario usu = new Usuario();
            usu = usuarioDao.obtenerUsuario(idUsuario);
            return usu;
        }
    }
}
