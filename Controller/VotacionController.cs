using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Model.Dao;

namespace Controller
{
    public class VotacionController
    {
        VotacionDao votancionDao = new VotacionDao();


        public DataTable ListarVotanciones(string cTexto)
        {
            return votancionDao.listarVotaciones(cTexto);
        }        
       

        public string CrearVotancion(Votacion oVo)
        {
            string Rpta = votancionDao.crearVotacion(oVo);
            return Rpta;
        }
        public string EditarVotancion(Votacion oVo)
        {
            string Rpta = votancionDao.editarVotacion(oVo);
            return Rpta;
        }

        public string EliminarVotacion(int idVotacion)
        {
            string Rpta = votancionDao.eliminarVotacion(idVotacion);
            return Rpta;
        }
        public Votacion ObtenerVotancion(int idVotacion)
        {
            Votacion usu = new Votacion();
            usu = votancionDao.obtenerVotacion(idVotacion);
            return usu;
        }
    }
}
