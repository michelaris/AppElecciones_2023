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
    public class CandidatoController
    {
        CandidatoDao candidatoDao = new CandidatoDao();

       
        public DataTable ListarCandidatos(string cTexto)
        {
            return candidatoDao.listarCandidatos(cTexto);
        }
        public DataTable ListarCandidatosPorEleccion(int idEleccion)
        {
            return candidatoDao.listarCandidatosPorEleccion(idEleccion);
        }

        public DataTable listarCandidatosPorEleccionParaVotante(int idEleccion)
        {
            return candidatoDao.listarCandidatosPorEleccionParaVotante(idEleccion);
        }

        public string CrearCandidato(Candidato oCa)
        {
            string Rpta = candidatoDao.crearCandidato(oCa);
            return Rpta;
        }
        public string EditarCandidato(Candidato oCa)
        {
            string Rpta = candidatoDao.editarCandidato(oCa);
            return Rpta;
        }

        public string EliminarCandidato(int idCandidato)
        {
            string Rpta = candidatoDao.eliminarCandidato(idCandidato);
            return Rpta;
        }
        public Candidato ObtenerCandidato(int idCandidato)
        {
            Candidato usu = new Candidato();
            usu = candidatoDao.obtenerCandidato(idCandidato);
            return usu;
        }
    }
}
