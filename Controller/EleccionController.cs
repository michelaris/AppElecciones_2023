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
    public class EleccionController
    {
        EleccionDao EleccionDao = new EleccionDao();
       
        public DataTable ListarElecciones(string cTexto)
        {
            return EleccionDao.listarElecciones(cTexto);
        }

        public string CrearEleccion(Eleccion oEl)
        {
            string Rpta = EleccionDao.crearEleccion(oEl);
            return Rpta;
        }
        public string EditarEleccion(Eleccion oEl)
        {
            string Rpta = EleccionDao.editarEleccion(oEl);
            return Rpta;
        }

        public string EliminarEleccion(int idEleccion)
        {
            string Rpta = EleccionDao.eliminarEleccion(idEleccion);
            return Rpta;
        }
        public Eleccion ObtenerEleccion(int idEleccion)
        {
            Eleccion usu = new Eleccion();
            usu = EleccionDao.obtenerEleccion(idEleccion);
            return usu;
        }
        /*----------------*/
        public DataTable ListarResultados(int idEleccion)
        {
            return EleccionDao.listarResultados(idEleccion);
        }
        public DataTable ListarEleccionesConVotacion(string cTexto)
        {
            return EleccionDao.listarEleccionesConVotacion(cTexto);
        }
    }
}
