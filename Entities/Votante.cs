using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Votante
    {
        public int IdVotante { get; set; }
        public string DocumentoIdentidad { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool EmitioVotacion { get; set; }
        public int IdEleccion { get; set; }
        public int IdUsuario { get; set; }

        public Votante()
        {

        }
    }
}
