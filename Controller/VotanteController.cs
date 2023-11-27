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
    public class VotanteController
    {
        VotanteDao votanteDao = new VotanteDao();

        public bool LoginVotante(string dni)
        {
            return votanteDao.loginVotante(dni);
        }

        public DataTable ListarVotantes(string cTexto)
        {
            return votanteDao.listarVotantes(cTexto);
        }
        public DataTable ListarVotantesPorEleccion(int idEleccion)
        {
            return votanteDao.listarVotantesPorEleccion(idEleccion);
        }

        public string CrearVotante(Votante oVo)
        {
            string Rpta = votanteDao.crearVotante(oVo);
            return Rpta;
        }
        public string CargarListaDeVotantes(string path)
        {
            string Rpta = votanteDao.cargarListaDeVotantes(path);
            return Rpta;
        }


        public string EditarVotante(Votante oVo)
        {
            string Rpta = votanteDao.editarVotante(oVo);
            return Rpta;
        }
        public string EditarVotante_EmitioVotacion(int idVotante, bool emitioVotacion)
        {
            string Rpta = votanteDao.editarVotante_EmitioVotacion(idVotante, emitioVotacion);
            return Rpta;
        }


        public string EliminarVotante(int idVotante)
        {
            string Rpta = votanteDao.eliminarVotante(idVotante);
            return Rpta;
        }
        public Votante ObtenerVotante(int idVotante)
        {
            Votante usu = new Votante();
            usu = votanteDao.obtenerVotante(idVotante);
            return usu;
        }
    }
}
